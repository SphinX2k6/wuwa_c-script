using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.CombatMessage;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02003471 RID: 13425
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CombatDebugController : ControllerBase
	{
		// Token: 0x0602244F RID: 140367 RVA: 0x009B531C File Offset: 0x009B351C
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

		// Token: 0x06022450 RID: 140368 RVA: 0x009B5468 File Offset: 0x009B3668
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

		// Token: 0x06022451 RID: 140369 RVA: 0x009B55AC File Offset: 0x009B37AC
		public void DataReport(string eventName, string data)
		{
		}

		// Token: 0x06022452 RID: 140370 RVA: 0x009B55AE File Offset: 0x009B37AE
		public string FilterCmd(string script)
		{
			this.ScriptHelper.Init();
			return this.ScriptHelper.FilterCmd(script);
		}

		// Token: 0x06022453 RID: 140371 RVA: 0x009B55C8 File Offset: 0x009B37C8
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

		// Token: 0x06022454 RID: 140372 RVA: 0x009B5620 File Offset: 0x009B3820
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

		// Token: 0x17004807 RID: 18439
		// (get) Token: 0x06022455 RID: 140373 RVA: 0x009B5692 File Offset: 0x009B3892
		public static CombatDebugController Instance
		{
			get
			{
				return CombatDebugController._Instance;
			}
		}

		// Token: 0x06022456 RID: 140374 RVA: 0x009B5699 File Offset: 0x009B3899
		public static CombatDebugController GetOrCreateInstance()
		{
			if (CombatDebugController._Instance == null)
			{
				CombatDebugController.CreateInstance();
			}
			return CombatDebugController._Instance;
		}

		// Token: 0x06022457 RID: 140375 RVA: 0x009B56AD File Offset: 0x009B38AD
		public static bool CreateInstance()
		{
			if (CombatDebugController._Instance != null)
			{
				return true;
			}
			CombatDebugController._Instance = new CombatDebugController();
			return true;
		}

		// Token: 0x06022458 RID: 140376 RVA: 0x009B56C3 File Offset: 0x009B38C3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022459 RID: 140377 RVA: 0x009B56C5 File Offset: 0x009B38C5
		public static void ResetStaticDefaultValue()
		{
			CombatDebugController._Instance = null;
		}

		// Token: 0x0602245A RID: 140378 RVA: 0x009B56CD File Offset: 0x009B38CD
		static CombatDebugController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CombatDebugController.CreateStaticDefaultValue), new Action(CombatDebugController.ResetStaticDefaultValue));
		}

		// Token: 0x0602245B RID: 140379 RVA: 0x009B56EC File Offset: 0x009B38EC
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

		// Token: 0x04012DD4 RID: 77268
		public int DebugEntityId;

		// Token: 0x04012DD5 RID: 77269
		public const int REFRESH_SERVER_INFO_PERIOD = 300;

		// Token: 0x04012DD6 RID: 77270
		public readonly CombatScriptHelper ScriptHelper = new CombatScriptHelper();

		// Token: 0x04012DD7 RID: 77271
		private readonly Dictionary<EMessageId, bool> LogMessageWhiteMap;

		// Token: 0x04012DD8 RID: 77272
		private double RequestTimeStamp;

		// Token: 0x04012DD9 RID: 77273
		private readonly Dictionary<EAttributeType, string> AttributeNameCache;

		// Token: 0x04012DDA RID: 77274
		[Nullable(2)]
		private static CombatDebugController _Instance;
	}
}
