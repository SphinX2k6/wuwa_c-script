using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001265 RID: 4709
[NullableContext(1)]
[Nullable(0)]
public class FarmGoldDropDownRoot : UiPanelBase
{
	// Token: 0x06008020 RID: 32800 RVA: 0x001B18E8 File Offset: 0x001AFAE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickRootToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008021 RID: 32801 RVA: 0x001B19D0 File Offset: 0x001AFBD0
	private void OnClickRootToggle(EToggleState toggleState)
	{
		bool bIsUIActive = base.GetScrollViewWithScrollbar(3).RootUIComp.Get().bIsUIActive;
		this.ChangeScrollActive(!bIsUIActive);
	}

	// Token: 0x06008022 RID: 32802 RVA: 0x001B1A01 File Offset: 0x001AFC01
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<FarmGoldDropDownItem, FarmGoldDifficulty>(base.GetScrollViewWithScrollbar(3), new Func<FarmGoldDropDownItem>(this.InitDropDownItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, null);
		this.ChangeScrollActive(false);
	}

	// Token: 0x06008023 RID: 32803 RVA: 0x001B1A3B File Offset: 0x001AFC3B
	private FarmGoldDropDownItem InitDropDownItem()
	{
		FarmGoldDropDownItem farmGoldDropDownItem = new FarmGoldDropDownItem();
		farmGoldDropDownItem.SetActivityData(this.ActivityData);
		farmGoldDropDownItem.SetClickCallback(new Action<int, int>(this.OnClickDropDownItem));
		return farmGoldDropDownItem;
	}

	// Token: 0x06008024 RID: 32804 RVA: 0x001B1A60 File Offset: 0x001AFC60
	private void OnClickDropDownItem(int diffcultId, int selectIndex)
	{
		if (this.ScrollView.GetSelectedIndex() == selectIndex)
		{
			return;
		}
		FarmGoldLevelData levelDataByIndex = this.ActivityData.GetLevelDataByIndex(this.Data.GetConfig().SortId - 1);
		FarmGoldController.Instance.RequestSetDifficulty(this.ActivityData.Id, levelDataByIndex.GetInstId(), diffcultId);
		this.ChangeScrollActive(false);
	}

	// Token: 0x06008025 RID: 32805 RVA: 0x001B1AC0 File Offset: 0x001AFCC0
	public void SetActivityData(FarmGoldData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x06008026 RID: 32806 RVA: 0x001B1AC9 File Offset: 0x001AFCC9
	public void RefreshLevelData(FarmGoldLevelData data)
	{
		this.Data = data;
		this.RefreshRootText();
		this.RefresDifficulScroll();
	}

	// Token: 0x06008027 RID: 32807 RVA: 0x001B1AE0 File Offset: 0x001AFCE0
	private void RefresDifficulScroll()
	{
		if (this.Data == null)
		{
			return;
		}
		IReadOnlyList<FarmGoldDifficulty> farmGoldDifficultList = FarmGoldConfig.Instance.GetFarmGoldDifficultList(this.ActivityData.Id, this.Data.GetInstId());
		this.ScrollView.RefreshByData(farmGoldDifficultList, null, false);
		this.ScrollView.SelectGridProxy(this.Data.GetSelectDifficultIndex(), false);
	}

	// Token: 0x06008028 RID: 32808 RVA: 0x001B1B3C File Offset: 0x001AFD3C
	private void RefreshRootText()
	{
		if (this.Data == null)
		{
			return;
		}
		string difficultTogText = this.ActivityData.GetDifficultTogText(this.Data.GetSelectDifficult());
		base.GetText(1).SetText(difficultTogText, true);
	}

	// Token: 0x06008029 RID: 32809 RVA: 0x001B1B77 File Offset: 0x001AFD77
	private void ChangeScrollActive(bool showView)
	{
		this.ScrollView.SetActive(showView);
		this.SetToggleState(!showView);
		if (showView)
		{
			this.ShowMaskButton().Forget();
			return;
		}
		this.HideMaskButton();
	}

	// Token: 0x0600802A RID: 32810 RVA: 0x001B1BA4 File Offset: 0x001AFDA4
	private void SetToggleState(bool foldView)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(foldView ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600802B RID: 32811 RVA: 0x001B1BC2 File Offset: 0x001AFDC2
	private void HideScroll()
	{
		this.ChangeScrollActive(false);
	}

	// Token: 0x0600802C RID: 32812 RVA: 0x001B1BCC File Offset: 0x001AFDCC
	private UniTask ShowMaskButton()
	{
		FarmGoldDropDownRoot.<ShowMaskButton>d__17 <ShowMaskButton>d__;
		<ShowMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowMaskButton>d__.<>4__this = this;
		<ShowMaskButton>d__.<>1__state = -1;
		<ShowMaskButton>d__.<>t__builder.Start<FarmGoldDropDownRoot.<ShowMaskButton>d__17>(ref <ShowMaskButton>d__);
		return <ShowMaskButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600802D RID: 32813 RVA: 0x001B1C0F File Offset: 0x001AFE0F
	private void HideMaskButton()
	{
		if (this.MaskButton == null)
		{
			return;
		}
		this.MaskButton.ResetItemParent();
		this.MaskButton.SetActive(false);
	}

	// Token: 0x04003A31 RID: 14897
	[Nullable(2)]
	private FarmGoldData ActivityData;

	// Token: 0x04003A32 RID: 14898
	[Nullable(2)]
	private FarmGoldLevelData Data;

	// Token: 0x04003A33 RID: 14899
	[Nullable(2)]
	private DynamicMaskButton MaskButton;

	// Token: 0x04003A34 RID: 14900
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<FarmGoldDropDownItem, FarmGoldDifficulty> ScrollView;

	// Token: 0x02007878 RID: 30840
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027B14 RID: 162580
		RootToggle,
		// Token: 0x04027B15 RID: 162581
		RootText,
		// Token: 0x04027B16 RID: 162582
		SortToggle,
		// Token: 0x04027B17 RID: 162583
		ScrollView,
		// Token: 0x04027B18 RID: 162584
		TogItem
	}
}
