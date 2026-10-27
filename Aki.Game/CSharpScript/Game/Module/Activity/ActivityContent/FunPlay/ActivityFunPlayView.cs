using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x02006573 RID: 25971
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFunPlayView : UiTickViewBase
	{
		// Token: 0x0604116A RID: 266602 RVA: 0x00FC637E File Offset: 0x00FC457E
		public ActivityFunPlayView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604116B RID: 266603 RVA: 0x00FC6394 File Offset: 0x00FC4594
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnUp));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnDown));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickConfirmBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604116C RID: 266604 RVA: 0x00FC6638 File Offset: 0x00FC4838
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityFunPlayView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityFunPlayView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604116D RID: 266605 RVA: 0x00FC667C File Offset: 0x00FC487C
		private UniTask InitRewardComp()
		{
			ActivityFunPlayView.<InitRewardComp>d__13 <InitRewardComp>d__;
			<InitRewardComp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRewardComp>d__.<>4__this = this;
			<InitRewardComp>d__.<>1__state = -1;
			<InitRewardComp>d__.<>t__builder.Start<ActivityFunPlayView.<InitRewardComp>d__13>(ref <InitRewardComp>d__);
			return <InitRewardComp>d__.<>t__builder.Task;
		}

		// Token: 0x0604116E RID: 266606 RVA: 0x00FC66C0 File Offset: 0x00FC48C0
		private UniTask InitPageView()
		{
			ActivityFunPlayView.<InitPageView>d__14 <InitPageView>d__;
			<InitPageView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPageView>d__.<>4__this = this;
			<InitPageView>d__.<>1__state = -1;
			<InitPageView>d__.<>t__builder.Start<ActivityFunPlayView.<InitPageView>d__14>(ref <InitPageView>d__);
			return <InitPageView>d__.<>t__builder.Task;
		}

		// Token: 0x0604116F RID: 266607 RVA: 0x00FC6704 File Offset: 0x00FC4904
		private void InitLoopScrollView()
		{
			UUILoopScrollViewComponent scrollView = base.GetItem(1).GetOwner().GetComponentByClass(UUILoopScrollViewComponent.StaticClass()) as UUILoopScrollViewComponent;
			this.ExhibitionView = new LoopScrollView<ActivityFunPlayTabItem, ActivityFunPlayChallengeData>(scrollView, base.GetItem(2).GetOwner() as AUIBaseActor, new Func<ActivityFunPlayTabItem>(this.CreateItem), false);
			base.GetItem(2).SetUIActive(false);
			this.ExhibitionView.BindOnScrollValueChanged(new Action<FVector2D>(this.OnScrollValueChanged));
		}

		// Token: 0x06041170 RID: 266608 RVA: 0x00FC6780 File Offset: 0x00FC4980
		private void InitCaptionItem()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			if (this.CurrentActivity != null)
			{
				this.CaptionItem.SetTitle(this.CurrentActivity.GetTitle());
			}
			this.CaptionItem.SetHelpBtnActive(true);
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnHelpBtnClick));
		}

		// Token: 0x06041171 RID: 266609 RVA: 0x00FC67F8 File Offset: 0x00FC49F8
		private UniTask RefreshActivityScroller(bool reset)
		{
			ActivityFunPlayView.<RefreshActivityScroller>d__17 <RefreshActivityScroller>d__;
			<RefreshActivityScroller>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshActivityScroller>d__.<>4__this = this;
			<RefreshActivityScroller>d__.reset = reset;
			<RefreshActivityScroller>d__.<>1__state = -1;
			<RefreshActivityScroller>d__.<>t__builder.Start<ActivityFunPlayView.<RefreshActivityScroller>d__17>(ref <RefreshActivityScroller>d__);
			return <RefreshActivityScroller>d__.<>t__builder.Task;
		}

		// Token: 0x06041172 RID: 266610 RVA: 0x00FC6844 File Offset: 0x00FC4A44
		protected override void OnBeforeShow()
		{
			ActivityController.Instance.CheckIsActivityClose(null, new int?(this.CurrentActivity.Id));
			this.RefreshActivityScroller(true);
		}

		// Token: 0x06041173 RID: 266611 RVA: 0x00FC687C File Offset: 0x00FC4A7C
		private ActivityFunPlayTabItem CreateItem()
		{
			return new ActivityFunPlayTabItem();
		}

		// Token: 0x06041174 RID: 266612 RVA: 0x00FC6884 File Offset: 0x00FC4A84
		private void OnClickConfirmBtn()
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			int? num = (currentChallengeData != null) ? new int?(currentChallengeData.GetChallengeId()) : null;
			if (num != null)
			{
				ActivityFunPlayController.Instance.RequestEnterChallengeAsync(num.Value);
			}
		}

		// Token: 0x06041175 RID: 266613 RVA: 0x00FC68D0 File Offset: 0x00FC4AD0
		private void OnClickBtnUp()
		{
			int gridIndex = Math.Max(this.ExhibitionView.GetDisplayGridStartIndex() - 1, 0);
			if (this.PreRedDotIndex != -1)
			{
				gridIndex = this.PreRedDotIndex;
			}
			LoopScrollView<ActivityFunPlayTabItem, ActivityFunPlayChallengeData> exhibitionView = this.ExhibitionView;
			if (exhibitionView == null)
			{
				return;
			}
			exhibitionView.ScrollToGridIndex(gridIndex, true);
		}

		// Token: 0x06041176 RID: 266614 RVA: 0x00FC6914 File Offset: 0x00FC4B14
		private void OnClickBtnDown()
		{
			int gridIndex = this.ExhibitionView.GetDisplayGridStartIndex() + 1;
			if (this.NextRedDotIndex != -1)
			{
				gridIndex = this.NextRedDotIndex;
			}
			LoopScrollView<ActivityFunPlayTabItem, ActivityFunPlayChallengeData> exhibitionView = this.ExhibitionView;
			if (exhibitionView == null)
			{
				return;
			}
			exhibitionView.ScrollToGridIndex(gridIndex, true);
		}

		// Token: 0x06041177 RID: 266615 RVA: 0x00FC6954 File Offset: 0x00FC4B54
		private void OnScrollValueChanged(FVector2D _)
		{
			bool flag = false;
			bool flag2 = false;
			this.PreRedDotIndex = -1;
			this.NextRedDotIndex = -1;
			int displayGridStartIndex = this.ExhibitionView.GetDisplayGridStartIndex();
			int displayGridEndIndexPurely = this.ExhibitionView.GetDisplayGridEndIndexPurely();
			List<ActivityFunPlayChallengeData> allChallengeData = ActivityFunPlayModel.Instance.GetAllChallengeData();
			for (int i = 0; i < allChallengeData.Count; i++)
			{
				ActivityFunPlayChallengeData activityFunPlayChallengeData = allChallengeData[i];
				if (!flag && activityFunPlayChallengeData.GetRedPoint() && i < displayGridStartIndex)
				{
					flag = true;
					this.PreRedDotIndex = i;
				}
				if (!flag2 && activityFunPlayChallengeData.GetRedPoint() && i > displayGridEndIndexPurely)
				{
					flag2 = true;
					this.NextRedDotIndex = i;
				}
			}
			base.GetItem(5).SetUIActive(flag);
			base.GetItem(6).SetUIActive(flag2);
			base.GetButton(3).RootUIComp.Get().SetUIActive(displayGridStartIndex > 0);
			base.GetButton(4).RootUIComp.Get().SetUIActive(displayGridEndIndexPurely < allChallengeData.Count - 1);
		}

		// Token: 0x06041178 RID: 266616 RVA: 0x00FC6A4C File Offset: 0x00FC4C4C
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06041179 RID: 266617 RVA: 0x00FC6A58 File Offset: 0x00FC4C58
		private void OnHelpBtnClick()
		{
			int helpId = this.CurrentActivity.GetHelpId();
			HelpController.Instance.OpenHelpById(helpId);
		}

		// Token: 0x0604117A RID: 266618 RVA: 0x00FC6A7C File Offset: 0x00FC4C7C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnSelectActivityFunPlayChallengeItem, new Action(this.OnSelectChallengeItem));
			EventSystem.Instance.Add(EEventName.ActivityFunPlayInfoRefresh, new Action(this.OnInfoRefresh));
		}

		// Token: 0x0604117B RID: 266619 RVA: 0x00FC6AB6 File Offset: 0x00FC4CB6
		private void OnSelectChallengeItem()
		{
			this.RefreshLockUi();
			this.RefreshCenterInfo(true);
			this.RefreshRightInfo();
			this.PlaySwitchAnimation();
		}

		// Token: 0x0604117C RID: 266620 RVA: 0x00FC6AD4 File Offset: 0x00FC4CD4
		private void RefreshCenterInfo(bool reset)
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			if (currentChallengeData == null)
			{
				return;
			}
			bool isUnlock = currentChallengeData.GetIsUnlock();
			base.GetItem(14).SetUIActive(isUnlock);
			if (isUnlock)
			{
				ActivityFunPlayPages pageView = this.PageView;
				if (pageView == null)
				{
					return;
				}
				pageView.Refresh(reset);
			}
		}

		// Token: 0x0604117D RID: 266621 RVA: 0x00FC6B1C File Offset: 0x00FC4D1C
		private void RefreshLockUi()
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			if (currentChallengeData == null)
			{
				return;
			}
			bool isUnlock = currentChallengeData.GetIsUnlock();
			base.GetItem(7).SetUIActive(!isUnlock);
			if (!isUnlock)
			{
				string leftTimeText = currentChallengeData.GetLeftTimeText();
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), EFunPlayTextKey.UnlockTxt.ToString(), new <>z__ReadOnlySingleElementList<object>(leftTimeText));
			}
		}

		// Token: 0x0604117E RID: 266622 RVA: 0x00FC6B80 File Offset: 0x00FC4D80
		private void RefreshRightInfo()
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			if (currentChallengeData == null)
			{
				return;
			}
			bool isUnlock = currentChallengeData.GetIsUnlock();
			base.GetItem(9).SetUIActive(isUnlock);
			if (isUnlock)
			{
				this.RefreshTitleAndDesc();
				ActivityFunPlayRewardView rewardComp = this.RewardComp;
				if (rewardComp == null)
				{
					return;
				}
				rewardComp.Refresh();
			}
		}

		// Token: 0x0604117F RID: 266623 RVA: 0x00FC6BCC File Offset: 0x00FC4DCC
		private void RefreshTitleAndDesc()
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			if (currentChallengeData == null)
			{
				return;
			}
			string title = currentChallengeData.GetTitle();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), title, Array.Empty<object>());
			string desc = currentChallengeData.GetDesc();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), desc, Array.Empty<object>());
		}

		// Token: 0x06041180 RID: 266624 RVA: 0x00FC6C28 File Offset: 0x00FC4E28
		private void OnInfoRefresh()
		{
			Log.Instance.Info(ELogModule.ActivityFunPlay, ELogAuthor.CB, "趣味活动页面信息刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RefreshActivityScroller(false);
			this.RefreshLockUi();
			this.RefreshCenterInfo(false);
			this.RefreshRightInfo();
		}

		// Token: 0x06041181 RID: 266625 RVA: 0x00FC6C6F File Offset: 0x00FC4E6F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnSelectActivityFunPlayChallengeItem, new Action(this.OnSelectChallengeItem));
			EventSystem.Instance.Remove(EEventName.ActivityFunPlayInfoRefresh, new Action(this.OnInfoRefresh));
		}

		// Token: 0x06041182 RID: 266626 RVA: 0x00FC6CAC File Offset: 0x00FC4EAC
		private void PlaySwitchAnimation()
		{
			if (this.UiViewSequence.HasSequenceNameInPlaying("Switch"))
			{
				this.UiViewSequence.ReplaySequence("Switch");
				return;
			}
			this.UiViewSequence.PlaySequence("Switch", false, null);
		}

		// Token: 0x06041183 RID: 266627 RVA: 0x00FC6CF8 File Offset: 0x00FC4EF8
		protected override void OnTick(float delta)
		{
			this.TickTime += delta;
			if (this.TickTime >= (float)TimeUtil.Instance.InverseMillisecond)
			{
				this.TickTime = 0f;
				int? needRefreshUnlock = this.GetNeedRefreshUnlock();
				if (needRefreshUnlock == null)
				{
					return;
				}
				this.OnInfoRefresh();
				EventSystem.Instance.Emit<int>(EEventName.RefreshActivityFunPlayRedDot, needRefreshUnlock.Value);
				if (this.CurrentActivity != null)
				{
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.CurrentActivity.Id);
				}
			}
		}

		// Token: 0x06041184 RID: 266628 RVA: 0x00FC6D84 File Offset: 0x00FC4F84
		public int? GetNeedRefreshUnlock()
		{
			if (this.LockChallengeIds.Count == 0)
			{
				return null;
			}
			int num = this.LockChallengeIds[0];
			ActivityFunPlayChallengeData challengeData = ActivityFunPlayModel.Instance.GetChallengeData(num);
			if (challengeData != null && challengeData.GetIsUnlock())
			{
				this.LockChallengeIds.RemoveAt(0);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityFunPlay;
				ELogAuthor author = ELogAuthor.CB;
				string message = "解锁刷新的关卡id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", num);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new int?(num);
			}
			return null;
		}

		// Token: 0x06041185 RID: 266629 RVA: 0x00FC6E1C File Offset: 0x00FC501C
		private void InitLastLockChallengeIds()
		{
			foreach (ActivityFunPlayChallengeData activityFunPlayChallengeData in ActivityFunPlayModel.Instance.GetAllChallengeData())
			{
				if (!activityFunPlayChallengeData.GetIsUnlock())
				{
					int challengeId = activityFunPlayChallengeData.GetChallengeId();
					this.LockChallengeIds.Add(challengeId);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.ActivityFunPlay;
					ELogAuthor author = ELogAuthor.CB;
					string message = "添加未解锁的关卡id";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", challengeId);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
		}

		// Token: 0x04021EA4 RID: 138916
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021EA5 RID: 138917
		private ActivityFunPlayData CurrentActivity;

		// Token: 0x04021EA6 RID: 138918
		private LoopScrollView<ActivityFunPlayTabItem, ActivityFunPlayChallengeData> ExhibitionView;

		// Token: 0x04021EA7 RID: 138919
		private ActivityFunPlayRewardView RewardComp;

		// Token: 0x04021EA8 RID: 138920
		private ActivityFunPlayPages PageView;

		// Token: 0x04021EA9 RID: 138921
		private int PreRedDotIndex;

		// Token: 0x04021EAA RID: 138922
		private int NextRedDotIndex;

		// Token: 0x04021EAB RID: 138923
		private readonly List<int> LockChallengeIds = new List<int>();

		// Token: 0x04021EAC RID: 138924
		private float TickTime;

		// Token: 0x0200C76A RID: 51050
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403C3FB RID: 246779
			public const int CaptionItem = 0;

			// Token: 0x0403C3FC RID: 246780
			public const int LeftScroller = 1;

			// Token: 0x0403C3FD RID: 246781
			public const int LeftItem = 2;

			// Token: 0x0403C3FE RID: 246782
			public const int BtnUp = 3;

			// Token: 0x0403C3FF RID: 246783
			public const int BtnDown = 4;

			// Token: 0x0403C400 RID: 246784
			public const int UpRed = 5;

			// Token: 0x0403C401 RID: 246785
			public const int DownRed = 6;

			// Token: 0x0403C402 RID: 246786
			public const int LockUiItem = 7;

			// Token: 0x0403C403 RID: 246787
			public const int LockTxt = 8;

			// Token: 0x0403C404 RID: 246788
			public const int RightInfo = 9;

			// Token: 0x0403C405 RID: 246789
			public const int TxtTitle = 10;

			// Token: 0x0403C406 RID: 246790
			public const int TxtInfo = 11;

			// Token: 0x0403C407 RID: 246791
			public const int RewardComp = 12;

			// Token: 0x0403C408 RID: 246792
			public const int BtnConfirm = 13;

			// Token: 0x0403C409 RID: 246793
			public const int CenterInfo = 14;
		}
	}
}
