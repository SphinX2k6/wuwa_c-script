using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Utils;

namespace CSharpScript.ThirdParty.UniTaskExtensions
{
	// Token: 0x0200003D RID: 61
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public class UnobservedExceptionHandler
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0000B395 File Offset: 0x00009595
		private static bool InMainThread
		{
			get
			{
				return UnobservedExceptionHandler.MainThreadId == Environment.CurrentManagedThreadId;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public static void Initialize(UGameInstance gameInstance)
		{
			UnobservedExceptionHandler.MainThreadId = Environment.CurrentManagedThreadId;
			Action<Exception> value;
			if ((value = UnobservedExceptionHandler.<>O.<0>__OnUniTaskUnobservedException) == null)
			{
				value = (UnobservedExceptionHandler.<>O.<0>__OnUniTaskUnobservedException = new Action<Exception>(UnobservedExceptionHandler.OnUniTaskUnobservedException));
			}
			UniTaskScheduler.UnobservedTaskException += value;
			AppDomain currentDomain = AppDomain.CurrentDomain;
			UnhandledExceptionEventHandler value2;
			if ((value2 = UnobservedExceptionHandler.<>O.<1>__UnhandledExceptionEvent) == null)
			{
				value2 = (UnobservedExceptionHandler.<>O.<1>__UnhandledExceptionEvent = new UnhandledExceptionEventHandler(UnobservedExceptionHandler.UnhandledExceptionEvent));
			}
			currentDomain.UnhandledException += value2;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000B400 File Offset: 0x00009600
		public static void Clear()
		{
			Action<Exception> value;
			if ((value = UnobservedExceptionHandler.<>O.<0>__OnUniTaskUnobservedException) == null)
			{
				value = (UnobservedExceptionHandler.<>O.<0>__OnUniTaskUnobservedException = new Action<Exception>(UnobservedExceptionHandler.OnUniTaskUnobservedException));
			}
			UniTaskScheduler.UnobservedTaskException -= value;
			AppDomain currentDomain = AppDomain.CurrentDomain;
			UnhandledExceptionEventHandler value2;
			if ((value2 = UnobservedExceptionHandler.<>O.<1>__UnhandledExceptionEvent) == null)
			{
				value2 = (UnobservedExceptionHandler.<>O.<1>__UnhandledExceptionEvent = new UnhandledExceptionEventHandler(UnobservedExceptionHandler.UnhandledExceptionEvent));
			}
			currentDomain.UnhandledException -= value2;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000B452 File Offset: 0x00009652
		private static void OnUniTaskUnobservedException(Exception ex)
		{
			UnobservedExceptionHandler.HandleUnobservedException(ex);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000B45A File Offset: 0x0000965A
		private static void UnhandledExceptionEvent(object sender, UnhandledExceptionEventArgs args)
		{
			UnobservedExceptionHandler.HandleUnobservedException((Exception)args.ExceptionObject);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000B46C File Offset: 0x0000966C
		private static void HandleUnobservedException(Exception ex)
		{
			if (UnobservedExceptionHandler.InMainThread)
			{
				LauncherLog.Instance.ErrorWithStack("UnobservedException", ex, default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UnrealLogger.Error("UnobservedException: \n " + ex.Message + " \n StackTrace: " + ex.StackTrace);
		}

		// Token: 0x040000ED RID: 237
		private static int MainThreadId;

		// Token: 0x020002BA RID: 698
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000AE6 RID: 2790
			[Nullable(0)]
			public static Action<Exception> <0>__OnUniTaskUnobservedException;

			// Token: 0x04000AE7 RID: 2791
			[Nullable(0)]
			public static UnhandledExceptionEventHandler <1>__UnhandledExceptionEvent;
		}
	}
}
