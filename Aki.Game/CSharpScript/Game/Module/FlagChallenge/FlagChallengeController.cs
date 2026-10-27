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
	// Token: 0x02005A2B RID: 23083
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class FlagChallengeController : UiControllerBase
	{
		// Token: 0x0603A937 RID: 239927 RVA: 0x00DF0C90 File Offset: 0x00DEEE90
		protected override void OnAddEvents()
		{
			Net.Instance.Register(ENotifyMessageId.FlagChallengeTaskInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTaskInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.FlagChallengeLevelInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLevelInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.FlagStrongholdInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnStrongholdInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.FlagChallengePerRoleLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPerRoleLevelNotify));
			Net.Instance.Register(ENotifyMessageId.FlagChallengeUnlockTeleporterNotify, new Action<IMessage, Net.CallbackStatus>(this.UnlockTeleporterNotify));
		}

		// Token: 0x0603A938 RID: 239928 RVA: 0x00DF0D2C File Offset: 0x00DEEF2C
		protected override void OnRemoveEvents()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengeTaskInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengeLevelInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagStrongholdInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengePerRoleLevelNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengeUnlockTeleporterNotify);
		}

		// Token: 0x0603A939 RID: 239929 RVA: 0x00DF0D8C File Offset: 0x00DEEF8C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(flagChallengeRewardResponse.ErrorCode, 16460, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0603A93A RID: 239930 RVA: 0x00DF0DE4 File Offset: 0x00DEEFE4
		[NullableContext(1)]
		public void RequestChallenge(int instId, int strongholdId, List<int> roleIdList)
		{
			FlagChallengeCtx flagChallengeCtx = FlagChallengeCtx.Create();
			flagChallengeCtx.FlagStrongholdId = strongholdId;
			InstanceDungeonModel.Instance.InstanceEnterContentText.FlagChallengeCtx = flagChallengeCtx;
			InstanceDungeonController.Instance.PrewarTeamFightRequest(instId, roleIdList, 0, 0, null, null).Forget<bool>();
		}

		// Token: 0x0603A93B RID: 239931 RVA: 0x00DF0E24 File Offset: 0x00DEF024
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

		// Token: 0x0603A93C RID: 239932 RVA: 0x00DF0F10 File Offset: 0x00DEF110
		private void OnLevelInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			FlagChallengeLevelInfoUpdateNotify flagChallengeLevelInfoUpdateNotify = (FlagChallengeLevelInfoUpdateNotify)msg;
			FlagChallengeModel.Instance.UpdateLevelData(flagChallengeLevelInfoUpdateNotify.FlagChallengeLevelInfo);
			EventSystem.Instance.Emit(EEventName.OnFlagChallengeUpdateLevelData);
		}

		// Token: 0x0603A93D RID: 239933 RVA: 0x00DF0F44 File Offset: 0x00DEF144
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

		// Token: 0x0603A93E RID: 239934 RVA: 0x00DF1060 File Offset: 0x00DEF260
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

		// Token: 0x0603A93F RID: 239935 RVA: 0x00DF10B4 File Offset: 0x00DEF2B4
		private void UnlockTeleporterNotify(IMessage msg, Net.CallbackStatus status)
		{
			RepeatedField<int> teleporterId = ((FlagChallengeUnlockTeleporterNotify)msg).TeleporterId;
			FlagChallengeModel.Instance.UpdateTeleportData(teleporterId);
		}

		// Token: 0x0603A940 RID: 239936 RVA: 0x00DF10D8 File Offset: 0x00DEF2D8
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

		// Token: 0x0603A941 RID: 239937 RVA: 0x00DF1132 File Offset: 0x00DEF332
		public void OpenFlagChallengeTaskView(int activityId)
		{
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeRewardView, activityId, null);
		}

		// Token: 0x0603A942 RID: 239938 RVA: 0x00DF114C File Offset: 0x00DEF34C
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

		// Token: 0x0603A943 RID: 239939 RVA: 0x00DF1188 File Offset: 0x00DEF388
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

		// Token: 0x0603A944 RID: 239940 RVA: 0x00DF11CC File Offset: 0x00DEF3CC
		public void OpenFlagChallengeBuffView(int activityId, int? selectBuffId = null)
		{
			FlagChallengeBuffViewParams param = new FlagChallengeBuffViewParams
			{
				ActivityId = activityId,
				BuffId = selectBuffId
			};
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeBuffView, param, null);
		}

		// Token: 0x0603A945 RID: 239941 RVA: 0x00DF1200 File Offset: 0x00DEF400
		public void OpenBuffActiveTipsView(int activityId)
		{
			FlagChallengeBuffActiveTipsParams param = new FlagChallengeBuffActiveTipsParams
			{
				ActivityId = activityId
			};
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeBuffActiveTips, param, null);
		}

		// Token: 0x17008BDB RID: 35803
		// (get) Token: 0x0603A946 RID: 239942 RVA: 0x00DF122B File Offset: 0x00DEF42B
		[Nullable(1)]
		public static FlagChallengeController Instance
		{
			[NullableContext(1)]
			get
			{
				return FlagChallengeController._Instance;
			}
		}

		// Token: 0x0603A947 RID: 239943 RVA: 0x00DF1232 File Offset: 0x00DEF432
		[NullableContext(1)]
		public static FlagChallengeController GetOrCreateInstance()
		{
			if (FlagChallengeController._Instance == null)
			{
				FlagChallengeController.CreateInstance();
			}
			return FlagChallengeController._Instance;
		}

		// Token: 0x0603A948 RID: 239944 RVA: 0x00DF1246 File Offset: 0x00DEF446
		public static bool CreateInstance()
		{
			if (FlagChallengeController._Instance != null)
			{
				return true;
			}
			FlagChallengeController._Instance = new FlagChallengeController();
			return true;
		}

		// Token: 0x0603A949 RID: 239945 RVA: 0x00DF125C File Offset: 0x00DEF45C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A94A RID: 239946 RVA: 0x00DF125E File Offset: 0x00DEF45E
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeController._Instance = null;
		}

		// Token: 0x0603A94B RID: 239947 RVA: 0x00DF1266 File Offset: 0x00DEF466
		static FlagChallengeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeController.CreateStaticDefaultValue), new Action(FlagChallengeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E7E4 RID: 124900
		private static FlagChallengeController _Instance;
	}
}
