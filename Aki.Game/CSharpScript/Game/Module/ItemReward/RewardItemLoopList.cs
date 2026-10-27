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
	// Token: 0x0200580D RID: 22541
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardItemLoopList : UiPanelBase
	{
		// Token: 0x060394B7 RID: 234679 RVA: 0x00D96878 File Offset: 0x00D94A78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x060394B8 RID: 234680 RVA: 0x00D968EC File Offset: 0x00D94AEC
		protected override void OnStart()
		{
			this.LoopScrollViewOb = new LoopScrollView<RewardSmallItemGrid, RewardItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<RewardSmallItemGrid>(this.InitItem), false);
		}

		// Token: 0x060394B9 RID: 234681 RVA: 0x00D9691E File Offset: 0x00D94B1E
		protected override void OnBeforeDestroy()
		{
			this.LoopScrollViewOb = null;
			this.SelectedItemGrid = null;
		}

		// Token: 0x060394BA RID: 234682 RVA: 0x00D9692E File Offset: 0x00D94B2E
		private RewardSmallItemGrid InitItem()
		{
			return this.NewRewardItem();
		}

		// Token: 0x060394BB RID: 234683 RVA: 0x00D96938 File Offset: 0x00D94B38
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
			this.LoopScrollViewOb.RefreshByData(rewardItemDataList, false, null, false);
			this.TipsCanSkip = new bool?(tipsCanSkip);
		}

		// Token: 0x060394BC RID: 234684 RVA: 0x00D96985 File Offset: 0x00D94B85
		private RewardSmallItemGrid NewRewardItem()
		{
			RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
			rewardSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
			return rewardSmallItemGrid;
		}

		// Token: 0x060394BD RID: 234685 RVA: 0x00D969C4 File Offset: 0x00D94BC4
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
				ItemController.Instance.OpenItemTipsByItemUid(uniqueId, configId, this.TipsCanSkip.GetValueOrDefault(true), null);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(configId, this.TipsCanSkip.GetValueOrDefault(true), null);
		}

		// Token: 0x0401DF5F RID: 122719
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RewardSmallItemGrid, RewardItemData> LoopScrollViewOb;

		// Token: 0x0401DF60 RID: 122720
		[Nullable(2)]
		private ItemGridBase SelectedItemGrid;

		// Token: 0x0401DF61 RID: 122721
		private bool? TipsCanSkip;

		// Token: 0x0200BA0F RID: 47631
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040383CC RID: 230348
			public const int ItemLoopList = 0;

			// Token: 0x040383CD RID: 230349
			public const int SourceItem = 1;
		}
	}
}
