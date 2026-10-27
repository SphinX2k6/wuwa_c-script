using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006406 RID: 25606
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MotorFightController : ActivityControllerBase
	{
		// Token: 0x060406A6 RID: 263846 RVA: 0x00F9513C File Offset: 0x00F9333C
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MotorFightLevelUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateMotorFightLevel));
			Net.Instance.Register(ENotifyMessageId.MotorFightItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateMotorFightItem));
			Net.Instance.Register(ENotifyMessageId.MotorFightRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateMotorFightRole));
			Net.Instance.Register(ENotifyMessageId.MotorFightTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateMotorFightTask));
			Net.Instance.Register(ENotifyMessageId.MotorFightTalentTreeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateMotorFightTalentTree));
			Net.Instance.Register(ENotifyMessageId.MotorFightGameOverNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorFightGameOver));
		}

		// Token: 0x060406A7 RID: 263847 RVA: 0x00F951F4 File Offset: 0x00F933F4
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightLevelUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightItemUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightRoleUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightTalentTreeUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightGameOverNotify);
		}

		// Token: 0x060406A8 RID: 263848 RVA: 0x00F95261 File Offset: 0x00F93461
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x060406A9 RID: 263849 RVA: 0x00F9529B File Offset: 0x00F9349B
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x060406AA RID: 263850 RVA: 0x00F952D5 File Offset: 0x00F934D5
		protected override void OnOpenView(ActivityBaseData data)
		{
			throw new Exception("Method not implemented.");
		}

		// Token: 0x060406AB RID: 263851 RVA: 0x00F952E1 File Offset: 0x00F934E1
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_MotorcycleBattleMain";
		}

		// Token: 0x060406AC RID: 263852 RVA: 0x00F952E8 File Offset: 0x00F934E8
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new MotorFightActivitySubView();
		}

		// Token: 0x060406AD RID: 263853 RVA: 0x00F952F0 File Offset: 0x00F934F0
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			MotorFightActivityData motorFightActivityData = new MotorFightActivityData();
			this.MotorFightActivityData = motorFightActivityData;
			return motorFightActivityData;
		}

		// Token: 0x060406AE RID: 263854 RVA: 0x00F9530C File Offset: 0x00F9350C
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			foreach (EUiViewName viewName in new List<EUiViewName>
			{
				EUiViewName.MotorFightMainView,
				EUiViewName.MotorFightLevelDetailView,
				EUiViewName.MotorFightRoleSelectView,
				EUiViewName.MotorFightTalentTreeView,
				EUiViewName.MotorFightHandBookView,
				EUiViewName.MotorFightRankView,
				EUiViewName.MotorFightRewardView
			})
			{
				if (UiManager.Instance.IsViewOpen(viewName))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060406AF RID: 263855 RVA: 0x00F953B8 File Offset: 0x00F935B8
		[NullableContext(2)]
		public MotorFightActivityData GetMotorFightActivityData()
		{
			if (this.MotorFightActivityData == null)
			{
				Log.Instance.Error(ELogModule.MotorFightActivity, ELogAuthor.CXJ, "摩托战斗活动数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.MotorFightActivityData;
		}

		// Token: 0x060406B0 RID: 263856 RVA: 0x00F953F4 File Offset: 0x00F935F4
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			MotorFightController.<OnOpenSubView>d__15 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.<>4__this = this;
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<MotorFightController.<OnOpenSubView>d__15>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x060406B1 RID: 263857 RVA: 0x00F95440 File Offset: 0x00F93640
		[NullableContext(2)]
		private void UpdateMotorFightLevel(IMessage msg, Net.CallbackStatus status)
		{
			MotorFightLevelUpdateNotify motorFightLevelUpdateNotify = (MotorFightLevelUpdateNotify)msg;
			MotorFightActivityData motorFightActivityData = this.GetMotorFightActivityData();
			if (motorFightActivityData == null)
			{
				return;
			}
			motorFightActivityData.UpdateLevelDataList(motorFightLevelUpdateNotify.MotorFightLevelPb, true);
		}

		// Token: 0x060406B2 RID: 263858 RVA: 0x00F9546C File Offset: 0x00F9366C
		[NullableContext(2)]
		private void UpdateMotorFightItem(IMessage msg, Net.CallbackStatus status)
		{
			MotorFightItemUpdateNotify motorFightItemUpdateNotify = (MotorFightItemUpdateNotify)msg;
			MotorFightActivityData motorFightActivityData = this.GetMotorFightActivityData();
			if (motorFightActivityData == null)
			{
				return;
			}
			motorFightActivityData.UpdateMotorFightItemDataList(motorFightItemUpdateNotify.UnlockedItem, true);
		}

		// Token: 0x060406B3 RID: 263859 RVA: 0x00F95498 File Offset: 0x00F93698
		[NullableContext(2)]
		private void UpdateMotorFightRole(IMessage msg, Net.CallbackStatus status)
		{
			MotorFightRoleUpdateNotify motorFightRoleUpdateNotify = (MotorFightRoleUpdateNotify)msg;
			MotorFightActivityData motorFightActivityData = this.GetMotorFightActivityData();
			if (motorFightActivityData == null)
			{
				return;
			}
			motorFightActivityData.UpdateRoleData(motorFightRoleUpdateNotify.UnlockedRole, true);
		}

		// Token: 0x060406B4 RID: 263860 RVA: 0x00F954C4 File Offset: 0x00F936C4
		[NullableContext(2)]
		private void UpdateMotorFightTask(IMessage msg, Net.CallbackStatus status)
		{
			MotorFightTaskUpdateNotify motorFightTaskUpdateNotify = (MotorFightTaskUpdateNotify)msg;
			MotorFightActivityData motorFightActivityData = this.GetMotorFightActivityData();
			if (motorFightActivityData == null)
			{
				return;
			}
			motorFightActivityData.UpdateTaskData(motorFightTaskUpdateNotify.Task, true);
		}

		// Token: 0x060406B5 RID: 263861 RVA: 0x00F954F0 File Offset: 0x00F936F0
		[NullableContext(2)]
		private void UpdateMotorFightTalentTree(IMessage msg, Net.CallbackStatus status)
		{
			MotorFightTalentTreeUpdateNotify motorFightTalentTreeUpdateNotify = (MotorFightTalentTreeUpdateNotify)msg;
			MotorFightActivityData motorFightActivityData = this.GetMotorFightActivityData();
			if (motorFightActivityData == null)
			{
				return;
			}
			motorFightActivityData.UpdateMotorFightTalentDataList(motorFightTalentTreeUpdateNotify.Talent, true);
		}

		// Token: 0x060406B6 RID: 263862 RVA: 0x00F9551C File Offset: 0x00F9371C
		[NullableContext(2)]
		private void OnMotorFightGameOver(IMessage msg, Net.CallbackStatus status)
		{
			MotorFightGameOverNotify motorFightGameOverNotify = (MotorFightGameOverNotify)msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MotorFightActivity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "摩托战斗结算通知";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isWin", motorFightGameOverNotify.Win);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit(EEventName.MotorArrowGameOver);
			if (motorFightGameOverNotify.Win)
			{
				UiManager.Instance.OpenView(EUiViewName.MotorFightSuccessView, motorFightGameOverNotify.Result, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.MotorFightFailView, null, null);
		}

		// Token: 0x060406B7 RID: 263863 RVA: 0x00F955A4 File Offset: 0x00F937A4
		public void RequestUnlockTalentNode(int talentId, Action callback)
		{
			MotorFightTalentUpRequest motorFightTalentUpRequest = MotorFightTalentUpRequest.Create();
			motorFightTalentUpRequest.TalentId = talentId;
			Net.Instance.Call(ERequestMessageId.MotorFightTalentUpRequest, motorFightTalentUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MotorFightTalentUpResponse motorFightTalentUpResponse = (MotorFightTalentUpResponse)msg;
				if (motorFightTalentUpResponse == null)
				{
					return;
				}
				if (motorFightTalentUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(motorFightTalentUpResponse.ErrorCode, 19118, null, true, true);
					return;
				}
				MotorFightActivityData motorFightActivityData = this.GetMotorFightActivityData();
				if (motorFightActivityData != null)
				{
					motorFightActivityData.UpdateMotorFightTalentData(talentId);
				}
				callback();
			}, 0);
		}

		// Token: 0x060406B8 RID: 263864 RVA: 0x00F955FC File Offset: 0x00F937FC
		public void RequestTaskReward(List<int> taskIds)
		{
			MotorFightOneKeyRewardRequest motorFightOneKeyRewardRequest = MotorFightOneKeyRewardRequest.Create();
			motorFightOneKeyRewardRequest.TaskIds.AddRange(taskIds);
			Net.Instance.Call(ERequestMessageId.MotorFightOneKeyRewardRequest, motorFightOneKeyRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MotorFightOneKeyRewardResponse motorFightOneKeyRewardResponse = (MotorFightOneKeyRewardResponse)msg;
				if (motorFightOneKeyRewardResponse == null)
				{
					return;
				}
				if (motorFightOneKeyRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(motorFightOneKeyRewardResponse.ErrorCode, 26998, null, true, true);
					return;
				}
				MotorFightActivityData motorFightActivityData = this.GetMotorFightActivityData();
				if (motorFightActivityData == null)
				{
					return;
				}
				motorFightActivityData.GetTaskReward(taskIds);
			}, 0);
		}

		// Token: 0x060406B9 RID: 263865 RVA: 0x00F95654 File Offset: 0x00F93854
		public UniTask RequestRankDataList()
		{
			MotorFightController.<RequestRankDataList>d__24 <RequestRankDataList>d__;
			<RequestRankDataList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRankDataList>d__.<>4__this = this;
			<RequestRankDataList>d__.<>1__state = -1;
			<RequestRankDataList>d__.<>t__builder.Start<MotorFightController.<RequestRankDataList>d__24>(ref <RequestRankDataList>d__);
			return <RequestRankDataList>d__.<>t__builder.Task;
		}

		// Token: 0x060406BA RID: 263866 RVA: 0x00F95698 File Offset: 0x00F93898
		public UniTask RequestMyRankData()
		{
			MotorFightController.<RequestMyRankData>d__25 <RequestMyRankData>d__;
			<RequestMyRankData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestMyRankData>d__.<>4__this = this;
			<RequestMyRankData>d__.<>1__state = -1;
			<RequestMyRankData>d__.<>t__builder.Start<MotorFightController.<RequestMyRankData>d__25>(ref <RequestMyRankData>d__);
			return <RequestMyRankData>d__.<>t__builder.Task;
		}

		// Token: 0x060406BB RID: 263867 RVA: 0x00F956DC File Offset: 0x00F938DC
		[NullableContext(2)]
		public void RequestSettlement(bool isShowSettleView, Action callback = null)
		{
			MotorFightSettleRequest message = MotorFightSettleRequest.Create();
			Net.Instance.Call(ERequestMessageId.MotorFightSettleRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MotorFightSettleResponse motorFightSettleResponse = (MotorFightSettleResponse)msg;
				if (motorFightSettleResponse == null)
				{
					return;
				}
				if (motorFightSettleResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(motorFightSettleResponse.ErrCode, 28563, null, true, true);
					return;
				}
				Action callback2 = callback;
				if (callback2 != null)
				{
					callback2();
				}
				this.GetMotorFightActivityData().SetLastSavedLevelData(null);
				if (!isShowSettleView)
				{
					return;
				}
				int levelId = motorFightSettleResponse.Result.ResultCommon.LevelId;
				int totalScore = motorFightSettleResponse.Result.ResultCommon.TotalScore;
				MotorFightLevelData levelDataById = this.GetMotorFightActivityData().GetLevelDataById(levelId);
				if (levelDataById != null && levelDataById.Type == EMotorFightLevelType.Endless && totalScore == 0)
				{
					this.LeaveInstanceDungeon();
					return;
				}
				if (motorFightSettleResponse.Win)
				{
					UiManager.Instance.OpenView(EUiViewName.MotorFightSuccessView, motorFightSettleResponse.Result, null);
				}
				else
				{
					UiManager.Instance.OpenView(EUiViewName.MotorFightFailView, null, null);
				}
				EventSystem.Instance.Emit(EEventName.MotorArrowGameOver);
			}, 0);
		}

		// Token: 0x060406BC RID: 263868 RVA: 0x00F95728 File Offset: 0x00F93928
		public UniTask RequestLastSavedLevelData()
		{
			MotorFightController.<RequestLastSavedLevelData>d__27 <RequestLastSavedLevelData>d__;
			<RequestLastSavedLevelData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestLastSavedLevelData>d__.<>4__this = this;
			<RequestLastSavedLevelData>d__.<>1__state = -1;
			<RequestLastSavedLevelData>d__.<>t__builder.Start<MotorFightController.<RequestLastSavedLevelData>d__27>(ref <RequestLastSavedLevelData>d__);
			return <RequestLastSavedLevelData>d__.<>t__builder.Task;
		}

		// Token: 0x060406BD RID: 263869 RVA: 0x00F9576C File Offset: 0x00F9396C
		public void EnterMotorFightDungeonDirectly(int levelId, int roleId, bool isContinue = false)
		{
			this.LastLevelId = levelId;
			this.LastMotorFightRoleId = roleId;
			MotorFightCtx motorFightCtx = MotorFightCtx.Create();
			motorFightCtx.LevelId = levelId;
			motorFightCtx.RoleId = roleId;
			motorFightCtx.Continue = isContinue;
			MotorFightRoleData motorFightRoleData = this.GetMotorFightActivityData().GetMotorFightRoleData(roleId);
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(motorFightRoleData.TrialRoleId, true);
			InstanceDungeonModel.Instance.InstanceEnterContentText.MotorFightCtx = motorFightCtx;
			this.LastRealRoleId = roleDataById.GetDataId();
			InstanceDungeonController.Instance.PrewarTeamFightRequest(0, new List<int>
			{
				this.LastRealRoleId
			}, 0, 0, null, null);
		}

		// Token: 0x060406BE RID: 263870 RVA: 0x00F95800 File Offset: 0x00F93A00
		public void ReChallengeMotorFightDungeon()
		{
			MotorFightCtx motorFightCtx = MotorFightCtx.Create();
			motorFightCtx.LevelId = this.LastLevelId;
			motorFightCtx.RoleId = this.LastMotorFightRoleId;
			motorFightCtx.Continue = false;
			InstanceDungeonModel.Instance.InstanceEnterContentText.MotorFightCtx = motorFightCtx;
			InstanceDungeonController.Instance.PrewarTeamFightRequest(0, new List<int>
			{
				this.LastRealRoleId
			}, 0, 0, null, null);
		}

		// Token: 0x060406BF RID: 263871 RVA: 0x00F95863 File Offset: 0x00F93A63
		private void OnWorldDone()
		{
			if (this.IsNeedShowMotorFightMainView)
			{
				this.AddMainViewSplashTask();
			}
		}

		// Token: 0x060406C0 RID: 263872 RVA: 0x00F95873 File Offset: 0x00F93A73
		public void LeaveInstanceDungeon()
		{
			if (this.MotorFightActivityData != null && !this.MotorFightActivityData.CheckIfClose())
			{
				this.IsNeedShowMotorFightMainView = true;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
		}

		// Token: 0x060406C1 RID: 263873 RVA: 0x00F958A0 File Offset: 0x00F93AA0
		private void AddMainViewSplashTask()
		{
			MotorFightActivityData activityData = this.GetMotorFightActivityData();
			if (activityData == null)
			{
				return;
			}
			SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.MotorFightMainView, activityData, null);
			});
			SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
		}

		// Token: 0x060406C2 RID: 263874 RVA: 0x00F958E8 File Offset: 0x00F93AE8
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (this.MotorFightActivityData == null)
			{
				return;
			}
			if (closeActivities.Contains(this.MotorFightActivityData.Id) && this.CheckInMotorFightDungeon())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MotorFightActivityEnd);
				confirmBoxDataNew.FunctionMap.Add(1, new Action(this.LeaveInstanceDungeon));
				confirmBoxDataNew.FunctionMap.Add(0, new Action(this.LeaveInstanceDungeon));
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
		}

		// Token: 0x060406C3 RID: 263875 RVA: 0x00F95960 File Offset: 0x00F93B60
		public bool CheckInMotorFightDungeon()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				int instanceId = CreatureModel.Instance.GetInstanceId();
				InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
				return config != null && config.GetValueOrDefault().InstSubType == 44;
			}
			return false;
		}

		// Token: 0x1700946F RID: 37999
		// (get) Token: 0x060406C4 RID: 263876 RVA: 0x00F959B0 File Offset: 0x00F93BB0
		public static MotorFightController Instance
		{
			get
			{
				return MotorFightController._Instance;
			}
		}

		// Token: 0x060406C5 RID: 263877 RVA: 0x00F959B7 File Offset: 0x00F93BB7
		public static MotorFightController GetOrCreateInstance()
		{
			if (MotorFightController._Instance == null)
			{
				MotorFightController.CreateInstance();
			}
			return MotorFightController._Instance;
		}

		// Token: 0x060406C6 RID: 263878 RVA: 0x00F959CB File Offset: 0x00F93BCB
		public static bool CreateInstance()
		{
			if (MotorFightController._Instance != null)
			{
				return true;
			}
			MotorFightController._Instance = new MotorFightController();
			return true;
		}

		// Token: 0x060406C7 RID: 263879 RVA: 0x00F959E1 File Offset: 0x00F93BE1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060406C8 RID: 263880 RVA: 0x00F959E3 File Offset: 0x00F93BE3
		public static void ResetStaticDefaultValue()
		{
			MotorFightController._Instance = null;
		}

		// Token: 0x060406C9 RID: 263881 RVA: 0x00F959EB File Offset: 0x00F93BEB
		static MotorFightController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorFightController.CreateStaticDefaultValue), new Action(MotorFightController.ResetStaticDefaultValue));
		}

		// Token: 0x040217EA RID: 137194
		[Nullable(2)]
		private MotorFightActivityData MotorFightActivityData;

		// Token: 0x040217EB RID: 137195
		public bool IsNeedShowMotorFightMainView;

		// Token: 0x040217EC RID: 137196
		private int LastLevelId;

		// Token: 0x040217ED RID: 137197
		private int LastMotorFightRoleId;

		// Token: 0x040217EE RID: 137198
		private int LastRealRoleId;

		// Token: 0x040217EF RID: 137199
		[Nullable(2)]
		private static MotorFightController _Instance;
	}
}
