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
	// Token: 0x020047D7 RID: 18391
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreHonamiTowerSuccessItem : UiPanelBase
	{
		// Token: 0x0602E373 RID: 189299 RVA: 0x00CE3E64 File Offset: 0x00CE2064
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E374 RID: 189300 RVA: 0x00CE3F10 File Offset: 0x00CE2110
		protected override void OnStart()
		{
			this.RecordLayout = new GenericLayout<HonamiTowerRecordItem, IHonamiTowerRecordData>(base.GetVerticalLayout(0), new Func<HonamiTowerRecordItem>(this.OnCreateRecordItem), null, false, true);
			this.RewardLayout = new GenericLayout<RewardSmallItemGrid, RewardItemData>(base.GetHorizontalLayout(3), new Func<RewardSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
		}

		// Token: 0x0602E375 RID: 189301 RVA: 0x00CE3F5F File Offset: 0x00CE215F
		public void Refresh(IHonamiTowerSuccessData data)
		{
			GenericLayout<HonamiTowerRecordItem, IHonamiTowerRecordData> recordLayout = this.RecordLayout;
			if (recordLayout != null)
			{
				recordLayout.RefreshByData(data.RecordItemList, null, false);
			}
			this.RefreshRewardList(new List<RewardItemData>(data.RewardItemList));
		}

		// Token: 0x0602E376 RID: 189302 RVA: 0x00CE3F8B File Offset: 0x00CE218B
		private HonamiTowerRecordItem OnCreateRecordItem()
		{
			return new HonamiTowerRecordItem();
		}

		// Token: 0x0602E377 RID: 189303 RVA: 0x00CE3F94 File Offset: 0x00CE2194
		private void RefreshRewardList(List<RewardItemData> rewardList)
		{
			bool flag = rewardList.Count > 0;
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			rewardList.Sort(delegate(RewardItemData aRewardItem, RewardItemData bRewardItem)
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
			GenericLayout<RewardSmallItemGrid, RewardItemData> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByData(rewardList, null, false);
		}

		// Token: 0x0602E378 RID: 189304 RVA: 0x00CE400D File Offset: 0x00CE220D
		private RewardSmallItemGrid OnCreateRewardItem()
		{
			RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
			rewardSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
			return rewardSmallItemGrid;
		}

		// Token: 0x0602E379 RID: 189305 RVA: 0x00CE404C File Offset: 0x00CE224C
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
			ItemController.Instance.OpenItemTipsByItemId(configId, true, null, false);
		}

		// Token: 0x040189D4 RID: 100820
		private ItemGridBase SelectedItemGrid;

		// Token: 0x040189D5 RID: 100821
		private GenericLayout<HonamiTowerRecordItem, IHonamiTowerRecordData> RecordLayout;

		// Token: 0x040189D6 RID: 100822
		private GenericLayout<RewardSmallItemGrid, RewardItemData> RewardLayout;

		// Token: 0x0200A40C RID: 41996
		[NullableContext(0)]
		private class ESuccessItemType
		{
			// Token: 0x04032D6C RID: 208236
			public const int RecordLayout = 0;

			// Token: 0x04032D6D RID: 208237
			public const int RewardTitleText = 1;

			// Token: 0x04032D6E RID: 208238
			public const int RewardItem = 2;

			// Token: 0x04032D6F RID: 208239
			public const int RewardLayout = 3;
		}
	}
}
