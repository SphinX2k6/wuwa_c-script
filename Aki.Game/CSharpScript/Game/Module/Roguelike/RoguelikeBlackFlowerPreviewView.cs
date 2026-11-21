using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.SubViews.Popup;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DD4 RID: 15828
	public class RoguelikeBlackFlowerPreviewView : UiViewBase
	{
		// Token: 0x06028726 RID: 165670 RVA: 0x00B558B3 File Offset: 0x00B53AB3
		[NullableContext(1)]
		public RoguelikeBlackFlowerPreviewView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028727 RID: 165671 RVA: 0x00B558BC File Offset: 0x00B53ABC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x06028728 RID: 165672 RVA: 0x00B55930 File Offset: 0x00B53B30
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<BlackFlowerRewardPreviewListItem, TLevelDropReward>(base.GetScrollViewWithScrollbar(2), new Func<BlackFlowerRewardPreviewListItem>(this.RewardPreviewItemCreateFunc), null, false, null);
			this.ExchangeRewardId = (this.OpenParam as RoguelikeBlackFlowerOpenParam).DropId;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BlackFlower_RewardInfo", Array.Empty<object>());
		}

		// Token: 0x06028729 RID: 165673 RVA: 0x00B5598F File Offset: 0x00B53B8F
		protected override void OnBeforeShow()
		{
			this.ShowReward();
		}

		// Token: 0x0602872A RID: 165674 RVA: 0x00B55998 File Offset: 0x00B53B98
		private void ShowReward()
		{
			ExchangeReward? config = ConfigExchangeRewardById.GetConfig(this.ExchangeRewardId, true);
			List<TLevelDropReward> list = new List<TLevelDropReward>();
			foreach (DicIntInt dicIntInt in config.Value.RewardIdIter())
			{
				TLevelDropReward item = new TLevelDropReward
				{
					WorldLevel = dicIntInt.Key,
					DropId = dicIntInt.Value
				};
				list.Add(item);
			}
			list.Sort((TLevelDropReward a, TLevelDropReward b) => a.WorldLevel - b.WorldLevel);
			List<ValueTuple<int, int>> list2 = new List<ValueTuple<int, int>>();
			int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
			int num = 0;
			int selectIndex = 0;
			foreach (TLevelDropReward tlevelDropReward in list)
			{
				int worldLevel = tlevelDropReward.WorldLevel;
				int dropId = tlevelDropReward.DropId;
				list2.Add(new ValueTuple<int, int>(worldLevel, dropId));
				if (num < worldLevel && curWorldLevel >= worldLevel)
				{
					num = worldLevel;
					selectIndex = list2.Count - 1;
				}
			}
			GenericScrollViewNew<BlackFlowerRewardPreviewListItem, TLevelDropReward> rewardScroll = this.RewardScroll;
			if (rewardScroll == null)
			{
				return;
			}
			TTimerAction <>9__2;
			rewardScroll.RefreshByDataAsync(list, false).ContinueWith(delegate()
			{
				TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
				TTimerAction action;
				if ((action = <>9__2) == null)
				{
					action = (<>9__2 = delegate(float _)
					{
						this.RewardScroll.ScrollToTop(selectIndex);
					});
				}
				gameplayTimeInstance.Next(action, null, null);
			});
		}

		// Token: 0x0602872B RID: 165675 RVA: 0x00B55B18 File Offset: 0x00B53D18
		[NullableContext(1)]
		private BlackFlowerRewardPreviewListItem RewardPreviewItemCreateFunc()
		{
			return new BlackFlowerRewardPreviewListItem();
		}

		// Token: 0x04015F4D RID: 89933
		private int ExchangeRewardId;

		// Token: 0x04015F4E RID: 89934
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<BlackFlowerRewardPreviewListItem, TLevelDropReward> RewardScroll;

		// Token: 0x020099D3 RID: 39379
		private class ERewardPreviewComponents
		{
			// Token: 0x0402FF4E RID: 196430
			public const int TxtTitle = 1;

			// Token: 0x0402FF4F RID: 196431
			public const int RewardScrollList = 2;
		}
	}
}
