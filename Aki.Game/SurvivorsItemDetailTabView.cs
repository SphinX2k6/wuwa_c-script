using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002079 RID: 8313
public class SurvivorsItemDetailTabView : UiPanelBase
{
	// Token: 0x06014866 RID: 84070 RVA: 0x005FB32C File Offset: 0x005F952C
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

	// Token: 0x06014867 RID: 84071 RVA: 0x005FB3E0 File Offset: 0x005F95E0
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsItemDetailTabView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsItemDetailTabView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014868 RID: 84072 RVA: 0x005FB423 File Offset: 0x005F9623
	[NullableContext(1)]
	private SurvivorsItemGrid CreateItemProxy()
	{
		SurvivorsItemGrid survivorsItemGrid = new SurvivorsItemGrid();
		survivorsItemGrid.SetClickCallback(new Action<int, int>(this.OnSelectItem));
		survivorsItemGrid.SetCanExecuteChange(new Func<int, bool>(this.CanExecuteChange));
		return survivorsItemGrid;
	}

	// Token: 0x06014869 RID: 84073 RVA: 0x005FB450 File Offset: 0x005F9650
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

	// Token: 0x0601486A RID: 84074 RVA: 0x005FB4D1 File Offset: 0x005F96D1
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

	// Token: 0x0601486B RID: 84075 RVA: 0x005FB511 File Offset: 0x005F9711
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

	// Token: 0x0601486C RID: 84076 RVA: 0x005FB531 File Offset: 0x005F9731
	private bool CanExecuteChange(int index)
	{
		LoopScrollView<SurvivorsItemGrid, SurvivorsItemGainData> loopScroll = this.LoopScroll;
		return loopScroll == null || loopScroll.GetSelectedGridIndex() != index;
	}

	// Token: 0x0601486D RID: 84077 RVA: 0x005FB54C File Offset: 0x005F974C
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

	// Token: 0x0400ADF6 RID: 44534
	[Nullable(2)]
	private SurvivorsRogueCardBase CardItem;

	// Token: 0x0400ADF7 RID: 44535
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<SurvivorsItemGrid, SurvivorsItemGainData> LoopScroll;
}
