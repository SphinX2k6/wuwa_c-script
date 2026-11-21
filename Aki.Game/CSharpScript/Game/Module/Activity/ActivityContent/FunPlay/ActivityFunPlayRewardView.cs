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
	// Token: 0x020054EF RID: 21743
	public class ActivityFunPlayRewardView : UiPanelBase
	{
		// Token: 0x06035E0C RID: 220684 RVA: 0x00F0CAAC File Offset: 0x00F0ACAC
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

		// Token: 0x06035E0D RID: 220685 RVA: 0x00F0CBD8 File Offset: 0x00F0ADD8
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, new Func<CommonItemSmallItemGrid>(this.<OnStart>g__Function1|3_0), null, false, null);
			this.AddEventListener();
		}

		// Token: 0x06035E0E RID: 220686 RVA: 0x00F0CC0E File Offset: 0x00F0AE0E
		protected void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ActivityFunPlayInfoRefresh, new Action(this.OnGetFunPlayReward));
		}

		// Token: 0x06035E0F RID: 220687 RVA: 0x00F0CC2C File Offset: 0x00F0AE2C
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ActivityFunPlayInfoRefresh, new Action(this.OnGetFunPlayReward));
		}

		// Token: 0x06035E10 RID: 220688 RVA: 0x00F0CC4A File Offset: 0x00F0AE4A
		private void OnGetFunPlayReward()
		{
			this.Refresh();
		}

		// Token: 0x06035E11 RID: 220689 RVA: 0x00F0CC52 File Offset: 0x00F0AE52
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

		// Token: 0x06035E12 RID: 220690 RVA: 0x00F0CC80 File Offset: 0x00F0AE80
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

		// Token: 0x06035E13 RID: 220691 RVA: 0x00F0CCEB File Offset: 0x00F0AEEB
		public void Refresh()
		{
			this.RefreshReward();
			this.RefreshContentState();
		}

		// Token: 0x06035E14 RID: 220692 RVA: 0x00F0CCFC File Offset: 0x00F0AEFC
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

		// Token: 0x06035E15 RID: 220693 RVA: 0x00F0CD38 File Offset: 0x00F0AF38
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

		// Token: 0x06035E16 RID: 220694 RVA: 0x00F0CDE3 File Offset: 0x00F0AFE3
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x06035E18 RID: 220696 RVA: 0x00F0CDF3 File Offset: 0x00F0AFF3
		[NullableContext(1)]
		[CompilerGenerated]
		private CommonItemSmallItemGrid <OnStart>g__Function1|3_0()
		{
			return this.CreatePropItem();
		}

		// Token: 0x0401C7CE RID: 116686
		[Nullable(1)]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0200B14C RID: 45388
		private class EComponents
		{
			// Token: 0x04036D39 RID: 224569
			public const int Title = 0;

			// Token: 0x04036D3A RID: 224570
			public const int ItemScroller = 1;

			// Token: 0x04036D3B RID: 224571
			public const int UnFinishedText = 2;

			// Token: 0x04036D3C RID: 224572
			public const int SprDone = 3;

			// Token: 0x04036D3D RID: 224573
			public const int FinishButton = 4;

			// Token: 0x04036D3E RID: 224574
			public const int FinishedItem = 5;
		}
	}
}
