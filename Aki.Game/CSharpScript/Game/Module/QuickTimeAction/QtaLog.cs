using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuickTimeAction.Context;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02004F3F RID: 20287
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaLog
	{
		// Token: 0x06034032 RID: 213042 RVA: 0x00C32020 File Offset: 0x00C30220
		[NullableContext(2)]
		private static void LogInternal(CombatLog.ELogType logType, QtaContextBase qtaContext, [Nullable(1)] string message, [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs, Exception stack = null)
		{
			int value = (qtaContext != null) ? qtaContext.QtaId : 0;
			int value2 = (qtaContext != null) ? qtaContext.HandleId : 0;
			EQtaSource? value3 = (qtaContext != null) ? qtaContext.Source : null;
			EQtaState? value4 = (qtaContext != null) ? new EQtaState?(qtaContext.State) : null;
			EQtaResult? value5 = (qtaContext != null) ? new EQtaResult?(qtaContext.PendingResultType) : null;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 6);
			defaultInterpolatedStringHandler.AppendLiteral("[qta:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("|hd:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
			defaultInterpolatedStringHandler.AppendLiteral("|src:");
			defaultInterpolatedStringHandler.AppendFormatted<EQtaSource?>(value3);
			defaultInterpolatedStringHandler.AppendLiteral("|ste:");
			defaultInterpolatedStringHandler.AppendFormatted<EQtaState?>(value4);
			defaultInterpolatedStringHandler.AppendLiteral("|ret:");
			defaultInterpolatedStringHandler.AppendFormatted<EQtaResult?>(value5);
			defaultInterpolatedStringHandler.AppendLiteral("] ");
			defaultInterpolatedStringHandler.AppendFormatted(message);
			string message2 = defaultInterpolatedStringHandler.ToStringAndClear();
			switch (logType)
			{
			case CombatLog.ELogType.Info:
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.HWR, message2, pairs);
				return;
			case CombatLog.ELogType.Debug:
				break;
			case CombatLog.ELogType.Warn:
				Log.Instance.Warn(ELogModule.Battle, ELogAuthor.HWR, message2, pairs);
				return;
			case CombatLog.ELogType.Error:
				if (stack != null)
				{
					Log.Instance.ErrorWithStack(ELogModule.Battle, ELogAuthor.HWR, message2, stack, pairs);
					return;
				}
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, message2, pairs);
				break;
			default:
				return;
			}
		}

		// Token: 0x06034033 RID: 213043 RVA: 0x00C32184 File Offset: 0x00C30384
		[Conditional("DEBUG")]
		public static void Debug([Nullable(2)] QtaContextBase qtaContext, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x06034034 RID: 213044 RVA: 0x00C32186 File Offset: 0x00C30386
		public static void Info([Nullable(2)] QtaContextBase qtaContext, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			QtaLog.LogInternal(CombatLog.ELogType.Info, qtaContext, message, pairs, null);
		}

		// Token: 0x06034035 RID: 213045 RVA: 0x00C32192 File Offset: 0x00C30392
		public static void Error([Nullable(2)] QtaContextBase qtaContext, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			QtaLog.LogInternal(CombatLog.ELogType.Error, qtaContext, message, pairs, null);
		}
	}
}
