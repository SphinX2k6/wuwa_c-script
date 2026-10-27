using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200638B RID: 25483
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorChoseLevelView : UiTickViewBase
	{
		// Token: 0x06040151 RID: 262481 RVA: 0x00F81CB2 File Offset: 0x00F7FEB2
		public MultiMotorChoseLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06040152 RID: 262482 RVA: 0x00F81CBC File Offset: 0x00F7FEBC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 23;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickRewardBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(21, new Action(this.OnClickStartBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040153 RID: 262483 RVA: 0x00F8204A File Offset: 0x00F8024A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x06040154 RID: 262484 RVA: 0x00F82084 File Offset: 0x00F80284
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x06040155 RID: 262485 RVA: 0x00F820C0 File Offset: 0x00F802C0
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorChoseLevelView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorChoseLevelView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040156 RID: 262486 RVA: 0x00F82103 File Offset: 0x00F80303
		protected override void OnStart()
		{
			this.RefreshLevelScrollView();
			this.RefreshRoleTexture();
			this.RefreshTimeText();
			this.RefreshRewardText();
		}

		// Token: 0x06040157 RID: 262487 RVA: 0x00F8211D File Offset: 0x00F8031D
		protected override void OnBeforeShow()
		{
			if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Default)
			{
				InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
				if (matchingCountDownItem != null)
				{
					matchingCountDownItem.PlayAnimation("Close");
				}
				InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
				if (matchingCountDownItem2 != null)
				{
					matchingCountDownItem2.SetUiActive(false);
				}
			}
			this.RefreshRewardRedDot();
		}

		// Token: 0x06040158 RID: 262488 RVA: 0x00F8215C File Offset: 0x00F8035C
		protected override void OnAfterShow()
		{
			this.MatchingCountDownItem.BindOnClickBtnCancelMatching(delegate
			{
				InstanceDungeonEntranceController.Instance.CancelMatchRequest();
			});
			this.MatchingCountDownItem.BindOnAfterCloseAnimation(delegate(string sequenceName)
			{
				if (sequenceName == "Close")
				{
					this.SetMatchingItemActive(false);
				}
			});
			if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Matching)
			{
				this.SetMatchingItemActive(true);
				InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
				if (matchingCountDownItem != null)
				{
					matchingCountDownItem.PlayAnimation("Start");
				}
				this.MatchingCountDownItem.StartTimer();
				return;
			}
			this.SetMatchingItemActive(false);
		}

		// Token: 0x06040159 RID: 262489 RVA: 0x00F821E8 File Offset: 0x00F803E8
		private void RefreshLevelScrollView()
		{
			List<int> allLevels = MultiMotorModel.Instance.GetCurrentOpenActivityAllLevel();
			GenericScrollViewNew<MultiMotorChoseLevelItem, int> levelScrollView = this.LevelScrollView;
			if (levelScrollView == null)
			{
				return;
			}
			levelScrollView.RefreshByData(allLevels, delegate
			{
				MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
				int index = 0;
				for (int i = 0; i < allLevels.Count; i++)
				{
					int num = allLevels[i];
					if (!MultiMotorModel.Instance.GetLevelUnLock(num))
					{
						break;
					}
					MultiMotorLevelData multiMotorLevelData = null;
					if (activityData != null)
					{
						activityData.LevelDataMap.TryGetValue(num, out multiMotorLevelData);
					}
					if (multiMotorLevelData == null || !multiMotorLevelData.IsFinish)
					{
						index = i;
						break;
					}
					index = i;
				}
				GenericScrollViewNew<MultiMotorChoseLevelItem, int> levelScrollView2 = this.LevelScrollView;
				MultiMotorChoseLevelItem multiMotorChoseLevelItem = (levelScrollView2 != null) ? levelScrollView2.GetScrollItemByIndex(index) : null;
				if (multiMotorChoseLevelItem == null)
				{
					return;
				}
				multiMotorChoseLevelItem.SelectToggle();
			}, false);
		}

		// Token: 0x0604015A RID: 262490 RVA: 0x00F82238 File Offset: 0x00F80438
		private void RefreshRoleTexture()
		{
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female;
			string resourceId = flag ? "T_LevelSelectBgFemale" : "T_LevelSelectBgMale";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
			string resourceId2 = flag ? "T_RoleFemale" : "T_RoleMale";
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(resourceId2);
			base.SetTextureByPath(resourcePath2, base.GetTexture(1), null, null);
		}

		// Token: 0x0604015B RID: 262491 RVA: 0x00F822BC File Offset: 0x00F804BC
		private void RefreshRewardRedDot()
		{
			MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
			base.GetItem(8).SetUIActive(activityData != null && activityData.HasAnyRewardRedDot);
		}

		// Token: 0x0604015C RID: 262492 RVA: 0x00F822EC File Offset: 0x00F804EC
		private void RefreshRewardText()
		{
			MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
			Dictionary<int, MultiMotorTaskData> dictionary = (activityData != null) ? activityData.TaskDataMap : null;
			int num = 0;
			int num2 = 0;
			if (dictionary != null)
			{
				foreach (KeyValuePair<int, MultiMotorTaskData> keyValuePair in dictionary)
				{
					num++;
					if (keyValuePair.Value.IsReceived)
					{
						num2++;
					}
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "MultRacing_RewardTitle", new <>z__ReadOnlyArray<object>(new object[]
			{
				num2.ToString(),
				num.ToString()
			}));
		}

		// Token: 0x0604015D RID: 262493 RVA: 0x00F823A0 File Offset: 0x00F805A0
		protected override void OnTick(float delta)
		{
			if (this.RefreshTimeAccum > 500f)
			{
				this.RefreshTimeText();
				this.RefreshLockToUnlockTimeText();
				this.RefreshTimeAccum = 0f;
			}
			this.RefreshTimeAccum += delta;
		}

		// Token: 0x0604015E RID: 262494 RVA: 0x00F823D4 File Offset: 0x00F805D4
		private void RefreshTimeText()
		{
			MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			bool uiactive = activityData.CheckIfInLimitTime();
			base.GetText(7).SetUIActive(uiactive);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(activityData.EndShowTime, localTextNew);
			base.GetText(7).SetText(remainTimeText ?? "", true);
		}

		// Token: 0x0604015F RID: 262495 RVA: 0x00F8243C File Offset: 0x00F8063C
		private void RefreshLevelInfo()
		{
			if (this.CurrentLevel <= 0)
			{
				return;
			}
			OnlineMotorLevel? motorMultiParkourLevelById = MultiMotorConfig.Instance.GetMotorMultiParkourLevelById(this.CurrentLevel);
			if (motorMultiParkourLevelById == null)
			{
				return;
			}
			if (MultiMotorModel.Instance.GetLevelUnLock(this.CurrentLevel))
			{
				this.SetLockState(false);
				base.SetTextureByPath(motorMultiParkourLevelById.Value.LevelTexture, base.GetTexture(10), null, null);
				this.RefreshFinishedInfo();
			}
			else
			{
				this.SetLockState(true);
				this.ShowFinishState(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), motorMultiParkourLevelById.Value.Name, Array.Empty<object>());
			List<bool> list = new List<bool>();
			for (int i = 0; i < motorMultiParkourLevelById.Value.Difficulty; i++)
			{
				list.Add(true);
			}
			GenericLayout<MultiMotorLevelDifficultyItem, bool> difficultyLayout = this.DifficultyLayout;
			if (difficultyLayout == null)
			{
				return;
			}
			difficultyLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06040160 RID: 262496 RVA: 0x00F82528 File Offset: 0x00F80728
		private void SetLockState(bool isLock)
		{
			base.GetTexture(10).SetUIActive(!isLock);
			base.GetItem(13).SetUIActive(!isLock);
			base.GetItem(11).SetUIActive(isLock);
			base.GetText(12).SetUIActive(isLock);
			if (isLock)
			{
				this.RefreshLockToUnlockTimeText();
			}
		}

		// Token: 0x06040161 RID: 262497 RVA: 0x00F8257C File Offset: 0x00F8077C
		private void RefreshLockToUnlockTimeText()
		{
			if (this.CurrentLevel <= 0)
			{
				return;
			}
			MultiMotorLevelData multiMotorLevelData = null;
			MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
			if (activityData != null)
			{
				activityData.LevelDataMap.TryGetValue(this.CurrentLevel, out multiMotorLevelData);
			}
			long num = (multiMotorLevelData != null) ? multiMotorLevelData.UnlockTime : 0L;
			UUIText text = base.GetText(12);
			if (num == 0L)
			{
				text.SetUIActive(false);
				return;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			double num2 = (double)num - serverTime;
			if (num2 > 0.0)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "MultRacing_UnlockInfo", new <>z__ReadOnlySingleElementList<object>(TimeUtil.Instance.GetRemainTimeDataFormat8(num2).CountDownText));
				return;
			}
			if (!MultiMotorModel.Instance.GetLevelUnLock(this.CurrentLevel))
			{
				LguiUtil.Instance.SetLocalTextNew(text, "MultiMotor_Unlock_Tips", Array.Empty<object>());
				return;
			}
			if (base.GetItem(11).IsUIActiveSelf())
			{
				this.RefreshLevelInfo();
				this.RefreshLevelScrollView();
			}
		}

		// Token: 0x06040162 RID: 262498 RVA: 0x00F82664 File Offset: 0x00F80864
		private void RefreshFinishedInfo()
		{
			MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			MultiMotorLevelData multiMotorLevelData;
			activityData.LevelDataMap.TryGetValue(this.CurrentLevel, out multiMotorLevelData);
			if (multiMotorLevelData == null)
			{
				this.ShowFinishState(false);
				return;
			}
			base.GetItem(16).SetUIActive(multiMotorLevelData.BestRanking > 0);
			if (multiMotorLevelData.BestRanking > 0)
			{
				string resourceId;
				MultiMotorDefine.MultiMotorRankSprite.TryGetValue(multiMotorLevelData.BestRanking, out resourceId);
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
				this.SetSpriteByPath(resourcePath, base.GetSprite(17), false, null, null);
			}
			base.GetItem(18).SetUIActive(multiMotorLevelData.BestRecordTime != 0);
			base.GetItem(20).SetUIActive(multiMotorLevelData.BestRecordTime == 0);
			string remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat5((double)multiMotorLevelData.BestRecordTime * TimeUtil.Instance.Millisecond);
			UUIText text = base.GetText(19);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeDataFormat, true);
		}

		// Token: 0x06040163 RID: 262499 RVA: 0x00F82757 File Offset: 0x00F80957
		private void ShowFinishState(bool isFinish)
		{
			base.GetItem(16).SetUIActive(isFinish);
			base.GetItem(18).SetUIActive(isFinish);
			base.GetItem(20).SetUIActive(!isFinish);
		}

		// Token: 0x06040164 RID: 262500 RVA: 0x00F82786 File Offset: 0x00F80986
		private MultiMotorChoseLevelItem InitLevelItem()
		{
			return new MultiMotorChoseLevelItem
			{
				OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickLevelScrollView)
			};
		}

		// Token: 0x06040165 RID: 262501 RVA: 0x00F8279F File Offset: 0x00F8099F
		private MultiMotorLevelDifficultyItem InitDifficultyItem()
		{
			return new MultiMotorLevelDifficultyItem();
		}

		// Token: 0x06040166 RID: 262502 RVA: 0x00F827A8 File Offset: 0x00F809A8
		private void OnClickRewardBtn()
		{
			if (this.CurrentLevel <= 0)
			{
				return;
			}
			MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			MultiMotorLevelData multiMotorLevelData;
			activityData.LevelDataMap.TryGetValue(this.CurrentLevel, out multiMotorLevelData);
			if (multiMotorLevelData == null)
			{
				return;
			}
			IMultiMotorParkourRewardViewData param = new IMultiMotorParkourRewardViewData
			{
				ActivityData = activityData,
				SelectLevelData = multiMotorLevelData
			};
			UiManager.Instance.OpenView(EUiViewName.MultiMotorRewardView, param, null);
		}

		// Token: 0x06040167 RID: 262503 RVA: 0x00F8280C File Offset: 0x00F80A0C
		private void OnClickStartBtn()
		{
			int instanceId = this.GetInstanceId();
			if (instanceId == 0)
			{
				return;
			}
			if (!OnlineController.Instance.ShowTipsWhenOnlineDisabled(null))
			{
				return;
			}
			OnlineMotorLevel? motorMultiParkourLevelById = MultiMotorConfig.Instance.GetMotorMultiParkourLevelById(this.CurrentLevel);
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig((motorMultiParkourLevelById != null) ? motorMultiParkourLevelById.GetValueOrDefault().InstId : 0);
			if (!(((config != null) ? config.GetValueOrDefault().GetSubPackageIdListArray() : null) ?? Array.Empty<int>()).All((int id) => SubPackageDownLoadModel.Instance.CheckSubPackageDownLoadBySubPackageId(id)))
			{
				return;
			}
			if (!GameModeModel.Instance.IsMulti)
			{
				InstanceDungeonEntranceController.Instance.StartMatchRequest(instanceId, false, false);
				this.MatchingCountDownItem.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
				return;
			}
			int currentTeamSize = OnlineModel.Instance.GetCurrentTeamSize();
			if (currentTeamSize <= 1)
			{
				InstanceDungeonEntranceController.Instance.StartMatchRequest(instanceId, false, false);
				return;
			}
			if (currentTeamSize < OnlineModel.Instance.TeamMaxSize)
			{
				InstanceDungeonEntranceController.Instance.StartMatchRequest(instanceId, true, false);
				this.MatchingCountDownItem.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
				return;
			}
			BattleTeamModel.Instance.Context.SetMultiEntry(true);
			InstanceDungeonModel.Instance.InstanceContinue = false;
			InstanceDungeonEntranceModel.Instance.SetMatchingId(instanceId);
			InstanceDungeonEntranceController.Instance.TeamChallengeRequest(instanceId, true);
		}

		// Token: 0x06040168 RID: 262504 RVA: 0x00F82993 File Offset: 0x00F80B93
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06040169 RID: 262505 RVA: 0x00F8299C File Offset: 0x00F80B9C
		private void OnClickLevelScrollView(int levelId, UUIExtendToggle toggle)
		{
			this.CurrentLevel = levelId;
			if (toggle != this.CurrentSelectToggle)
			{
				UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
				if (currentSelectToggle == null || currentSelectToggle.ToggleState != EToggleState.ETT_UnDetermined)
				{
					UUIExtendToggle currentSelectToggle2 = this.CurrentSelectToggle;
					if (currentSelectToggle2 != null)
					{
						currentSelectToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
					}
				}
			}
			this.CurrentSelectToggle = toggle;
			this.RefreshLevelInfo();
		}

		// Token: 0x0604016A RID: 262506 RVA: 0x00F829F8 File Offset: 0x00F80BF8
		private int GetInstanceId()
		{
			OnlineMotorLevel? motorMultiParkourLevelById = MultiMotorConfig.Instance.GetMotorMultiParkourLevelById(this.CurrentLevel);
			if (motorMultiParkourLevelById == null)
			{
				return 0;
			}
			return motorMultiParkourLevelById.GetValueOrDefault().InstId;
		}

		// Token: 0x0604016B RID: 262507 RVA: 0x00F82A30 File Offset: 0x00F80C30
		private void SetMatchingItemActive(bool isShow)
		{
			base.GetItem(22).SetUIActive(isShow);
			bool flag = GameModeModel.Instance.IsMulti && !OnlineModel.Instance.GetIsMyTeam();
			base.GetButton(21).RootUIComp.Get().SetUIActive(!isShow && !flag);
		}

		// Token: 0x0604016C RID: 262508 RVA: 0x00F82A8C File Offset: 0x00F80C8C
		private void OnMatchingChange()
		{
			switch (InstanceDungeonEntranceModel.Instance.GetMatchingState())
			{
			case EInstanceMatchState.Default:
			{
				InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
				if (matchingCountDownItem == null)
				{
					return;
				}
				matchingCountDownItem.PlayAnimation("Close");
				return;
			}
			case EInstanceMatchState.Matching:
			{
				ScrollingTipsController.Instance.ShowTipsById("MatchingOtherCancel", Array.Empty<object>());
				InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
				if (matchingCountDownItem2 != null)
				{
					matchingCountDownItem2.PlayAnimation("Start");
				}
				this.SetMatchingItemActive(true);
				this.BeginMatching();
				return;
			}
			case EInstanceMatchState.MatchConfirm:
			{
				InstanceDungeonMatchingCountDown matchingCountDownItem3 = this.MatchingCountDownItem;
				if (matchingCountDownItem3 != null)
				{
					matchingCountDownItem3.PlayAnimation("Finish");
				}
				UiManager.Instance.OpenView(EUiViewName.OnlineInstanceMatchTips, null, null);
				return;
			}
			case EInstanceMatchState.Waiting:
				break;
			case EInstanceMatchState.ConfirmToReady:
				this.SetMatchingItemActive(false);
				BattleTeamModel.Instance.Context.SetMultiEntry(true);
				if (UiManager.Instance.IsViewOpen(EUiViewName.InstanceDungeonMonsterPreView))
				{
					UiManager.Instance.CloseView(EUiViewName.InstanceDungeonMonsterPreView, null);
				}
				FormationController.Instance.OpenBattleTeamView(InstanceDungeonEntranceModel.Instance.GetMatchingId(), true, true, false, null);
				EventSystem.Instance.Emit(EEventName.OnEnterTeam);
				break;
			default:
				return;
			}
		}

		// Token: 0x0604016D RID: 262509 RVA: 0x00F82BA0 File Offset: 0x00F80DA0
		private void OnMatchingBegin()
		{
			this.SetMatchingItemActive(true);
			InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
			if (matchingCountDownItem != null)
			{
				matchingCountDownItem.PlayAnimation("Start");
			}
			InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
			if (matchingCountDownItem2 != null)
			{
				matchingCountDownItem2.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
			}
			this.BeginMatching();
		}

		// Token: 0x0604016E RID: 262510 RVA: 0x00F82C00 File Offset: 0x00F80E00
		private void BeginMatching()
		{
			this.MatchingCountDownItem.SetMatchingTime(0);
			this.MatchingCountDownItem.StartTimer();
		}

		// Token: 0x04021646 RID: 136774
		private const int REFRESH_TIME = 500;

		// Token: 0x04021647 RID: 136775
		private const int MATCHING_ITEM_OFFSET = -98;

		// Token: 0x04021648 RID: 136776
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021649 RID: 136777
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<MultiMotorChoseLevelItem, int> LevelScrollView;

		// Token: 0x0402164A RID: 136778
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MultiMotorLevelDifficultyItem, bool> DifficultyLayout;

		// Token: 0x0402164B RID: 136779
		[Nullable(2)]
		private InstanceDungeonMatchingCountDown MatchingCountDownItem;

		// Token: 0x0402164C RID: 136780
		private int CurrentLevel;

		// Token: 0x0402164D RID: 136781
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x0402164E RID: 136782
		private float RefreshTimeAccum;

		// Token: 0x0200C59F RID: 50591
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BA8B RID: 244363
			public const int RoleATexture = 0;

			// Token: 0x0403BA8C RID: 244364
			public const int RoleBTexture = 1;

			// Token: 0x0403BA8D RID: 244365
			public const int CaptionItem = 2;

			// Token: 0x0403BA8E RID: 244366
			public const int LevelScrollView = 3;

			// Token: 0x0403BA8F RID: 244367
			public const int LevelItem = 4;

			// Token: 0x0403BA90 RID: 244368
			public const int RewardBtn = 5;

			// Token: 0x0403BA91 RID: 244369
			public const int RewardText = 6;

			// Token: 0x0403BA92 RID: 244370
			public const int TimeText = 7;

			// Token: 0x0403BA93 RID: 244371
			public const int RewardRedDotItem = 8;

			// Token: 0x0403BA94 RID: 244372
			public const int LevelText = 9;

			// Token: 0x0403BA95 RID: 244373
			public const int LevelTexture = 10;

			// Token: 0x0403BA96 RID: 244374
			public const int LockItem = 11;

			// Token: 0x0403BA97 RID: 244375
			public const int LockToUnlockTimeText = 12;

			// Token: 0x0403BA98 RID: 244376
			public const int DetailItem = 13;

			// Token: 0x0403BA99 RID: 244377
			public const int LevelFlagLayout = 14;

			// Token: 0x0403BA9A RID: 244378
			public const int LevelFlagItem = 15;

			// Token: 0x0403BA9B RID: 244379
			public const int LevelRankItem = 16;

			// Token: 0x0403BA9C RID: 244380
			public const int LevelRankSprite = 17;

			// Token: 0x0403BA9D RID: 244381
			public const int LevelTimeItem = 18;

			// Token: 0x0403BA9E RID: 244382
			public const int LevelTimeText = 19;

			// Token: 0x0403BA9F RID: 244383
			public const int LevelEmptyItem = 20;

			// Token: 0x0403BAA0 RID: 244384
			public const int StartBtn = 21;

			// Token: 0x0403BAA1 RID: 244385
			public const int MatchItem = 22;
		}
	}
}
