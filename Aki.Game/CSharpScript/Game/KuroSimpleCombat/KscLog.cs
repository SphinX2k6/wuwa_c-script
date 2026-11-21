using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat
{
	// Token: 0x0200613B RID: 24891
	[NullableContext(1)]
	[Nullable(0)]
	public class KscLog
	{
		// Token: 0x0603B9CF RID: 244175 RVA: 0x010E84CC File Offset: 0x010E66CC
		private static void Log(KscLog.ELogType logType, ELogAuthor logAuthor, KscLog.EModule flag, [Nullable(2)] UObject obj, string log, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[KSC][");
			defaultInterpolatedStringHandler.AppendFormatted<KscLog.EModule>(flag);
			defaultInterpolatedStringHandler.AppendLiteral("][Object:");
			defaultInterpolatedStringHandler.AppendFormatted((obj != null) ? obj.GetName() : null);
			defaultInterpolatedStringHandler.AppendLiteral("] ");
			defaultInterpolatedStringHandler.AppendFormatted(log);
			string message = defaultInterpolatedStringHandler.ToStringAndClear();
			switch (logType)
			{
			case KscLog.ELogType.Debug:
				break;
			case KscLog.ELogType.Info:
				global::Log.Instance.Info(ELogModule.CombatInfo, logAuthor, message, pairs);
				return;
			case KscLog.ELogType.Warn:
				global::Log.Instance.Warn(ELogModule.CombatInfo, logAuthor, message, pairs);
				return;
			case KscLog.ELogType.Error:
				global::Log.Instance.Error(ELogModule.CombatInfo, logAuthor, message, pairs);
				break;
			default:
				return;
			}
		}

		// Token: 0x0603B9D0 RID: 244176 RVA: 0x010E8585 File Offset: 0x010E6785
		[Conditional("DEBUG")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Debug(KscLog.EModule flag, ELogAuthor author, [Nullable(2)] UObject obj, string log, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x0603B9D1 RID: 244177 RVA: 0x010E8587 File Offset: 0x010E6787
		public static void Info(KscLog.EModule flag, ELogAuthor author, [Nullable(2)] UObject obj, string log, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			KscLog.Log(KscLog.ELogType.Info, author, flag, obj, log, pairs);
		}

		// Token: 0x0603B9D2 RID: 244178 RVA: 0x010E8595 File Offset: 0x010E6795
		public static void Warn(KscLog.EModule flag, ELogAuthor author, [Nullable(2)] UObject obj, string log, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			KscLog.Log(KscLog.ELogType.Warn, author, flag, obj, log, pairs);
		}

		// Token: 0x0603B9D3 RID: 244179 RVA: 0x010E85A3 File Offset: 0x010E67A3
		public static void Error(KscLog.EModule flag, ELogAuthor author, [Nullable(2)] UObject obj, string log, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			KscLog.Log(KscLog.ELogType.Error, author, flag, obj, log, pairs);
		}

		// Token: 0x0603B9D4 RID: 244180 RVA: 0x010E85B1 File Offset: 0x010E67B1
		[Conditional("DEBUG")]
		private static void PrintOnScreen(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x0401F6FF RID: 128767
		[StaticVariableRuleIgnore]
		private static readonly StringBuilder Sb = new StringBuilder(256);

		// Token: 0x0200B9A8 RID: 47528
		[NullableContext(0)]
		private enum ELogType
		{
			// Token: 0x040393BA RID: 234426
			Debug,
			// Token: 0x040393BB RID: 234427
			Info,
			// Token: 0x040393BC RID: 234428
			Warn,
			// Token: 0x040393BD RID: 234429
			Error
		}

		// Token: 0x0200B9A9 RID: 47529
		[NullableContext(0)]
		public enum EModule
		{
			// Token: 0x040393BF RID: 234431
			Common,
			// Token: 0x040393C0 RID: 234432
			Load,
			// Token: 0x040393C1 RID: 234433
			Attr,
			// Token: 0x040393C2 RID: 234434
			Input,
			// Token: 0x040393C3 RID: 234435
			Skill
		}
	}
}
