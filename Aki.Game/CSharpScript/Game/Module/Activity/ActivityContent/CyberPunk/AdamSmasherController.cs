using System;
using System.Collections.Generic;
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
	// Token: 0x020057F0 RID: 22512
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class AdamSmasherController : ControllerBase
	{
		// Token: 0x060378B0 RID: 227504 RVA: 0x00F8647E File Offset: 0x00F8467E
		protected override bool OnInit()
		{
			this.OnRegisterNetEvent();
			this.OnAddEvents();
			return true;
		}

		// Token: 0x060378B1 RID: 227505 RVA: 0x00F8648D File Offset: 0x00F8468D
		protected override bool OnClear()
		{
			this.OnUnRegisterNetEvent();
			this.OnRemoveEvents();
			this.ResetAllState();
			return true;
		}

		// Token: 0x060378B2 RID: 227506 RVA: 0x00F864A2 File Offset: 0x00F846A2
		private void ResetAllState()
		{
			this.SelectedRoleIdList.Clear();
		}

		// Token: 0x060378B3 RID: 227507 RVA: 0x00F864AF File Offset: 0x00F846AF
		protected void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.EdgeRunnerLordGymLevelPlayResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAdamSmasherResultNotify));
		}

		// Token: 0x060378B4 RID: 227508 RVA: 0x00F864CD File Offset: 0x00F846CD
		protected void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.EdgeRunnerLordGymLevelPlayResultNotify);
		}

		// Token: 0x060378B5 RID: 227509 RVA: 0x00F864DF File Offset: 0x00F846DF
		protected void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		}

		// Token: 0x060378B6 RID: 227510 RVA: 0x00F864FD File Offset: 0x00F846FD
		protected void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		}

		// Token: 0x060378B7 RID: 227511 RVA: 0x00F8651C File Offset: 0x00F8471C
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

		// Token: 0x060378B8 RID: 227512 RVA: 0x00F867E4 File Offset: 0x00F849E4
		private void OnWorldDoneAndCloseLoading()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				return;
			}
			foreach (int num in ActivityRoleTrialController.Instance.CurrentActivityIdList)
			{
				ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(num) as ActivityRoleTrialData;
				if (activityRoleTrialData != null && activityRoleTrialData.IsRoleInstanceOn())
				{
					int currentActivityId = CyberPunkController.Instance.CurrentActivityId;
					CyberPunkConfig instance = CyberPunkConfig.Instance;
					IReadOnlyList<EdgeRunnerTrial> readOnlyList = ((instance != null) ? instance.GetTrialRoleListByCyberPunkActivityId(currentActivityId) : null) ?? Array.Empty<EdgeRunnerTrial>();
					bool flag = false;
					for (int i = 0; i < readOnlyList.Count; i++)
					{
						if (readOnlyList[i].ActivityId == num)
						{
							flag = true;
							break;
						}
					}
					if (flag)
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

		// Token: 0x060378B9 RID: 227513 RVA: 0x00F868F8 File Offset: 0x00F84AF8
		[NullableContext(0)]
		public UniTask<bool> OpenAdamSmasherSelectView()
		{
			AdamSmasherController.<OpenAdamSmasherSelectView>d__13 <OpenAdamSmasherSelectView>d__;
			<OpenAdamSmasherSelectView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenAdamSmasherSelectView>d__.<>1__state = -1;
			<OpenAdamSmasherSelectView>d__.<>t__builder.Start<AdamSmasherController.<OpenAdamSmasherSelectView>d__13>(ref <OpenAdamSmasherSelectView>d__);
			return <OpenAdamSmasherSelectView>d__.<>t__builder.Task;
		}

		// Token: 0x060378BA RID: 227514 RVA: 0x00F86934 File Offset: 0x00F84B34
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

		// Token: 0x060378BB RID: 227515 RVA: 0x00F8697C File Offset: 0x00F84B7C
		public bool IsStageCleared(int stageId)
		{
			CyberPunkData cyberPunkData = this.GetCyberPunkData();
			EdgeRunnerLordGymPassRecord edgeRunnerLordGymPassRecord = (cyberPunkData != null) ? cyberPunkData.GetAdamSmasherData(stageId) : null;
			return edgeRunnerLordGymPassRecord != null && edgeRunnerLordGymPassRecord.PassTime > 0;
		}

		// Token: 0x060378BC RID: 227516 RVA: 0x00F869AC File Offset: 0x00F84BAC
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

		// Token: 0x060378BD RID: 227517 RVA: 0x00F86A00 File Offset: 0x00F84C00
		[NullableContext(0)]
		public UniTask<bool> ReChallenge(int stageId)
		{
			AdamSmasherController.<ReChallenge>d__17 <ReChallenge>d__;
			<ReChallenge>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ReChallenge>d__.<>1__state = -1;
			<ReChallenge>d__.<>t__builder.Start<AdamSmasherController.<ReChallenge>d__17>(ref <ReChallenge>d__);
			return <ReChallenge>d__.<>t__builder.Task;
		}

		// Token: 0x060378BE RID: 227518 RVA: 0x00F86A3B File Offset: 0x00F84C3B
		public IReadOnlyList<int> GetSelectedRoleIdList()
		{
			return this.SelectedRoleIdList;
		}

		// Token: 0x060378BF RID: 227519 RVA: 0x00F86A44 File Offset: 0x00F84C44
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

		// Token: 0x060378C0 RID: 227520 RVA: 0x00F86A90 File Offset: 0x00F84C90
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

		// Token: 0x060378C1 RID: 227521 RVA: 0x00F86B4C File Offset: 0x00F84D4C
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

		// Token: 0x060378C2 RID: 227522 RVA: 0x00F86B98 File Offset: 0x00F84D98
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

		// Token: 0x060378C3 RID: 227523 RVA: 0x00F86C00 File Offset: 0x00F84E00
		public int[] GetTrialRoleIds(int stageId)
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			EdgeRunnerLordGym? edgeRunnerLordGym = (instance != null) ? instance.GetStageConfig(stageId) : null;
			return ((edgeRunnerLordGym != null) ? edgeRunnerLordGym.GetValueOrDefault().GetTrialRoleArray() : null) ?? Array.Empty<int>();
		}

		// Token: 0x060378C4 RID: 227524 RVA: 0x00F86C4C File Offset: 0x00F84E4C
		public int[] GetUpRoleIds(int stageId)
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			EdgeRunnerLordGym? edgeRunnerLordGym = (instance != null) ? instance.GetStageConfig(stageId) : null;
			return ((edgeRunnerLordGym != null) ? edgeRunnerLordGym.GetValueOrDefault().GetUpRoleArray() : null) ?? Array.Empty<int>();
		}

		// Token: 0x060378C5 RID: 227525 RVA: 0x00F86C98 File Offset: 0x00F84E98
		public bool IsInAdamSmasherDungeon()
		{
			GameModeModel instance = GameModeModel.Instance;
			InstanceDungeon? instanceDungeon = (instance != null) ? instance.InstanceDungeon : null;
			return instanceDungeon != null && instanceDungeon.Value.InstSubType == 56;
		}

		// Token: 0x060378C6 RID: 227526 RVA: 0x00F86CE0 File Offset: 0x00F84EE0
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

		// Token: 0x060378C7 RID: 227527 RVA: 0x00F86D18 File Offset: 0x00F84F18
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

		// Token: 0x060378C8 RID: 227528 RVA: 0x00F86D70 File Offset: 0x00F84F70
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

		// Token: 0x060378C9 RID: 227529 RVA: 0x00F86DA4 File Offset: 0x00F84FA4
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

		// Token: 0x060378CA RID: 227530 RVA: 0x00F86DD0 File Offset: 0x00F84FD0
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

		// Token: 0x17006B00 RID: 27392
		// (get) Token: 0x060378CB RID: 227531 RVA: 0x00F86E3C File Offset: 0x00F8503C
		public static AdamSmasherController Instance
		{
			get
			{
				return AdamSmasherController._Instance;
			}
		}

		// Token: 0x060378CC RID: 227532 RVA: 0x00F86E43 File Offset: 0x00F85043
		public static AdamSmasherController GetOrCreateInstance()
		{
			if (AdamSmasherController._Instance == null)
			{
				AdamSmasherController.CreateInstance();
			}
			return AdamSmasherController._Instance;
		}

		// Token: 0x060378CD RID: 227533 RVA: 0x00F86E57 File Offset: 0x00F85057
		public static bool CreateInstance()
		{
			if (AdamSmasherController._Instance != null)
			{
				return true;
			}
			AdamSmasherController._Instance = new AdamSmasherController();
			return true;
		}

		// Token: 0x060378CE RID: 227534 RVA: 0x00F86E6D File Offset: 0x00F8506D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060378CF RID: 227535 RVA: 0x00F86E6F File Offset: 0x00F8506F
		public static void ResetStaticDefaultValue()
		{
			AdamSmasherController._Instance = null;
		}

		// Token: 0x060378D0 RID: 227536 RVA: 0x00F86E77 File Offset: 0x00F85077
		static AdamSmasherController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AdamSmasherController.CreateStaticDefaultValue), new Action(AdamSmasherController.ResetStaticDefaultValue));
		}

		// Token: 0x0401D4DB RID: 120027
		private const string LOG_TAG = "[AdamSmasher]";

		// Token: 0x0401D4DC RID: 120028
		private const int ADAM_SMASHER_ACTIVITY_UID = 0;

		// Token: 0x0401D4DD RID: 120029
		private const int SECONDS_PER_MINUTE = 60;

		// Token: 0x0401D4DE RID: 120030
		private List<int> SelectedRoleIdList = new List<int>();

		// Token: 0x0401D4DF RID: 120031
		[Nullable(2)]
		private static AdamSmasherController _Instance;
	}
}
