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
	// Token: 0x020052C1 RID: 21185
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballTowerLevelView : PinballMainChildViewBase<PinballMainViewModel>
	{
		// Token: 0x06034BD6 RID: 216022 RVA: 0x00EC033C File Offset: 0x00EBE53C
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

		// Token: 0x06034BD7 RID: 216023 RVA: 0x00EC0534 File Offset: 0x00EBE734
		protected override UniTask OnBeforeStartAsync()
		{
			PinballTowerLevelView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballTowerLevelView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034BD8 RID: 216024 RVA: 0x00EC0578 File Offset: 0x00EBE778
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PinballTowerLevelView.<OnPlayingStartSequenceAsync>d__7 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PinballTowerLevelView.<OnPlayingStartSequenceAsync>d__7>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034BD9 RID: 216025 RVA: 0x00EC05BB File Offset: 0x00EBE7BB
		protected override void OnBeforeShow()
		{
			this.SetCaptionInfo();
		}

		// Token: 0x06034BDA RID: 216026 RVA: 0x00EC05C4 File Offset: 0x00EBE7C4
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PinballTowerLevelView.<OnPlayingCloseSequenceAsync>d__9 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PinballTowerLevelView.<OnPlayingCloseSequenceAsync>d__9>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034BDB RID: 216027 RVA: 0x00EC0608 File Offset: 0x00EBE808
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

		// Token: 0x06034BDC RID: 216028 RVA: 0x00EC0694 File Offset: 0x00EBE894
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

		// Token: 0x06034BDD RID: 216029 RVA: 0x00EC06DE File Offset: 0x00EBE8DE
		private bool IsLevelLock(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelLockStatus(levelId) != EPinballChapterLevelLockStatus.Activated;
		}

		// Token: 0x06034BDE RID: 216030 RVA: 0x00EC06F6 File Offset: 0x00EBE8F6
		private string GetLevelLockTexts(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelPreConditionLockTexts(levelId);
		}

		// Token: 0x06034BDF RID: 216031 RVA: 0x00EC0708 File Offset: 0x00EBE908
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

		// Token: 0x06034BE0 RID: 216032 RVA: 0x00EC08EC File Offset: 0x00EBEAEC
		private void OnBtnRankingClick()
		{
			PinballActivityData activityData = PinballModel.Instance.ActivityData;
			if (activityData != null)
			{
				UiManager.Instance.OpenView(EUiViewName.PinballRankView, activityData, null);
			}
		}

		// Token: 0x06034BE1 RID: 216033 RVA: 0x00EC0918 File Offset: 0x00EBEB18
		private void OnBtnLeftClick()
		{
			this.CurFloorIndex = Math.Max(this.CurFloorIndex - 1, 0);
			this.SeqPlayer.StopSequenceByKey("Switch", false, false);
			this.SeqPlayer.PlayLevelSequenceByName("Switch", false, null, false);
			this.RefreshLevelInfo();
		}

		// Token: 0x06034BE2 RID: 216034 RVA: 0x00EC096C File Offset: 0x00EBEB6C
		private void OnBtnRightClick()
		{
			this.CurFloorIndex = Math.Min(this.CurFloorIndex + 1, this.LevelDataList.Count - 1);
			this.SeqPlayer.StopSequenceByKey("Switch", false, false);
			this.SeqPlayer.PlayLevelSequenceByName("Switch", false, null, false);
			this.RefreshLevelInfo();
		}

		// Token: 0x06034BE3 RID: 216035 RVA: 0x00EC09CC File Offset: 0x00EBEBCC
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

		// Token: 0x0401BEC8 RID: 114376
		[Nullable(2)]
		private PinballLevelInfoPanel LevelInfoPanel;

		// Token: 0x0401BEC9 RID: 114377
		private List<PinballLevelRecordData> LevelDataList;

		// Token: 0x0401BECA RID: 114378
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401BECB RID: 114379
		private int CurFloorIndex;

		// Token: 0x0200AF47 RID: 44871
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403628E RID: 221838
			LevelDetailTips,
			// Token: 0x0403628F RID: 221839
			BtnRanking,
			// Token: 0x04036290 RID: 221840
			NormalItem,
			// Token: 0x04036291 RID: 221841
			TxtNormalFloor,
			// Token: 0x04036292 RID: 221842
			BossItem,
			// Token: 0x04036293 RID: 221843
			TxtBossFloor,
			// Token: 0x04036294 RID: 221844
			BtnLeft,
			// Token: 0x04036295 RID: 221845
			BtnRight,
			// Token: 0x04036296 RID: 221846
			TimeRecordItem,
			// Token: 0x04036297 RID: 221847
			TxtTimeRecord
		}
	}
}
