using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068A0 RID: 26784
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class AdamSmasherController : ControllerBase
	{
		// Token: 0x06042D58 RID: 273752 RVA: 0x01044F06 File Offset: 0x01043106
		protected override bool OnInit()
		{
			this.OnRegisterNetEvent();
			this.OnAddEvents();
			return true;
		}

		// Token: 0x06042D59 RID: 273753 RVA: 0x01044F15 File Offset: 0x01043115
		protected override bool OnClear()
		{
			this.OnUnRegisterNetEvent();
			this.OnRemoveEvents();
			this.ResetAllState();
			return true;
		}

		// Token: 0x06042D5A RID: 273754 RVA: 0x01044F2A File Offset: 0x0104312A
		private void ResetAllState()
		{
			this.SelectedRoleIdList.Clear();
		}

		// Token: 0x06042D5B RID: 273755 RVA: 0x01044F37 File Offset: 0x01043137
		protected void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.EdgeRunnerLordGymLevelPlayResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAdamSmasherResultNotify));
		}

		// Token: 0x06042D5C RID: 273756 RVA: 0x01044F55 File Offset: 0x01043155
		protected void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.EdgeRunnerLordGymLevelPlayResultNotify);
		}

		// Token: 0x06042D5D RID: 273757 RVA: 0x01044F67 File Offset: 0x01043167
		protected void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		}

		// Token: 0x06042D5E RID: 273758 RVA: 0x01044F85 File Offset: 0x01043185
		protected void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		}

		// Token: 0x06042D5F RID: 273759 RVA: 0x01044FA4 File Offset: 0x010431A4
		[NullableContext(2)]
		private void OnAdamSmasherResultNotify(IMessage msg, Net.CallbackStatus _)
		{
			EdgeRunnerLordGymLevelPlayResultNotify edgeRunnerLordGymLevelPlayResultNotify = (EdgeRunnerLordGymLevelPlayResultNotify)msg;
			if (this.IsCyberPunkActivityEnded())
			{
				this.OpenActivityEndedFailView(edgeRunnerLordGymLevelPlayResultNotify);
				return;
			}
			EdgeRunnerLordGymPassRecord lordGymPassRecord = edgeRunnerLordGymLevelPlayResultNotify.LordGymPassRecord;
			if (!edgeRunnerLordGymLevelPlayResultNotify.IsSuccess)
			{
				int failLoadGymId = edgeRunnerLordGymLevelPlayResultNotify.FailLoadGymId;
				AdamSmasherChallengeFailViewParam param = new AdamSmasherChallengeFailViewParam
				{
					StageId = failLoadGymId
				};
				UiManager.Instance.OpenView(EUiViewName.AdamSmasherChallengeFailView, param, null);
				return;
			}
			if (lordGymPassRecord == null)
			{
				return;
			}
			CyberPunkData cyberPunkData = this.GetCyberPunkData();
			if (cyberPunkData == null)
			{
				return;
			}
			cyberPunkData.UpdateAdamSmasherPassRecord(lordGymPassRecord);
			List<RewardItemData> list = new List<RewardItemData>();
			foreach (Aki.Protocol.ItemData itemData in edgeRunnerLordGymLevelPlayResultNotify.ItemDatas)
			{
				RewardItemData item = new RewardItemData(itemData.ItemId, itemData.Count, (itemData.ItemIncId != 0) ? new int?(itemData.ItemIncId) : null, EDropItemType.Normal);
				list.Add(item);
			}
			RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
			rewardExploreConfirmButtonData.ButtonTextId = "ConfirmBox_505_ButtonText_0";
			rewardExploreConfirmButtonData.DescriptionTextId = null;
			rewardExploreConfirmButtonData.IsTimeDownCloseView = false;
			rewardExploreConfirmButtonData.IsClickedCloseView = true;
			rewardExploreConfirmButtonData.OnClickedCallback = delegate(int _)
			{
				UiManager.Instance.OpenView(EUiViewName.AdamSmasherSelectView, null, null);
			};
			RewardExploreConfirmButtonData item2 = rewardExploreConfirmButtonData;
			int nextStageId = this.GetNextStageId(lordGymPassRecord.LoadGymId);
			List<IRewardExploreConfirmButton> buttonInfoList;
			if (nextStageId > 0 && this.IsStageUnlocked(nextStageId))
			{
				RewardExploreConfirmButtonData item3 = new RewardExploreConfirmButtonData
				{
					ButtonTextId = "Text_GymContinueChallenge_Text",
					DescriptionTextId = null,
					IsTimeDownCloseView = false,
					IsClickedCloseView = true,
					OnClickedCallback = delegate(int _)
					{
						this.RequestStartChallenge(nextStageId, new List<int>(this.SelectedRoleIdList)).Forget<bool>();
					}
				};
				buttonInfoList = new List<IRewardExploreConfirmButton>
				{
					item2,
					item3
				};
			}
			else
			{
				RewardExploreConfirmButtonData rewardExploreConfirmButtonData2 = new RewardExploreConfirmButtonData();
				rewardExploreConfirmButtonData2.ButtonTextId = "Text_GymReturnToWorld_Text";
				rewardExploreConfirmButtonData2.DescriptionTextId = null;
				rewardExploreConfirmButtonData2.IsTimeDownCloseView = false;
				rewardExploreConfirmButtonData2.IsClickedCloseView = true;
				rewardExploreConfirmButtonData2.OnClickedCallback = delegate(int _)
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
				};
				RewardExploreConfirmButtonData item4 = rewardExploreConfirmButtonData2;
				buttonInfoList = new List<IRewardExploreConfirmButton>
				{
					item2,
					item4
				};
			}
			RewardExploreRecordData exploreRecordInfo = new RewardExploreRecordData
			{
				TitleTextId = "LordGym_TimeTitle",
				Record = TimeUtil.Instance.GetTimeString((double)edgeRunnerLordGymLevelPlayResultNotify.PassTime),
				IsNewRecord = edgeRunnerLordGymLevelPlayResultNotify.IsNewRecord
			};
			ExploreRewardViewData data = new ExploreRewardViewData
			{
				ConfigId = 3011,
				IsSuccess = true,
				RewardItemDataList = list,
				ExploreRecordInfo = exploreRecordInfo,
				ButtonInfoList = buttonInfoList,
				IsBagFull = new bool?(edgeRunnerLordGymLevelPlayResultNotify.IsPkgFull)
			};
			ItemRewardController.Instance.OpenExploreRewardViewNew(data);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, 0);
		}

		// Token: 0x06042D60 RID: 273760 RVA: 0x0104526C File Offset: 0x0104346C
		private void OnWorldDoneAndCloseLoading()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				return;
			}
			using (List<int>.Enumerator enumerator = ActivityRoleTrialController.Instance.CurrentActivityIdList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int trialActivityId = enumerator.Current;
					ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(trialActivityId) as ActivityRoleTrialData;
					if (activityRoleTrialData != null && activityRoleTrialData.IsRoleInstanceOn())
					{
						int currentActivityId = CyberPunkController.Instance.CurrentActivityId;
						CyberPunkConfig instance = CyberPunkConfig.Instance;
						if ((((instance != null) ? instance.GetTrialRoleListByCyberPunkActivityId(currentActivityId) : null) ?? Array.Empty<EdgeRunnerTrial>()).Any((EdgeRunnerTrial trialConfig) => trialConfig.ActivityId == trialActivityId))
						{
							activityRoleTrialData.SetRoleTrialState(ERoleTrialFlowState.ActivityOn);
							if (this.GetCyberPunkData() == null)
							{
								break;
							}
							ActivityController.Instance.OpenActivityById(currentActivityId, EActivityViewOpenType.Other, null, delegate(bool _)
							{
								if (this.GetCyberPunkData() == null)
								{
									return;
								}
								UiManager.Instance.OpenView(EUiViewName.CyberPunkTrialRoleView, null, null);
							});
							break;
						}
					}
				}
			}
		}

		// Token: 0x06042D61 RID: 273761 RVA: 0x01045364 File Offset: 0x01043564
		[NullableContext(0)]
		public UniTask<bool> OpenAdamSmasherSelectView()
		{
			AdamSmasherController.<OpenAdamSmasherSelectView>d__13 <OpenAdamSmasherSelectView>d__;
			<OpenAdamSmasherSelectView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenAdamSmasherSelectView>d__.<>1__state = -1;
			<OpenAdamSmasherSelectView>d__.<>t__builder.Start<AdamSmasherController.<OpenAdamSmasherSelectView>d__13>(ref <OpenAdamSmasherSelectView>d__);
			return <OpenAdamSmasherSelectView>d__.<>t__builder.Task;
		}

		// Token: 0x06042D62 RID: 273762 RVA: 0x010453A0 File Offset: 0x010435A0
		public bool IsStageUnlocked(int stageId)
		{
			IReadOnlyList<EdgeRunnerLordGym> stageConfigList = this.GetStageConfigList();
			if (stageConfigList == null || stageConfigList.Count == 0)
			{
				return false;
			}
			if (stageConfigList[0].Id == stageId)
			{
				return true;
			}
			this.GetCyberPunkData();
			return this.IsStageCleared(stageId - 1);
		}

		// Token: 0x06042D63 RID: 273763 RVA: 0x010453E8 File Offset: 0x010435E8
		public bool IsStageCleared(int stageId)
		{
			CyberPunkData cyberPunkData = this.GetCyberPunkData();
			EdgeRunnerLordGymPassRecord edgeRunnerLordGymPassRecord = (cyberPunkData != null) ? cyberPunkData.GetAdamSmasherData(stageId) : null;
			return edgeRunnerLordGymPassRecord != null && edgeRunnerLordGymPassRecord.PassTime > 0;
		}

		// Token: 0x06042D64 RID: 273764 RVA: 0x01045418 File Offset: 0x01043618
		[NullableContext(0)]
		public UniTask<bool> RequestStartChallenge(int stageId, [Nullable(1)] List<int> roleIdList)
		{
			AdamSmasherController.<RequestStartChallenge>d__16 <RequestStartChallenge>d__;
			<RequestStartChallenge>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestStartChallenge>d__.<>4__this = this;
			<RequestStartChallenge>d__.stageId = stageId;
			<RequestStartChallenge>d__.roleIdList = roleIdList;
			<RequestStartChallenge>d__.<>1__state = -1;
			<RequestStartChallenge>d__.<>t__builder.Start<AdamSmasherController.<RequestStartChallenge>d__16>(ref <RequestStartChallenge>d__);
			return <RequestStartChallenge>d__.<>t__builder.Task;
		}

		// Token: 0x06042D65 RID: 273765 RVA: 0x0104546C File Offset: 0x0104366C
		[NullableContext(0)]
		public UniTask<bool> ReChallenge(int stageId)
		{
			AdamSmasherController.<ReChallenge>d__17 <ReChallenge>d__;
			<ReChallenge>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ReChallenge>d__.<>1__state = -1;
			<ReChallenge>d__.<>t__builder.Start<AdamSmasherController.<ReChallenge>d__17>(ref <ReChallenge>d__);
			return <ReChallenge>d__.<>t__builder.Task;
		}

		// Token: 0x06042D66 RID: 273766 RVA: 0x010454A7 File Offset: 0x010436A7
		public IReadOnlyList<int> GetSelectedRoleIdList()
		{
			return this.SelectedRoleIdList;
		}

		// Token: 0x06042D67 RID: 273767 RVA: 0x010454B0 File Offset: 0x010436B0
		[NullableContext(0)]
		public UniTask<bool> EnterAdamSmasherDungeon(int instId)
		{
			AdamSmasherController.<EnterAdamSmasherDungeon>d__19 <EnterAdamSmasherDungeon>d__;
			<EnterAdamSmasherDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnterAdamSmasherDungeon>d__.<>4__this = this;
			<EnterAdamSmasherDungeon>d__.instId = instId;
			<EnterAdamSmasherDungeon>d__.<>1__state = -1;
			<EnterAdamSmasherDungeon>d__.<>t__builder.Start<AdamSmasherController.<EnterAdamSmasherDungeon>d__19>(ref <EnterAdamSmasherDungeon>d__);
			return <EnterAdamSmasherDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x06042D68 RID: 273768 RVA: 0x010454FC File Offset: 0x010436FC
		[NullableContext(2)]
		public AdamStageDetailInfo GetStageDetailInfo(int stageId)
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			EdgeRunnerLordGym? edgeRunnerLordGym = (instance != null) ? instance.GetStageConfig(stageId) : null;
			if (edgeRunnerLordGym == null)
			{
				return null;
			}
			CyberPunkData cyberPunkData = this.GetCyberPunkData();
			EdgeRunnerLordGymPassRecord edgeRunnerLordGymPassRecord = (cyberPunkData != null) ? cyberPunkData.GetAdamSmasherData(stageId) : null;
			return new AdamStageDetailInfo
			{
				RecommendLevel = edgeRunnerLordGym.Value.Level,
				BuffDesc = (edgeRunnerLordGym.Value.BuffDesc ?? ""),
				BestScore = 0,
				BestTime = ((edgeRunnerLordGymPassRecord != null) ? edgeRunnerLordGymPassRecord.PassTime : 0),
				HasFirstClearReward = (edgeRunnerLordGym.Value.RewardId > 0),
				FirstClearRewardClaimed = (edgeRunnerLordGymPassRecord != null)
			};
		}

		// Token: 0x06042D69 RID: 273769 RVA: 0x010455B8 File Offset: 0x010437B8
		public List<TItem> GetSelectedStageRewardPreview(int stageId)
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			int num = (instance != null) ? instance.GetFirstRewardPreview(stageId) : 0;
			if (num <= 0)
			{
				return new List<TItem>();
			}
			List<TItem> exchangeRewardPreviewRewardList = ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList(num, null);
			if (exchangeRewardPreviewRewardList == null)
			{
				return new List<TItem>();
			}
			return exchangeRewardPreviewRewardList;
		}

		// Token: 0x06042D6A RID: 273770 RVA: 0x01045604 File Offset: 0x01043804
		[NullableContext(2)]
		public string GetStageRecordText(int stageId)
		{
			CyberPunkData cyberPunkData = this.GetCyberPunkData();
			EdgeRunnerLordGymPassRecord edgeRunnerLordGymPassRecord = (cyberPunkData != null) ? cyberPunkData.GetAdamSmasherData(stageId) : null;
			if (edgeRunnerLordGymPassRecord == null || edgeRunnerLordGymPassRecord.PassTime <= 0)
			{
				return null;
			}
			int num = edgeRunnerLordGymPassRecord.PassTime / 60;
			int num2 = edgeRunnerLordGymPassRecord.PassTime % 60;
			return num.ToString("D2") + ":" + num2.ToString("D2");
		}

		// Token: 0x06042D6B RID: 273771 RVA: 0x0104566C File Offset: 0x0104386C
		public int[] GetTrialRoleIds(int stageId)
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			EdgeRunnerLordGym? edgeRunnerLordGym = (instance != null) ? instance.GetStageConfig(stageId) : null;
			return ((edgeRunnerLordGym != null) ? edgeRunnerLordGym.GetValueOrDefault().GetTrialRoleArray() : null) ?? Array.Empty<int>();
		}

		// Token: 0x06042D6C RID: 273772 RVA: 0x010456B8 File Offset: 0x010438B8
		public int[] GetUpRoleIds(int stageId)
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			EdgeRunnerLordGym? edgeRunnerLordGym = (instance != null) ? instance.GetStageConfig(stageId) : null;
			return ((edgeRunnerLordGym != null) ? edgeRunnerLordGym.GetValueOrDefault().GetUpRoleArray() : null) ?? Array.Empty<int>();
		}

		// Token: 0x06042D6D RID: 273773 RVA: 0x01045704 File Offset: 0x01043904
		public bool IsInAdamSmasherDungeon()
		{
			GameModeModel instance = GameModeModel.Instance;
			InstanceDungeon? instanceDungeon = (instance != null) ? instance.InstanceDungeon : null;
			return instanceDungeon != null && instanceDungeon.Value.InstSubType == 56;
		}

		// Token: 0x06042D6E RID: 273774 RVA: 0x0104574C File Offset: 0x0104394C
		private bool IsCyberPunkActivityEnded()
		{
			int currentActivityId = CyberPunkController.Instance.CurrentActivityId;
			if (currentActivityId <= 0)
			{
				return false;
			}
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(currentActivityId);
			return activityById == null || !activityById.CheckIfInOpenTime();
		}

		// Token: 0x06042D6F RID: 273775 RVA: 0x01045784 File Offset: 0x01043984
		private void OpenActivityEndedFailView(EdgeRunnerLordGymLevelPlayResultNotify notify)
		{
			int num;
			if (notify.FailLoadGymId == 0)
			{
				EdgeRunnerLordGymPassRecord lordGymPassRecord = notify.LordGymPassRecord;
				num = ((lordGymPassRecord != null) ? lordGymPassRecord.LoadGymId : 0);
			}
			else
			{
				num = notify.FailLoadGymId;
			}
			int stageId = num;
			AdamSmasherChallengeFailViewParam param = new AdamSmasherChallengeFailViewParam
			{
				StageId = stageId,
				IsActivityEnded = true
			};
			UiManager.Instance.OpenView(EUiViewName.AdamSmasherChallengeFailView, param, null);
		}

		// Token: 0x06042D70 RID: 273776 RVA: 0x010457DC File Offset: 0x010439DC
		[NullableContext(2)]
		private CyberPunkData GetCyberPunkData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.EdgeRunnerActivity);
			if (currentActivitiesByType != null && currentActivitiesByType.Count > 0)
			{
				return currentActivitiesByType[0] as CyberPunkData;
			}
			return null;
		}

		// Token: 0x06042D71 RID: 273777 RVA: 0x01045810 File Offset: 0x01043A10
		[NullableContext(2)]
		private IReadOnlyList<EdgeRunnerLordGym> GetStageConfigList()
		{
			int currentActivityId = CyberPunkController.Instance.CurrentActivityId;
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.GetStageConfigList(currentActivityId);
		}

		// Token: 0x06042D72 RID: 273778 RVA: 0x0104583C File Offset: 0x01043A3C
		private int GetNextStageId(int stageId)
		{
			IReadOnlyList<EdgeRunnerLordGym> stageConfigList = this.GetStageConfigList();
			if (stageConfigList == null || stageConfigList.Count == 0)
			{
				return 0;
			}
			int num = -1;
			for (int i = 0; i < stageConfigList.Count; i++)
			{
				if (stageConfigList[i].Id == stageId)
				{
					num = i;
					break;
				}
			}
			if (num < 0 || num >= stageConfigList.Count - 1)
			{
				return 0;
			}
			return stageConfigList[num + 1].Id;
		}

		// Token: 0x170097C0 RID: 38848
		// (get) Token: 0x06042D73 RID: 273779 RVA: 0x010458A8 File Offset: 0x01043AA8
		public static AdamSmasherController Instance
		{
			get
			{
				return AdamSmasherController._Instance;
			}
		}

		// Token: 0x06042D74 RID: 273780 RVA: 0x010458AF File Offset: 0x01043AAF
		public static AdamSmasherController GetOrCreateInstance()
		{
			if (AdamSmasherController._Instance == null)
			{
				AdamSmasherController.CreateInstance();
			}
			return AdamSmasherController._Instance;
		}

		// Token: 0x06042D75 RID: 273781 RVA: 0x010458C3 File Offset: 0x01043AC3
		public static bool CreateInstance()
		{
			if (AdamSmasherController._Instance != null)
			{
				return true;
			}
			AdamSmasherController._Instance = new AdamSmasherController();
			return true;
		}

		// Token: 0x06042D76 RID: 273782 RVA: 0x010458D9 File Offset: 0x01043AD9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06042D77 RID: 273783 RVA: 0x010458DB File Offset: 0x01043ADB
		public static void ResetStaticDefaultValue()
		{
			AdamSmasherController._Instance = null;
		}

		// Token: 0x06042D78 RID: 273784 RVA: 0x010458E3 File Offset: 0x01043AE3
		static AdamSmasherController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AdamSmasherController.CreateStaticDefaultValue), new Action(AdamSmasherController.ResetStaticDefaultValue));
		}

		// Token: 0x04022C7F RID: 142463
		private const string LOG_TAG = "[AdamSmasher]";

		// Token: 0x04022C80 RID: 142464
		private const int ADAM_SMASHER_ACTIVITY_UID = 0;

		// Token: 0x04022C81 RID: 142465
		private const int SECONDS_PER_MINUTE = 60;

		// Token: 0x04022C82 RID: 142466
		private List<int> SelectedRoleIdList = new List<int>();

		// Token: 0x04022C83 RID: 142467
		[Nullable(2)]
		private static AdamSmasherController _Instance;
	}
}
