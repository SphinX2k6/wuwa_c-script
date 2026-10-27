using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x0200656B RID: 25963
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityFunPlayController : ActivityControllerBase
	{
		// Token: 0x0604110E RID: 266510 RVA: 0x00FC4DCD File Offset: 0x00FC2FCD
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0604110F RID: 266511 RVA: 0x00FC4DD0 File Offset: 0x00FC2FD0
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06041110 RID: 266512 RVA: 0x00FC4DD2 File Offset: 0x00FC2FD2
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityInterestMain";
		}

		// Token: 0x06041111 RID: 266513 RVA: 0x00FC4DD9 File Offset: 0x00FC2FD9
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewFunPlay();
		}

		// Token: 0x06041112 RID: 266514 RVA: 0x00FC4DE0 File Offset: 0x00FC2FE0
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Data = new ActivityFunPlayData();
			return this.Data;
		}

		// Token: 0x06041113 RID: 266515 RVA: 0x00FC4DF3 File Offset: 0x00FC2FF3
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.FunPlayChallengeInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFunPlayChallengeInfoUpdateNotify));
		}

		// Token: 0x06041114 RID: 266516 RVA: 0x00FC4E14 File Offset: 0x00FC3014
		[NullableContext(2)]
		private void OnFunPlayChallengeInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			foreach (FunPlayChallengeInfo data in ((FunPlayChallengeInfoUpdateNotify)msg).FunPlayChallengeInfos)
			{
				ActivityFunPlayModel instance = ActivityFunPlayModel.Instance;
				if (instance != null)
				{
					instance.UpdateChallengeData(data);
				}
			}
			EventSystem.Instance.Emit(EEventName.ActivityFunPlayInfoRefresh);
		}

		// Token: 0x06041115 RID: 266517 RVA: 0x00FC4E84 File Offset: 0x00FC3084
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FunPlayChallengeInfoUpdateNotify);
		}

		// Token: 0x06041116 RID: 266518 RVA: 0x00FC4E98 File Offset: 0x00FC3098
		public void ChallengeAwardRequest(int challengeId)
		{
			FunPlayChallengeAwardRequest funPlayChallengeAwardRequest = FunPlayChallengeAwardRequest.Create();
			funPlayChallengeAwardRequest.ChallengeId = challengeId;
			Net.Instance.Call(ERequestMessageId.FunPlayChallengeAwardRequest, funPlayChallengeAwardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FunPlayChallengeAwardResponse funPlayChallengeAwardResponse = (FunPlayChallengeAwardResponse)msg;
				if (funPlayChallengeAwardResponse == null)
				{
					Log.Instance.Error(ELogModule.ActivityFunPlay, ELogAuthor.CB, "领取奖励回包为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				if (funPlayChallengeAwardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(funPlayChallengeAwardResponse.ErrorCode, 24156, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06041117 RID: 266519 RVA: 0x00FC4EE4 File Offset: 0x00FC30E4
		public UniTask RequestEnterChallengeAsync(int challengeId)
		{
			ActivityFunPlayController.<RequestEnterChallengeAsync>d__10 <RequestEnterChallengeAsync>d__;
			<RequestEnterChallengeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestEnterChallengeAsync>d__.<>4__this = this;
			<RequestEnterChallengeAsync>d__.challengeId = challengeId;
			<RequestEnterChallengeAsync>d__.<>1__state = -1;
			<RequestEnterChallengeAsync>d__.<>t__builder.Start<ActivityFunPlayController.<RequestEnterChallengeAsync>d__10>(ref <RequestEnterChallengeAsync>d__);
			return <RequestEnterChallengeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041118 RID: 266520 RVA: 0x00FC4F30 File Offset: 0x00FC3130
		private List<int> GetEnterChallengeRoleIds(int instId)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instId);
			if (config == null)
			{
				FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
				return ((currentFormationData != null) ? currentFormationData.RoleIdList : null) ?? new List<int>();
			}
			int trialRoleFormation = config.Value.TrialRoleFormation;
			if (trialRoleFormation != 0)
			{
				InstanceTrialRoleConfig? trialRoleConfig = InstanceDungeonConfig.Instance.GetTrialRoleConfig(trialRoleFormation);
				if (trialRoleConfig != null)
				{
					bool flag = trialRoleConfig.Value.MaleFormationLength > 0 && trialRoleConfig.Value.FemaleFormationLength > 0;
					if (trialRoleConfig.Value.OnlyTrial && flag)
					{
						return new List<int>();
					}
				}
			}
			Aki.Config.FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(config.Value.FightFormationId);
			int[] array = (fightFormationConfig != null) ? fightFormationConfig.GetValueOrDefault().AutoRole() : null;
			if (array != null && array.Length != 0)
			{
				List<int> list = new List<int>();
				foreach (int id in array)
				{
					list.Add(RoleConfig.Instance.GetTrialRoleIdConfigByGroupId(id));
				}
				return list;
			}
			FormationData currentFormationData2 = FormationModel.Instance.CurrentFormationData;
			return ((currentFormationData2 != null) ? currentFormationData2.RoleIdList : null) ?? new List<int>();
		}

		// Token: 0x06041119 RID: 266521 RVA: 0x00FC507C File Offset: 0x00FC327C
		[NullableContext(0)]
		public UniTask<bool> OpenActivityFunPlayView()
		{
			ActivityFunPlayController.<OpenActivityFunPlayView>d__12 <OpenActivityFunPlayView>d__;
			<OpenActivityFunPlayView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenActivityFunPlayView>d__.<>1__state = -1;
			<OpenActivityFunPlayView>d__.<>t__builder.Start<ActivityFunPlayController.<OpenActivityFunPlayView>d__12>(ref <OpenActivityFunPlayView>d__);
			return <OpenActivityFunPlayView>d__.<>t__builder.Task;
		}

		// Token: 0x17009547 RID: 38215
		// (get) Token: 0x0604111A RID: 266522 RVA: 0x00FC50B7 File Offset: 0x00FC32B7
		public static ActivityFunPlayController Instance
		{
			get
			{
				return ActivityFunPlayController._Instance;
			}
		}

		// Token: 0x0604111B RID: 266523 RVA: 0x00FC50BE File Offset: 0x00FC32BE
		public static ActivityFunPlayController GetOrCreateInstance()
		{
			if (ActivityFunPlayController._Instance == null)
			{
				ActivityFunPlayController.CreateInstance();
			}
			return ActivityFunPlayController._Instance;
		}

		// Token: 0x0604111C RID: 266524 RVA: 0x00FC50D2 File Offset: 0x00FC32D2
		public static bool CreateInstance()
		{
			if (ActivityFunPlayController._Instance != null)
			{
				return true;
			}
			ActivityFunPlayController._Instance = new ActivityFunPlayController();
			return true;
		}

		// Token: 0x0604111D RID: 266525 RVA: 0x00FC50E8 File Offset: 0x00FC32E8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604111E RID: 266526 RVA: 0x00FC50EA File Offset: 0x00FC32EA
		public static void ResetStaticDefaultValue()
		{
			ActivityFunPlayController._Instance = null;
		}

		// Token: 0x0604111F RID: 266527 RVA: 0x00FC50F2 File Offset: 0x00FC32F2
		static ActivityFunPlayController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityFunPlayController.CreateStaticDefaultValue), new Action(ActivityFunPlayController.ResetStaticDefaultValue));
		}

		// Token: 0x04021E8F RID: 138895
		[Nullable(2)]
		public ActivityFunPlayData Data;

		// Token: 0x04021E90 RID: 138896
		[Nullable(2)]
		private static ActivityFunPlayController _Instance;
	}
}
