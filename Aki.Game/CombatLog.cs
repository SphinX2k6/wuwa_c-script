using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02002A25 RID: 10789
[NullableContext(1)]
[Nullable(0)]
public class CombatLog : Singleton
{
	// Token: 0x0601B313 RID: 111379 RVA: 0x008594F0 File Offset: 0x008576F0
	private void GetEntityLogInfo([Nullable(2)] Entity entity, out long entityId, out string entityTypeName, out string actorName)
	{
		entityId = 0L;
		entityTypeName = string.Empty;
		actorName = string.Empty;
		if (entity == null)
		{
			return;
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component != null)
		{
			entityId = component.GetCreatureDataId();
			entityTypeName = (Enum.GetName<EEntityType>(component.GetEntityType()) ?? string.Empty);
		}
		CharacterActorComponent component2 = entity.GetComponent<CharacterActorComponent>();
		if (component2 != null)
		{
			TsBaseCharacter actor = component2.Actor;
			if (((actor != null) ? new bool?(actor.IsValid()) : null).GetValueOrDefault())
			{
				actorName = component2.Actor.GetName();
			}
		}
	}

	// Token: 0x0601B314 RID: 111380 RVA: 0x00859580 File Offset: 0x00857780
	private void LogInternal(int logType, CombatLog.EDebugModule flag, long entityId, string entityTypeName, string actorName, string message, [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs, [Nullable(2)] Exception stack = null)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 5);
		defaultInterpolatedStringHandler.AppendLiteral("[");
		defaultInterpolatedStringHandler.AppendFormatted<CombatLog.EDebugModule>(flag);
		defaultInterpolatedStringHandler.AppendLiteral("][EntityId:");
		defaultInterpolatedStringHandler.AppendFormatted<long>(entityId);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(entityTypeName);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(actorName);
		defaultInterpolatedStringHandler.AppendLiteral("] ");
		defaultInterpolatedStringHandler.AppendFormatted(message);
		string message2 = defaultInterpolatedStringHandler.ToStringAndClear();
		switch (logType)
		{
		case 0:
			Log.Instance.Info(ELogModule.CombatInfo, ELogAuthor.WCL, message2, pairs);
			return;
		case 1:
			break;
		case 2:
			Log.Instance.Warn(ELogModule.CombatInfo, ELogAuthor.WCL, message2, pairs);
			return;
		case 3:
			if (stack != null)
			{
				Log.Instance.ErrorWithStack(ELogModule.CombatInfo, ELogAuthor.WCL, message2, stack, pairs);
				return;
			}
			Log.Instance.Error(ELogModule.CombatInfo, ELogAuthor.WCL, message2, pairs);
			break;
		default:
			return;
		}
	}

	// Token: 0x0601B315 RID: 111381 RVA: 0x00859678 File Offset: 0x00857878
	public void Info(CombatLog.EDebugModule flag, [Nullable(2)] Entity entity, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		long entityId;
		string entityTypeName;
		string actorName;
		this.GetEntityLogInfo(entity, out entityId, out entityTypeName, out actorName);
		this.LogInternal(0, flag, entityId, entityTypeName, actorName, message, pairs, null);
	}

	// Token: 0x0601B316 RID: 111382 RVA: 0x008596A4 File Offset: 0x008578A4
	public void Info(CombatLog.EDebugModule flag, long entityId, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.LogInternal(0, flag, entityId, string.Empty, string.Empty, message, pairs, null);
	}

	// Token: 0x0601B317 RID: 111383 RVA: 0x008596C8 File Offset: 0x008578C8
	[Conditional("DEBUG")]
	public void Debug(CombatLog.EDebugModule flag, [Nullable(2)] Entity entity, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x0601B318 RID: 111384 RVA: 0x008596CA File Offset: 0x008578CA
	[Conditional("DEBUG")]
	public void Debug(CombatLog.EDebugModule flag, long entityId, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x0601B319 RID: 111385 RVA: 0x008596CC File Offset: 0x008578CC
	[Conditional("DEBUG")]
	public void DebugEx(CombatLog.EDebugModule flag, [Nullable(2)] Entity entity, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x0601B31A RID: 111386 RVA: 0x008596CE File Offset: 0x008578CE
	[Conditional("DEBUG")]
	public void DebugEx(CombatLog.EDebugModule flag, long entityId, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x0601B31B RID: 111387 RVA: 0x008596D0 File Offset: 0x008578D0
	public void Warn(CombatLog.EDebugModule flag, [Nullable(2)] Entity entity, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		long entityId;
		string entityTypeName;
		string actorName;
		this.GetEntityLogInfo(entity, out entityId, out entityTypeName, out actorName);
		this.LogInternal(2, flag, entityId, entityTypeName, actorName, message, pairs, null);
	}

	// Token: 0x0601B31C RID: 111388 RVA: 0x008596FC File Offset: 0x008578FC
	public void Warn(CombatLog.EDebugModule flag, long entityId, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.LogInternal(2, flag, entityId, string.Empty, string.Empty, message, pairs, null);
	}

	// Token: 0x0601B31D RID: 111389 RVA: 0x00859720 File Offset: 0x00857920
	public unsafe void Error(CombatLog.EDebugModule flag, [Nullable(2)] Entity entity, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		long entityId;
		string entityTypeName;
		string actorName;
		this.GetEntityLogInfo(entity, out entityId, out entityTypeName, out actorName);
		StringBuilder sb = CombatLog.Sb;
		sb.Clear();
		sb.Append(message);
		ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = pairs;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			ValueTuple<string, object> valueTuple = *readOnlySpan[i];
			string item = valueTuple.Item1;
			object item2 = valueTuple.Item2;
			StringBuilder stringBuilder = sb;
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(3, 2, stringBuilder);
			appendInterpolatedStringHandler.AppendLiteral("[");
			appendInterpolatedStringHandler.AppendFormatted(item);
			appendInterpolatedStringHandler.AppendLiteral(":");
			appendInterpolatedStringHandler.AppendFormatted((item2 != null) ? item2.ToString() : "null");
			appendInterpolatedStringHandler.AppendLiteral("]");
			stringBuilder2.Append(ref appendInterpolatedStringHandler);
		}
		sb.ToString();
		this.LogInternal(3, flag, entityId, entityTypeName, actorName, message, pairs, null);
	}

	// Token: 0x0601B31E RID: 111390 RVA: 0x00859800 File Offset: 0x00857A00
	public unsafe void Error(CombatLog.EDebugModule flag, long entityId, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		StringBuilder sb = CombatLog.Sb;
		sb.Clear();
		sb.Append(message);
		ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = pairs;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			ValueTuple<string, object> valueTuple = *readOnlySpan[i];
			string item = valueTuple.Item1;
			object item2 = valueTuple.Item2;
			StringBuilder stringBuilder = sb;
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(3, 2, stringBuilder);
			appendInterpolatedStringHandler.AppendLiteral("[");
			appendInterpolatedStringHandler.AppendFormatted(item);
			appendInterpolatedStringHandler.AppendLiteral(":");
			appendInterpolatedStringHandler.AppendFormatted((item2 != null) ? item2.ToString() : "null");
			appendInterpolatedStringHandler.AppendLiteral("]");
			stringBuilder2.Append(ref appendInterpolatedStringHandler);
		}
		this.LogInternal(3, flag, entityId, string.Empty, string.Empty, message, pairs, null);
	}

	// Token: 0x0601B31F RID: 111391 RVA: 0x008598C9 File Offset: 0x00857AC9
	[Conditional("DEBUG")]
	private void PrintOnScreen(string message, FLinearColor color)
	{
	}

	// Token: 0x0601B320 RID: 111392 RVA: 0x008598CC File Offset: 0x00857ACC
	public void ErrorWithStack(CombatLog.EDebugModule flag, [Nullable(2)] Entity entity, string message, Exception e, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		long entityId;
		string entityTypeName;
		string actorName;
		this.GetEntityLogInfo(entity, out entityId, out entityTypeName, out actorName);
		this.LogInternal(3, flag, entityId, entityTypeName, actorName, message, pairs, e);
	}

	// Token: 0x0601B321 RID: 111393 RVA: 0x008598F8 File Offset: 0x00857AF8
	public void ErrorWithStack(CombatLog.EDebugModule flag, long entityId, string message, Exception e, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.LogInternal(3, flag, entityId, string.Empty, string.Empty, message, pairs, e);
	}

	// Token: 0x17002C55 RID: 11349
	// (get) Token: 0x0601B322 RID: 111394 RVA: 0x0085991D File Offset: 0x00857B1D
	public static CombatLog Instance
	{
		get
		{
			if (CombatLog._instance == null)
			{
				CombatLog._instance = new CombatLog();
				CombatLog._instance.OnInit();
			}
			return CombatLog._instance;
		}
	}

	// Token: 0x0601B323 RID: 111395 RVA: 0x00859940 File Offset: 0x00857B40
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B324 RID: 111396 RVA: 0x00859942 File Offset: 0x00857B42
	public static void ResetStaticDefaultValue()
	{
		CombatLog instance = CombatLog._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CombatLog._instance = null;
	}

	// Token: 0x0601B325 RID: 111397 RVA: 0x0085995B File Offset: 0x00857B5B
	static CombatLog()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CombatLog.CreateStaticDefaultValue), new Action(CombatLog.ResetStaticDefaultValue));
	}

	// Token: 0x0400EC21 RID: 60449
	public HashSet<CombatLog.EDebugModule> DebugCombatInfo = new HashSet<CombatLog.EDebugModule>();

	// Token: 0x0400EC22 RID: 60450
	[StaticVariableRuleIgnore]
	private static StringBuilder Sb = new StringBuilder(256);

	// Token: 0x0400EC23 RID: 60451
	[Nullable(2)]
	private static CombatLog _instance;

	// Token: 0x02008A81 RID: 35457
	[NullableContext(0)]
	public enum ELogType
	{
		// Token: 0x0402BF81 RID: 180097
		Info,
		// Token: 0x0402BF82 RID: 180098
		Debug,
		// Token: 0x0402BF83 RID: 180099
		Warn,
		// Token: 0x0402BF84 RID: 180100
		Error
	}

	// Token: 0x02008A82 RID: 35458
	[NullableContext(0)]
	public enum EDebugModule
	{
		// Token: 0x0402BF86 RID: 180102
		Notify,
		// Token: 0x0402BF87 RID: 180103
		Request,
		// Token: 0x0402BF88 RID: 180104
		Ai,
		// Token: 0x0402BF89 RID: 180105
		Buff,
		// Token: 0x0402BF8A RID: 180106
		Cue,
		// Token: 0x0402BF8B RID: 180107
		Skill,
		// Token: 0x0402BF8C RID: 180108
		Hit,
		// Token: 0x0402BF8D RID: 180109
		Control,
		// Token: 0x0402BF8E RID: 180110
		Animation,
		// Token: 0x0402BF8F RID: 180111
		Caught,
		// Token: 0x0402BF90 RID: 180112
		Message,
		// Token: 0x0402BF91 RID: 180113
		LogicState,
		// Token: 0x0402BF92 RID: 180114
		Move,
		// Token: 0x0402BF93 RID: 180115
		StateMachine,
		// Token: 0x0402BF94 RID: 180116
		StateMachineNew,
		// Token: 0x0402BF95 RID: 180117
		Actor,
		// Token: 0x0402BF96 RID: 180118
		Material,
		// Token: 0x0402BF97 RID: 180119
		Part,
		// Token: 0x0402BF98 RID: 180120
		UnifiedState,
		// Token: 0x0402BF99 RID: 180121
		BehaviorTree,
		// Token: 0x0402BF9A RID: 180122
		FightState,
		// Token: 0x0402BF9B RID: 180123
		Attribute,
		// Token: 0x0402BF9C RID: 180124
		PassiveSkill,
		// Token: 0x0402BF9D RID: 180125
		Bullet,
		// Token: 0x0402BF9E RID: 180126
		BattleUi,
		// Token: 0x0402BF9F RID: 180127
		Damage,
		// Token: 0x0402BFA0 RID: 180128
		Death,
		// Token: 0x0402BFA1 RID: 180129
		LockOn,
		// Token: 0x0402BFA2 RID: 180130
		Vehicle
	}
}
