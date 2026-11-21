using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200228B RID: 8843
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyRogueArtifactItem : GridProxyAbstract<RogueWeeklyEntry>
{
	// Token: 0x06015DD3 RID: 89555 RVA: 0x00656EC0 File Offset: 0x006550C0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick))
		};
	}

	// Token: 0x06015DD4 RID: 89556 RVA: 0x00656F95 File Offset: 0x00655195
	protected override void OnStart()
	{
		this.TagLayout = new GenericLayout<WeeklyRogueTagItem, int>(base.GetHorizontalLayout(4), new Func<WeeklyRogueTagItem>(this.OnCreateTagItem), null, false, true);
	}

	// Token: 0x06015DD5 RID: 89557 RVA: 0x00656FB8 File Offset: 0x006551B8
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.WeeklyRogueDescModeChange, new Action(this.OnDescModeChange));
	}

	// Token: 0x06015DD6 RID: 89558 RVA: 0x00656FD6 File Offset: 0x006551D6
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyRogueDescModeChange, new Action(this.OnDescModeChange));
	}

	// Token: 0x06015DD7 RID: 89559 RVA: 0x00656FF4 File Offset: 0x006551F4
	public override void Refresh(RogueWeeklyEntry data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.UpdateByConfigId(data.ConfigId);
	}

	// Token: 0x06015DD8 RID: 89560 RVA: 0x0065700C File Offset: 0x0065520C
	private void OnClick(EToggleState state)
	{
		int? obj = (base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked) ? new int?(base.GridIndex) : null;
		Action<int?> onSelectedChange = this.OnSelectedChange;
		if (onSelectedChange == null)
		{
			return;
		}
		onSelectedChange(obj);
	}

	// Token: 0x06015DD9 RID: 89561 RVA: 0x00657050 File Offset: 0x00655250
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		WeeklyRogueModel.Instance.SelectEntry = this.Data;
	}

	// Token: 0x06015DDA RID: 89562 RVA: 0x00657073 File Offset: 0x00655273
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		WeeklyRogueModel.Instance.SelectEntry = null;
	}

	// Token: 0x06015DDB RID: 89563 RVA: 0x00657091 File Offset: 0x00655291
	private void OnDescModeChange()
	{
		if (this.ConfigId == 0)
		{
			return;
		}
		this.RefreshDesc();
	}

	// Token: 0x06015DDC RID: 89564 RVA: 0x006570A4 File Offset: 0x006552A4
	private void RefreshDesc()
	{
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(this.ConfigId);
		if (rogueWeeklyBuffPool == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WeeklyRogue;
			ELogAuthor author = ELogAuthor.LPH;
			string message = "刷新周常肉鸽信物格子失败，找不到对应的配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", this.ConfigId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (WeeklyRogueModel.Instance.DescMode == EDescModel.SIMPLE)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDescSimple, WeeklyRogueModel.Instance.GetRogueWeeklyBuffDescParam(this.ConfigId));
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDesc, WeeklyRogueModel.Instance.GetRogueWeeklyBuffDescParam(this.ConfigId));
	}

	// Token: 0x06015DDD RID: 89565 RVA: 0x00657170 File Offset: 0x00655370
	public void UpdateByConfigId(int configId)
	{
		this.ConfigId = configId;
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(configId);
		if (rogueWeeklyBuffPool == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WeeklyRogue;
			ELogAuthor author = ELogAuthor.LPH;
			string message = "刷新周常肉鸽信物格子失败，找不到对应的配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UUIItem item = base.GetItem(6);
		RogueWeeklyEntry data = this.Data;
		bool? flag;
		if (data == null)
		{
			flag = null;
		}
		else
		{
			RogueWeeklyBuff rogueWeeklyBuff = data.RogueWeeklyBuff;
			flag = ((rogueWeeklyBuff != null) ? new bool?(rogueWeeklyBuff.IsNew) : null);
		}
		bool? flag2 = flag;
		item.SetUIActive(flag2.GetValueOrDefault());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueWeeklyBuffPool.Value.BuffName, Array.Empty<object>());
		this.RefreshDesc();
		base.SetTextureByPath(rogueWeeklyBuffPool.Value.BuffIcon, base.GetTexture(1), null, null);
		this.TagLayout.RefreshByData(WeeklyRogueModel.Instance.GetRogueWeeklyBuffTagIdList(configId), null, false);
	}

	// Token: 0x06015DDE RID: 89566 RVA: 0x0065727A File Offset: 0x0065547A
	public void SetInteractive(bool bActive)
	{
		base.GetExtendToggle(0).SetSelfInteractive(bActive);
	}

	// Token: 0x06015DDF RID: 89567 RVA: 0x00657289 File Offset: 0x00655489
	private WeeklyRogueTagItem OnCreateTagItem()
	{
		return new WeeklyRogueTagItem();
	}

	// Token: 0x0400B810 RID: 47120
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WeeklyRogueTagItem, int> TagLayout;

	// Token: 0x0400B811 RID: 47121
	private RogueWeeklyEntry Data;

	// Token: 0x0400B812 RID: 47122
	private int ConfigId;

	// Token: 0x0400B813 RID: 47123
	[Nullable(2)]
	public Action<int?> OnSelectedChange;

	// Token: 0x020084E6 RID: 34022
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402AD7A RID: 175482
		ToggleItem,
		// Token: 0x0402AD7B RID: 175483
		TexIcon,
		// Token: 0x0402AD7C RID: 175484
		TxtName,
		// Token: 0x0402AD7D RID: 175485
		TxtDesc,
		// Token: 0x0402AD7E RID: 175486
		TagLayout,
		// Token: 0x0402AD7F RID: 175487
		TagItem,
		// Token: 0x0402AD80 RID: 175488
		NewItem
	}
}
