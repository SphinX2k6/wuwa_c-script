using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x0200633C RID: 25404
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballDailyLevelView : PinballMainChildViewBase<PinballMainViewModel>
	{
		// Token: 0x0603FED9 RID: 261849 RVA: 0x00F77888 File Offset: 0x00F75A88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FEDA RID: 261850 RVA: 0x00F778D0 File Offset: 0x00F75AD0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballDailyLevelView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballDailyLevelView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FEDB RID: 261851 RVA: 0x00F77914 File Offset: 0x00F75B14
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PinballDailyLevelView.<OnPlayingStartSequenceAsync>d__4 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PinballDailyLevelView.<OnPlayingStartSequenceAsync>d__4>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FEDC RID: 261852 RVA: 0x00F77957 File Offset: 0x00F75B57
		protected override void OnBeforeShow()
		{
			this.SetCaptionInfo();
		}

		// Token: 0x0603FEDD RID: 261853 RVA: 0x00F77960 File Offset: 0x00F75B60
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PinballDailyLevelView.<OnPlayingCloseSequenceAsync>d__6 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PinballDailyLevelView.<OnPlayingCloseSequenceAsync>d__6>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FEDE RID: 261854 RVA: 0x00F779A4 File Offset: 0x00F75BA4
		private void SetCaptionInfo()
		{
			if (base.ViewModel != null)
			{
				PinballChapterData dailyChapterData = PinballModel.Instance.ActivityData.GetDailyChapterData();
				PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(dailyChapterData.ChapterId);
				Action<string> setViewTitle = base.ViewModel.SetViewTitle;
				if (setViewTitle != null)
				{
					setViewTitle(pinballChapterConfigById.Value.Name);
				}
				Action<int> setViewHelpId = base.ViewModel.SetViewHelpId;
				if (setViewHelpId != null)
				{
					setViewHelpId(556);
				}
				base.ViewModel.SetOverrideCloseFunc(new Action(this.OnBtnBackClick));
			}
		}

		// Token: 0x0603FEDF RID: 261855 RVA: 0x00F77A34 File Offset: 0x00F75C34
		private void RefreshLevelInfo()
		{
			PinballActivityData activityData = PinballModel.Instance.ActivityData;
			int dailyConfigId = activityData.GetDailyConfigId();
			int dailyRandomLevelId = activityData.GetDailyRandomLevelId();
			int curDailyRewardDropId = activityData.GetCurDailyRewardDropId();
			PinballLevelInfoData data = new PinballLevelInfoData
			{
				LevelId = dailyConfigId,
				RealLevelId = dailyRandomLevelId,
				RewardDropId = new int?(curDailyRewardDropId),
				RewardClearTitle = "Pinball_Level_DailyClear",
				ShowDesc = new bool?(true),
				ShowReward = new bool?(true)
			};
			this.LevelInfoPanel.Refresh(data);
		}

		// Token: 0x0603FEE0 RID: 261856 RVA: 0x00F77AB0 File Offset: 0x00F75CB0
		private void OnBtnBackClick()
		{
			if (this.RootView.GetChildViewStackNum() > 1)
			{
				base.BackToLastView();
				return;
			}
			UiAsyncTask task = new UiAsyncTask("PinballDailyLevelViewToMainView", delegate()
			{
				PinballDailyLevelView.<<OnBtnBackClick>b__9_0>d <<OnBtnBackClick>b__9_0>d;
				<<OnBtnBackClick>b__9_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OnBtnBackClick>b__9_0>d.<>4__this = this;
				<<OnBtnBackClick>b__9_0>d.<>1__state = -1;
				<<OnBtnBackClick>b__9_0>d.<>t__builder.Start<PinballDailyLevelView.<<OnBtnBackClick>b__9_0>d>(ref <<OnBtnBackClick>b__9_0>d);
				return <<OnBtnBackClick>b__9_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x04021587 RID: 136583
		[Nullable(2)]
		private PinballLevelInfoPanel LevelInfoPanel;

		// Token: 0x0200C54D RID: 50509
		private enum EComponent
		{
			// Token: 0x0403B8C3 RID: 243907
			LevelDetailTips
		}
	}
}
