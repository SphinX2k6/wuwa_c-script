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
	// Token: 0x02004C11 RID: 19473
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class FlagChallengeBattleController : ControllerBase
	{
		// Token: 0x06030925 RID: 198949 RVA: 0x00D89D6C File Offset: 0x00D87F6C
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

		// Token: 0x06030926 RID: 198950 RVA: 0x00D89E24 File Offset: 0x00D88024
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

		// Token: 0x06030927 RID: 198951 RVA: 0x00D89EAA File Offset: 0x00D880AA
		protected override bool OnLeaveLevel()
		{
			FlagChallengeBattleModel.Instance.OnLeaveInstance();
			return true;
		}

		// Token: 0x06030928 RID: 198952 RVA: 0x00D89EB8 File Offset: 0x00D880B8
		public UniTask LeaveFlagChallengeInstance()
		{
			FlagChallengeBattleController.<LeaveFlagChallengeInstance>d__3 <LeaveFlagChallengeInstance>d__;
			<LeaveFlagChallengeInstance>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LeaveFlagChallengeInstance>d__.<>1__state = -1;
			<LeaveFlagChallengeInstance>d__.<>t__builder.Start<FlagChallengeBattleController.<LeaveFlagChallengeInstance>d__3>(ref <LeaveFlagChallengeInstance>d__);
			return <LeaveFlagChallengeInstance>d__.<>t__builder.Task;
		}

		// Token: 0x06030929 RID: 198953 RVA: 0x00D89EF4 File Offset: 0x00D880F4
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

		// Token: 0x0603092A RID: 198954 RVA: 0x00D89F74 File Offset: 0x00D88174
		private void OnInstNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			FlagChallengeInstNotify flagChallengeInstNotify = (FlagChallengeInstNotify)msg;
			int challengeLevelId = flagChallengeInstNotify.ChallengeLevelId;
			int activityId = FlagChallengeConfig.Instance.GetLevelConfig(challengeLevelId).Value.ActivityId;
			FlagChallengeBattleModel.Instance.HandleInstNotify(flagChallengeInstNotify);
		}

		// Token: 0x0603092B RID: 198955 RVA: 0x00D89FB8 File Offset: 0x00D881B8
		private void OnSettleNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			int challengeLevelId = ((FlagChallengeSettleNotify)msg).ChallengeLevelId;
			FlagChallengeBattleModel.Instance.HandleSettleNotify(challengeLevelId);
			this.OpenSettleView();
		}

		// Token: 0x0603092C RID: 198956 RVA: 0x00D89FE4 File Offset: 0x00D881E4
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

		// Token: 0x0603092D RID: 198957 RVA: 0x00D8A047 File Offset: 0x00D88247
		private void OnStrongholdOccupied(int strongholdId)
		{
			if (!FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return;
			}
			this.OpenOccupiedSuccessView(strongholdId);
		}

		// Token: 0x0603092E RID: 198958 RVA: 0x00D8A060 File Offset: 0x00D88260
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

		// Token: 0x0603092F RID: 198959 RVA: 0x00D8A0A9 File Offset: 0x00D882A9
		public void OpenOccupiedSuccessView(int strongholdId)
		{
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeOccupiedSuccessView, new FlagChallengeOccupiedSuccessViewParams
			{
				ActivityId = FlagChallengeBattleModel.Instance.ActivityId,
				StrongholdId = strongholdId
			}, null);
		}

		// Token: 0x06030930 RID: 198960 RVA: 0x00D8A0D7 File Offset: 0x00D882D7
		public void OpenSettleView()
		{
			UiManager.Instance.OpenView(EUiViewName.FlagChallengeSettleView, null, null);
		}

		// Token: 0x06030931 RID: 198961 RVA: 0x00D8A0EA File Offset: 0x00D882EA
		public void OpenPauseView()
		{
			UiManager.Instance.OpenView(EUiViewName.FlagChallengePauseView, null, null);
		}

		// Token: 0x1700617D RID: 24957
		// (get) Token: 0x06030932 RID: 198962 RVA: 0x00D8A0FD File Offset: 0x00D882FD
		[Nullable(1)]
		public static FlagChallengeBattleController Instance
		{
			[NullableContext(1)]
			get
			{
				return FlagChallengeBattleController._Instance;
			}
		}

		// Token: 0x06030933 RID: 198963 RVA: 0x00D8A104 File Offset: 0x00D88304
		[NullableContext(1)]
		public static FlagChallengeBattleController GetOrCreateInstance()
		{
			if (FlagChallengeBattleController._Instance == null)
			{
				FlagChallengeBattleController.CreateInstance();
			}
			return FlagChallengeBattleController._Instance;
		}

		// Token: 0x06030934 RID: 198964 RVA: 0x00D8A118 File Offset: 0x00D88318
		public static bool CreateInstance()
		{
			if (FlagChallengeBattleController._Instance != null)
			{
				return true;
			}
			FlagChallengeBattleController._Instance = new FlagChallengeBattleController();
			return true;
		}

		// Token: 0x06030935 RID: 198965 RVA: 0x00D8A12E File Offset: 0x00D8832E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030936 RID: 198966 RVA: 0x00D8A130 File Offset: 0x00D88330
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeBattleController._Instance = null;
		}

		// Token: 0x06030937 RID: 198967 RVA: 0x00D8A138 File Offset: 0x00D88338
		static FlagChallengeBattleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeBattleController.CreateStaticDefaultValue), new Action(FlagChallengeBattleController.ResetStaticDefaultValue));
		}

		// Token: 0x04019B45 RID: 105285
		private static FlagChallengeBattleController _Instance;
	}
}
