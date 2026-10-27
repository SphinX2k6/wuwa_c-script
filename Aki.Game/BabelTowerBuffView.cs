using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200111F RID: 4383
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerBuffView : UiViewBase
{
	// Token: 0x060072A9 RID: 29353 RVA: 0x001785C8 File Offset: 0x001767C8
	[NullableContext(1)]
	public BabelTowerBuffView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060072AA RID: 29354 RVA: 0x001785D8 File Offset: 0x001767D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnBuffToggleClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnDeTermToggleClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnCloseBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060072AB RID: 29355 RVA: 0x001787AC File Offset: 0x001769AC
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerBuffView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerBuffView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060072AC RID: 29356 RVA: 0x001787EF File Offset: 0x001769EF
	protected override void OnBeforeShow()
	{
		if (this.SelectedToggle == null)
		{
			this.SelectBuffTabToggle();
		}
	}

	// Token: 0x060072AD RID: 29357 RVA: 0x001787FF File Offset: 0x001769FF
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060072AE RID: 29358 RVA: 0x00178808 File Offset: 0x00176A08
	[NullableContext(1)]
	private BabelTowerBuffItem CreateBuffItem()
	{
		return new BabelTowerBuffItem
		{
			OnToggleClick = new Action<int>(this.OnBuffItemClick)
		};
	}

	// Token: 0x060072AF RID: 29359 RVA: 0x00178821 File Offset: 0x00176A21
	private void OnBuffItemClick(int index)
	{
		this.SelectBuffItemByIndex(index);
	}

	// Token: 0x060072B0 RID: 29360 RVA: 0x0017882A File Offset: 0x00176A2A
	private void OnBuffToggleClick(EToggleState state)
	{
		this.SelectBuffTabToggle();
	}

	// Token: 0x060072B1 RID: 29361 RVA: 0x00178832 File Offset: 0x00176A32
	private void OnDeTermToggleClick(EToggleState state)
	{
		this.SelectDeTermTabToggle();
	}

	// Token: 0x060072B2 RID: 29362 RVA: 0x0017883A File Offset: 0x00176A3A
	private void SelectBuffTabToggle()
	{
		this.SelectTabToggle(base.GetExtendToggle(2));
		this.OnBuffToggleSelected();
	}

	// Token: 0x060072B3 RID: 29363 RVA: 0x0017884F File Offset: 0x00176A4F
	private void SelectDeTermTabToggle()
	{
		this.SelectTabToggle(base.GetExtendToggle(3));
		this.OnDeTermToggleSelected();
	}

	// Token: 0x060072B4 RID: 29364 RVA: 0x00178864 File Offset: 0x00176A64
	private void OnBuffToggleSelected()
	{
		UiAsyncTask task = new UiAsyncTask("BabelTowerBuffView.ToggleSelect", delegate()
		{
			BabelTowerBuffView.<<OnBuffToggleSelected>b__21_0>d <<OnBuffToggleSelected>b__21_0>d;
			<<OnBuffToggleSelected>b__21_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnBuffToggleSelected>b__21_0>d.<>4__this = this;
			<<OnBuffToggleSelected>b__21_0>d.<>1__state = -1;
			<<OnBuffToggleSelected>b__21_0>d.<>t__builder.Start<BabelTowerBuffView.<<OnBuffToggleSelected>b__21_0>d>(ref <<OnBuffToggleSelected>b__21_0>d);
			return <<OnBuffToggleSelected>b__21_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060072B5 RID: 29365 RVA: 0x00178894 File Offset: 0x00176A94
	private void OnDeTermToggleSelected()
	{
		UiAsyncTask task = new UiAsyncTask("BabelTowerBuffView.ToggleSelect", delegate()
		{
			BabelTowerBuffView.<<OnDeTermToggleSelected>b__22_0>d <<OnDeTermToggleSelected>b__22_0>d;
			<<OnDeTermToggleSelected>b__22_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnDeTermToggleSelected>b__22_0>d.<>4__this = this;
			<<OnDeTermToggleSelected>b__22_0>d.<>1__state = -1;
			<<OnDeTermToggleSelected>b__22_0>d.<>t__builder.Start<BabelTowerBuffView.<<OnDeTermToggleSelected>b__22_0>d>(ref <<OnDeTermToggleSelected>b__22_0>d);
			return <<OnDeTermToggleSelected>b__22_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060072B6 RID: 29366 RVA: 0x001788C4 File Offset: 0x00176AC4
	private UniTask OnTabBuffToggleSelectedAsync()
	{
		BabelTowerBuffView.<OnTabBuffToggleSelectedAsync>d__23 <OnTabBuffToggleSelectedAsync>d__;
		<OnTabBuffToggleSelectedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTabBuffToggleSelectedAsync>d__.<>4__this = this;
		<OnTabBuffToggleSelectedAsync>d__.<>1__state = -1;
		<OnTabBuffToggleSelectedAsync>d__.<>t__builder.Start<BabelTowerBuffView.<OnTabBuffToggleSelectedAsync>d__23>(ref <OnTabBuffToggleSelectedAsync>d__);
		return <OnTabBuffToggleSelectedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060072B7 RID: 29367 RVA: 0x00178908 File Offset: 0x00176B08
	private UniTask OnTabDeTermToggleSelectedAsync()
	{
		BabelTowerBuffView.<OnTabDeTermToggleSelectedAsync>d__24 <OnTabDeTermToggleSelectedAsync>d__;
		<OnTabDeTermToggleSelectedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTabDeTermToggleSelectedAsync>d__.<>4__this = this;
		<OnTabDeTermToggleSelectedAsync>d__.<>1__state = -1;
		<OnTabDeTermToggleSelectedAsync>d__.<>t__builder.Start<BabelTowerBuffView.<OnTabDeTermToggleSelectedAsync>d__24>(ref <OnTabDeTermToggleSelectedAsync>d__);
		return <OnTabDeTermToggleSelectedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060072B8 RID: 29368 RVA: 0x0017894B File Offset: 0x00176B4B
	[NullableContext(1)]
	private void SelectTabToggle(UUIExtendToggle toggle)
	{
		UUIExtendToggle selectedToggle = this.SelectedToggle;
		if (selectedToggle != null)
		{
			selectedToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.SelectedToggle = toggle;
		this.SelectedToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060072B9 RID: 29369 RVA: 0x0017897C File Offset: 0x00176B7C
	private UniTask OnSelectedTabToggleChangeAsync()
	{
		BabelTowerBuffView.<OnSelectedTabToggleChangeAsync>d__26 <OnSelectedTabToggleChangeAsync>d__;
		<OnSelectedTabToggleChangeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnSelectedTabToggleChangeAsync>d__.<>4__this = this;
		<OnSelectedTabToggleChangeAsync>d__.<>1__state = -1;
		<OnSelectedTabToggleChangeAsync>d__.<>t__builder.Start<BabelTowerBuffView.<OnSelectedTabToggleChangeAsync>d__26>(ref <OnSelectedTabToggleChangeAsync>d__);
		return <OnSelectedTabToggleChangeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060072BA RID: 29370 RVA: 0x001789C0 File Offset: 0x00176BC0
	private void RefreshDetailItem()
	{
		if (this.BuffItemDataList == null || this.SelectedBuffItemIndex < 0 || this.SelectedBuffItemIndex >= this.BuffItemDataList.Count)
		{
			return;
		}
		this.DetailItem.Update(this.BuffItemDataList[this.SelectedBuffItemIndex]);
	}

	// Token: 0x060072BB RID: 29371 RVA: 0x00178A10 File Offset: 0x00176C10
	private void UpdateEmptyState(bool isEmpty)
	{
		base.GetItem(6).SetUIActive(isEmpty);
		if (isEmpty)
		{
			string textStringId = "";
			BabelTowerBuffView.ETab? selectedTab = this.SelectedTab;
			BabelTowerBuffView.ETab etab = BabelTowerBuffView.ETab.BuffTab;
			if (selectedTab.GetValueOrDefault() == etab & selectedTab != null)
			{
				textStringId = "PrefabTextItem_1001383652_Text";
			}
			else if (this.SelectedTab.GetValueOrDefault() == BabelTowerBuffView.ETab.DeTermTab)
			{
				textStringId = "PrefabTextItem_438129107_Text";
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), textStringId, Array.Empty<object>());
		}
		UUIItem uuiitem = base.GetLoopScrollViewComponent(4).RootUIComp.Get();
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(!isEmpty);
		}
		this.DetailItem.SetActive(!isEmpty);
	}

	// Token: 0x060072BC RID: 29372 RVA: 0x00178AB5 File Offset: 0x00176CB5
	private void SelectBuffItemByIndex(int index)
	{
		if (this.BuffItemDataList == null || index < 0 || index >= this.BuffItemDataList.Count)
		{
			return;
		}
		this.SelectedBuffItemIndex = index;
		LoopScrollView<BabelTowerBuffItem, IBabelTowerBuffItemData> buffScrollView = this.BuffScrollView;
		if (buffScrollView != null)
		{
			buffScrollView.SelectGridProxy(index, false);
		}
		this.RefreshDetailItem();
	}

	// Token: 0x0400350F RID: 13583
	private IBabelTowerBuffViewData Data;

	// Token: 0x04003510 RID: 13584
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BabelTowerBuffItem, IBabelTowerBuffItemData> BuffScrollView;

	// Token: 0x04003511 RID: 13585
	private BabelTowerBuffDetailItem DetailItem;

	// Token: 0x04003512 RID: 13586
	private UUIExtendToggle SelectedToggle;

	// Token: 0x04003513 RID: 13587
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003514 RID: 13588
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IBabelTowerBuffItemData> BuffItemDataList;

	// Token: 0x04003515 RID: 13589
	private BabelTowerBuffView.ETab? SelectedTab;

	// Token: 0x04003516 RID: 13590
	private int SelectedBuffItemIndex = -1;

	// Token: 0x020076E6 RID: 30438
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040273BA RID: 160698
		public const int CaptionItem = 0;

		// Token: 0x040273BB RID: 160699
		public const int BackButton = 1;

		// Token: 0x040273BC RID: 160700
		public const int BuffToggle = 2;

		// Token: 0x040273BD RID: 160701
		public const int DeTermToggle = 3;

		// Token: 0x040273BE RID: 160702
		public const int BuffItemScrollView = 4;

		// Token: 0x040273BF RID: 160703
		public const int BuffItem = 5;

		// Token: 0x040273C0 RID: 160704
		public const int EmptyItem = 6;

		// Token: 0x040273C1 RID: 160705
		public const int EmptyText = 7;

		// Token: 0x040273C2 RID: 160706
		public const int TipsItem = 8;
	}

	// Token: 0x020076E7 RID: 30439
	[NullableContext(0)]
	private enum ETab
	{
		// Token: 0x040273C4 RID: 160708
		BuffTab,
		// Token: 0x040273C5 RID: 160709
		DeTermTab
	}
}
