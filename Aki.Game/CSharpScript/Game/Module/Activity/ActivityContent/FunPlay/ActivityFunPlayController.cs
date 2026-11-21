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
	// Token: 0x020054E9 RID: 21737
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityFunPlayController : ActivityControllerBase
	{
		// Token: 0x06035DD3 RID: 220627 RVA: 0x00F0BDB1 File Offset: 0x00F09FB1
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06035DD4 RID: 220628 RVA: 0x00F0BDB4 File Offset: 0x00F09FB4
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06035DD5 RID: 220629 RVA: 0x00F0BDB6 File Offset: 0x00F09FB6
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityInterestMain";
		}

		// Token: 0x06035DD6 RID: 220630 RVA: 0x00F0BDBD File Offset: 0x00F09FBD
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewFunPlay();
		}

		// Token: 0x06035DD7 RID: 220631 RVA: 0x00F0BDC4 File Offset: 0x00F09FC4
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Data = new ActivityFunPlayData();
			return this.Data;
		}

		// Token: 0x06035DD8 RID: 220632 RVA: 0x00F0BDD7 File Offset: 0x00F09FD7
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.FunPlayChallengeInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFunPlayChallengeInfoUpdateNotify));
		}

		// Token: 0x06035DD9 RID: 220633 RVA: 0x00F0BDF8 File Offset: 0x00F09FF8
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

		// Token: 0x06035DDA RID: 220634 RVA: 0x00F0BE68 File Offset: 0x00F0A068
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FunPlayChallengeInfoUpdateNotify);
		}

		// Token: 0x06035DDB RID: 220635 RVA: 0x00F0BE7C File Offset: 0x00F0A07C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(funPlayChallengeAwardResponse.ErrorCode, 25841, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06035DDC RID: 220636 RVA: 0x00F0BEC8 File Offset: 0x00F0A0C8
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

		// Token: 0x06035DDD RID: 220637 RVA: 0x00F0BF14 File Offset: 0x00F0A114
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

		// Token: 0x06035DDE RID: 220638 RVA: 0x00F0C060 File Offset: 0x00F0A260
		[NullableContext(0)]
		public UniTask<bool> OpenActivityFunPlayView()
		{
			ActivityFunPlayController.<OpenActivityFunPlayView>d__12 <OpenActivityFunPlayView>d__;
			<OpenActivityFunPlayView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenActivityFunPlayView>d__.<>1__state = -1;
			<OpenActivityFunPlayView>d__.<>t__builder.Start<ActivityFunPlayController.<OpenActivityFunPlayView>d__12>(ref <OpenActivityFunPlayView>d__);
			return <OpenActivityFunPlayView>d__.<>t__builder.Task;
		}

		// Token: 0x170068A9 RID: 26793
		// (get) Token: 0x06035DDF RID: 220639 RVA: 0x00F0C09B File Offset: 0x00F0A29B
		public static ActivityFunPlayController Instance
		{
			get
			{
				return ActivityFunPlayController._Instance;
			}
		}

		// Token: 0x06035DE0 RID: 220640 RVA: 0x00F0C0A2 File Offset: 0x00F0A2A2
		public static ActivityFunPlayController GetOrCreateInstance()
		{
			if (ActivityFunPlayController._Instance == null)
			{
				ActivityFunPlayController.CreateInstance();
			}
			return ActivityFunPlayController._Instance;
		}

		// Token: 0x06035DE1 RID: 220641 RVA: 0x00F0C0B6 File Offset: 0x00F0A2B6
		public static bool CreateInstance()
		{
			if (ActivityFunPlayController._Instance != null)
			{
				return true;
			}
			ActivityFunPlayController._Instance = new ActivityFunPlayController();
			return true;
		}

		// Token: 0x06035DE2 RID: 220642 RVA: 0x00F0C0CC File Offset: 0x00F0A2CC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035DE3 RID: 220643 RVA: 0x00F0C0CE File Offset: 0x00F0A2CE
		public static void ResetStaticDefaultValue()
		{
			ActivityFunPlayController._Instance = null;
		}

		// Token: 0x06035DE4 RID: 220644 RVA: 0x00F0C0D6 File Offset: 0x00F0A2D6
		static ActivityFunPlayController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityFunPlayController.CreateStaticDefaultValue), new Action(ActivityFunPlayController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C7C0 RID: 116672
		[Nullable(2)]
		public ActivityFunPlayData Data;

		// Token: 0x0401C7C1 RID: 116673
		[Nullable(2)]
		private static ActivityFunPlayController _Instance;
	}
}
