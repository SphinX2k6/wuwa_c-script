using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.CombatMessage;
using CSharpScript.Core.Common;
using CSharpScript.Launcher.ThinkDataReport;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004549 RID: 17737
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CombatDebugController : ControllerBase
	{
		// Token: 0x0602DD6D RID: 187757 RVA: 0x00A89BE8 File Offset: 0x00A87DE8
		[NullableContext(2)]
		public void CombatInfoMessage(CombatLog.EDebugModule flag, EMessageId messageName, CombatCommon combatCommon = null)
		{
			if (!CombatLog.Instance.DebugCombatInfo.Contains(flag))
			{
				return;
			}
			bool flag2;
			if (!this.LogMessageWhiteMap.TryGetValue(messageName, out flag2) || !flag2)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (combatCommon != null)
			{
				long value = MathUtils.Instance.LongToBigInt(combatCommon.EntityId);
				long value2 = MathUtils.Instance.LongToNumber(combatCommon.Originator);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 4);
				defaultInterpolatedStringHandler.AppendLiteral("[Message][");
				defaultInterpolatedStringHandler.AppendFormatted<CombatLog.EDebugModule>(flag);
				defaultInterpolatedStringHandler.AppendLiteral("][");
				defaultInterpolatedStringHandler.AppendFormatted<EMessageId>(messageName);
				defaultInterpolatedStringHandler.AppendLiteral("][EntityId:");
				defaultInterpolatedStringHandler.AppendFormatted<long>(value);
				defaultInterpolatedStringHandler.AppendLiteral("][PlayerId:");
				defaultInterpolatedStringHandler.AppendFormatted<long>(value2);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				string message = defaultInterpolatedStringHandler.ToStringAndClear();
				Log.Instance.Info(ELogModule.CombatInfo, ELogAuthor.WCL, message, default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[Message][");
			defaultInterpolatedStringHandler.AppendFormatted<CombatLog.EDebugModule>(flag);
			defaultInterpolatedStringHandler.AppendLiteral("][");
			defaultInterpolatedStringHandler.AppendFormatted<EMessageId>(messageName);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			string message2 = defaultInterpolatedStringHandler.ToStringAndClear();
			Log.Instance.Info(ELogModule.CombatInfo, ELogAuthor.WCL, message2, default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602DD6E RID: 187758 RVA: 0x00A89D34 File Offset: 0x00A87F34
		[NullableContext(2)]
		public void CombatContextInfoMessage(CombatLog.EDebugModule flag, EMessageId messageName, CombatRequestData requestData = null)
		{
			if (!CombatLog.Instance.DebugCombatInfo.Contains(CombatLog.EDebugModule.Message))
			{
				return;
			}
			bool flag2;
			if (!this.LogMessageWhiteMap.TryGetValue(messageName, out flag2) || !flag2)
			{
				return;
			}
			CombatCommon combatCommon = (requestData != null) ? requestData.CombatCommon : null;
			if (combatCommon != null)
			{
				long value = MathUtils.Instance.LongToBigInt(combatCommon.EntityId);
				long value2 = MathUtils.Instance.LongToNumber(combatCommon.Originator);
				long value3 = MathUtils.Instance.LongToBigInt(combatCommon.MessageId);
				long value4 = MathUtils.Instance.LongToBigInt(combatCommon.PreMessageId);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 6);
				defaultInterpolatedStringHandler.AppendLiteral("[Message][");
				defaultInterpolatedStringHandler.AppendFormatted<CombatLog.EDebugModule>(flag);
				defaultInterpolatedStringHandler.AppendLiteral("][");
				defaultInterpolatedStringHandler.AppendFormatted<EMessageId>(messageName);
				defaultInterpolatedStringHandler.AppendLiteral("][EntityId:");
				defaultInterpolatedStringHandler.AppendFormatted<long>(value);
				defaultInterpolatedStringHandler.AppendLiteral("][PlayerId:");
				defaultInterpolatedStringHandler.AppendFormatted<long>(value2);
				defaultInterpolatedStringHandler.AppendLiteral("][MessageId:");
				defaultInterpolatedStringHandler.AppendFormatted<long>(value3);
				defaultInterpolatedStringHandler.AppendLiteral("][PreMessageId:");
				defaultInterpolatedStringHandler.AppendFormatted<long>(value4);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				string message = defaultInterpolatedStringHandler.ToStringAndClear();
				Log.Instance.Info(ELogModule.CombatInfo, ELogAuthor.YJX, message, default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x0602DD6F RID: 187759 RVA: 0x00A89E78 File Offset: 0x00A88078
		public void DataReport(string eventName, string data)
		{
			if (!Info.Instance.IsBuildDevelopmentOrDebug)
			{
				return;
			}
			ThinkDataLaunchReporter.Instance.Report(eventName, data);
		}

		// Token: 0x0602DD70 RID: 187760 RVA: 0x00A89E93 File Offset: 0x00A88093
		public string FilterCmd(string script)
		{
			this.ScriptHelper.Init();
			return this.ScriptHelper.FilterCmd(script);
		}

		// Token: 0x0602DD71 RID: 187761 RVA: 0x00A89EAC File Offset: 0x00A880AC
		private void RefreshPlayerServerDebugInfo()
		{
			if (this.DebugEntityId == 0)
			{
				return;
			}
			Entity entity = EntitySystem.Instance.Get(this.DebugEntityId);
			RoleBuffComponent roleBuffComponent = (entity != null) ? entity.GetComponent<RoleBuffComponent>() : null;
			if (roleBuffComponent == null)
			{
				return;
			}
			PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
			CharacterGasDebugComponent characterGasDebugComponent = (formationBuffComp != null) ? formationBuffComp.Entity.GetComponent<CharacterGasDebugComponent>() : null;
			if (characterGasDebugComponent == null)
			{
				return;
			}
			characterGasDebugComponent.ServerDebugInfoRequest();
		}

		// Token: 0x0602DD72 RID: 187762 RVA: 0x00A89F04 File Offset: 0x00A88104
		public void RefreshServerDebugInfo()
		{
			if (this.DebugEntityId == 0)
			{
				return;
			}
			Entity entity = EntitySystem.Instance.Get(this.DebugEntityId);
			CharacterGasDebugComponent characterGasDebugComponent = (entity != null) ? entity.GetComponent<CharacterGasDebugComponent>() : null;
			if (characterGasDebugComponent == null || Time.Instance.Now - this.RequestTimeStamp < 300.0)
			{
				return;
			}
			this.RequestTimeStamp = Time.Instance.Now;
			if (characterGasDebugComponent != null)
			{
				characterGasDebugComponent.ServerDebugInfoRequest();
			}
			this.RefreshPlayerServerDebugInfo();
		}

		// Token: 0x17007550 RID: 30032
		// (get) Token: 0x0602DD73 RID: 187763 RVA: 0x00A89F76 File Offset: 0x00A88176
		public static CombatDebugController Instance
		{
			get
			{
				return CombatDebugController._Instance;
			}
		}

		// Token: 0x0602DD74 RID: 187764 RVA: 0x00A89F7D File Offset: 0x00A8817D
		public static CombatDebugController GetOrCreateInstance()
		{
			if (CombatDebugController._Instance == null)
			{
				CombatDebugController.CreateInstance();
			}
			return CombatDebugController._Instance;
		}

		// Token: 0x0602DD75 RID: 187765 RVA: 0x00A89F91 File Offset: 0x00A88191
		public static bool CreateInstance()
		{
			if (CombatDebugController._Instance != null)
			{
				return true;
			}
			CombatDebugController._Instance = new CombatDebugController();
			return true;
		}

		// Token: 0x0602DD76 RID: 187766 RVA: 0x00A89FA7 File Offset: 0x00A881A7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DD77 RID: 187767 RVA: 0x00A89FA9 File Offset: 0x00A881A9
		public static void ResetStaticDefaultValue()
		{
			CombatDebugController._Instance = null;
		}

		// Token: 0x0602DD78 RID: 187768 RVA: 0x00A89FB1 File Offset: 0x00A881B1
		static CombatDebugController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CombatDebugController.CreateStaticDefaultValue), new Action(CombatDebugController.ResetStaticDefaultValue));
		}

		// Token: 0x0602DD79 RID: 187769 RVA: 0x00A89FD0 File Offset: 0x00A881D0
		public CombatDebugController()
		{
			Dictionary<EMessageId, bool> dictionary = new Dictionary<EMessageId, bool>();
			dictionary[EMessageId.HitRequest] = true;
			dictionary[EMessageId.HitEndRequest] = true;
			dictionary[EMessageId.SkillRequest] = true;
			dictionary[EMessageId.UseSkillRequest] = true;
			dictionary[EMessageId.EndSkillRequest] = true;
			dictionary[EMessageId.SwitchCharacterStateRequest] = true;
			dictionary[EMessageId.LogicStateInitRequest] = true;
			dictionary[EMessageId.MaterialRequest] = true;
			dictionary[EMessageId.EntityIsVisibleRequest] = true;
			dictionary[EMessageId.AiInformationRequest] = true;
			dictionary[EMessageId.PartUpdateRequest] = true;
			dictionary[EMessageId.HitNotify] = true;
			dictionary[EMessageId.SkillNotify] = true;
			dictionary[EMessageId.UseSkillNotify] = true;
			dictionary[EMessageId.EndSkillNotify] = true;
			dictionary[EMessageId.EntityLoadCompleteNotify] = true;
			dictionary[EMessageId.SwitchCharacterStateNotify] = true;
			dictionary[EMessageId.SwitchLogicStateNotify] = true;
			dictionary[EMessageId.MaterialNotify] = true;
			dictionary[EMessageId.EntityIsVisibleNotify] = true;
			dictionary[EMessageId.AiInformationNotify] = true;
			dictionary[EMessageId.PartUpdateNotify] = true;
			dictionary[EMessageId.AnimationStateInitNotify] = true;
			dictionary[EMessageId.AnimationStateChangedPush] = true;
			dictionary[EMessageId.LogicStateInitNotify] = true;
			dictionary[EMessageId.ApplyGameplayEffectRequest] = true;
			dictionary[EMessageId.OrderApplyBuffRequest] = true;
			dictionary[EMessageId.OrderRemoveBuffRequest] = true;
			dictionary[EMessageId.RemoveGameplayEffectRequest] = true;
			dictionary[EMessageId.OrderApplyBuffNotify] = true;
			this.LogMessageWhiteMap = dictionary;
			this.AttributeNameCache = new Dictionary<EAttributeType, string>();
			base..ctor();
		}

		// Token: 0x0401879A RID: 100250
		public int DebugEntityId;

		// Token: 0x0401879B RID: 100251
		public const int REFRESH_SERVER_INFO_PERIOD = 300;

		// Token: 0x0401879C RID: 100252
		public readonly CombatScriptHelper ScriptHelper = new CombatScriptHelper();

		// Token: 0x0401879D RID: 100253
		private readonly Dictionary<EMessageId, bool> LogMessageWhiteMap;

		// Token: 0x0401879E RID: 100254
		private double RequestTimeStamp;

		// Token: 0x0401879F RID: 100255
		private readonly Dictionary<EAttributeType, string> AttributeNameCache;

		// Token: 0x040187A0 RID: 100256
		[Nullable(2)]
		private static CombatDebugController _Instance;
	}
}
