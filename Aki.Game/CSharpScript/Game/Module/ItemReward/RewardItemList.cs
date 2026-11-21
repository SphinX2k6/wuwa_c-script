using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047E3 RID: 18403
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardItemList : UiPanelBase
	{
		// Token: 0x0602E3C3 RID: 189379 RVA: 0x00CE5518 File Offset: 0x00CE3718
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

		// Token: 0x0602E3C4 RID: 189380 RVA: 0x00CE55AD File Offset: 0x00CE37AD
		protected override void OnStart()
		{
			this.SourceItem = base.GetItem(1);
			this.SourceItem.SetUIActive(false);
			this.GenericScrollView = new GenericScrollViewNew<RewardSmallItemGrid, RewardItemData>(base.GetScrollViewWithScrollbar(2), new Func<RewardSmallItemGrid>(this.OnCreateRewardItem), null, false, null);
		}

		// Token: 0x0602E3C5 RID: 189381 RVA: 0x00CE55E9 File Offset: 0x00CE37E9
		protected override void OnBeforeDestroy()
		{
			this.SelectedItemGrid = null;
			this.GenericScrollView = null;
		}

		// Token: 0x0602E3C6 RID: 189382 RVA: 0x00CE55F9 File Offset: 0x00CE37F9
		private RewardSmallItemGrid OnCreateRewardItem()
		{
			return this.NewRewardItem();
		}

		// Token: 0x0602E3C7 RID: 189383 RVA: 0x00CE5604 File Offset: 0x00CE3804
		public void Refresh(List<RewardItemData> rewardItemDataList, bool tipsCanSkip = true)
		{
			rewardItemDataList.Sort(delegate(RewardItemData aRewardItem, RewardItemData bRewardItem)
			{
				EDropItemType dropItemType = aRewardItem.GetDropItemType();
				EDropItemType dropItemType2 = bRewardItem.GetDropItemType();
				if (dropItemType != dropItemType2)
				{
					return dropItemType2 - dropItemType;
				}
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
			this.TipsCanSkip = new bool?(tipsCanSkip);
		}

		// Token: 0x0602E3C8 RID: 189384 RVA: 0x00CE5650 File Offset: 0x00CE3850
		private RewardSmallItemGrid NewRewardItem()
		{
			RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
			rewardSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
			return rewardSmallItemGrid;
		}

		// Token: 0x0602E3C9 RID: 189385 RVA: 0x00CE5690 File Offset: 0x00CE3890
		private void OnClickedRewardItem(MediumItemGridExtendCallback callbackParameter)
		{
			ItemGridBase selectedItemGrid = this.SelectedItemGrid;
			if (selectedItemGrid != null)
			{
				selectedItemGrid.SetSelected(false, true);
			}
			this.SelectedItemGrid = callbackParameter.MediumItemGrid;
			RewardItemData rewardItemData = callbackParameter.Data as RewardItemData;
			int configId = rewardItemData.ConfigId;
			int uniqueId = rewardItemData.UniqueId;
			if (uniqueId > 0)
			{
				ItemController.Instance.OpenItemTipsByItemUid(uniqueId, configId, true, null);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(configId, this.TipsCanSkip.GetValueOrDefault(true), null, false);
		}

		// Token: 0x040189F2 RID: 100850
		[Nullable(2)]
		private UUIItem SourceItem;

		// Token: 0x040189F3 RID: 100851
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RewardSmallItemGrid, RewardItemData> GenericScrollView;

		// Token: 0x040189F4 RID: 100852
		[Nullable(2)]
		private ItemGridBase SelectedItemGrid;

		// Token: 0x040189F5 RID: 100853
		private bool? TipsCanSkip;

		// Token: 0x0200A423 RID: 42019
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032DB3 RID: 208307
			public const int ItemContentItem = 0;

			// Token: 0x04032DB4 RID: 208308
			public const int SourceItem = 1;

			// Token: 0x04032DB5 RID: 208309
			public const int ScrollViewWithScrollbar = 2;
		}
	}
}
