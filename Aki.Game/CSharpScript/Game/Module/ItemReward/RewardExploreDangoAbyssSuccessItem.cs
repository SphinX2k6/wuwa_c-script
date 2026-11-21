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
	// Token: 0x020047D4 RID: 18388
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreDangoAbyssSuccessItem : UiPanelBase
	{
		// Token: 0x0602E360 RID: 189280 RVA: 0x00CE3884 File Offset: 0x00CE1A84
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

		// Token: 0x0602E361 RID: 189281 RVA: 0x00CE3971 File Offset: 0x00CE1B71
		protected override void OnStart()
		{
			this.GenericScrollView = new GenericLayout<RewardSmallItemGrid, RewardItemData>(base.GetGridLayout(2), new Func<RewardSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
		}

		// Token: 0x0602E362 RID: 189282 RVA: 0x00CE3994 File Offset: 0x00CE1B94
		public void Refresh(IDangoAbyssSuccessData data)
		{
			this.RefreshReward(data.RewardItemData);
			this.RefreshProgress(data.Progress);
		}

		// Token: 0x0602E363 RID: 189283 RVA: 0x00CE39B0 File Offset: 0x00CE1BB0
		private void RefreshProgress(float progress)
		{
			int num = (int)Math.Floor((double)(progress * 100f));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "AbyssLevelProgress", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
		}

		// Token: 0x0602E364 RID: 189284 RVA: 0x00CE39F0 File Offset: 0x00CE1BF0
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

		// Token: 0x0602E365 RID: 189285 RVA: 0x00CE3A45 File Offset: 0x00CE1C45
		private RewardSmallItemGrid OnCreateRewardItem()
		{
			return this.NewRewardItem();
		}

		// Token: 0x0602E366 RID: 189286 RVA: 0x00CE3A4D File Offset: 0x00CE1C4D
		private RewardSmallItemGrid NewRewardItem()
		{
			RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
			rewardSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
			return rewardSmallItemGrid;
		}

		// Token: 0x0602E367 RID: 189287 RVA: 0x00CE3A8C File Offset: 0x00CE1C8C
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

		// Token: 0x040189D1 RID: 100817
		[Nullable(2)]
		private ItemGridBase SelectedItemGrid;

		// Token: 0x040189D2 RID: 100818
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardSmallItemGrid, RewardItemData> GenericScrollView;

		// Token: 0x0200A408 RID: 41992
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04032D5A RID: 208218
			public const int ProgressItem = 0;

			// Token: 0x04032D5B RID: 208219
			public const int ProgressText = 1;

			// Token: 0x04032D5C RID: 208220
			public const int RewardGridLayout = 2;

			// Token: 0x04032D5D RID: 208221
			public const int RewardItem = 3;

			// Token: 0x04032D5E RID: 208222
			public const int MaxText = 4;

			// Token: 0x04032D5F RID: 208223
			public const int LayoutRoot = 5;
		}
	}
}
