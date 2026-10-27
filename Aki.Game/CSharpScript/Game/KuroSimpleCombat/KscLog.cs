using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat
{
	// Token: 0x02006FBA RID: 28602
	[NullableContext(1)]
	[Nullable(0)]
	public class KscLog
	{
		// Token: 0x0604581F RID: 284703 RVA: 0x0113E6FC File Offset: 0x0113C8FC
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

		// Token: 0x06045820 RID: 284704 RVA: 0x0113E7B5 File Offset: 0x0113C9B5
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

		// Token: 0x06045821 RID: 284705 RVA: 0x0113E7B7 File Offset: 0x0113C9B7
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

		// Token: 0x06045822 RID: 284706 RVA: 0x0113E7C5 File Offset: 0x0113C9C5
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

		// Token: 0x06045823 RID: 284707 RVA: 0x0113E7D3 File Offset: 0x0113C9D3
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

		// Token: 0x06045824 RID: 284708 RVA: 0x0113E7E1 File Offset: 0x0113C9E1
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

		// Token: 0x0402444A RID: 148554
		[StaticVariableRuleIgnore]
		private static readonly StringBuilder Sb = new StringBuilder(256);

		// Token: 0x0200CDB6 RID: 52662
		[NullableContext(0)]
		private enum ELogType
		{
			// Token: 0x0403DF8B RID: 253835
			Debug,
			// Token: 0x0403DF8C RID: 253836
			Info,
			// Token: 0x0403DF8D RID: 253837
			Warn,
			// Token: 0x0403DF8E RID: 253838
			Error
		}

		// Token: 0x0200CDB7 RID: 52663
		[NullableContext(0)]
		public enum EModule
		{
			// Token: 0x0403DF90 RID: 253840
			Common,
			// Token: 0x0403DF91 RID: 253841
			Load,
			// Token: 0x0403DF92 RID: 253842
			Attr,
			// Token: 0x0403DF93 RID: 253843
			Input,
			// Token: 0x0403DF94 RID: 253844
			Skill
		}
	}
}
