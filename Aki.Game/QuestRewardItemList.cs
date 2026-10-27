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

// Token: 0x02001DA4 RID: 7588
[NullableContext(1)]
[Nullable(0)]
public class QuestRewardItemList : UiPanelBase
{
	// Token: 0x0600E64B RID: 58955 RVA: 0x0036489D File Offset: 0x00362A9D
	[NullableContext(2)]
	public QuestRewardItemList(AActor rootActor)
	{
		if (rootActor == null)
		{
			return;
		}
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x0600E64C RID: 58956 RVA: 0x003648B4 File Offset: 0x00362AB4
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

	// Token: 0x0600E64D RID: 58957 RVA: 0x00364949 File Offset: 0x00362B49
	protected override void OnStart()
	{
		this.SourceItem = base.GetItem(1);
		this.SourceItem.SetUIActive(false);
		this.GenericScrollView = new GenericScrollViewNew<QuestRewardItemGrid, RewardItemData>(base.GetScrollViewWithScrollbar(2), new Func<QuestRewardItemGrid>(this.OnCreateRewardItem), null, false, null);
	}

	// Token: 0x0600E64E RID: 58958 RVA: 0x00364988 File Offset: 0x00362B88
	private QuestRewardItemGrid OnCreateRewardItem()
	{
		QuestRewardItemGrid questRewardItemGrid = new QuestRewardItemGrid();
		questRewardItemGrid.ItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		questRewardItemGrid.ItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
		return questRewardItemGrid;
	}

	// Token: 0x0600E64F RID: 58959 RVA: 0x003649DB File Offset: 0x00362BDB
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

	// Token: 0x0600E650 RID: 58960 RVA: 0x00364A10 File Offset: 0x00362C10
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
		ItemController.Instance.OpenItemTipsByItemId(configId, true, null);
	}

	// Token: 0x04006A91 RID: 27281
	[Nullable(2)]
	private UUIItem SourceItem;

	// Token: 0x04006A92 RID: 27282
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<QuestRewardItemGrid, RewardItemData> GenericScrollView;

	// Token: 0x04006A93 RID: 27283
	[Nullable(2)]
	private ItemGridBase SelectedItemGrid;

	// Token: 0x02008382 RID: 33666
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402ADA4 RID: 175524
		public const int ItemContentItem = 0;

		// Token: 0x0402ADA5 RID: 175525
		public const int SourceItem = 1;

		// Token: 0x0402ADA6 RID: 175526
		public const int ScrollViewWithScrollbar = 2;
	}
}
