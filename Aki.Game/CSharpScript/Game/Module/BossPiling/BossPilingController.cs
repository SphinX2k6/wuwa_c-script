using System;
using System.Collections.Generic;
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
	// Token: 0x02004BDA RID: 19418
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BossPilingController : ActivityControllerBase
	{
		// Token: 0x0603076F RID: 198511 RVA: 0x00D81D11 File Offset: 0x00D7FF11
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06030770 RID: 198512 RVA: 0x00D81D13 File Offset: 0x00D7FF13
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_BossPilingActivityMain";
		}

		// Token: 0x06030771 RID: 198513 RVA: 0x00D81D1C File Offset: 0x00D7FF1C
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			BossPilingController.<OnOpenSubView>d__7 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<BossPilingController.<OnOpenSubView>d__7>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x06030772 RID: 198514 RVA: 0x00D81D57 File Offset: 0x00D7FF57
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new BossPilingSubView();
		}

		// Token: 0x06030773 RID: 198515 RVA: 0x00D81D5E File Offset: 0x00D7FF5E
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new BossPilingActivityData();
		}

		// Token: 0x06030774 RID: 198516 RVA: 0x00D81D71 File Offset: 0x00D7FF71
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06030775 RID: 198517 RVA: 0x00D81D74 File Offset: 0x00D7FF74
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

		// Token: 0x06030776 RID: 198518 RVA: 0x00D81DA0 File Offset: 0x00D7FFA0
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.BossPilingLevelInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossPilingLevelInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.BossPilingInstNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossPilingInstNotify));
			Net.Instance.Register(ENotifyMessageId.BossPilingBuffUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossPilingBuffUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.BossPilingSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossPilingSettleNotify));
			Net.Instance.Register(ENotifyMessageId.BossPilingTaskInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossPilingTaskNotify));
		}

		// Token: 0x06030777 RID: 198519 RVA: 0x00D81E3C File Offset: 0x00D8003C
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.BossPilingLevelInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BossPilingInstNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BossPilingBuffUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BossPilingSettleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BossPilingTaskInfoUpdateNotify);
		}

		// Token: 0x06030778 RID: 198520 RVA: 0x00D81E9C File Offset: 0x00D8009C
		[NullableContext(2)]
		private void OnBossPilingLevelInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			BossPilingLevelInfoUpdateNotify bossPilingLevelInfoUpdateNotify = (BossPilingLevelInfoUpdateNotify)msg;
			BossPilingModel.Instance.GetActivityData().UpdateLevelData(bossPilingLevelInfoUpdateNotify.BossPilingLevelInfo);
		}

		// Token: 0x06030779 RID: 198521 RVA: 0x00D81EC8 File Offset: 0x00D800C8
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
			BossPilingModel.Instance.GetActivityData().InitDungeon(bossPilingInstNotify.BossPilingLevelId, new Dictionary<int, int>(bossPilingInstNotify.BossPilingBuffs));
		}

		// Token: 0x0603077A RID: 198522 RVA: 0x00D81F80 File Offset: 0x00D80180
		[NullableContext(2)]
		private void OnBossPilingBuffUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			BossPilingBuffUpdateNotify bossPilingBuffUpdateNotify = (BossPilingBuffUpdateNotify)msg;
			this.RefreshBuffView(new Dictionary<int, int>(bossPilingBuffUpdateNotify.BossPilingBuffs));
			BossPilingModel.Instance.GetActivityData().UpdateDungeonBuff(new Dictionary<int, int>(bossPilingBuffUpdateNotify.BossPilingBuffs));
		}

		// Token: 0x0603077B RID: 198523 RVA: 0x00D81FC0 File Offset: 0x00D801C0
		[NullableContext(2)]
		private void OnBossPilingSettleNotify(IMessage msg, Net.CallbackStatus _)
		{
			BossPilingSettleNotify param = (BossPilingSettleNotify)msg;
			UiManager.Instance.OpenView(EUiViewName.BossPilingSettleView, param, null);
		}

		// Token: 0x0603077C RID: 198524 RVA: 0x00D81FE8 File Offset: 0x00D801E8
		[NullableContext(2)]
		private void OnBossPilingTaskNotify(IMessage msg, Net.CallbackStatus _)
		{
			BossPilingTaskInfoUpdateNotify bossPilingTaskInfoUpdateNotify = (BossPilingTaskInfoUpdateNotify)msg;
			BossPilingModel.Instance.GetActivityData().UpdateTaskData(bossPilingTaskInfoUpdateNotify.ConditionTasks);
			EventSystem.Instance.Emit(EEventName.OnBossPilingReward);
		}

		// Token: 0x0603077D RID: 198525 RVA: 0x00D82024 File Offset: 0x00D80224
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

		// Token: 0x0603077E RID: 198526 RVA: 0x00D820D4 File Offset: 0x00D802D4
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

		// Token: 0x0603077F RID: 198527 RVA: 0x00D82118 File Offset: 0x00D80318
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

		// Token: 0x06030780 RID: 198528 RVA: 0x00D8221C File Offset: 0x00D8041C
		[NullableContext(0)]
		public UniTask<bool> RequestBossPilingSettle()
		{
			BossPilingController.<RequestBossPilingSettle>d__22 <RequestBossPilingSettle>d__;
			<RequestBossPilingSettle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestBossPilingSettle>d__.<>1__state = -1;
			<RequestBossPilingSettle>d__.<>t__builder.Start<BossPilingController.<RequestBossPilingSettle>d__22>(ref <RequestBossPilingSettle>d__);
			return <RequestBossPilingSettle>d__.<>t__builder.Task;
		}

		// Token: 0x06030781 RID: 198529 RVA: 0x00D82258 File Offset: 0x00D80458
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
				InstanceDungeonController.Instance.SingleInstReChallengeRequest(false);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x17006142 RID: 24898
		// (get) Token: 0x06030782 RID: 198530 RVA: 0x00D8234C File Offset: 0x00D8054C
		public static BossPilingController Instance
		{
			get
			{
				return BossPilingController._Instance;
			}
		}

		// Token: 0x06030783 RID: 198531 RVA: 0x00D82353 File Offset: 0x00D80553
		public static BossPilingController GetOrCreateInstance()
		{
			if (BossPilingController._Instance == null)
			{
				BossPilingController.CreateInstance();
			}
			return BossPilingController._Instance;
		}

		// Token: 0x06030784 RID: 198532 RVA: 0x00D82367 File Offset: 0x00D80567
		public static bool CreateInstance()
		{
			if (BossPilingController._Instance != null)
			{
				return true;
			}
			BossPilingController._Instance = new BossPilingController();
			return true;
		}

		// Token: 0x06030785 RID: 198533 RVA: 0x00D8237D File Offset: 0x00D8057D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030786 RID: 198534 RVA: 0x00D8237F File Offset: 0x00D8057F
		public static void ResetStaticDefaultValue()
		{
			BossPilingController._Instance = null;
		}

		// Token: 0x06030787 RID: 198535 RVA: 0x00D82387 File Offset: 0x00D80587
		static BossPilingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BossPilingController.CreateStaticDefaultValue), new Action(BossPilingController.ResetStaticDefaultValue));
		}

		// Token: 0x04019AA3 RID: 105123
		public int ActivityId;

		// Token: 0x04019AA4 RID: 105124
		public int CacheLevelId;

		// Token: 0x04019AA5 RID: 105125
		[Nullable(2)]
		public Dictionary<int, int> CacheBuffMap;

		// Token: 0x04019AA6 RID: 105126
		public List<int> CurTeamRole = new List<int>();

		// Token: 0x04019AA7 RID: 105127
		public List<int> CurTeamTag = new List<int>();

		// Token: 0x04019AA8 RID: 105128
		[Nullable(2)]
		private static BossPilingController _Instance;
	}
}
