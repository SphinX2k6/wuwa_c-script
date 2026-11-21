using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.ExceptionServices
{
	// Token: 0x0200052D RID: 1325
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class ExceptionDispatchInfo
	{
		// Token: 0x060048EC RID: 18668 RVA: 0x000F1FAB File Offset: 0x000F01AB
		private ExceptionDispatchInfo(Exception exception)
		{
			this._exception = exception;
			this._dispatchState = exception.CaptureDispatchState();
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x000F1FC6 File Offset: 0x000F01C6
		public static ExceptionDispatchInfo Capture(Exception source)
		{
			ArgumentNullException.ThrowIfNull(source, "source");
			return new ExceptionDispatchInfo(source);
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060048EE RID: 18670 RVA: 0x000F1FD9 File Offset: 0x000F01D9
		public Exception SourceException
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x000F1FE1 File Offset: 0x000F01E1
		[DoesNotReturn]
		[StackTraceHidden]
		public void Throw()
		{
			this._exception.RestoreDispatchState(this._dispatchState);
			throw this._exception;
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x000F1FFA File Offset: 0x000F01FA
		[DoesNotReturn]
		[StackTraceHidden]
		public static void Throw(Exception source)
		{
			ExceptionDispatchInfo.Capture(source).Throw();
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x000F2007 File Offset: 0x000F0207
		[StackTraceHidden]
		public static Exception SetCurrentStackTrace(Exception source)
		{
			ArgumentNullException.ThrowIfNull(source, "source");
			source.SetCurrentStackTrace();
			return source;
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x000F201B File Offset: 0x000F021B
		public static Exception SetRemoteStackTrace(Exception source, string stackTrace)
		{
			ArgumentNullException.ThrowIfNull(source, "source");
			ArgumentNullException.ThrowIfNull(stackTrace, "stackTrace");
			source.SetRemoteStackTrace(stackTrace);
			return source;
		}

		// Token: 0x0400117F RID: 4479
		private readonly Exception _exception;

		// Token: 0x04001180 RID: 4480
		private readonly Exception.DispatchState _dispatchState;
	}
}
