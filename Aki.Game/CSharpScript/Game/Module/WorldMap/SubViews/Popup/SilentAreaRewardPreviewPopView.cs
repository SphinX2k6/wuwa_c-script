using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Popup
{
	// Token: 0x0200372E RID: 14126
	public class SilentAreaRewardPreviewPopView : UiViewBase
	{
		// Token: 0x06024BF9 RID: 150521 RVA: 0x00A61575 File Offset: 0x00A5F775
		[NullableContext(1)]
		public SilentAreaRewardPreviewPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06024BFA RID: 150522 RVA: 0x00A61580 File Offset: 0x00A5F780
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

		// Token: 0x06024BFB RID: 150523 RVA: 0x00A615F4 File Offset: 0x00A5F7F4
		protected override UniTask OnBeforeStartAsync()
		{
			SilentAreaRewardPreviewPopView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SilentAreaRewardPreviewPopView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024BFC RID: 150524 RVA: 0x00A61630 File Offset: 0x00A5F830
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<RewardPreviewListItem, TLevelDropReward>(base.GetScrollViewWithScrollbar(2), new Func<RewardPreviewListItem>(this.RewardPreviewItemCreateFunc), null, false, null);
			this.ExchangeRewardId = (int)this.OpenParam;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SilentArea_rewardinfo", Array.Empty<object>());
		}

		// Token: 0x06024BFD RID: 150525 RVA: 0x00A6168A File Offset: 0x00A5F88A
		protected override void OnBeforeShow()
		{
			this.ShowReward();
		}

		// Token: 0x06024BFE RID: 150526 RVA: 0x00A61694 File Offset: 0x00A5F894
		private void ShowReward()
		{
			ExchangeReward? config = ConfigExchangeRewardById.GetConfig(this.ExchangeRewardId, true);
			if (config == null)
			{
				return;
			}
			List<TLevelDropReward> list = new List<TLevelDropReward>();
			for (int i = 0; i < config.Value.RewardIdLength; i++)
			{
				DicIntInt? dicIntInt = config.Value.RewardId(i);
				list.Add(new TLevelDropReward
				{
					WorldLevel = dicIntInt.Value.Key,
					DropId = dicIntInt.Value.Value
				});
			}
			list.Sort((TLevelDropReward a, TLevelDropReward b) => a.WorldLevel - b.WorldLevel);
			List<TLevelDropReward> list2 = new List<TLevelDropReward>();
			WorldLevelModel instance = WorldLevelModel.Instance;
			int num = (instance != null) ? instance.CurWorldLevel : 0;
			int num2 = 0;
			int selectIndex = 0;
			foreach (TLevelDropReward tlevelDropReward in list)
			{
				list2.Add(tlevelDropReward);
				if (num2 < tlevelDropReward.WorldLevel && num >= tlevelDropReward.WorldLevel)
				{
					num2 = tlevelDropReward.WorldLevel;
					selectIndex = list2.Count - 1;
				}
			}
			if (this.RewardScroll != null)
			{
				TTimerAction <>9__2;
				this.RewardScroll.RefreshByDataAsync(list, false).Finally(delegate()
				{
					TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
					TTimerAction action;
					if ((action = <>9__2) == null)
					{
						action = (<>9__2 = delegate(float delta)
						{
							GenericScrollViewNew<RewardPreviewListItem, TLevelDropReward> rewardScroll = this.RewardScroll;
							if (rewardScroll == null)
							{
								return;
							}
							rewardScroll.ScrollToTopByIndex(selectIndex);
						});
					}
					gameplayTimeInstance.Next(action, null, null);
				});
			}
		}

		// Token: 0x06024BFF RID: 150527 RVA: 0x00A6181C File Offset: 0x00A5FA1C
		[NullableContext(1)]
		private RewardPreviewListItem RewardPreviewItemCreateFunc()
		{
			return new RewardPreviewListItem();
		}

		// Token: 0x04014657 RID: 83543
		private int ExchangeRewardId;

		// Token: 0x04014658 RID: 83544
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RewardPreviewListItem, TLevelDropReward> RewardScroll;

		// Token: 0x02009474 RID: 38004
		public static class ERewardPreviewComponents
		{
			// Token: 0x0402E688 RID: 190088
			public const int TxtTitle = 1;

			// Token: 0x0402E689 RID: 190089
			public const int RewardScrollList = 2;
		}
	}
}
