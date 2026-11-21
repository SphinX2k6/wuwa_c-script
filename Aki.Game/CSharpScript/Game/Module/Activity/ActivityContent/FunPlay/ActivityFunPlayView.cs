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
	// Token: 0x020054F1 RID: 21745
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFunPlayView : UiTickViewBase
	{
		// Token: 0x06035E2F RID: 220719 RVA: 0x00F0D362 File Offset: 0x00F0B562
		public ActivityFunPlayView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035E30 RID: 220720 RVA: 0x00F0D378 File Offset: 0x00F0B578
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

		// Token: 0x06035E31 RID: 220721 RVA: 0x00F0D61C File Offset: 0x00F0B81C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityFunPlayView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityFunPlayView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035E32 RID: 220722 RVA: 0x00F0D660 File Offset: 0x00F0B860
		private UniTask InitRewardComp()
		{
			ActivityFunPlayView.<InitRewardComp>d__13 <InitRewardComp>d__;
			<InitRewardComp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRewardComp>d__.<>4__this = this;
			<InitRewardComp>d__.<>1__state = -1;
			<InitRewardComp>d__.<>t__builder.Start<ActivityFunPlayView.<InitRewardComp>d__13>(ref <InitRewardComp>d__);
			return <InitRewardComp>d__.<>t__builder.Task;
		}

		// Token: 0x06035E33 RID: 220723 RVA: 0x00F0D6A4 File Offset: 0x00F0B8A4
		private UniTask InitPageView()
		{
			ActivityFunPlayView.<InitPageView>d__14 <InitPageView>d__;
			<InitPageView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPageView>d__.<>4__this = this;
			<InitPageView>d__.<>1__state = -1;
			<InitPageView>d__.<>t__builder.Start<ActivityFunPlayView.<InitPageView>d__14>(ref <InitPageView>d__);
			return <InitPageView>d__.<>t__builder.Task;
		}

		// Token: 0x06035E34 RID: 220724 RVA: 0x00F0D6E8 File Offset: 0x00F0B8E8
		private void InitLoopScrollView()
		{
			UUILoopScrollViewComponent scrollView = base.GetItem(1).GetOwner().GetComponentByClass(UUILoopScrollViewComponent.StaticClass()) as UUILoopScrollViewComponent;
			this.ExhibitionView = new LoopScrollView<ActivityFunPlayTabItem, ActivityFunPlayChallengeData>(scrollView, base.GetItem(2).GetOwner() as AUIBaseActor, new Func<ActivityFunPlayTabItem>(this.CreateItem), false);
			base.GetItem(2).SetUIActive(false);
			this.ExhibitionView.BindOnScrollValueChanged(new Action<FVector2D>(this.OnScrollValueChanged));
		}

		// Token: 0x06035E35 RID: 220725 RVA: 0x00F0D764 File Offset: 0x00F0B964
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

		// Token: 0x06035E36 RID: 220726 RVA: 0x00F0D7DC File Offset: 0x00F0B9DC
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

		// Token: 0x06035E37 RID: 220727 RVA: 0x00F0D828 File Offset: 0x00F0BA28
		protected override void OnBeforeShow()
		{
			ActivityController.Instance.CheckIsActivityClose(null, new int?(this.CurrentActivity.Id));
			this.RefreshActivityScroller(true);
		}

		// Token: 0x06035E38 RID: 220728 RVA: 0x00F0D860 File Offset: 0x00F0BA60
		private ActivityFunPlayTabItem CreateItem()
		{
			return new ActivityFunPlayTabItem();
		}

		// Token: 0x06035E39 RID: 220729 RVA: 0x00F0D868 File Offset: 0x00F0BA68
		private void OnClickConfirmBtn()
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			int? num = (currentChallengeData != null) ? new int?(currentChallengeData.GetChallengeId()) : null;
			if (num != null)
			{
				ActivityFunPlayController.Instance.RequestEnterChallengeAsync(num.Value);
			}
		}

		// Token: 0x06035E3A RID: 220730 RVA: 0x00F0D8B4 File Offset: 0x00F0BAB4
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

		// Token: 0x06035E3B RID: 220731 RVA: 0x00F0D8F8 File Offset: 0x00F0BAF8
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

		// Token: 0x06035E3C RID: 220732 RVA: 0x00F0D938 File Offset: 0x00F0BB38
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

		// Token: 0x06035E3D RID: 220733 RVA: 0x00F0DA30 File Offset: 0x00F0BC30
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035E3E RID: 220734 RVA: 0x00F0DA3C File Offset: 0x00F0BC3C
		private void OnHelpBtnClick()
		{
			int helpId = this.CurrentActivity.GetHelpId();
			HelpController.Instance.OpenHelpById(helpId);
		}

		// Token: 0x06035E3F RID: 220735 RVA: 0x00F0DA60 File Offset: 0x00F0BC60
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnSelectActivityFunPlayChallengeItem, new Action(this.OnSelectChallengeItem));
			EventSystem.Instance.Add(EEventName.ActivityFunPlayInfoRefresh, new Action(this.OnInfoRefresh));
		}

		// Token: 0x06035E40 RID: 220736 RVA: 0x00F0DA9A File Offset: 0x00F0BC9A
		private void OnSelectChallengeItem()
		{
			this.RefreshLockUi();
			this.RefreshCenterInfo(true);
			this.RefreshRightInfo();
			this.PlaySwitchAnimation();
		}

		// Token: 0x06035E41 RID: 220737 RVA: 0x00F0DAB8 File Offset: 0x00F0BCB8
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

		// Token: 0x06035E42 RID: 220738 RVA: 0x00F0DB00 File Offset: 0x00F0BD00
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

		// Token: 0x06035E43 RID: 220739 RVA: 0x00F0DB64 File Offset: 0x00F0BD64
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

		// Token: 0x06035E44 RID: 220740 RVA: 0x00F0DBB0 File Offset: 0x00F0BDB0
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

		// Token: 0x06035E45 RID: 220741 RVA: 0x00F0DC0C File Offset: 0x00F0BE0C
		private void OnInfoRefresh()
		{
			Log.Instance.Info(ELogModule.ActivityFunPlay, ELogAuthor.CB, "趣味活动页面信息刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RefreshActivityScroller(false);
			this.RefreshLockUi();
			this.RefreshCenterInfo(false);
			this.RefreshRightInfo();
		}

		// Token: 0x06035E46 RID: 220742 RVA: 0x00F0DC53 File Offset: 0x00F0BE53
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnSelectActivityFunPlayChallengeItem, new Action(this.OnSelectChallengeItem));
			EventSystem.Instance.Remove(EEventName.ActivityFunPlayInfoRefresh, new Action(this.OnInfoRefresh));
		}

		// Token: 0x06035E47 RID: 220743 RVA: 0x00F0DC90 File Offset: 0x00F0BE90
		private void PlaySwitchAnimation()
		{
			if (this.UiViewSequence.HasSequenceNameInPlaying("Switch"))
			{
				this.UiViewSequence.ReplaySequence("Switch");
				return;
			}
			this.UiViewSequence.PlaySequence("Switch", false, null);
		}

		// Token: 0x06035E48 RID: 220744 RVA: 0x00F0DCDC File Offset: 0x00F0BEDC
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

		// Token: 0x06035E49 RID: 220745 RVA: 0x00F0DD68 File Offset: 0x00F0BF68
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

		// Token: 0x06035E4A RID: 220746 RVA: 0x00F0DE00 File Offset: 0x00F0C000
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

		// Token: 0x0401C7D5 RID: 116693
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C7D6 RID: 116694
		private ActivityFunPlayData CurrentActivity;

		// Token: 0x0401C7D7 RID: 116695
		private LoopScrollView<ActivityFunPlayTabItem, ActivityFunPlayChallengeData> ExhibitionView;

		// Token: 0x0401C7D8 RID: 116696
		private ActivityFunPlayRewardView RewardComp;

		// Token: 0x0401C7D9 RID: 116697
		private ActivityFunPlayPages PageView;

		// Token: 0x0401C7DA RID: 116698
		private int PreRedDotIndex;

		// Token: 0x0401C7DB RID: 116699
		private int NextRedDotIndex;

		// Token: 0x0401C7DC RID: 116700
		private readonly List<int> LockChallengeIds = new List<int>();

		// Token: 0x0401C7DD RID: 116701
		private float TickTime;

		// Token: 0x0200B14F RID: 45391
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036D4D RID: 224589
			public const int CaptionItem = 0;

			// Token: 0x04036D4E RID: 224590
			public const int LeftScroller = 1;

			// Token: 0x04036D4F RID: 224591
			public const int LeftItem = 2;

			// Token: 0x04036D50 RID: 224592
			public const int BtnUp = 3;

			// Token: 0x04036D51 RID: 224593
			public const int BtnDown = 4;

			// Token: 0x04036D52 RID: 224594
			public const int UpRed = 5;

			// Token: 0x04036D53 RID: 224595
			public const int DownRed = 6;

			// Token: 0x04036D54 RID: 224596
			public const int LockUiItem = 7;

			// Token: 0x04036D55 RID: 224597
			public const int LockTxt = 8;

			// Token: 0x04036D56 RID: 224598
			public const int RightInfo = 9;

			// Token: 0x04036D57 RID: 224599
			public const int TxtTitle = 10;

			// Token: 0x04036D58 RID: 224600
			public const int TxtInfo = 11;

			// Token: 0x04036D59 RID: 224601
			public const int RewardComp = 12;

			// Token: 0x04036D5A RID: 224602
			public const int BtnConfirm = 13;

			// Token: 0x04036D5B RID: 224603
			public const int CenterInfo = 14;
		}
	}
}
