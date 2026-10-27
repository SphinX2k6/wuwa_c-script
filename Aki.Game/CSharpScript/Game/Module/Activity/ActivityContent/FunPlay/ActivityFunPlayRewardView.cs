using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x02006571 RID: 25969
	public class ActivityFunPlayRewardView : UiPanelBase
	{
		// Token: 0x06041147 RID: 266567 RVA: 0x00FC5AC8 File Offset: 0x00FC3CC8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickFinishButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06041148 RID: 266568 RVA: 0x00FC5BF4 File Offset: 0x00FC3DF4
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, new Func<CommonItemSmallItemGrid>(this.<OnStart>g__Function1|3_0), null, false, null);
			this.AddEventListener();
		}

		// Token: 0x06041149 RID: 266569 RVA: 0x00FC5C2A File Offset: 0x00FC3E2A
		protected void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ActivityFunPlayInfoRefresh, new Action(this.OnGetFunPlayReward));
		}

		// Token: 0x0604114A RID: 266570 RVA: 0x00FC5C48 File Offset: 0x00FC3E48
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ActivityFunPlayInfoRefresh, new Action(this.OnGetFunPlayReward));
		}

		// Token: 0x0604114B RID: 266571 RVA: 0x00FC5C66 File Offset: 0x00FC3E66
		private void OnGetFunPlayReward()
		{
			this.Refresh();
		}

		// Token: 0x0604114C RID: 266572 RVA: 0x00FC5C6E File Offset: 0x00FC3E6E
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreatePropItem()
		{
			CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
			commonItemSmallItemGrid.ShowReceivedCallBack = delegate(TItem _)
			{
				ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
				return currentChallengeData != null && currentChallengeData.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayRewarded);
			};
			return commonItemSmallItemGrid;
		}

		// Token: 0x0604114D RID: 266573 RVA: 0x00FC5C9C File Offset: 0x00FC3E9C
		private void OnClickFinishButton()
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			int? num = (currentChallengeData != null) ? new int?(currentChallengeData.GetChallengeId()) : null;
			if (num == null)
			{
				Log.Instance.Error(ELogModule.ActivityFunPlay, ELogAuthor.CB, "当前趣味玩法关卡数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			ActivityFunPlayController.Instance.ChallengeAwardRequest(num.Value);
		}

		// Token: 0x0604114E RID: 266574 RVA: 0x00FC5D07 File Offset: 0x00FC3F07
		public void Refresh()
		{
			this.RefreshReward();
			this.RefreshContentState();
		}

		// Token: 0x0604114F RID: 266575 RVA: 0x00FC5D18 File Offset: 0x00FC3F18
		private void RefreshReward()
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			List<TItem> list = (currentChallengeData != null) ? currentChallengeData.GetPreviewReward() : null;
			if (list != null)
			{
				GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
				if (rewardScrollView == null)
				{
					return;
				}
				rewardScrollView.RefreshByData(list, null, false);
			}
		}

		// Token: 0x06041150 RID: 266576 RVA: 0x00FC5D54 File Offset: 0x00FC3F54
		private void RefreshContentState()
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			if (currentChallengeData == null)
			{
				Log.Instance.Error(ELogModule.ActivityFunPlay, ELogAuthor.CB, "趣味玩法关卡数据空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(currentChallengeData.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayCanNoReward));
			}
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(currentChallengeData.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayCanReward));
			}
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(currentChallengeData.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayCanReward));
			}
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(currentChallengeData.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayRewarded));
		}

		// Token: 0x06041151 RID: 266577 RVA: 0x00FC5DFF File Offset: 0x00FC3FFF
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x06041153 RID: 266579 RVA: 0x00FC5E0F File Offset: 0x00FC400F
		[NullableContext(1)]
		[CompilerGenerated]
		private CommonItemSmallItemGrid <OnStart>g__Function1|3_0()
		{
			return this.CreatePropItem();
		}

		// Token: 0x04021E9D RID: 138909
		[Nullable(1)]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0200C767 RID: 51047
		private class EComponents
		{
			// Token: 0x0403C3E7 RID: 246759
			public const int Title = 0;

			// Token: 0x0403C3E8 RID: 246760
			public const int ItemScroller = 1;

			// Token: 0x0403C3E9 RID: 246761
			public const int UnFinishedText = 2;

			// Token: 0x0403C3EA RID: 246762
			public const int SprDone = 3;

			// Token: 0x0403C3EB RID: 246763
			public const int FinishButton = 4;

			// Token: 0x0403C3EC RID: 246764
			public const int FinishedItem = 5;
		}
	}
}
