using System;
using System.Collections.Generic;
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
	// Token: 0x02005309 RID: 21257
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorChoseLevelView : UiTickViewBase
	{
		// Token: 0x06034E12 RID: 216594 RVA: 0x00EC8C16 File Offset: 0x00EC6E16
		public MultiMotorChoseLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034E13 RID: 216595 RVA: 0x00EC8C20 File Offset: 0x00EC6E20
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

		// Token: 0x06034E14 RID: 216596 RVA: 0x00EC8FAE File Offset: 0x00EC71AE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x06034E15 RID: 216597 RVA: 0x00EC8FE8 File Offset: 0x00EC71E8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x06034E16 RID: 216598 RVA: 0x00EC9024 File Offset: 0x00EC7224
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorChoseLevelView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorChoseLevelView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034E17 RID: 216599 RVA: 0x00EC9067 File Offset: 0x00EC7267
		protected override void OnStart()
		{
			this.RefreshLevelScrollView();
			this.RefreshRoleTexture();
			this.RefreshTimeText();
			this.RefreshRewardText();
		}

		// Token: 0x06034E18 RID: 216600 RVA: 0x00EC9081 File Offset: 0x00EC7281
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

		// Token: 0x06034E19 RID: 216601 RVA: 0x00EC90C0 File Offset: 0x00EC72C0
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

		// Token: 0x06034E1A RID: 216602 RVA: 0x00EC914C File Offset: 0x00EC734C
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

		// Token: 0x06034E1B RID: 216603 RVA: 0x00EC919C File Offset: 0x00EC739C
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

		// Token: 0x06034E1C RID: 216604 RVA: 0x00EC9220 File Offset: 0x00EC7420
		private void RefreshRewardRedDot()
		{
			MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
			base.GetItem(8).SetUIActive(activityData != null && activityData.HasAnyRewardRedDot);
		}

		// Token: 0x06034E1D RID: 216605 RVA: 0x00EC9250 File Offset: 0x00EC7450
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

		// Token: 0x06034E1E RID: 216606 RVA: 0x00EC9304 File Offset: 0x00EC7504
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

		// Token: 0x06034E1F RID: 216607 RVA: 0x00EC9338 File Offset: 0x00EC7538
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

		// Token: 0x06034E20 RID: 216608 RVA: 0x00EC93A0 File Offset: 0x00EC75A0
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

		// Token: 0x06034E21 RID: 216609 RVA: 0x00EC948C File Offset: 0x00EC768C
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

		// Token: 0x06034E22 RID: 216610 RVA: 0x00EC94E0 File Offset: 0x00EC76E0
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

		// Token: 0x06034E23 RID: 216611 RVA: 0x00EC95C8 File Offset: 0x00EC77C8
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

		// Token: 0x06034E24 RID: 216612 RVA: 0x00EC96BB File Offset: 0x00EC78BB
		private void ShowFinishState(bool isFinish)
		{
			base.GetItem(16).SetUIActive(isFinish);
			base.GetItem(18).SetUIActive(isFinish);
			base.GetItem(20).SetUIActive(!isFinish);
		}

		// Token: 0x06034E25 RID: 216613 RVA: 0x00EC96EA File Offset: 0x00EC78EA
		private MultiMotorChoseLevelItem InitLevelItem()
		{
			return new MultiMotorChoseLevelItem
			{
				OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickLevelScrollView)
			};
		}

		// Token: 0x06034E26 RID: 216614 RVA: 0x00EC9703 File Offset: 0x00EC7903
		private MultiMotorLevelDifficultyItem InitDifficultyItem()
		{
			return new MultiMotorLevelDifficultyItem();
		}

		// Token: 0x06034E27 RID: 216615 RVA: 0x00EC970C File Offset: 0x00EC790C
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

		// Token: 0x06034E28 RID: 216616 RVA: 0x00EC9770 File Offset: 0x00EC7970
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
			bool flag = true;
			foreach (int subPackageId in ((config != null) ? config.GetValueOrDefault().GetSubPackageIdListArray() : null) ?? Array.Empty<int>())
			{
				if (!SubPackageDownLoadModel.Instance.CheckSubPackageDownLoadBySubPackageId(subPackageId))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
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

		// Token: 0x06034E29 RID: 216617 RVA: 0x00EC9905 File Offset: 0x00EC7B05
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034E2A RID: 216618 RVA: 0x00EC9910 File Offset: 0x00EC7B10
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

		// Token: 0x06034E2B RID: 216619 RVA: 0x00EC996C File Offset: 0x00EC7B6C
		private int GetInstanceId()
		{
			OnlineMotorLevel? motorMultiParkourLevelById = MultiMotorConfig.Instance.GetMotorMultiParkourLevelById(this.CurrentLevel);
			if (motorMultiParkourLevelById == null)
			{
				return 0;
			}
			return motorMultiParkourLevelById.GetValueOrDefault().InstId;
		}

		// Token: 0x06034E2C RID: 216620 RVA: 0x00EC99A4 File Offset: 0x00EC7BA4
		private void SetMatchingItemActive(bool isShow)
		{
			base.GetItem(22).SetUIActive(isShow);
			bool flag = GameModeModel.Instance.IsMulti && !OnlineModel.Instance.GetIsMyTeam();
			base.GetButton(21).RootUIComp.Get().SetUIActive(!isShow && !flag);
		}

		// Token: 0x06034E2D RID: 216621 RVA: 0x00EC9A00 File Offset: 0x00EC7C00
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

		// Token: 0x06034E2E RID: 216622 RVA: 0x00EC9B14 File Offset: 0x00EC7D14
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

		// Token: 0x06034E2F RID: 216623 RVA: 0x00EC9B74 File Offset: 0x00EC7D74
		private void BeginMatching()
		{
			this.MatchingCountDownItem.SetMatchingTime(0);
			this.MatchingCountDownItem.StartTimer();
		}

		// Token: 0x0401BF75 RID: 114549
		private const int REFRESH_TIME = 500;

		// Token: 0x0401BF76 RID: 114550
		private const int MATCHING_ITEM_OFFSET = -98;

		// Token: 0x0401BF77 RID: 114551
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BF78 RID: 114552
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<MultiMotorChoseLevelItem, int> LevelScrollView;

		// Token: 0x0401BF79 RID: 114553
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MultiMotorLevelDifficultyItem, bool> DifficultyLayout;

		// Token: 0x0401BF7A RID: 114554
		[Nullable(2)]
		private InstanceDungeonMatchingCountDown MatchingCountDownItem;

		// Token: 0x0401BF7B RID: 114555
		private int CurrentLevel;

		// Token: 0x0401BF7C RID: 114556
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x0401BF7D RID: 114557
		private float RefreshTimeAccum;

		// Token: 0x0200AF86 RID: 44934
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040363ED RID: 222189
			public const int RoleATexture = 0;

			// Token: 0x040363EE RID: 222190
			public const int RoleBTexture = 1;

			// Token: 0x040363EF RID: 222191
			public const int CaptionItem = 2;

			// Token: 0x040363F0 RID: 222192
			public const int LevelScrollView = 3;

			// Token: 0x040363F1 RID: 222193
			public const int LevelItem = 4;

			// Token: 0x040363F2 RID: 222194
			public const int RewardBtn = 5;

			// Token: 0x040363F3 RID: 222195
			public const int RewardText = 6;

			// Token: 0x040363F4 RID: 222196
			public const int TimeText = 7;

			// Token: 0x040363F5 RID: 222197
			public const int RewardRedDotItem = 8;

			// Token: 0x040363F6 RID: 222198
			public const int LevelText = 9;

			// Token: 0x040363F7 RID: 222199
			public const int LevelTexture = 10;

			// Token: 0x040363F8 RID: 222200
			public const int LockItem = 11;

			// Token: 0x040363F9 RID: 222201
			public const int LockToUnlockTimeText = 12;

			// Token: 0x040363FA RID: 222202
			public const int DetailItem = 13;

			// Token: 0x040363FB RID: 222203
			public const int LevelFlagLayout = 14;

			// Token: 0x040363FC RID: 222204
			public const int LevelFlagItem = 15;

			// Token: 0x040363FD RID: 222205
			public const int LevelRankItem = 16;

			// Token: 0x040363FE RID: 222206
			public const int LevelRankSprite = 17;

			// Token: 0x040363FF RID: 222207
			public const int LevelTimeItem = 18;

			// Token: 0x04036400 RID: 222208
			public const int LevelTimeText = 19;

			// Token: 0x04036401 RID: 222209
			public const int LevelEmptyItem = 20;

			// Token: 0x04036402 RID: 222210
			public const int StartBtn = 21;

			// Token: 0x04036403 RID: 222211
			public const int MatchItem = 22;
		}
	}
}
