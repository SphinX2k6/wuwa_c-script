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
	// Token: 0x02006343 RID: 25411
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballTowerLevelView : PinballMainChildViewBase<PinballMainViewModel>
	{
		// Token: 0x0603FF15 RID: 261909 RVA: 0x00F793DC File Offset: 0x00F775DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnRankingClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnLeftClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnBtnRightClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FF16 RID: 261910 RVA: 0x00F795D4 File Offset: 0x00F777D4
		protected override UniTask OnBeforeStartAsync()
		{
			PinballTowerLevelView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballTowerLevelView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FF17 RID: 261911 RVA: 0x00F79618 File Offset: 0x00F77818
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PinballTowerLevelView.<OnPlayingStartSequenceAsync>d__7 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PinballTowerLevelView.<OnPlayingStartSequenceAsync>d__7>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FF18 RID: 261912 RVA: 0x00F7965B File Offset: 0x00F7785B
		protected override void OnBeforeShow()
		{
			this.SetCaptionInfo();
		}

		// Token: 0x0603FF19 RID: 261913 RVA: 0x00F79664 File Offset: 0x00F77864
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PinballTowerLevelView.<OnPlayingCloseSequenceAsync>d__9 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PinballTowerLevelView.<OnPlayingCloseSequenceAsync>d__9>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FF1A RID: 261914 RVA: 0x00F796A8 File Offset: 0x00F778A8
		private void SetCaptionInfo()
		{
			if (base.ViewModel != null)
			{
				PinballChapterData chapterData = base.ViewModel.GetChapterData();
				PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(chapterData.ChapterId);
				Action<string> setViewTitle = base.ViewModel.SetViewTitle;
				if (setViewTitle != null)
				{
					setViewTitle(pinballChapterConfigById.Value.Name);
				}
				Action<int> setViewHelpId = base.ViewModel.SetViewHelpId;
				if (setViewHelpId != null)
				{
					setViewHelpId(557);
				}
				base.ViewModel.SetOverrideCloseFunc(new Action(this.OnBtnBackClick));
			}
		}

		// Token: 0x0603FF1B RID: 261915 RVA: 0x00F79734 File Offset: 0x00F77934
		private int AutoFindFloorIndex()
		{
			int result = this.LevelDataList.Count - 1;
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				if (this.LevelDataList[i].PassStatus == EPinballLevelPassStatus.Unfinished)
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x0603FF1C RID: 261916 RVA: 0x00F7977E File Offset: 0x00F7797E
		private bool IsLevelLock(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelLockStatus(levelId) != EPinballChapterLevelLockStatus.Activated;
		}

		// Token: 0x0603FF1D RID: 261917 RVA: 0x00F79796 File Offset: 0x00F77996
		private string GetLevelLockTexts(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelPreConditionLockTexts(levelId);
		}

		// Token: 0x0603FF1E RID: 261918 RVA: 0x00F797A8 File Offset: 0x00F779A8
		private void RefreshLevelInfo()
		{
			PinballLevelRecordData pinballLevelRecordData = this.LevelDataList[this.CurFloorIndex];
			bool value = this.IsLevelLock(pinballLevelRecordData.LevelId);
			string levelLockTexts = this.GetLevelLockTexts(pinballLevelRecordData.LevelId);
			PinballLevelInfoData data = new PinballLevelInfoData
			{
				LevelId = pinballLevelRecordData.LevelId,
				RealLevelId = pinballLevelRecordData.LevelId,
				LevelStarConditionIds = pinballLevelRecordData.LevelStarConditionIds,
				LevelLock = new bool?(value),
				LevelLockTexts = levelLockTexts,
				ShowStar = new bool?(true),
				ShowReward = new bool?(true),
				RewardReceived = new bool?(pinballLevelRecordData.LevelStarConditionIds.Length != 0)
			};
			this.LevelInfoPanel.Refresh(data);
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(pinballLevelRecordData.LevelId);
			bool isTowerBoss = pinballLevelConfigById.Value.IsTowerBoss;
			string item = pinballLevelConfigById.Value.TowerNum.ToString();
			bool uiactive = pinballLevelRecordData.PassStatus == EPinballLevelPassStatus.Perfect;
			string timeDataFormatWithHour = TimeUtil.Instance.GetTimeDataFormatWithHour((double)pinballLevelRecordData.LevelPassedTime);
			base.GetItem(2).SetUIActive(!isTowerBoss);
			base.GetItem(4).SetUIActive(isTowerBoss);
			base.GetItem(8).SetUIActive(uiactive);
			base.GetButton(6).RootUIComp.Get().SetUIActive(this.CurFloorIndex > 0);
			base.GetButton(7).RootUIComp.Get().SetUIActive(this.CurFloorIndex < this.LevelDataList.Count - 1);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "Pinball_Level_TowerTime", new <>z__ReadOnlySingleElementList<object>(timeDataFormatWithHour));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Pinball_Level_EndlessFloor", new <>z__ReadOnlySingleElementList<object>(item));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Pinball_Level_EndlessFloor", new <>z__ReadOnlySingleElementList<object>(item));
		}

		// Token: 0x0603FF1F RID: 261919 RVA: 0x00F7998C File Offset: 0x00F77B8C
		private void OnBtnRankingClick()
		{
			PinballActivityData activityData = PinballModel.Instance.ActivityData;
			if (activityData != null)
			{
				UiManager.Instance.OpenView(EUiViewName.PinballRankView, activityData, null);
			}
		}

		// Token: 0x0603FF20 RID: 261920 RVA: 0x00F799B8 File Offset: 0x00F77BB8
		private void OnBtnLeftClick()
		{
			this.CurFloorIndex = Math.Max(this.CurFloorIndex - 1, 0);
			this.SeqPlayer.StopSequenceByKey("Switch", false, false);
			this.SeqPlayer.PlayLevelSequenceByName("Switch", false, null, false);
			this.RefreshLevelInfo();
		}

		// Token: 0x0603FF21 RID: 261921 RVA: 0x00F79A0C File Offset: 0x00F77C0C
		private void OnBtnRightClick()
		{
			this.CurFloorIndex = Math.Min(this.CurFloorIndex + 1, this.LevelDataList.Count - 1);
			this.SeqPlayer.StopSequenceByKey("Switch", false, false);
			this.SeqPlayer.PlayLevelSequenceByName("Switch", false, null, false);
			this.RefreshLevelInfo();
		}

		// Token: 0x0603FF22 RID: 261922 RVA: 0x00F79A6C File Offset: 0x00F77C6C
		private void OnBtnBackClick()
		{
			base.ViewModel.ClearSelectLevelData();
			if (this.RootView.GetChildViewStackNum() > 1)
			{
				base.BackToLastView();
				return;
			}
			UiAsyncTask task = new UiAsyncTask("PinballLevelViewToMainView", delegate()
			{
				PinballTowerLevelView.<<OnBtnBackClick>b__18_0>d <<OnBtnBackClick>b__18_0>d;
				<<OnBtnBackClick>b__18_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OnBtnBackClick>b__18_0>d.<>4__this = this;
				<<OnBtnBackClick>b__18_0>d.<>1__state = -1;
				<<OnBtnBackClick>b__18_0>d.<>t__builder.Start<PinballTowerLevelView.<<OnBtnBackClick>b__18_0>d>(ref <<OnBtnBackClick>b__18_0>d);
				return <<OnBtnBackClick>b__18_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x04021599 RID: 136601
		[Nullable(2)]
		private PinballLevelInfoPanel LevelInfoPanel;

		// Token: 0x0402159A RID: 136602
		private List<PinballLevelRecordData> LevelDataList;

		// Token: 0x0402159B RID: 136603
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0402159C RID: 136604
		private int CurFloorIndex;

		// Token: 0x0200C560 RID: 50528
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B92C RID: 244012
			LevelDetailTips,
			// Token: 0x0403B92D RID: 244013
			BtnRanking,
			// Token: 0x0403B92E RID: 244014
			NormalItem,
			// Token: 0x0403B92F RID: 244015
			TxtNormalFloor,
			// Token: 0x0403B930 RID: 244016
			BossItem,
			// Token: 0x0403B931 RID: 244017
			TxtBossFloor,
			// Token: 0x0403B932 RID: 244018
			BtnLeft,
			// Token: 0x0403B933 RID: 244019
			BtnRight,
			// Token: 0x0403B934 RID: 244020
			TimeRecordItem,
			// Token: 0x0403B935 RID: 244021
			TxtTimeRecord
		}
	}
}
