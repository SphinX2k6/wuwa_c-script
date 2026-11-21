using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuickTimeAction.Context;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02003F08 RID: 16136
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaLog
	{
		// Token: 0x06028EA0 RID: 167584 RVA: 0x00B7B7C0 File Offset: 0x00B799C0
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

		// Token: 0x06028EA1 RID: 167585 RVA: 0x00B7B924 File Offset: 0x00B79B24
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

		// Token: 0x06028EA2 RID: 167586 RVA: 0x00B7B926 File Offset: 0x00B79B26
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

		// Token: 0x06028EA3 RID: 167587 RVA: 0x00B7B932 File Offset: 0x00B79B32
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
