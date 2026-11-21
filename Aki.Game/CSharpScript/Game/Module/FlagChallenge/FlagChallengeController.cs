using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.FlagChallenge;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A07 RID: 18951
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class FlagChallengeController : UiControllerBase
	{
		// Token: 0x0602F880 RID: 194688 RVA: 0x00D41214 File Offset: 0x00D3F414
		protected override void OnAddEvents()
		{
			Net.Instance.Register(ENotifyMessageId.FlagChallengeTaskInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTaskInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.FlagChallengeLevelInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLevelInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.FlagStrongholdInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnStrongholdInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.FlagChallengePerRoleLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPerRoleLevelNotify));
			Net.Instance.Register(ENotifyMessageId.FlagChallengeUnlockTeleporterNotify, new Action<IMessage, Net.CallbackStatus>(this.UnlockTeleporterNotify));
		}

		// Token: 0x0602F881 RID: 194689 RVA: 0x00D412B0 File Offset: 0x00D3F4B0
		protected override void OnRemoveEvents()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengeTaskInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengeLevelInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagStrongholdInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengePerRoleLevelNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengeUnlockTeleporterNotify);
		}

		// Token: 0x0602F882 RID: 194690 RVA: 0x00D41310 File Offset: 0x00D3F510
		[NullableContext(1)]
		public void RequestFlagChallengeReward(int activityId, List<int> taskIds)
		{
			FlagChallengeRewardRequest flagChallengeRewardRequest = FlagChallengeRewardRequest.Create();
			flagChallengeRewardRequest.ActivityId = activityId;
			flagChallengeRewardRequest.FlagChallengeTaskIds.AddRange(taskIds);
			Net.Instance.Call(ERequestMessageId.FlagChallengeRewardRequest, flagChallengeRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FlagChallengeRewardResponse flagChallengeRewardResponse = (FlagChallengeRewardResponse)msg;
				if (flagChallengeRewardResponse == null)
				{
					return;
				}
				if (flagChallengeRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(flagChallengeRewardResponse.ErrorCode, 20586, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0602F883 RID: 194691 RVA: 0x00D41368 File Offset: 0x00D3F568
		[NullableContext(1)]
		public void RequestChallenge(int instId, int strongholdId, List<int> roleIdList)
		{
			FlagChallengeCtx flagChallengeCtx = FlagChallengeCtx.Create();
			flagChallengeCtx.FlagStrongholdId = strongholdId;
			InstanceDungeonModel.Instance.InstanceEnterContentText.FlagChallengeCtx = flagChallengeCtx;
			InstanceDungeonController.Instance.PrewarTeamFightRequest(instId, roleIdList, 0, 0, null, null).Forget<bool>();
		}

		// Token: 0x0602F884 RID: 194692 RVA: 0x00D413A8 File Offset: 0x00D3F5A8
		private void OnTaskInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RepeatedField<ConditionTask> conditionTasks = ((FlagChallengeTaskInfoUpdateNotify)msg).ConditionTasks;
			FlagChallengeModel.Instance.UpdateTaskData(conditionTasks);
			HashSet<int> hashSet = new HashSet<int>();
			foreach (ConditionTask conditionTask in conditionTasks)
			{
				FlagChallengeTask? taskConfig = FlagChallengeConfig.Instance.GetTaskConfig(conditionTask.Id);
				if (taskConfig != null)
				{
					hashSet.Add(taskConfig.Value.ActivityId);
				}
			}
			foreach (int p in hashSet)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, p);
				EventSystem.Instance.Emit<int>(EEventName.OnFlagChallengeTaskUpdate, p);
			}
		}

		// Token: 0x0602F885 RID: 194693 RVA: 0x00D41494 File Offset: 0x00D3F694
		private void OnLevelInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			FlagChallengeLevelInfoUpdateNotify flagChallengeLevelInfoUpdateNotify = (FlagChallengeLevelInfoUpdateNotify)msg;
			FlagChallengeModel.Instance.UpdateLevelData(flagChallengeLevelInfoUpdateNotify.FlagChallengeLevelInfo);
			EventSystem.Instance.Emit(EEventName.OnFlagChallengeUpdateLevelData);
		}

		// Token: 0x0602F886 RID: 194694 RVA: 0x00D414C8 File Offset: 0x00D3F6C8
		private void OnStrongholdInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			FlagStrongholdInfoUpdateNotify flagStrongholdInfoUpdateNotify = (FlagStrongholdInfoUpdateNotify)msg;
			FlagChallengeModel instance = FlagChallengeModel.Instance;
			List<int> list = new List<int>();
			foreach (FlagStrongholdInfo flagStrongholdInfo in flagStrongholdInfoUpdateNotify.FlagStrongholdInfo)
			{
				FlagChallengeStrongholdData strongholdData = instance.GetStrongholdData(flagStrongholdInfo.Id);
				if (strongholdData != null && !strongholdData.IsPass && flagStrongholdInfo.IsPass)
				{
					list.Add(strongholdData.Id);
				}
			}
			instance.UpdateStrongholdData(flagStrongholdInfoUpdateNotify.FlagStrongholdInfo);
			foreach (int num in list)
			{
				int strongholdActivityId = FlagChallengeUtils.GetStrongholdActivityId(num);
				FlagChallengeData flagChallengeData = instance.GetFlagChallengeData(strongholdActivityId);
				FlagChallengeStrongholdData strongholdData2 = flagChallengeData.GetStrongholdData(num);
				if (!flagChallengeData.IsAreaAllBossStrongholdPass(strongholdData2.StrongholdConfig.AreaId) || strongholdData2.IsBossStronghold())
				{
					EventSystem.Instance.Emit<int>(EEventName.OnFlagChallengeStrongholdOccupied, num);
				}
			}
		}

		// Token: 0x0602F887 RID: 194695 RVA: 0x00D415E4 File Offset: 0x00D3F7E4
		private void OnPerRoleLevelNotify(IMessage msg, Net.CallbackStatus status)
		{
			FlagChallengePerRoleLevelNotify flagChallengePerRoleLevelNotify = (FlagChallengePerRoleLevelNotify)msg;
			FlagChallengeRoleLevelInfo flagChallengeRoleLevelInfo = flagChallengePerRoleLevelNotify.FlagChallengeRoleLevelInfo;
			if (flagChallengeRoleLevelInfo == null)
			{
				return;
			}
			FlagChallengeModel.Instance.UpdateRoleLevelData(flagChallengePerRoleLevelNotify.ActivityId, flagChallengeRoleLevelInfo);
			EventSystem.Instance.Emit<int, int, int>(EEventName.OnFlagChallengeFixedRoleLevelUpdate, flagChallengePerRoleLevelNotify.ActivityId, flagChallengeRoleLevelInfo.PerLevel, flagChallengeRoleLevelInfo.PerExp);
		}

		// Token: 0x0602F888 RID: 194696 RVA: 0x00D41638 File Offset: 0x00D3F838
		private void UnlockTeleporterNotify(IMessage msg, Net.CallbackStatus status)
		{
			RepeatedField<int> teleporterId = ((FlagChallengeUnlockTeleporterNotify)msg).TeleporterId;
			FlagChallengeModel.Instance.UpdateTeleportData(teleporterId);
		}

		// Token: 0x0602F889 RID: 194697 RVA: 0x00D4165C File Offset: 0x00D3F85C
		public void OpenFlagChallengeMainView(int activityId, int? levelId = null)
		{
			ActivityFlagChallengeData param = ActivityModel.Instance.GetActivityById(activityId) as ActivityFlagChallengeData;
			if (levelId != null)
			{
				FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(activityId);
				if (flagChallengeData != null)
				{
					flagChallengeData.SetMainViewSelectLevelId(new int?(levelId.Value));
				}
			}
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeMainView, param, null);
		}

		// Token: 0x0602F88A RID: 194698 RVA: 0x00D416B6 File Offset: 0x00D3F8B6
		public void OpenFlagChallengeTaskView(int activityId)
		{
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeRewardView, activityId, null);
		}

		// Token: 0x0602F88B RID: 194699 RVA: 0x00D416D0 File Offset: 0x00D3F8D0
		public void OpenFlagChallengeSelectRoleView(int activityId, int levelId, int strongholdId)
		{
			FlagChallengeSelectRoleViewParams param = new FlagChallengeSelectRoleViewParams
			{
				ActivityId = activityId,
				LevelId = levelId,
				StrongholdId = strongholdId
			};
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeSelectRoleView, param, null);
		}

		// Token: 0x0602F88C RID: 194700 RVA: 0x00D4170C File Offset: 0x00D3F90C
		public void OpenFlagChallengeAreaDetailView(int activityId, int levelId, int areaId, int? strongholdId = null)
		{
			FlagChallengeAreaDetailViewParams param = new FlagChallengeAreaDetailViewParams
			{
				ActivityId = activityId,
				LevelId = levelId,
				AreaId = areaId,
				StrongholdId = strongholdId
			};
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeAreaDetailView, param, null);
		}

		// Token: 0x0602F88D RID: 194701 RVA: 0x00D41750 File Offset: 0x00D3F950
		public void OpenFlagChallengeBuffView(int activityId, int? selectBuffId = null)
		{
			FlagChallengeBuffViewParams param = new FlagChallengeBuffViewParams
			{
				ActivityId = activityId,
				BuffId = selectBuffId
			};
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeBuffView, param, null);
		}

		// Token: 0x0602F88E RID: 194702 RVA: 0x00D41784 File Offset: 0x00D3F984
		public void OpenBuffActiveTipsView(int activityId)
		{
			FlagChallengeBuffActiveTipsParams param = new FlagChallengeBuffActiveTipsParams
			{
				ActivityId = activityId
			};
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeBuffActiveTips, param, null);
		}

		// Token: 0x17005FA9 RID: 24489
		// (get) Token: 0x0602F88F RID: 194703 RVA: 0x00D417AF File Offset: 0x00D3F9AF
		[Nullable(1)]
		public static FlagChallengeController Instance
		{
			[NullableContext(1)]
			get
			{
				return FlagChallengeController._Instance;
			}
		}

		// Token: 0x0602F890 RID: 194704 RVA: 0x00D417B6 File Offset: 0x00D3F9B6
		[NullableContext(1)]
		public static FlagChallengeController GetOrCreateInstance()
		{
			if (FlagChallengeController._Instance == null)
			{
				FlagChallengeController.CreateInstance();
			}
			return FlagChallengeController._Instance;
		}

		// Token: 0x0602F891 RID: 194705 RVA: 0x00D417CA File Offset: 0x00D3F9CA
		public static bool CreateInstance()
		{
			if (FlagChallengeController._Instance != null)
			{
				return true;
			}
			FlagChallengeController._Instance = new FlagChallengeController();
			return true;
		}

		// Token: 0x0602F892 RID: 194706 RVA: 0x00D417E0 File Offset: 0x00D3F9E0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F893 RID: 194707 RVA: 0x00D417E2 File Offset: 0x00D3F9E2
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeController._Instance = null;
		}

		// Token: 0x0602F894 RID: 194708 RVA: 0x00D417EA File Offset: 0x00D3F9EA
		static FlagChallengeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeController.CreateStaticDefaultValue), new Action(FlagChallengeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401928B RID: 103051
		private static FlagChallengeController _Instance;
	}
}
