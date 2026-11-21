using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005D3 RID: 1491
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerBuffView : UiViewBase
{
	// Token: 0x0600463F RID: 17983 RVA: 0x00180F84 File Offset: 0x0017F184
	[NullableContext(1)]
	public BabelTowerBuffView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004640 RID: 17984 RVA: 0x00180F94 File Offset: 0x0017F194
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

	// Token: 0x06004641 RID: 17985 RVA: 0x00181168 File Offset: 0x0017F368
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerBuffView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerBuffView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004642 RID: 17986 RVA: 0x001811AB File Offset: 0x0017F3AB
	protected override void OnBeforeShow()
	{
		if (this.SelectedToggle == null)
		{
			this.SelectBuffTabToggle();
		}
	}

	// Token: 0x06004643 RID: 17987 RVA: 0x001811BB File Offset: 0x0017F3BB
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06004644 RID: 17988 RVA: 0x001811C4 File Offset: 0x0017F3C4
	[NullableContext(1)]
	private BabelTowerBuffItem CreateBuffItem()
	{
		return new BabelTowerBuffItem
		{
			OnToggleClick = new Action<int>(this.OnBuffItemClick)
		};
	}

	// Token: 0x06004645 RID: 17989 RVA: 0x001811DD File Offset: 0x0017F3DD
	private void OnBuffItemClick(int index)
	{
		this.SelectBuffItemByIndex(index);
	}

	// Token: 0x06004646 RID: 17990 RVA: 0x001811E6 File Offset: 0x0017F3E6
	private void OnBuffToggleClick(EToggleState state)
	{
		this.SelectBuffTabToggle();
	}

	// Token: 0x06004647 RID: 17991 RVA: 0x001811EE File Offset: 0x0017F3EE
	private void OnDeTermToggleClick(EToggleState state)
	{
		this.SelectDeTermTabToggle();
	}

	// Token: 0x06004648 RID: 17992 RVA: 0x001811F6 File Offset: 0x0017F3F6
	private void SelectBuffTabToggle()
	{
		this.SelectTabToggle(base.GetExtendToggle(2));
		this.OnBuffToggleSelected();
	}

	// Token: 0x06004649 RID: 17993 RVA: 0x0018120B File Offset: 0x0017F40B
	private void SelectDeTermTabToggle()
	{
		this.SelectTabToggle(base.GetExtendToggle(3));
		this.OnDeTermToggleSelected();
	}

	// Token: 0x0600464A RID: 17994 RVA: 0x00181220 File Offset: 0x0017F420
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

	// Token: 0x0600464B RID: 17995 RVA: 0x00181250 File Offset: 0x0017F450
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

	// Token: 0x0600464C RID: 17996 RVA: 0x00181280 File Offset: 0x0017F480
	private UniTask OnTabBuffToggleSelectedAsync()
	{
		BabelTowerBuffView.<OnTabBuffToggleSelectedAsync>d__23 <OnTabBuffToggleSelectedAsync>d__;
		<OnTabBuffToggleSelectedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTabBuffToggleSelectedAsync>d__.<>4__this = this;
		<OnTabBuffToggleSelectedAsync>d__.<>1__state = -1;
		<OnTabBuffToggleSelectedAsync>d__.<>t__builder.Start<BabelTowerBuffView.<OnTabBuffToggleSelectedAsync>d__23>(ref <OnTabBuffToggleSelectedAsync>d__);
		return <OnTabBuffToggleSelectedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600464D RID: 17997 RVA: 0x001812C4 File Offset: 0x0017F4C4
	private UniTask OnTabDeTermToggleSelectedAsync()
	{
		BabelTowerBuffView.<OnTabDeTermToggleSelectedAsync>d__24 <OnTabDeTermToggleSelectedAsync>d__;
		<OnTabDeTermToggleSelectedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTabDeTermToggleSelectedAsync>d__.<>4__this = this;
		<OnTabDeTermToggleSelectedAsync>d__.<>1__state = -1;
		<OnTabDeTermToggleSelectedAsync>d__.<>t__builder.Start<BabelTowerBuffView.<OnTabDeTermToggleSelectedAsync>d__24>(ref <OnTabDeTermToggleSelectedAsync>d__);
		return <OnTabDeTermToggleSelectedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600464E RID: 17998 RVA: 0x00181307 File Offset: 0x0017F507
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

	// Token: 0x0600464F RID: 17999 RVA: 0x00181338 File Offset: 0x0017F538
	private UniTask OnSelectedTabToggleChangeAsync()
	{
		BabelTowerBuffView.<OnSelectedTabToggleChangeAsync>d__26 <OnSelectedTabToggleChangeAsync>d__;
		<OnSelectedTabToggleChangeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnSelectedTabToggleChangeAsync>d__.<>4__this = this;
		<OnSelectedTabToggleChangeAsync>d__.<>1__state = -1;
		<OnSelectedTabToggleChangeAsync>d__.<>t__builder.Start<BabelTowerBuffView.<OnSelectedTabToggleChangeAsync>d__26>(ref <OnSelectedTabToggleChangeAsync>d__);
		return <OnSelectedTabToggleChangeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004650 RID: 18000 RVA: 0x0018137C File Offset: 0x0017F57C
	private void RefreshDetailItem()
	{
		if (this.BuffItemDataList == null || this.SelectedBuffItemIndex < 0 || this.SelectedBuffItemIndex >= this.BuffItemDataList.Count)
		{
			return;
		}
		this.DetailItem.Update(this.BuffItemDataList[this.SelectedBuffItemIndex]);
	}

	// Token: 0x06004651 RID: 18001 RVA: 0x001813CC File Offset: 0x0017F5CC
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

	// Token: 0x06004652 RID: 18002 RVA: 0x00181471 File Offset: 0x0017F671
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

	// Token: 0x040035A8 RID: 13736
	private IBabelTowerBuffViewData Data;

	// Token: 0x040035A9 RID: 13737
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BabelTowerBuffItem, IBabelTowerBuffItemData> BuffScrollView;

	// Token: 0x040035AA RID: 13738
	private BabelTowerBuffDetailItem DetailItem;

	// Token: 0x040035AB RID: 13739
	private UUIExtendToggle SelectedToggle;

	// Token: 0x040035AC RID: 13740
	private PopupCaptionItem CaptionItem;

	// Token: 0x040035AD RID: 13741
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IBabelTowerBuffItemData> BuffItemDataList;

	// Token: 0x040035AE RID: 13742
	private BabelTowerBuffView.ETab? SelectedTab;

	// Token: 0x040035AF RID: 13743
	private int SelectedBuffItemIndex = -1;

	// Token: 0x0200687A RID: 26746
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022703 RID: 141059
		public const int CaptionItem = 0;

		// Token: 0x04022704 RID: 141060
		public const int BackButton = 1;

		// Token: 0x04022705 RID: 141061
		public const int BuffToggle = 2;

		// Token: 0x04022706 RID: 141062
		public const int DeTermToggle = 3;

		// Token: 0x04022707 RID: 141063
		public const int BuffItemScrollView = 4;

		// Token: 0x04022708 RID: 141064
		public const int BuffItem = 5;

		// Token: 0x04022709 RID: 141065
		public const int EmptyItem = 6;

		// Token: 0x0402270A RID: 141066
		public const int EmptyText = 7;

		// Token: 0x0402270B RID: 141067
		public const int TipsItem = 8;
	}

	// Token: 0x0200687B RID: 26747
	[NullableContext(0)]
	private enum ETab
	{
		// Token: 0x0402270D RID: 141069
		BuffTab,
		// Token: 0x0402270E RID: 141070
		DeTermTab
	}
}
