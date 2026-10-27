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
	// Token: 0x020057FD RID: 22525
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreDangoAbyssSuccessItem : UiPanelBase
	{
		// Token: 0x0603944C RID: 234572 RVA: 0x00D94A3C File Offset: 0x00D92C3C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603944D RID: 234573 RVA: 0x00D94B29 File Offset: 0x00D92D29
		protected override void OnStart()
		{
			this.GenericScrollView = new GenericLayout<RewardSmallItemGrid, RewardItemData>(base.GetGridLayout(2), new Func<RewardSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
		}

		// Token: 0x0603944E RID: 234574 RVA: 0x00D94B4C File Offset: 0x00D92D4C
		public void Refresh(IDangoAbyssSuccessData data)
		{
			this.RefreshReward(data.RewardItemData);
			this.RefreshProgress(data.Progress);
		}

		// Token: 0x0603944F RID: 234575 RVA: 0x00D94B68 File Offset: 0x00D92D68
		private void RefreshProgress(float progress)
		{
			int num = (int)Math.Floor((double)(progress * 100f));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "AbyssLevelProgress", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
		}

		// Token: 0x06039450 RID: 234576 RVA: 0x00D94BA8 File Offset: 0x00D92DA8
		private void RefreshReward(List<RewardItemData> rewardItemDataList)
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
			base.GetItem(5).SetUIActive(rewardItemDataList.Count > 0);
		}

		// Token: 0x06039451 RID: 234577 RVA: 0x00D94BFD File Offset: 0x00D92DFD
		private RewardSmallItemGrid OnCreateRewardItem()
		{
			return this.NewRewardItem();
		}

		// Token: 0x06039452 RID: 234578 RVA: 0x00D94C05 File Offset: 0x00D92E05
		private RewardSmallItemGrid NewRewardItem()
		{
			RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
			rewardSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
			return rewardSmallItemGrid;
		}

		// Token: 0x06039453 RID: 234579 RVA: 0x00D94C44 File Offset: 0x00D92E44
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

		// Token: 0x0401DF3A RID: 122682
		[Nullable(2)]
		private ItemGridBase SelectedItemGrid;

		// Token: 0x0401DF3B RID: 122683
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardSmallItemGrid, RewardItemData> GenericScrollView;

		// Token: 0x0200B9F2 RID: 47602
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403836D RID: 230253
			public const int ProgressItem = 0;

			// Token: 0x0403836E RID: 230254
			public const int ProgressText = 1;

			// Token: 0x0403836F RID: 230255
			public const int RewardGridLayout = 2;

			// Token: 0x04038370 RID: 230256
			public const int RewardItem = 3;

			// Token: 0x04038371 RID: 230257
			public const int MaxText = 4;

			// Token: 0x04038372 RID: 230258
			public const int LayoutRoot = 5;
		}
	}
}
