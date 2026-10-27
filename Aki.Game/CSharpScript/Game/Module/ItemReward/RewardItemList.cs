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
	// Token: 0x0200580C RID: 22540
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardItemList : UiPanelBase
	{
		// Token: 0x060394AF RID: 234671 RVA: 0x00D96688 File Offset: 0x00D94888
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

		// Token: 0x060394B0 RID: 234672 RVA: 0x00D9671D File Offset: 0x00D9491D
		protected override void OnStart()
		{
			this.SourceItem = base.GetItem(1);
			this.SourceItem.SetUIActive(false);
			this.GenericScrollView = new GenericScrollViewNew<RewardSmallItemGrid, RewardItemData>(base.GetScrollViewWithScrollbar(2), new Func<RewardSmallItemGrid>(this.OnCreateRewardItem), null, false, null);
		}

		// Token: 0x060394B1 RID: 234673 RVA: 0x00D96759 File Offset: 0x00D94959
		protected override void OnBeforeDestroy()
		{
			this.SelectedItemGrid = null;
			this.GenericScrollView = null;
		}

		// Token: 0x060394B2 RID: 234674 RVA: 0x00D96769 File Offset: 0x00D94969
		private RewardSmallItemGrid OnCreateRewardItem()
		{
			return this.NewRewardItem();
		}

		// Token: 0x060394B3 RID: 234675 RVA: 0x00D96774 File Offset: 0x00D94974
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

		// Token: 0x060394B4 RID: 234676 RVA: 0x00D967C0 File Offset: 0x00D949C0
		private RewardSmallItemGrid NewRewardItem()
		{
			RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
			rewardSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
			return rewardSmallItemGrid;
		}

		// Token: 0x060394B5 RID: 234677 RVA: 0x00D96800 File Offset: 0x00D94A00
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
			ItemController.Instance.OpenItemTipsByItemId(configId, this.TipsCanSkip.GetValueOrDefault(true), null);
		}

		// Token: 0x0401DF5B RID: 122715
		[Nullable(2)]
		private UUIItem SourceItem;

		// Token: 0x0401DF5C RID: 122716
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RewardSmallItemGrid, RewardItemData> GenericScrollView;

		// Token: 0x0401DF5D RID: 122717
		[Nullable(2)]
		private ItemGridBase SelectedItemGrid;

		// Token: 0x0401DF5E RID: 122718
		private bool? TipsCanSkip;

		// Token: 0x0200BA0D RID: 47629
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040383C6 RID: 230342
			public const int ItemContentItem = 0;

			// Token: 0x040383C7 RID: 230343
			public const int SourceItem = 1;

			// Token: 0x040383C8 RID: 230344
			public const int ScrollViewWithScrollbar = 2;
		}
	}
}
