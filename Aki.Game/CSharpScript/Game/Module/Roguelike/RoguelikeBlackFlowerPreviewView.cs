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
	// Token: 0x02004E0B RID: 19979
	public class RoguelikeBlackFlowerPreviewView : UiViewBase
	{
		// Token: 0x060338BB RID: 211131 RVA: 0x00C0C3A7 File Offset: 0x00C0A5A7
		[NullableContext(1)]
		public RoguelikeBlackFlowerPreviewView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060338BC RID: 211132 RVA: 0x00C0C3B0 File Offset: 0x00C0A5B0
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

		// Token: 0x060338BD RID: 211133 RVA: 0x00C0C424 File Offset: 0x00C0A624
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<BlackFlowerRewardPreviewListItem, TLevelDropReward>(base.GetScrollViewWithScrollbar(2), new Func<BlackFlowerRewardPreviewListItem>(this.RewardPreviewItemCreateFunc), null, false, null);
			this.ExchangeRewardId = (this.OpenParam as RoguelikeBlackFlowerOpenParam).DropId;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BlackFlower_RewardInfo", Array.Empty<object>());
		}

		// Token: 0x060338BE RID: 211134 RVA: 0x00C0C483 File Offset: 0x00C0A683
		protected override void OnBeforeShow()
		{
			this.ShowReward();
		}

		// Token: 0x060338BF RID: 211135 RVA: 0x00C0C48C File Offset: 0x00C0A68C
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

		// Token: 0x060338C0 RID: 211136 RVA: 0x00C0C60C File Offset: 0x00C0A80C
		[NullableContext(1)]
		private BlackFlowerRewardPreviewListItem RewardPreviewItemCreateFunc()
		{
			return new BlackFlowerRewardPreviewListItem();
		}

		// Token: 0x0401B57A RID: 111994
		private int ExchangeRewardId;

		// Token: 0x0401B57B RID: 111995
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<BlackFlowerRewardPreviewListItem, TLevelDropReward> RewardScroll;

		// Token: 0x0200AF9E RID: 44958
		private class ERewardPreviewComponents
		{
			// Token: 0x0403551B RID: 218395
			public const int TxtTitle = 1;

			// Token: 0x0403551C RID: 218396
			public const int RewardScrollList = 2;
		}
	}
}
