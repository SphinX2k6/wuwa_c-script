using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x020034B1 RID: 13489
[NullableContext(1)]
[Nullable(0)]
public class CombatLog : Singleton
{
	// Token: 0x0601D614 RID: 120340 RVA: 0x008320D0 File Offset: 0x008302D0
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

	// Token: 0x0601D615 RID: 120341 RVA: 0x00832160 File Offset: 0x00830360
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

	// Token: 0x0601D616 RID: 120342 RVA: 0x00832258 File Offset: 0x00830458
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

	// Token: 0x0601D617 RID: 120343 RVA: 0x00832284 File Offset: 0x00830484
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

	// Token: 0x0601D618 RID: 120344 RVA: 0x008322A8 File Offset: 0x008304A8
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

	// Token: 0x0601D619 RID: 120345 RVA: 0x008322AA File Offset: 0x008304AA
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

	// Token: 0x0601D61A RID: 120346 RVA: 0x008322AC File Offset: 0x008304AC
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

	// Token: 0x0601D61B RID: 120347 RVA: 0x008322AE File Offset: 0x008304AE
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

	// Token: 0x0601D61C RID: 120348 RVA: 0x008322B0 File Offset: 0x008304B0
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

	// Token: 0x0601D61D RID: 120349 RVA: 0x008322DC File Offset: 0x008304DC
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

	// Token: 0x0601D61E RID: 120350 RVA: 0x00832300 File Offset: 0x00830500
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

	// Token: 0x0601D61F RID: 120351 RVA: 0x008323E0 File Offset: 0x008305E0
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

	// Token: 0x0601D620 RID: 120352 RVA: 0x008324A9 File Offset: 0x008306A9
	[Conditional("DEBUG")]
	private void PrintOnScreen(string message, FLinearColor color)
	{
	}

	// Token: 0x0601D621 RID: 120353 RVA: 0x008324AC File Offset: 0x008306AC
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

	// Token: 0x0601D622 RID: 120354 RVA: 0x008324D8 File Offset: 0x008306D8
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

	// Token: 0x170028BD RID: 10429
	// (get) Token: 0x0601D623 RID: 120355 RVA: 0x008324FD File Offset: 0x008306FD
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

	// Token: 0x0601D624 RID: 120356 RVA: 0x00832520 File Offset: 0x00830720
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D625 RID: 120357 RVA: 0x00832522 File Offset: 0x00830722
	public static void ResetStaticDefaultValue()
	{
		CombatLog instance = CombatLog._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CombatLog._instance = null;
	}

	// Token: 0x0601D626 RID: 120358 RVA: 0x0083253B File Offset: 0x0083073B
	static CombatLog()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CombatLog.CreateStaticDefaultValue), new Action(CombatLog.ResetStaticDefaultValue));
	}

	// Token: 0x0400E76D RID: 59245
	public HashSet<CombatLog.EDebugModule> DebugCombatInfo = new HashSet<CombatLog.EDebugModule>();

	// Token: 0x0400E76E RID: 59246
	[StaticVariableRuleIgnore]
	private static StringBuilder Sb = new StringBuilder(256);

	// Token: 0x0400E76F RID: 59247
	[Nullable(2)]
	private static CombatLog _instance;

	// Token: 0x02009866 RID: 39014
	[NullableContext(0)]
	public enum ELogType
	{
		// Token: 0x040308FC RID: 198908
		Info,
		// Token: 0x040308FD RID: 198909
		Debug,
		// Token: 0x040308FE RID: 198910
		Warn,
		// Token: 0x040308FF RID: 198911
		Error
	}

	// Token: 0x02009867 RID: 39015
	[NullableContext(0)]
	public enum EDebugModule
	{
		// Token: 0x04030901 RID: 198913
		Notify,
		// Token: 0x04030902 RID: 198914
		Request,
		// Token: 0x04030903 RID: 198915
		Ai,
		// Token: 0x04030904 RID: 198916
		Buff,
		// Token: 0x04030905 RID: 198917
		Cue,
		// Token: 0x04030906 RID: 198918
		Skill,
		// Token: 0x04030907 RID: 198919
		Hit,
		// Token: 0x04030908 RID: 198920
		Control,
		// Token: 0x04030909 RID: 198921
		Animation,
		// Token: 0x0403090A RID: 198922
		Caught,
		// Token: 0x0403090B RID: 198923
		Message,
		// Token: 0x0403090C RID: 198924
		LogicState,
		// Token: 0x0403090D RID: 198925
		Move,
		// Token: 0x0403090E RID: 198926
		StateMachine,
		// Token: 0x0403090F RID: 198927
		StateMachineNew,
		// Token: 0x04030910 RID: 198928
		Actor,
		// Token: 0x04030911 RID: 198929
		Material,
		// Token: 0x04030912 RID: 198930
		Part,
		// Token: 0x04030913 RID: 198931
		UnifiedState,
		// Token: 0x04030914 RID: 198932
		BehaviorTree,
		// Token: 0x04030915 RID: 198933
		FightState,
		// Token: 0x04030916 RID: 198934
		Attribute,
		// Token: 0x04030917 RID: 198935
		PassiveSkill,
		// Token: 0x04030918 RID: 198936
		Bullet,
		// Token: 0x04030919 RID: 198937
		BattleUi,
		// Token: 0x0403091A RID: 198938
		Damage,
		// Token: 0x0403091B RID: 198939
		Death,
		// Token: 0x0403091C RID: 198940
		LockOn,
		// Token: 0x0403091D RID: 198941
		Vehicle
	}
}
