using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057F0 RID: 22512
	[NullableContext(1)]
	[Nullable(0)]
	public class BattlePassExtraRewardView : UiViewBase
	{
		// Token: 0x0603937D RID: 234365 RVA: 0x00D9161C File Offset: 0x00D8F81C
		public BattlePassExtraRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603937E RID: 234366 RVA: 0x00D91628 File Offset: 0x00D8F828
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRight));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickLeft));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603937F RID: 234367 RVA: 0x00D91798 File Offset: 0x00D8F998
		protected override UniTask OnBeforeStartAsync()
		{
			BattlePassExtraRewardView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassExtraRewardView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039380 RID: 234368 RVA: 0x00D917DC File Offset: 0x00D8F9DC
		protected override void OnStart()
		{
			this.CommonScroll = new GenericScrollViewNew<RewardSmallItemGrid, RewardItemData>(base.GetScrollViewWithScrollbar(2), new Func<RewardSmallItemGrid>(this.OnCreateRewardItem), null, false, null);
			this.ExtraScroll = new GenericScrollViewNew<RewardSmallItemGrid, RewardItemData>(base.GetScrollViewWithScrollbar(4), new Func<RewardSmallItemGrid>(this.OnCreateRewardItem), null, false, null);
			this.Refresh();
		}

		// Token: 0x06039381 RID: 234369 RVA: 0x00D91831 File Offset: 0x00D8FA31
		protected override void OnBeforeDestroy()
		{
			this.SelectedItemGrid = null;
			this.CommonScroll = null;
			this.ExtraScroll = null;
		}

		// Token: 0x06039382 RID: 234370 RVA: 0x00D91848 File Offset: 0x00D8FA48
		private void Refresh()
		{
			RewardData<IBattlePassExtraRewardInfo> dataCache = this.DataCache;
			List<RewardItemData> list = (dataCache != null) ? dataCache.GetRewardInfo().CommonItems : null;
			if (list != null)
			{
				list.Sort(new Comparison<RewardItemData>(this.SortCompare));
				GenericScrollViewNew<RewardSmallItemGrid, RewardItemData> commonScroll = this.CommonScroll;
				if (commonScroll != null)
				{
					commonScroll.RefreshByData(list, null, false);
				}
			}
			RewardData<IBattlePassExtraRewardInfo> dataCache2 = this.DataCache;
			List<RewardItemData> list2 = (dataCache2 != null) ? dataCache2.GetRewardInfo().ExtraItems : null;
			if (list2 != null)
			{
				list2.Sort(new Comparison<RewardItemData>(this.SortCompare));
				GenericScrollViewNew<RewardSmallItemGrid, RewardItemData> extraScroll = this.ExtraScroll;
				if (extraScroll != null)
				{
					extraScroll.RefreshByData(list2, null, false);
				}
			}
			RewardData<IBattlePassExtraRewardInfo> dataCache3 = this.DataCache;
			string text = (dataCache3 != null) ? dataCache3.GetRewardInfo().TipsTextId : null;
			if (text != null)
			{
				UUIText text2 = base.GetText(6);
				if (text2 == null)
				{
					return;
				}
				text2.ShowTextNew(text);
			}
		}

		// Token: 0x06039383 RID: 234371 RVA: 0x00D91904 File Offset: 0x00D8FB04
		private int SortCompare(RewardItemData aRewardItem, RewardItemData bRewardItem)
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
		}

		// Token: 0x06039384 RID: 234372 RVA: 0x00D91966 File Offset: 0x00D8FB66
		private RewardSmallItemGrid OnCreateRewardItem()
		{
			RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
			rewardSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
			return rewardSmallItemGrid;
		}

		// Token: 0x06039385 RID: 234373 RVA: 0x00D919A4 File Offset: 0x00D8FBA4
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

		// Token: 0x06039386 RID: 234374 RVA: 0x00D91A08 File Offset: 0x00D8FC08
		private void OnClickRight()
		{
			base.CloseMe(null);
			RewardData<IBattlePassExtraRewardInfo> dataCache = this.DataCache;
			if (dataCache == null)
			{
				return;
			}
			dataCache.GetRewardInfo().RightAction();
		}

		// Token: 0x06039387 RID: 234375 RVA: 0x00D91A2B File Offset: 0x00D8FC2B
		private void OnClickLeft()
		{
			base.CloseMe(null);
			RewardData<IBattlePassExtraRewardInfo> dataCache = this.DataCache;
			if (dataCache == null)
			{
				return;
			}
			dataCache.GetRewardInfo().LeftAction();
		}

		// Token: 0x0401DF03 RID: 122627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<IBattlePassExtraRewardInfo> DataCache;

		// Token: 0x0401DF04 RID: 122628
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RewardSmallItemGrid, RewardItemData> CommonScroll;

		// Token: 0x0401DF05 RID: 122629
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RewardSmallItemGrid, RewardItemData> ExtraScroll;

		// Token: 0x0401DF06 RID: 122630
		[Nullable(2)]
		private ItemGridBase SelectedItemGrid;

		// Token: 0x0200B9CB RID: 47563
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040382B8 RID: 230072
			public const int RightButton = 0;

			// Token: 0x040382B9 RID: 230073
			public const int LeftButton = 1;

			// Token: 0x040382BA RID: 230074
			public const int UpScroll = 2;

			// Token: 0x040382BB RID: 230075
			public const int UpScrollItem = 3;

			// Token: 0x040382BC RID: 230076
			public const int DownScroll = 4;

			// Token: 0x040382BD RID: 230077
			public const int DownScrollItem = 5;

			// Token: 0x040382BE RID: 230078
			public const int TxtTips = 6;
		}
	}
}
