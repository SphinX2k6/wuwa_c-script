using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C31 RID: 23601
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class FlagChallengeBattleController : ControllerBase
	{
		// Token: 0x0603B9DA RID: 244186 RVA: 0x00E399FC File Offset: 0x00E37BFC
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.FlagChallengeTempRoleLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTempRoleLevelNotify));
			Net.Instance.Register(ENotifyMessageId.FlagChallengeInstNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInstNotify));
			Net.Instance.Register(ENotifyMessageId.FlagChallengeSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSettleNotify));
			Net.Instance.Register(ENotifyMessageId.FlagChallengeBoxExpNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBoxExpNotify));
			EventSystem.Instance.Add(EEventName.OnFlagChallengeStrongholdOccupied, new Action<int>(this.OnStrongholdOccupied));
			EventSystem.Instance.Add(EEventName.OnFlagChallengeFixedRoleLevelUpdate, new Action<int, int, int>(this.OnFixedRoleLevelUpdate));
			return true;
		}

		// Token: 0x0603B9DB RID: 244187 RVA: 0x00E39AB4 File Offset: 0x00E37CB4
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengeTempRoleLevelNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengeInstNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengeSettleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlagChallengeBoxExpNotify);
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeStrongholdOccupied, new Action<int>(this.OnStrongholdOccupied));
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeFixedRoleLevelUpdate, new Action<int, int, int>(this.OnFixedRoleLevelUpdate));
			return true;
		}

		// Token: 0x0603B9DC RID: 244188 RVA: 0x00E39B3A File Offset: 0x00E37D3A
		protected override bool OnLeaveLevel()
		{
			FlagChallengeBattleModel.Instance.OnLeaveInstance();
			return true;
		}

		// Token: 0x0603B9DD RID: 244189 RVA: 0x00E39B48 File Offset: 0x00E37D48
		public UniTask LeaveFlagChallengeInstance()
		{
			FlagChallengeBattleController.<LeaveFlagChallengeInstance>d__3 <LeaveFlagChallengeInstance>d__;
			<LeaveFlagChallengeInstance>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LeaveFlagChallengeInstance>d__.<>1__state = -1;
			<LeaveFlagChallengeInstance>d__.<>t__builder.Start<FlagChallengeBattleController.<LeaveFlagChallengeInstance>d__3>(ref <LeaveFlagChallengeInstance>d__);
			return <LeaveFlagChallengeInstance>d__.<>t__builder.Task;
		}

		// Token: 0x0603B9DE RID: 244190 RVA: 0x00E39B84 File Offset: 0x00E37D84
		private void OnTempRoleLevelNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			FlagChallengeTempRoleLevelNotify flagChallengeTempRoleLevelNotify = (FlagChallengeTempRoleLevelNotify)msg;
			int challengeLevelId = flagChallengeTempRoleLevelNotify.ChallengeLevelId;
			Aki.Protocol.FlagChallengeRoleLevelInfo flagChallengeRoleLevelInfo = flagChallengeTempRoleLevelNotify.FlagChallengeRoleLevelInfo;
			FlagChallengeBattleModel instance = FlagChallengeBattleModel.Instance;
			if (challengeLevelId != instance.LevelId || flagChallengeRoleLevelInfo == null)
			{
				return;
			}
			instance.UpdateRoleTempLevelData(flagChallengeRoleLevelInfo.PerLevel, flagChallengeRoleLevelInfo.PerExp);
			int preTempLevel = instance.GetPreTempLevel();
			int tempLevel = instance.GetTempLevel();
			if (tempLevel != preTempLevel)
			{
				int calculatedLevel = instance.GetCalculatedLevel();
				FlagChallengeModel.Instance.GetFlagChallengeData(instance.ActivityId).CheckBuffStatusChange(calculatedLevel + preTempLevel, calculatedLevel + tempLevel);
			}
		}

		// Token: 0x0603B9DF RID: 244191 RVA: 0x00E39C04 File Offset: 0x00E37E04
		private void OnInstNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			FlagChallengeInstNotify flagChallengeInstNotify = (FlagChallengeInstNotify)msg;
			int challengeLevelId = flagChallengeInstNotify.ChallengeLevelId;
			int activityId = FlagChallengeConfig.Instance.GetLevelConfig(challengeLevelId).Value.ActivityId;
			FlagChallengeBattleModel.Instance.HandleInstNotify(flagChallengeInstNotify);
		}

		// Token: 0x0603B9E0 RID: 244192 RVA: 0x00E39C48 File Offset: 0x00E37E48
		private void OnSettleNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			int challengeLevelId = ((FlagChallengeSettleNotify)msg).ChallengeLevelId;
			FlagChallengeBattleModel.Instance.HandleSettleNotify(challengeLevelId);
			this.OpenSettleView();
		}

		// Token: 0x0603B9E1 RID: 244193 RVA: 0x00E39C74 File Offset: 0x00E37E74
		private void OnBoxExpNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			FlagChallengeBoxExpNotify flagChallengeBoxExpNotify = (FlagChallengeBoxExpNotify)msg;
			int challengeLevelId = flagChallengeBoxExpNotify.ChallengeLevelId;
			FlagChallengeBattleModel instance = FlagChallengeBattleModel.Instance;
			if (challengeLevelId != instance.LevelId)
			{
				return;
			}
			int boxExp = flagChallengeBoxExpNotify.BoxExp;
			instance.UpdateBoxExp(boxExp);
			int preTotalLevel = instance.GetPreTotalLevel();
			int totalLevel = instance.GetTotalLevel();
			if (totalLevel != preTotalLevel)
			{
				FlagChallengeModel.Instance.GetFlagChallengeData(instance.ActivityId).CheckBuffStatusChange(preTotalLevel, totalLevel);
			}
		}

		// Token: 0x0603B9E2 RID: 244194 RVA: 0x00E39CD7 File Offset: 0x00E37ED7
		private void OnStrongholdOccupied(int strongholdId)
		{
			if (!FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return;
			}
			this.OpenOccupiedSuccessView(strongholdId);
		}

		// Token: 0x0603B9E3 RID: 244195 RVA: 0x00E39CF0 File Offset: 0x00E37EF0
		private void OnFixedRoleLevelUpdate(int activityId, int level, int exp)
		{
			FlagChallengeBattleModel instance = FlagChallengeBattleModel.Instance;
			if (activityId != instance.ActivityId)
			{
				return;
			}
			instance.UpdateRoleLevelData(level, exp);
			int preTotalLevel = instance.GetPreTotalLevel();
			int totalLevel = instance.GetTotalLevel();
			if (totalLevel != preTotalLevel)
			{
				FlagChallengeModel.Instance.GetFlagChallengeData(activityId).CheckBuffStatusChange(preTotalLevel, totalLevel);
			}
		}

		// Token: 0x0603B9E4 RID: 244196 RVA: 0x00E39D39 File Offset: 0x00E37F39
		public void OpenOccupiedSuccessView(int strongholdId)
		{
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeOccupiedSuccessView, new FlagChallengeOccupiedSuccessViewParams
			{
				ActivityId = FlagChallengeBattleModel.Instance.ActivityId,
				StrongholdId = strongholdId
			}, null);
		}

		// Token: 0x0603B9E5 RID: 244197 RVA: 0x00E39D67 File Offset: 0x00E37F67
		public void OpenSettleView()
		{
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeSettleView, null, null);
		}

		// Token: 0x0603B9E6 RID: 244198 RVA: 0x00E39D7A File Offset: 0x00E37F7A
		public void OpenPauseView()
		{
			UiManager.Instance.OpenView(EUiViewName.FlagChallengePauseView, null, null);
		}

		// Token: 0x17008DAB RID: 36267
		// (get) Token: 0x0603B9E7 RID: 244199 RVA: 0x00E39D8D File Offset: 0x00E37F8D
		[Nullable(1)]
		public static FlagChallengeBattleController Instance
		{
			[NullableContext(1)]
			get
			{
				return FlagChallengeBattleController._Instance;
			}
		}

		// Token: 0x0603B9E8 RID: 244200 RVA: 0x00E39D94 File Offset: 0x00E37F94
		[NullableContext(1)]
		public static FlagChallengeBattleController GetOrCreateInstance()
		{
			if (FlagChallengeBattleController._Instance == null)
			{
				FlagChallengeBattleController.CreateInstance();
			}
			return FlagChallengeBattleController._Instance;
		}

		// Token: 0x0603B9E9 RID: 244201 RVA: 0x00E39DA8 File Offset: 0x00E37FA8
		public static bool CreateInstance()
		{
			if (FlagChallengeBattleController._Instance != null)
			{
				return true;
			}
			FlagChallengeBattleController._Instance = new FlagChallengeBattleController();
			return true;
		}

		// Token: 0x0603B9EA RID: 244202 RVA: 0x00E39DBE File Offset: 0x00E37FBE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B9EB RID: 244203 RVA: 0x00E39DC0 File Offset: 0x00E37FC0
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeBattleController._Instance = null;
		}

		// Token: 0x0603B9EC RID: 244204 RVA: 0x00E39DC8 File Offset: 0x00E37FC8
		static FlagChallengeBattleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeBattleController.CreateStaticDefaultValue), new Action(FlagChallengeBattleController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F094 RID: 127124
		private static FlagChallengeBattleController _Instance;
	}
}
