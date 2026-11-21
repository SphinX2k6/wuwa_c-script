using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020022A2 RID: 8866
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyRogueTokenItem : GridProxyAbstract<RogueWeeklyEntry>
{
	// Token: 0x06015E5D RID: 89693 RVA: 0x00659998 File Offset: 0x00657B98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClick))
		};
	}

	// Token: 0x06015E5E RID: 89694 RVA: 0x00659ADE File Offset: 0x00657CDE
	protected override void OnStart()
	{
		this.TagLayout = new GenericLayout<WeeklyRogueTagItem, int>(base.GetHorizontalLayout(9), new Func<WeeklyRogueTagItem>(this.OnCreateTagItem), null, false, true);
		base.GetItem(11).SetUIActive(false);
	}

	// Token: 0x06015E5F RID: 89695 RVA: 0x00659B10 File Offset: 0x00657D10
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.WeeklyRogueDescModeChange, new Action(this.OnDescModeChange));
	}

	// Token: 0x06015E60 RID: 89696 RVA: 0x00659B2E File Offset: 0x00657D2E
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyRogueDescModeChange, new Action(this.OnDescModeChange));
	}

	// Token: 0x06015E61 RID: 89697 RVA: 0x00659B4C File Offset: 0x00657D4C
	public override void Refresh(RogueWeeklyEntry data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.UpdateByConfigId(data.ConfigId);
		base.GetItem(11).SetUIActive(data.IsRecommend);
	}

	// Token: 0x06015E62 RID: 89698 RVA: 0x00659B74 File Offset: 0x00657D74
	private void OnClick(EToggleState toggleState)
	{
		int? obj = (base.GetExtendToggle(4).GetToggleState() == EToggleState.ETT_Checked) ? new int?(base.GridIndex) : null;
		Action<int?> onSelectedChange = this.OnSelectedChange;
		if (onSelectedChange == null)
		{
			return;
		}
		onSelectedChange(obj);
	}

	// Token: 0x06015E63 RID: 89699 RVA: 0x00659BB8 File Offset: 0x00657DB8
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		WeeklyRogueModel.Instance.SelectEntry = this.Data;
	}

	// Token: 0x06015E64 RID: 89700 RVA: 0x00659BDB File Offset: 0x00657DDB
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		WeeklyRogueModel.Instance.SelectEntry = null;
	}

	// Token: 0x06015E65 RID: 89701 RVA: 0x00659BFC File Offset: 0x00657DFC
	private void OnDescModeChange()
	{
		if (this.ConfigId == 0)
		{
			return;
		}
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
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDescSimple, Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDesc, rogueWeeklyBuffPool.Value.BuffDescParam());
	}

	// Token: 0x06015E66 RID: 89702 RVA: 0x00659CC4 File Offset: 0x00657EC4
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
		base.GetItem(5).SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueWeeklyBuffPool.Value.BuffName, Array.Empty<object>());
		if (WeeklyRogueModel.Instance.DescMode == EDescModel.SIMPLE)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDescSimple, Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDesc, rogueWeeklyBuffPool.Value.BuffDescParam());
		}
		base.SetTextureByPath(rogueWeeklyBuffPool.Value.BuffIcon, base.GetTexture(1), null, null);
		RogueWeekQualityConfig? rogueWeeklyQualityConfig = WeeklyRogueConfig.Instance.GetRogueWeeklyQualityConfig(rogueWeeklyBuffPool.Value.Quality);
		if (rogueWeeklyQualityConfig != null)
		{
			base.SetTextureByPath(rogueWeeklyQualityConfig.Value.TokenBgNew, base.GetTexture(0), null, null);
		}
		base.GetSprite(6).SetColor(FColor.FromHex(rogueWeeklyQualityConfig.Value.TokenColor));
		base.GetItem(7).SetUIActive(rogueWeeklyBuffPool.Value.Quality == 6);
		base.GetItem(8).SetUIActive(rogueWeeklyBuffPool.Value.Quality == 5);
		this.TagLayout.RefreshByData(WeeklyRogueModel.Instance.GetRogueWeeklyBuffTagIdList(configId), null, false);
	}

	// Token: 0x06015E67 RID: 89703 RVA: 0x00659E98 File Offset: 0x00658098
	public void SetInteractive(bool bActive)
	{
		base.GetExtendToggle(4).SetSelfInteractive(bActive);
	}

	// Token: 0x06015E68 RID: 89704 RVA: 0x00659EA7 File Offset: 0x006580A7
	private WeeklyRogueTagItem OnCreateTagItem()
	{
		return new WeeklyRogueTagItem();
	}

	// Token: 0x0400B840 RID: 47168
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WeeklyRogueTagItem, int> TagLayout;

	// Token: 0x0400B841 RID: 47169
	[Nullable(2)]
	private RogueWeeklyEntry Data;

	// Token: 0x0400B842 RID: 47170
	private int ConfigId;

	// Token: 0x0400B843 RID: 47171
	[Nullable(2)]
	public Action<int?> OnSelectedChange;

	// Token: 0x02008500 RID: 34048
	[NullableContext(0)]
	private enum EWeeklyRogueTokenItem
	{
		// Token: 0x0402ADF3 RID: 175603
		QualityBgTexture,
		// Token: 0x0402ADF4 RID: 175604
		IconTexture,
		// Token: 0x0402ADF5 RID: 175605
		NameText,
		// Token: 0x0402ADF6 RID: 175606
		DescText,
		// Token: 0x0402ADF7 RID: 175607
		SelfToggle,
		// Token: 0x0402ADF8 RID: 175608
		NewItem,
		// Token: 0x0402ADF9 RID: 175609
		QualityLineSprite,
		// Token: 0x0402ADFA RID: 175610
		GoldItem,
		// Token: 0x0402ADFB RID: 175611
		YellowItem,
		// Token: 0x0402ADFC RID: 175612
		TagLayout,
		// Token: 0x0402ADFD RID: 175613
		TagItem,
		// Token: 0x0402ADFE RID: 175614
		ItemRecommend
	}
}
