using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002D31 RID: 11569
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyRogueArtifactItem : GridProxyAbstract<RogueWeeklyEntry>
{
	// Token: 0x06018531 RID: 99633 RVA: 0x00630EAC File Offset: 0x0062F0AC
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

	// Token: 0x06018532 RID: 99634 RVA: 0x00630F81 File Offset: 0x0062F181
	protected override void OnStart()
	{
		this.TagLayout = new GenericLayout<WeeklyRogueTagItem, int>(base.GetHorizontalLayout(4), new Func<WeeklyRogueTagItem>(this.OnCreateTagItem), null, false, true);
	}

	// Token: 0x06018533 RID: 99635 RVA: 0x00630FA4 File Offset: 0x0062F1A4
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.WeeklyRogueDescModeChange, new Action(this.OnDescModeChange));
	}

	// Token: 0x06018534 RID: 99636 RVA: 0x00630FC2 File Offset: 0x0062F1C2
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyRogueDescModeChange, new Action(this.OnDescModeChange));
	}

	// Token: 0x06018535 RID: 99637 RVA: 0x00630FE0 File Offset: 0x0062F1E0
	public override void Refresh(RogueWeeklyEntry data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.UpdateByConfigId(data.ConfigId);
	}

	// Token: 0x06018536 RID: 99638 RVA: 0x00630FF8 File Offset: 0x0062F1F8
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

	// Token: 0x06018537 RID: 99639 RVA: 0x0063103C File Offset: 0x0062F23C
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		WeeklyRogueModel.Instance.SelectEntry = this.Data;
	}

	// Token: 0x06018538 RID: 99640 RVA: 0x0063105F File Offset: 0x0062F25F
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		WeeklyRogueModel.Instance.SelectEntry = null;
	}

	// Token: 0x06018539 RID: 99641 RVA: 0x0063107D File Offset: 0x0062F27D
	private void OnDescModeChange()
	{
		if (this.ConfigId == 0)
		{
			return;
		}
		this.RefreshDesc();
	}

	// Token: 0x0601853A RID: 99642 RVA: 0x00631090 File Offset: 0x0062F290
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

	// Token: 0x0601853B RID: 99643 RVA: 0x0063115C File Offset: 0x0062F35C
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

	// Token: 0x0601853C RID: 99644 RVA: 0x00631266 File Offset: 0x0062F466
	public void SetInteractive(bool bActive)
	{
		base.GetExtendToggle(0).SetSelfInteractive(bActive);
	}

	// Token: 0x0601853D RID: 99645 RVA: 0x00631275 File Offset: 0x0062F475
	private WeeklyRogueTagItem OnCreateTagItem()
	{
		return new WeeklyRogueTagItem();
	}

	// Token: 0x0400B49B RID: 46235
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WeeklyRogueTagItem, int> TagLayout;

	// Token: 0x0400B49C RID: 46236
	private RogueWeeklyEntry Data;

	// Token: 0x0400B49D RID: 46237
	private int ConfigId;

	// Token: 0x0400B49E RID: 46238
	[Nullable(2)]
	public Action<int?> OnSelectedChange;

	// Token: 0x020092BF RID: 37567
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402F6F2 RID: 194290
		ToggleItem,
		// Token: 0x0402F6F3 RID: 194291
		TexIcon,
		// Token: 0x0402F6F4 RID: 194292
		TxtName,
		// Token: 0x0402F6F5 RID: 194293
		TxtDesc,
		// Token: 0x0402F6F6 RID: 194294
		TagLayout,
		// Token: 0x0402F6F7 RID: 194295
		TagItem,
		// Token: 0x0402F6F8 RID: 194296
		NewItem
	}
}
