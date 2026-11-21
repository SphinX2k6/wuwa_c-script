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

// Token: 0x02000719 RID: 1817
[NullableContext(1)]
[Nullable(0)]
public class FarmGoldDropDownRoot : UiPanelBase
{
	// Token: 0x060053B7 RID: 21431 RVA: 0x001BA5B8 File Offset: 0x001B87B8
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

	// Token: 0x060053B8 RID: 21432 RVA: 0x001BA6A0 File Offset: 0x001B88A0
	private void OnClickRootToggle(EToggleState toggleState)
	{
		bool bIsUIActive = base.GetScrollViewWithScrollbar(3).RootUIComp.Get().bIsUIActive;
		this.ChangeScrollActive(!bIsUIActive);
	}

	// Token: 0x060053B9 RID: 21433 RVA: 0x001BA6D1 File Offset: 0x001B88D1
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<FarmGoldDropDownItem, FarmGoldDifficulty>(base.GetScrollViewWithScrollbar(3), new Func<FarmGoldDropDownItem>(this.InitDropDownItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, null);
		this.ChangeScrollActive(false);
	}

	// Token: 0x060053BA RID: 21434 RVA: 0x001BA70B File Offset: 0x001B890B
	private FarmGoldDropDownItem InitDropDownItem()
	{
		FarmGoldDropDownItem farmGoldDropDownItem = new FarmGoldDropDownItem();
		farmGoldDropDownItem.SetActivityData(this.ActivityData);
		farmGoldDropDownItem.SetClickCallback(new Action<int, int>(this.OnClickDropDownItem));
		return farmGoldDropDownItem;
	}

	// Token: 0x060053BB RID: 21435 RVA: 0x001BA730 File Offset: 0x001B8930
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

	// Token: 0x060053BC RID: 21436 RVA: 0x001BA790 File Offset: 0x001B8990
	public void SetActivityData(FarmGoldData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x060053BD RID: 21437 RVA: 0x001BA799 File Offset: 0x001B8999
	public void RefreshLevelData(FarmGoldLevelData data)
	{
		this.Data = data;
		this.RefreshRootText();
		this.RefresDifficulScroll();
	}

	// Token: 0x060053BE RID: 21438 RVA: 0x001BA7B0 File Offset: 0x001B89B0
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

	// Token: 0x060053BF RID: 21439 RVA: 0x001BA80C File Offset: 0x001B8A0C
	private void RefreshRootText()
	{
		if (this.Data == null)
		{
			return;
		}
		string difficultTogText = this.ActivityData.GetDifficultTogText(this.Data.GetSelectDifficult());
		base.GetText(1).SetText(difficultTogText, true);
	}

	// Token: 0x060053C0 RID: 21440 RVA: 0x001BA847 File Offset: 0x001B8A47
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

	// Token: 0x060053C1 RID: 21441 RVA: 0x001BA874 File Offset: 0x001B8A74
	private void SetToggleState(bool foldView)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(foldView ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060053C2 RID: 21442 RVA: 0x001BA892 File Offset: 0x001B8A92
	private void HideScroll()
	{
		this.ChangeScrollActive(false);
	}

	// Token: 0x060053C3 RID: 21443 RVA: 0x001BA89C File Offset: 0x001B8A9C
	private UniTask ShowMaskButton()
	{
		FarmGoldDropDownRoot.<ShowMaskButton>d__17 <ShowMaskButton>d__;
		<ShowMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowMaskButton>d__.<>4__this = this;
		<ShowMaskButton>d__.<>1__state = -1;
		<ShowMaskButton>d__.<>t__builder.Start<FarmGoldDropDownRoot.<ShowMaskButton>d__17>(ref <ShowMaskButton>d__);
		return <ShowMaskButton>d__.<>t__builder.Task;
	}

	// Token: 0x060053C4 RID: 21444 RVA: 0x001BA8DF File Offset: 0x001B8ADF
	private void HideMaskButton()
	{
		if (this.MaskButton == null)
		{
			return;
		}
		this.MaskButton.ResetItemParent();
		this.MaskButton.SetActive(false);
	}

	// Token: 0x04003AC9 RID: 15049
	[Nullable(2)]
	private FarmGoldData ActivityData;

	// Token: 0x04003ACA RID: 15050
	[Nullable(2)]
	private FarmGoldLevelData Data;

	// Token: 0x04003ACB RID: 15051
	[Nullable(2)]
	private DynamicMaskButton MaskButton;

	// Token: 0x04003ACC RID: 15052
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<FarmGoldDropDownItem, FarmGoldDifficulty> ScrollView;

	// Token: 0x02006A03 RID: 27139
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022E45 RID: 142917
		RootToggle,
		// Token: 0x04022E46 RID: 142918
		RootText,
		// Token: 0x04022E47 RID: 142919
		SortToggle,
		// Token: 0x04022E48 RID: 142920
		ScrollView,
		// Token: 0x04022E49 RID: 142921
		TogItem
	}
}
