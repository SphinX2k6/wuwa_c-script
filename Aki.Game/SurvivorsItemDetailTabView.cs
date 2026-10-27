using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002AFD RID: 11005
public class SurvivorsItemDetailTabView : UiPanelBase
{
	// Token: 0x06016E35 RID: 93749 RVA: 0x005CE7AC File Offset: 0x005CC9AC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture))
		};
	}

	// Token: 0x06016E36 RID: 93750 RVA: 0x005CE860 File Offset: 0x005CCA60
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsItemDetailTabView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsItemDetailTabView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016E37 RID: 93751 RVA: 0x005CE8A3 File Offset: 0x005CCAA3
	[NullableContext(1)]
	private SurvivorsItemGrid CreateItemProxy()
	{
		SurvivorsItemGrid survivorsItemGrid = new SurvivorsItemGrid();
		survivorsItemGrid.SetClickCallback(new Action<int, int>(this.OnSelectItem));
		survivorsItemGrid.SetCanExecuteChange(new Func<int, bool>(this.CanExecuteChange));
		return survivorsItemGrid;
	}

	// Token: 0x06016E38 RID: 93752 RVA: 0x005CE8D0 File Offset: 0x005CCAD0
	protected override void OnStart()
	{
		List<SurvivorsItemGainData> itemGainList = SurvivorsRogueModel.Instance.GainData.GetItemGainList();
		if (itemGainList.Count == 0)
		{
			this.RefreshEmptyState(true);
		}
		else
		{
			this.RefreshEmptyState(false);
			LoopScrollView<SurvivorsItemGrid, SurvivorsItemGainData> loopScroll = this.LoopScroll;
			if (loopScroll != null)
			{
				loopScroll.RefreshByDataAsync(itemGainList, false, false).ContinueWith(delegate()
				{
					LoopScrollView<SurvivorsItemGrid, SurvivorsItemGainData> loopScroll2 = this.LoopScroll;
					if (loopScroll2 != null)
					{
						loopScroll2.ScrollToGridIndex(0, true);
					}
					SurvivorsItemGrid survivorsItemGrid = this.LoopScroll.UnsafeGetGridProxy(0, false);
					if (survivorsItemGrid == null)
					{
						return;
					}
					survivorsItemGrid.SetToggleStateForce(true, true, true);
				});
			}
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "SurvivorsPropAttribute_PropNum", new <>z__ReadOnlySingleElementList<object>(itemGainList.Count));
	}

	// Token: 0x06016E39 RID: 93753 RVA: 0x005CE951 File Offset: 0x005CCB51
	private void RefreshEmptyState(bool isEmpty)
	{
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(!isEmpty);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(isEmpty);
		}
		UUITexture texture = base.GetTexture(6);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(!isEmpty);
	}

	// Token: 0x06016E3A RID: 93754 RVA: 0x005CE991 File Offset: 0x005CCB91
	private void OnSelectItem(int index, int itemId)
	{
		this.RefreshItemCard(new int?(itemId));
		LoopScrollView<SurvivorsItemGrid, SurvivorsItemGainData> loopScroll = this.LoopScroll;
		if (loopScroll == null)
		{
			return;
		}
		loopScroll.SelectGridProxy(index, false);
	}

	// Token: 0x06016E3B RID: 93755 RVA: 0x005CE9B1 File Offset: 0x005CCBB1
	private bool CanExecuteChange(int index)
	{
		LoopScrollView<SurvivorsItemGrid, SurvivorsItemGainData> loopScroll = this.LoopScroll;
		return loopScroll == null || loopScroll.GetSelectedGridIndex() != index;
	}

	// Token: 0x06016E3C RID: 93756 RVA: 0x005CE9CC File Offset: 0x005CCBCC
	private void RefreshItemCard(int? itemId)
	{
		if (itemId == null)
		{
			SurvivorsRogueCardBase cardItem = this.CardItem;
			if (cardItem == null)
			{
				return;
			}
			cardItem.SetUiActive(false);
			return;
		}
		else
		{
			SurvivorsRogueCardBase cardItem2 = this.CardItem;
			if (cardItem2 != null)
			{
				cardItem2.SetUiActive(true);
			}
			SurvivorsRogueItemCard data = SurvivorsRogueCardDataFactory.CreateGeneralItem(itemId.Value);
			SurvivorsRogueCardBase cardItem3 = this.CardItem;
			if (cardItem3 == null)
			{
				return;
			}
			cardItem3.Apply(data);
			return;
		}
	}

	// Token: 0x0400A9F0 RID: 43504
	[Nullable(2)]
	private SurvivorsRogueCardBase CardItem;

	// Token: 0x0400A9F1 RID: 43505
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<SurvivorsItemGrid, SurvivorsItemGainData> LoopScroll;
}
