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
	// Token: 0x020047E4 RID: 18404
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardItemLoopList : UiPanelBase
	{
		// Token: 0x0602E3CB RID: 189387 RVA: 0x00CE5708 File Offset: 0x00CE3908
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

		// Token: 0x0602E3CC RID: 189388 RVA: 0x00CE577C File Offset: 0x00CE397C
		protected override void OnStart()
		{
			this.LoopScrollViewOb = new LoopScrollView<RewardSmallItemGrid, RewardItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<RewardSmallItemGrid>(this.InitItem), false);
		}

		// Token: 0x0602E3CD RID: 189389 RVA: 0x00CE57AE File Offset: 0x00CE39AE
		protected override void OnBeforeDestroy()
		{
			this.LoopScrollViewOb = null;
			this.SelectedItemGrid = null;
		}

		// Token: 0x0602E3CE RID: 189390 RVA: 0x00CE57BE File Offset: 0x00CE39BE
		private RewardSmallItemGrid InitItem()
		{
			return this.NewRewardItem();
		}

		// Token: 0x0602E3CF RID: 189391 RVA: 0x00CE57C8 File Offset: 0x00CE39C8
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

		// Token: 0x0602E3D0 RID: 189392 RVA: 0x00CE5815 File Offset: 0x00CE3A15
		private RewardSmallItemGrid NewRewardItem()
		{
			RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
			rewardSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
			return rewardSmallItemGrid;
		}

		// Token: 0x0602E3D1 RID: 189393 RVA: 0x00CE5854 File Offset: 0x00CE3A54
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
			ItemController.Instance.OpenItemTipsByItemId(configId, this.TipsCanSkip.GetValueOrDefault(true), null, false);
		}

		// Token: 0x040189F6 RID: 100854
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RewardSmallItemGrid, RewardItemData> LoopScrollViewOb;

		// Token: 0x040189F7 RID: 100855
		[Nullable(2)]
		private ItemGridBase SelectedItemGrid;

		// Token: 0x040189F8 RID: 100856
		private bool? TipsCanSkip;

		// Token: 0x0200A425 RID: 42021
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032DB9 RID: 208313
			public const int ItemLoopList = 0;

			// Token: 0x04032DBA RID: 208314
			public const int SourceItem = 1;
		}
	}
}
