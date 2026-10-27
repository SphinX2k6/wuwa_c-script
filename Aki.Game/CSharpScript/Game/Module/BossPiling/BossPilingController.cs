using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BossPiling.View;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005BFA RID: 23546
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BossPilingController : ActivityControllerBase
	{
		// Token: 0x0603B824 RID: 243748 RVA: 0x00E319C9 File Offset: 0x00E2FBC9
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603B825 RID: 243749 RVA: 0x00E319CB File Offset: 0x00E2FBCB
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_BossPilingActivityMain";
		}

		// Token: 0x0603B826 RID: 243750 RVA: 0x00E319D4 File Offset: 0x00E2FBD4
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			BossPilingController.<OnOpenSubView>d__7 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<BossPilingController.<OnOpenSubView>d__7>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x0603B827 RID: 243751 RVA: 0x00E31A0F File Offset: 0x00E2FC0F
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new BossPilingSubView();
		}

		// Token: 0x0603B828 RID: 243752 RVA: 0x00E31A16 File Offset: 0x00E2FC16
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new BossPilingActivityData();
		}

		// Token: 0x0603B829 RID: 243753 RVA: 0x00E31A29 File Offset: 0x00E2FC29
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603B82A RID: 243754 RVA: 0x00E31A2C File Offset: 0x00E2FC2C
		[NullableContext(2)]
		public BossPilingActivityData GetActivityData()
		{
			BossPilingActivityData bossPilingActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as BossPilingActivityData;
			if (bossPilingActivityData == null)
			{
				return null;
			}
			return bossPilingActivityData;
		}

		// Token: 0x0603B82B RID: 243755 RVA: 0x00E31A58 File Offset: 0x00E2FC58
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.BossPilingLevelInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossPilingLevelInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.BossPilingInstNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossPilingInstNotify));
			Net.Instance.Register(ENotifyMessageId.BossPilingBuffUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossPilingBuffUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.BossPilingSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossPilingSettleNotify));
			Net.Instance.Register(ENotifyMessageId.BossPilingTaskInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossPilingTaskNotify));
		}

		// Token: 0x0603B82C RID: 243756 RVA: 0x00E31AF4 File Offset: 0x00E2FCF4
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.BossPilingLevelInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BossPilingInstNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BossPilingBuffUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BossPilingSettleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BossPilingTaskInfoUpdateNotify);
		}

		// Token: 0x0603B82D RID: 243757 RVA: 0x00E31B54 File Offset: 0x00E2FD54
		[NullableContext(2)]
		private void OnBossPilingLevelInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			BossPilingLevelInfoUpdateNotify bossPilingLevelInfoUpdateNotify = (BossPilingLevelInfoUpdateNotify)msg;
			BossPilingModel.Instance.GetActivityData().UpdateLevelData(bossPilingLevelInfoUpdateNotify.BossPilingLevelInfo.ToArray<BossPilingLevelInfo>());
		}

		// Token: 0x0603B82E RID: 243758 RVA: 0x00E31B84 File Offset: 0x00E2FD84
		[NullableContext(2)]
		private void OnBossPilingInstNotify(IMessage msg, Net.CallbackStatus _)
		{
			BossPilingInstNotify bossPilingInstNotify = (BossPilingInstNotify)msg;
			if (this.GetActivityData() == null)
			{
				this.CacheLevelId = bossPilingInstNotify.BossPilingLevelId;
				this.CacheBuffMap = new Dictionary<int, int>();
				foreach (int key in bossPilingInstNotify.BossPilingBuffs.Keys)
				{
					int value = bossPilingInstNotify.BossPilingBuffs[key];
					this.CacheBuffMap[key] = value;
				}
				return;
			}
			BossPilingModel.Instance.InstBuffAcquireCount = 0;
			BossPilingModel.Instance.GetActivityData().InitDungeon(bossPilingInstNotify.BossPilingLevelId, bossPilingInstNotify.BossPilingBuffs.ToDictionary<int, int>());
		}

		// Token: 0x0603B82F RID: 243759 RVA: 0x00E31C3C File Offset: 0x00E2FE3C
		[NullableContext(2)]
		private void OnBossPilingBuffUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			BossPilingBuffUpdateNotify bossPilingBuffUpdateNotify = (BossPilingBuffUpdateNotify)msg;
			this.RefreshBuffView(bossPilingBuffUpdateNotify.BossPilingBuffs.ToDictionary<int, int>());
			BossPilingModel.Instance.GetActivityData().UpdateDungeonBuff(bossPilingBuffUpdateNotify.BossPilingBuffs.ToDictionary<int, int>());
		}

		// Token: 0x0603B830 RID: 243760 RVA: 0x00E31C7C File Offset: 0x00E2FE7C
		[NullableContext(2)]
		private void OnBossPilingSettleNotify(IMessage msg, Net.CallbackStatus _)
		{
			BossPilingSettleNotify param = (BossPilingSettleNotify)msg;
			UiManager.Instance.OpenView(EUiViewName.BossPilingSettleView, param, null);
		}

		// Token: 0x0603B831 RID: 243761 RVA: 0x00E31CA4 File Offset: 0x00E2FEA4
		[NullableContext(2)]
		private void OnBossPilingTaskNotify(IMessage msg, Net.CallbackStatus _)
		{
			BossPilingTaskInfoUpdateNotify bossPilingTaskInfoUpdateNotify = (BossPilingTaskInfoUpdateNotify)msg;
			BossPilingModel.Instance.GetActivityData().UpdateTaskData(bossPilingTaskInfoUpdateNotify.ConditionTasks.ToArray<ConditionTask>());
			EventSystem.Instance.Emit(EEventName.OnBossPilingReward);
		}

		// Token: 0x0603B832 RID: 243762 RVA: 0x00E31CE4 File Offset: 0x00E2FEE4
		private void RefreshBuffView(Dictionary<int, int> buffInfo)
		{
			foreach (int num in buffInfo.Keys)
			{
				if (BossPilingConfig.Instance.GetBuffInfo(num).Value.Quality == 5)
				{
					BossPilingModel.Instance.InstKeyBuffList.Add(num);
				}
			}
			if (BossPilingModel.Instance.InstKeyBuffList.Count > 0 && !UiManager.Instance.IsViewOpen(EUiViewName.BossPilingKeyBuffFloatView))
			{
				UiManager.Instance.OpenView(EUiViewName.BossPilingKeyBuffFloatView, null, null);
			}
		}

		// Token: 0x0603B833 RID: 243763 RVA: 0x00E31D94 File Offset: 0x00E2FF94
		[NullableContext(0)]
		public UniTask<bool> RequestBossPilingReward(int levelId)
		{
			BossPilingController.<RequestBossPilingReward>d__20 <RequestBossPilingReward>d__;
			<RequestBossPilingReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestBossPilingReward>d__.levelId = levelId;
			<RequestBossPilingReward>d__.<>1__state = -1;
			<RequestBossPilingReward>d__.<>t__builder.Start<BossPilingController.<RequestBossPilingReward>d__20>(ref <RequestBossPilingReward>d__);
			return <RequestBossPilingReward>d__.<>t__builder.Task;
		}

		// Token: 0x0603B834 RID: 243764 RVA: 0x00E31DD8 File Offset: 0x00E2FFD8
		public void RequestChallenge(int levelId, List<int> teamList, List<int> tagList, bool isBoss = false)
		{
			BossPilingLevels value2 = BossPilingConfig.Instance.GetLevelInfo(levelId).Value;
			int instanceId = isBoss ? value2.InstIds()[1] : value2.InstIds()[0];
			BossPilingModel.Instance.GetActivityData().ClearDungeonInfo();
			BossPilingCtx bossPilingCtx = BossPilingCtx.Create();
			bossPilingCtx.BossPilingLevelId = levelId;
			List<int> list = new List<int>();
			for (int i = 0; i < tagList.Count; i++)
			{
				int num = tagList[i];
				if (num != 0 || teamList[i] != 0)
				{
					list.Add(num);
				}
			}
			bossPilingCtx.SkillBranchId.AddRange(list);
			InstanceDungeonModel.Instance.InstanceEnterContentText.BossPilingCtx = bossPilingCtx;
			InstanceDungeonController.Instance.PrewarTeamFightRequest(instanceId, teamList, 0, 0, null, null).ContinueWith(delegate(bool value)
			{
				if (value)
				{
					this.CurTeamRole = teamList;
					this.CurTeamTag = tagList;
				}
			});
		}

		// Token: 0x0603B835 RID: 243765 RVA: 0x00E31EDC File Offset: 0x00E300DC
		[NullableContext(0)]
		public UniTask<bool> RequestBossPilingSettle()
		{
			BossPilingController.<RequestBossPilingSettle>d__22 <RequestBossPilingSettle>d__;
			<RequestBossPilingSettle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestBossPilingSettle>d__.<>1__state = -1;
			<RequestBossPilingSettle>d__.<>t__builder.Start<BossPilingController.<RequestBossPilingSettle>d__22>(ref <RequestBossPilingSettle>d__);
			return <RequestBossPilingSettle>d__.<>t__builder.Task;
		}

		// Token: 0x0603B836 RID: 243766 RVA: 0x00E31F18 File Offset: 0x00E30118
		public void OpenPauseView()
		{
			InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			if (instanceDungeon == null || !BossPilingModel.Instance.CheckIsBossPiling())
			{
				return;
			}
			ValueTuple<int, bool> levelIdAndHalfByInstId = BossPilingModel.Instance.GetLevelIdAndHalfByInstId(instanceDungeon.Value.Id);
			bool isFirst = levelIdAndHalfByInstId.Item2;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BossPilingExitConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(isFirst ? "BossPilingActivity_DungeonQuit05" : "BossPilingActivity_DungeonQuit06");
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				configTextByKey
			});
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				if (isFirst)
				{
					UiManager.Instance.OpenView(EUiViewName.BossPilingMainView, null, null);
					return;
				}
				this.RequestBossPilingSettle();
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				InstanceDungeonController.Instance.SingleInstReChallengeRequest();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x17008D70 RID: 36208
		// (get) Token: 0x0603B837 RID: 243767 RVA: 0x00E3200C File Offset: 0x00E3020C
		public static BossPilingController Instance
		{
			get
			{
				return BossPilingController._Instance;
			}
		}

		// Token: 0x0603B838 RID: 243768 RVA: 0x00E32013 File Offset: 0x00E30213
		public static BossPilingController GetOrCreateInstance()
		{
			if (BossPilingController._Instance == null)
			{
				BossPilingController.CreateInstance();
			}
			return BossPilingController._Instance;
		}

		// Token: 0x0603B839 RID: 243769 RVA: 0x00E32027 File Offset: 0x00E30227
		public static bool CreateInstance()
		{
			if (BossPilingController._Instance != null)
			{
				return true;
			}
			BossPilingController._Instance = new BossPilingController();
			return true;
		}

		// Token: 0x0603B83A RID: 243770 RVA: 0x00E3203D File Offset: 0x00E3023D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B83B RID: 243771 RVA: 0x00E3203F File Offset: 0x00E3023F
		public static void ResetStaticDefaultValue()
		{
			BossPilingController._Instance = null;
		}

		// Token: 0x0603B83C RID: 243772 RVA: 0x00E32047 File Offset: 0x00E30247
		static BossPilingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BossPilingController.CreateStaticDefaultValue), new Action(BossPilingController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EFF2 RID: 126962
		public int ActivityId;

		// Token: 0x0401EFF3 RID: 126963
		public int CacheLevelId;

		// Token: 0x0401EFF4 RID: 126964
		[Nullable(2)]
		public Dictionary<int, int> CacheBuffMap;

		// Token: 0x0401EFF5 RID: 126965
		public List<int> CurTeamRole = new List<int>();

		// Token: 0x0401EFF6 RID: 126966
		public List<int> CurTeamTag = new List<int>();

		// Token: 0x0401EFF7 RID: 126967
		[Nullable(2)]
		private static BossPilingController _Instance;
	}
}
