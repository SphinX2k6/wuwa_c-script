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
	// Token: 0x02005384 RID: 21380
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MotorFightController : ActivityControllerBase
	{
		// Token: 0x06035367 RID: 217959 RVA: 0x00EDC0DC File Offset: 0x00EDA2DC
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MotorFightLevelUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateMotorFightLevel));
			Net.Instance.Register(ENotifyMessageId.MotorFightItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateMotorFightItem));
			Net.Instance.Register(ENotifyMessageId.MotorFightRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateMotorFightRole));
			Net.Instance.Register(ENotifyMessageId.MotorFightTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateMotorFightTask));
			Net.Instance.Register(ENotifyMessageId.MotorFightTalentTreeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.UpdateMotorFightTalentTree));
			Net.Instance.Register(ENotifyMessageId.MotorFightGameOverNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorFightGameOver));
		}

		// Token: 0x06035368 RID: 217960 RVA: 0x00EDC194 File Offset: 0x00EDA394
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightLevelUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightItemUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightRoleUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightTalentTreeUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorFightGameOverNotify);
		}

		// Token: 0x06035369 RID: 217961 RVA: 0x00EDC201 File Offset: 0x00EDA401
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603536A RID: 217962 RVA: 0x00EDC23B File Offset: 0x00EDA43B
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603536B RID: 217963 RVA: 0x00EDC275 File Offset: 0x00EDA475
		protected override void OnOpenView(ActivityBaseData data)
		{
			throw new Exception("Method not implemented.");
		}

		// Token: 0x0603536C RID: 217964 RVA: 0x00EDC281 File Offset: 0x00EDA481
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_MotorcycleBattleMain";
		}

		// Token: 0x0603536D RID: 217965 RVA: 0x00EDC288 File Offset: 0x00EDA488
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new MotorFightActivitySubView();
		}

		// Token: 0x0603536E RID: 217966 RVA: 0x00EDC290 File Offset: 0x00EDA490
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			MotorFightActivityData motorFightActivityData = new MotorFightActivityData();
			this.MotorFightActivityData = motorFightActivityData;
			return motorFightActivityData;
		}

		// Token: 0x0603536F RID: 217967 RVA: 0x00EDC2AC File Offset: 0x00EDA4AC
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

		// Token: 0x06035370 RID: 217968 RVA: 0x00EDC358 File Offset: 0x00EDA558
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

		// Token: 0x06035371 RID: 217969 RVA: 0x00EDC394 File Offset: 0x00EDA594
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

		// Token: 0x06035372 RID: 217970 RVA: 0x00EDC3E0 File Offset: 0x00EDA5E0
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

		// Token: 0x06035373 RID: 217971 RVA: 0x00EDC40C File Offset: 0x00EDA60C
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

		// Token: 0x06035374 RID: 217972 RVA: 0x00EDC438 File Offset: 0x00EDA638
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

		// Token: 0x06035375 RID: 217973 RVA: 0x00EDC464 File Offset: 0x00EDA664
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

		// Token: 0x06035376 RID: 217974 RVA: 0x00EDC490 File Offset: 0x00EDA690
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

		// Token: 0x06035377 RID: 217975 RVA: 0x00EDC4BC File Offset: 0x00EDA6BC
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

		// Token: 0x06035378 RID: 217976 RVA: 0x00EDC544 File Offset: 0x00EDA744
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(motorFightTalentUpResponse.ErrorCode, 24183, null, true, true);
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

		// Token: 0x06035379 RID: 217977 RVA: 0x00EDC59C File Offset: 0x00EDA79C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(motorFightOneKeyRewardResponse.ErrorCode, 18713, null, true, true);
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

		// Token: 0x0603537A RID: 217978 RVA: 0x00EDC5F4 File Offset: 0x00EDA7F4
		public UniTask RequestRankDataList()
		{
			MotorFightController.<RequestRankDataList>d__24 <RequestRankDataList>d__;
			<RequestRankDataList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRankDataList>d__.<>4__this = this;
			<RequestRankDataList>d__.<>1__state = -1;
			<RequestRankDataList>d__.<>t__builder.Start<MotorFightController.<RequestRankDataList>d__24>(ref <RequestRankDataList>d__);
			return <RequestRankDataList>d__.<>t__builder.Task;
		}

		// Token: 0x0603537B RID: 217979 RVA: 0x00EDC638 File Offset: 0x00EDA838
		public UniTask RequestMyRankData()
		{
			MotorFightController.<RequestMyRankData>d__25 <RequestMyRankData>d__;
			<RequestMyRankData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestMyRankData>d__.<>4__this = this;
			<RequestMyRankData>d__.<>1__state = -1;
			<RequestMyRankData>d__.<>t__builder.Start<MotorFightController.<RequestMyRankData>d__25>(ref <RequestMyRankData>d__);
			return <RequestMyRankData>d__.<>t__builder.Task;
		}

		// Token: 0x0603537C RID: 217980 RVA: 0x00EDC67C File Offset: 0x00EDA87C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(motorFightSettleResponse.ErrCode, 19184, null, true, true);
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

		// Token: 0x0603537D RID: 217981 RVA: 0x00EDC6C8 File Offset: 0x00EDA8C8
		public UniTask RequestLastSavedLevelData()
		{
			MotorFightController.<RequestLastSavedLevelData>d__27 <RequestLastSavedLevelData>d__;
			<RequestLastSavedLevelData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestLastSavedLevelData>d__.<>4__this = this;
			<RequestLastSavedLevelData>d__.<>1__state = -1;
			<RequestLastSavedLevelData>d__.<>t__builder.Start<MotorFightController.<RequestLastSavedLevelData>d__27>(ref <RequestLastSavedLevelData>d__);
			return <RequestLastSavedLevelData>d__.<>t__builder.Task;
		}

		// Token: 0x0603537E RID: 217982 RVA: 0x00EDC70C File Offset: 0x00EDA90C
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

		// Token: 0x0603537F RID: 217983 RVA: 0x00EDC7A0 File Offset: 0x00EDA9A0
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

		// Token: 0x06035380 RID: 217984 RVA: 0x00EDC803 File Offset: 0x00EDAA03
		private void OnWorldDone()
		{
			if (this.IsNeedShowMotorFightMainView)
			{
				this.AddMainViewSplashTask();
			}
		}

		// Token: 0x06035381 RID: 217985 RVA: 0x00EDC813 File Offset: 0x00EDAA13
		public void LeaveInstanceDungeon()
		{
			if (this.MotorFightActivityData != null && !this.MotorFightActivityData.CheckIfClose())
			{
				this.IsNeedShowMotorFightMainView = true;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
		}

		// Token: 0x06035382 RID: 217986 RVA: 0x00EDC840 File Offset: 0x00EDAA40
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

		// Token: 0x06035383 RID: 217987 RVA: 0x00EDC888 File Offset: 0x00EDAA88
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

		// Token: 0x06035384 RID: 217988 RVA: 0x00EDC900 File Offset: 0x00EDAB00
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

		// Token: 0x170067D1 RID: 26577
		// (get) Token: 0x06035385 RID: 217989 RVA: 0x00EDC950 File Offset: 0x00EDAB50
		public static MotorFightController Instance
		{
			get
			{
				return MotorFightController._Instance;
			}
		}

		// Token: 0x06035386 RID: 217990 RVA: 0x00EDC957 File Offset: 0x00EDAB57
		public static MotorFightController GetOrCreateInstance()
		{
			if (MotorFightController._Instance == null)
			{
				MotorFightController.CreateInstance();
			}
			return MotorFightController._Instance;
		}

		// Token: 0x06035387 RID: 217991 RVA: 0x00EDC96B File Offset: 0x00EDAB6B
		public static bool CreateInstance()
		{
			if (MotorFightController._Instance != null)
			{
				return true;
			}
			MotorFightController._Instance = new MotorFightController();
			return true;
		}

		// Token: 0x06035388 RID: 217992 RVA: 0x00EDC981 File Offset: 0x00EDAB81
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035389 RID: 217993 RVA: 0x00EDC983 File Offset: 0x00EDAB83
		public static void ResetStaticDefaultValue()
		{
			MotorFightController._Instance = null;
		}

		// Token: 0x0603538A RID: 217994 RVA: 0x00EDC98B File Offset: 0x00EDAB8B
		static MotorFightController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorFightController.CreateStaticDefaultValue), new Action(MotorFightController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C119 RID: 114969
		[Nullable(2)]
		private MotorFightActivityData MotorFightActivityData;

		// Token: 0x0401C11A RID: 114970
		public bool IsNeedShowMotorFightMainView;

		// Token: 0x0401C11B RID: 114971
		private int LastLevelId;

		// Token: 0x0401C11C RID: 114972
		private int LastMotorFightRoleId;

		// Token: 0x0401C11D RID: 114973
		private int LastRealRoleId;

		// Token: 0x0401C11E RID: 114974
		[Nullable(2)]
		private static MotorFightController _Instance;
	}
}
