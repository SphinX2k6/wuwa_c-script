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

// Token: 0x02001039 RID: 4153
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTechnologyView : UiViewBase
{
	// Token: 0x0600A55D RID: 42333 RVA: 0x0030A1DC File Offset: 0x003083DC
	public FloroRanchTechnologyView(UiViewInfo info) : base(info)
	{
		this.TechnologyCoinData = new FloroRanchCurrencyData(ECurrencyType.TechnologyCoin);
	}

	// Token: 0x0600A55E RID: 42334 RVA: 0x0030A1FC File Offset: 0x003083FC
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

	// Token: 0x0600A55F RID: 42335 RVA: 0x0030A38C File Offset: 0x0030858C
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchTechnologyView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchTechnologyView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A560 RID: 42336 RVA: 0x0030A3D0 File Offset: 0x003085D0
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

	// Token: 0x0600A561 RID: 42337 RVA: 0x0030A40C File Offset: 0x0030860C
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

	// Token: 0x0600A562 RID: 42338 RVA: 0x0030A43F File Offset: 0x0030863F
	public void TrySelectTechNode(FloroRanchTechNodeItem technologyNode)
	{
		if (this.CurSelectNode == null)
		{
			this.CurSelectNode = technologyNode;
			this.OnSelectTechNode(technologyNode);
		}
	}

	// Token: 0x0600A563 RID: 42339 RVA: 0x0030A458 File Offset: 0x00308658
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

	// Token: 0x0600A564 RID: 42340 RVA: 0x0030A4BB File Offset: 0x003086BB
	private void OnBtnCloseClick()
	{
		EventSystem.Instance.Emit(EEventName.FloroRanchDataRedDot);
		base.CloseMe(null);
	}

	// Token: 0x0600A565 RID: 42341 RVA: 0x0030A4D4 File Offset: 0x003086D4
	private FloroRanchTechGridPanel CreateGridPanel()
	{
		return new FloroRanchTechGridPanel
		{
			OnSelectTechNode = new Action<FloroRanchTechNodeItem>(this.OnSelectTechNode)
		};
	}

	// Token: 0x040060DB RID: 24795
	[Nullable(2)]
	private FloroRanchActivityData ActivityData;

	// Token: 0x040060DC RID: 24796
	private List<List<FloroRanchTechnologyData>> TechnologyTreeList = new List<List<FloroRanchTechnologyData>>();

	// Token: 0x040060DD RID: 24797
	[Nullable(2)]
	public FloroRanchTechNodeItem CurSelectNode;

	// Token: 0x040060DE RID: 24798
	[Nullable(2)]
	public FloroRanchTechDetailPanel TechDetailPanel;

	// Token: 0x040060DF RID: 24799
	[Nullable(2)]
	public FloroRanchUnlockSuccessPanel UnlockSuccessPanel;

	// Token: 0x040060E0 RID: 24800
	public FloroRanchCurrencyData TechnologyCoinData;

	// Token: 0x040060E1 RID: 24801
	[Nullable(2)]
	private FloroRanchCurrencyItem CostItem;

	// Token: 0x040060E2 RID: 24802
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public GenericScrollViewNew<FloroRanchTechGridPanel, List<FloroRanchTechnologyData>> ScrollView;

	// Token: 0x02007289 RID: 29321
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402549F RID: 152735
		public const int BtnClose = 0;

		// Token: 0x040254A0 RID: 152736
		public const int ItemCost = 1;

		// Token: 0x040254A1 RID: 152737
		public const int ItemTechDetailPanel = 2;

		// Token: 0x040254A2 RID: 152738
		public const int LoopScrollView = 3;

		// Token: 0x040254A3 RID: 152739
		public const int LayoutTechGrid = 4;

		// Token: 0x040254A4 RID: 152740
		public const int ItemTechGrid = 5;

		// Token: 0x040254A5 RID: 152741
		public const int BtnMask = 6;

		// Token: 0x040254A6 RID: 152742
		public const int ItemMask = 7;

		// Token: 0x040254A7 RID: 152743
		public const int ItemUnlockSuccessPanel = 8;
	}
}
