using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001266 RID: 4710
[NullableContext(1)]
[Nullable(0)]
public class QuestRewardItemList : UiPanelBase
{
	// Token: 0x0600BA69 RID: 47721 RVA: 0x003704FD File Offset: 0x0036E6FD
	[NullableContext(2)]
	public QuestRewardItemList(AActor rootActor)
	{
		if (rootActor == null)
		{
			return;
		}
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x0600BA6A RID: 47722 RVA: 0x00370514 File Offset: 0x0036E714
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x0600BA6B RID: 47723 RVA: 0x003705A9 File Offset: 0x0036E7A9
	protected override void OnStart()
	{
		this.SourceItem = base.GetItem(1);
		this.SourceItem.SetUIActive(false);
		this.GenericScrollView = new GenericScrollViewNew<QuestRewardItemGrid, RewardItemData>(base.GetScrollViewWithScrollbar(2), new Func<QuestRewardItemGrid>(this.OnCreateRewardItem), null, false, null);
	}

	// Token: 0x0600BA6C RID: 47724 RVA: 0x003705E8 File Offset: 0x0036E7E8
	private QuestRewardItemGrid OnCreateRewardItem()
	{
		QuestRewardItemGrid questRewardItemGrid = new QuestRewardItemGrid();
		questRewardItemGrid.ItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		questRewardItemGrid.ItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
		return questRewardItemGrid;
	}

	// Token: 0x0600BA6D RID: 47725 RVA: 0x0037063B File Offset: 0x0036E83B
	public void Refresh(List<RewardItemData> rewardItemDataList)
	{
		rewardItemDataList.Sort(delegate(RewardItemData aRewardItem, RewardItemData bRewardItem)
		{
			int typeSortIndex = aRewardItem.GetTypeSortIndex();
			int typeSortIndex2 = bRewardItem.GetTypeSortIndex();
			if (typeSortIndex != typeSortIndex2)
			{
				return typeSortIndex2 - typeSortIndex;
			}
			int qualityId = aRewardItem.GetQualityId();
			int qualityId2 = bRewardItem.GetQualityId();
			if (qualityId != qualityId2)
			{
				return qualityId2 - qualityId;
			}
			return aRewardItem.ConfigId - bRewardItem.ConfigId;
		});
		this.GenericScrollView.RefreshByData(rewardItemDataList, null, false);
	}

	// Token: 0x0600BA6E RID: 47726 RVA: 0x00370670 File Offset: 0x0036E870
	private void OnClickedRewardItem(MediumItemGridExtendCallback callbackParameter)
	{
		ItemGridBase selectedItemGrid = this.SelectedItemGrid;
		if (selectedItemGrid != null)
		{
			selectedItemGrid.SetSelected(false, true);
		}
		this.SelectedItemGrid = callbackParameter.MediumItemGrid;
		RewardItemData rewardItemData = (RewardItemData)callbackParameter.Data;
		int configId = rewardItemData.ConfigId;
		int uniqueId = rewardItemData.UniqueId;
		if (uniqueId > 0)
		{
			ItemController.Instance.OpenItemTipsByItemUid(uniqueId, configId, true, null);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(configId, true, null, false);
	}

	// Token: 0x04006B72 RID: 27506
	[Nullable(2)]
	private UUIItem SourceItem;

	// Token: 0x04006B73 RID: 27507
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<QuestRewardItemGrid, RewardItemData> GenericScrollView;

	// Token: 0x04006B74 RID: 27508
	[Nullable(2)]
	private ItemGridBase SelectedItemGrid;

	// Token: 0x0200750A RID: 29962
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040260CA RID: 155850
		public const int ItemContentItem = 0;

		// Token: 0x040260CB RID: 155851
		public const int SourceItem = 1;

		// Token: 0x040260CC RID: 155852
		public const int ScrollViewWithScrollbar = 2;
	}
}
