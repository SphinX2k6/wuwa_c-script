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
	// Token: 0x020047C7 RID: 18375
	[NullableContext(1)]
	[Nullable(0)]
	public class BattlePassExtraRewardView : UiViewBase
	{
		// Token: 0x0602E291 RID: 189073 RVA: 0x00CE0464 File Offset: 0x00CDE664
		public BattlePassExtraRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602E292 RID: 189074 RVA: 0x00CE0470 File Offset: 0x00CDE670
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

		// Token: 0x0602E293 RID: 189075 RVA: 0x00CE05E0 File Offset: 0x00CDE7E0
		protected override UniTask OnBeforeStartAsync()
		{
			BattlePassExtraRewardView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassExtraRewardView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E294 RID: 189076 RVA: 0x00CE0624 File Offset: 0x00CDE824
		protected override void OnStart()
		{
			this.CommonScroll = new GenericScrollViewNew<RewardSmallItemGrid, RewardItemData>(base.GetScrollViewWithScrollbar(2), new Func<RewardSmallItemGrid>(this.OnCreateRewardItem), null, false, null);
			this.ExtraScroll = new GenericScrollViewNew<RewardSmallItemGrid, RewardItemData>(base.GetScrollViewWithScrollbar(4), new Func<RewardSmallItemGrid>(this.OnCreateRewardItem), null, false, null);
			this.Refresh();
		}

		// Token: 0x0602E295 RID: 189077 RVA: 0x00CE0679 File Offset: 0x00CDE879
		protected override void OnBeforeDestroy()
		{
			this.SelectedItemGrid = null;
			this.CommonScroll = null;
			this.ExtraScroll = null;
		}

		// Token: 0x0602E296 RID: 189078 RVA: 0x00CE0690 File Offset: 0x00CDE890
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

		// Token: 0x0602E297 RID: 189079 RVA: 0x00CE074C File Offset: 0x00CDE94C
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

		// Token: 0x0602E298 RID: 189080 RVA: 0x00CE07AE File Offset: 0x00CDE9AE
		private RewardSmallItemGrid OnCreateRewardItem()
		{
			RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
			rewardSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
			return rewardSmallItemGrid;
		}

		// Token: 0x0602E299 RID: 189081 RVA: 0x00CE07EC File Offset: 0x00CDE9EC
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

		// Token: 0x0602E29A RID: 189082 RVA: 0x00CE0851 File Offset: 0x00CDEA51
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

		// Token: 0x0602E29B RID: 189083 RVA: 0x00CE0874 File Offset: 0x00CDEA74
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

		// Token: 0x0401899A RID: 100762
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<IBattlePassExtraRewardInfo> DataCache;

		// Token: 0x0401899B RID: 100763
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RewardSmallItemGrid, RewardItemData> CommonScroll;

		// Token: 0x0401899C RID: 100764
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RewardSmallItemGrid, RewardItemData> ExtraScroll;

		// Token: 0x0401899D RID: 100765
		[Nullable(2)]
		private ItemGridBase SelectedItemGrid;

		// Token: 0x0200A3E1 RID: 41953
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04032CA5 RID: 208037
			public const int RightButton = 0;

			// Token: 0x04032CA6 RID: 208038
			public const int LeftButton = 1;

			// Token: 0x04032CA7 RID: 208039
			public const int UpScroll = 2;

			// Token: 0x04032CA8 RID: 208040
			public const int UpScrollItem = 3;

			// Token: 0x04032CA9 RID: 208041
			public const int DownScroll = 4;

			// Token: 0x04032CAA RID: 208042
			public const int DownScrollItem = 5;

			// Token: 0x04032CAB RID: 208043
			public const int TxtTips = 6;
		}
	}
}
