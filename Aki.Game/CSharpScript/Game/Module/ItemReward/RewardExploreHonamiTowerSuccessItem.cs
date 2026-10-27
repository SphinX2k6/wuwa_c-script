using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02005800 RID: 22528
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreHonamiTowerSuccessItem : UiPanelBase
	{
		// Token: 0x0603945F RID: 234591 RVA: 0x00D95018 File Offset: 0x00D93218
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

		// Token: 0x06039460 RID: 234592 RVA: 0x00D950C4 File Offset: 0x00D932C4
		protected override void OnStart()
		{
			this.RecordLayout = new GenericLayout<HonamiTowerRecordItem, IHonamiTowerRecordData>(base.GetVerticalLayout(0), new Func<HonamiTowerRecordItem>(this.OnCreateRecordItem), null, false, true);
			this.RewardLayout = new GenericLayout<RewardSmallItemGrid, RewardItemData>(base.GetHorizontalLayout(3), new Func<RewardSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
		}

		// Token: 0x06039461 RID: 234593 RVA: 0x00D95113 File Offset: 0x00D93313
		public void Refresh(IHonamiTowerSuccessData data)
		{
			GenericLayout<HonamiTowerRecordItem, IHonamiTowerRecordData> recordLayout = this.RecordLayout;
			if (recordLayout != null)
			{
				recordLayout.RefreshByData(data.RecordItemList.ToList<IHonamiTowerRecordData>(), null, false);
			}
			this.RefreshRewardList(data.RewardItemList.ToList<RewardItemData>());
		}

		// Token: 0x06039462 RID: 234594 RVA: 0x00D95144 File Offset: 0x00D93344
		private HonamiTowerRecordItem OnCreateRecordItem()
		{
			return new HonamiTowerRecordItem();
		}

		// Token: 0x06039463 RID: 234595 RVA: 0x00D9514C File Offset: 0x00D9334C
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

		// Token: 0x06039464 RID: 234596 RVA: 0x00D951C5 File Offset: 0x00D933C5
		private RewardSmallItemGrid OnCreateRewardItem()
		{
			RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
			rewardSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
			return rewardSmallItemGrid;
		}

		// Token: 0x06039465 RID: 234597 RVA: 0x00D95204 File Offset: 0x00D93404
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
			ItemController.Instance.OpenItemTipsByItemId(configId, true, null);
		}

		// Token: 0x0401DF3D RID: 122685
		private ItemGridBase SelectedItemGrid;

		// Token: 0x0401DF3E RID: 122686
		private GenericLayout<HonamiTowerRecordItem, IHonamiTowerRecordData> RecordLayout;

		// Token: 0x0401DF3F RID: 122687
		private GenericLayout<RewardSmallItemGrid, RewardItemData> RewardLayout;

		// Token: 0x0200B9F6 RID: 47606
		[NullableContext(0)]
		private class ESuccessItemType
		{
			// Token: 0x0403837F RID: 230271
			public const int RecordLayout = 0;

			// Token: 0x04038380 RID: 230272
			public const int RewardTitleText = 1;

			// Token: 0x04038381 RID: 230273
			public const int RewardItem = 2;

			// Token: 0x04038382 RID: 230274
			public const int RewardLayout = 3;
		}
	}
}
