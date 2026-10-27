using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FloroRanch;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B7A RID: 7034
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTechnologyView : UiViewBase
{
	// Token: 0x0600D14C RID: 53580 RVA: 0x002FF104 File Offset: 0x002FD304
	public FloroRanchTechnologyView(UiViewInfo info) : base(info)
	{
		this.TechnologyCoinData = new FloroRanchCurrencyData(ECurrencyType.TechnologyCoin);
	}

	// Token: 0x0600D14D RID: 53581 RVA: 0x002FF124 File Offset: 0x002FD324
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnCloseClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D14E RID: 53582 RVA: 0x002FF2B4 File Offset: 0x002FD4B4
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchTechnologyView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchTechnologyView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D14F RID: 53583 RVA: 0x002FF2F8 File Offset: 0x002FD4F8
	private void RefreshCurrencyNum()
	{
		int technologyCoinNum = this.ActivityData.GetTechnologyCoinNum();
		this.TechnologyCoinData.SetAmount((long)technologyCoinNum);
		FloroRanchCurrencyItem costItem = this.CostItem;
		if (costItem == null)
		{
			return;
		}
		costItem.SetCurrencyData(this.TechnologyCoinData);
	}

	// Token: 0x0600D150 RID: 53584 RVA: 0x002FF334 File Offset: 0x002FD534
	private void UnlockSuccessCallback(string textId)
	{
		FloroRanchUnlockSuccessPanel unlockSuccessPanel = this.UnlockSuccessPanel;
		if (unlockSuccessPanel != null)
		{
			unlockSuccessPanel.RefreshPanel(textId);
		}
		GenericScrollViewNew<FloroRanchTechGridPanel, List<FloroRanchTechnologyData>> scrollView = this.ScrollView;
		if (scrollView != null)
		{
			scrollView.RefreshByData(this.TechnologyTreeList, null, false);
		}
		this.RefreshCurrencyNum();
	}

	// Token: 0x0600D151 RID: 53585 RVA: 0x002FF367 File Offset: 0x002FD567
	public void TrySelectTechNode(FloroRanchTechNodeItem technologyNode)
	{
		if (this.CurSelectNode == null)
		{
			this.CurSelectNode = technologyNode;
			this.OnSelectTechNode(technologyNode);
		}
	}

	// Token: 0x0600D152 RID: 53586 RVA: 0x002FF380 File Offset: 0x002FD580
	private void OnSelectTechNode(FloroRanchTechNodeItem technologyNode)
	{
		if (this.CurSelectNode != null)
		{
			this.CurSelectNode.SetToggleState(EToggleState.ETT_UnChecked);
		}
		this.CurSelectNode = technologyNode;
		this.CurSelectNode.SetToggleState(EToggleState.ETT_Checked);
		this.TechDetailPanel.Refresh(technologyNode.Data);
		this.TechDetailPanel.SetUiActive(true);
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(true);
	}

	// Token: 0x0600D153 RID: 53587 RVA: 0x002FF3E3 File Offset: 0x002FD5E3
	private void OnBtnCloseClick()
	{
		EventSystem.Instance.Emit(EEventName.FloroRanchDataRedDot);
		base.CloseMe(null);
	}

	// Token: 0x0600D154 RID: 53588 RVA: 0x002FF3FC File Offset: 0x002FD5FC
	private FloroRanchTechGridPanel CreateGridPanel()
	{
		return new FloroRanchTechGridPanel
		{
			OnSelectTechNode = new Action<FloroRanchTechNodeItem>(this.OnSelectTechNode)
		};
	}

	// Token: 0x0400600C RID: 24588
	[Nullable(2)]
	private FloroRanchActivityData ActivityData;

	// Token: 0x0400600D RID: 24589
	private List<List<FloroRanchTechnologyData>> TechnologyTreeList = new List<List<FloroRanchTechnologyData>>();

	// Token: 0x0400600E RID: 24590
	[Nullable(2)]
	public FloroRanchTechNodeItem CurSelectNode;

	// Token: 0x0400600F RID: 24591
	[Nullable(2)]
	public FloroRanchTechDetailPanel TechDetailPanel;

	// Token: 0x04006010 RID: 24592
	[Nullable(2)]
	public FloroRanchUnlockSuccessPanel UnlockSuccessPanel;

	// Token: 0x04006011 RID: 24593
	public FloroRanchCurrencyData TechnologyCoinData;

	// Token: 0x04006012 RID: 24594
	[Nullable(2)]
	private FloroRanchCurrencyItem CostItem;

	// Token: 0x04006013 RID: 24595
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public GenericScrollViewNew<FloroRanchTechGridPanel, List<FloroRanchTechnologyData>> ScrollView;

	// Token: 0x020080FB RID: 33019
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A16B RID: 172395
		public const int BtnClose = 0;

		// Token: 0x0402A16C RID: 172396
		public const int ItemCost = 1;

		// Token: 0x0402A16D RID: 172397
		public const int ItemTechDetailPanel = 2;

		// Token: 0x0402A16E RID: 172398
		public const int LoopScrollView = 3;

		// Token: 0x0402A16F RID: 172399
		public const int LayoutTechGrid = 4;

		// Token: 0x0402A170 RID: 172400
		public const int ItemTechGrid = 5;

		// Token: 0x0402A171 RID: 172401
		public const int BtnMask = 6;

		// Token: 0x0402A172 RID: 172402
		public const int ItemMask = 7;

		// Token: 0x0402A173 RID: 172403
		public const int ItemUnlockSuccessPanel = 8;
	}
}
