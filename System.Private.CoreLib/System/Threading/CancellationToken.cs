using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x020003D4 RID: 980
	[NullableContext(2)]
	[Nullable(0)]
	[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
	public readonly struct CancellationToken : IEquatable<CancellationToken>
	{
		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06003F93 RID: 16275 RVA: 0x000D4ADC File Offset: 0x000D2CDC
		public static CancellationToken None
		{
			get
			{
				return default(CancellationToken);
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06003F94 RID: 16276 RVA: 0x000D4AF2 File Offset: 0x000D2CF2
		public bool IsCancellationRequested
		{
			get
			{
				return this._source != null && this._source.IsCancellationRequested;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06003F95 RID: 16277 RVA: 0x000D4B09 File Offset: 0x000D2D09
		public bool CanBeCanceled
		{
			get
			{
				return this._source != null;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06003F96 RID: 16278 RVA: 0x000D4B14 File Offset: 0x000D2D14
		[Nullable(1)]
		public WaitHandle WaitHandle
		{
			[NullableContext(1)]
			get
			{
				return (this._source ?? CancellationTokenSource.s_neverCanceledSource).WaitHandle;
			}
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x000D4B2A File Offset: 0x000D2D2A
		internal CancellationToken(CancellationTokenSource source)
		{
			this._source = source;
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x000D4B33 File Offset: 0x000D2D33
		public CancellationToken(bool canceled)
		{
			this = new CancellationToken(canceled ? CancellationTokenSource.s_canceledSource : null);
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x000D4B46 File Offset: 0x000D2D46
		[NullableContext(1)]
		public CancellationTokenRegistration Register(Action callback)
		{
			return this.Register(callback, false);
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x000D4B50 File Offset: 0x000D2D50
		[NullableContext(1)]
		public CancellationTokenRegistration Register(Action callback, bool useSynchronizationContext)
		{
			ArgumentNullException.ThrowIfNull(callback, "callback");
			return this.Register(new Action<object>(delegate(object obj)
			{
				((Action)obj)();
			}), callback, useSynchronizationContext, true);
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x000D4B85 File Offset: 0x000D2D85
		public CancellationTokenRegistration Register([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> callback, object state)
		{
			return this.Register(callback, state, false, true);
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x000D4B85 File Offset: 0x000D2D85
		public CancellationTokenRegistration Register([Nullable(new byte[]
		{
			1,
			2
		})] Action<object, CancellationToken> callback, object state)
		{
			return this.Register(callback, state, false, true);
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x000D4B91 File Offset: 0x000D2D91
		public CancellationTokenRegistration Register([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> callback, object state, bool useSynchronizationContext)
		{
			return this.Register(callback, state, useSynchronizationContext, true);
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x000D4B9D File Offset: 0x000D2D9D
		public CancellationTokenRegistration UnsafeRegister([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> callback, object state)
		{
			return this.Register(callback, state, false, false);
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x000D4B9D File Offset: 0x000D2D9D
		public CancellationTokenRegistration UnsafeRegister([Nullable(new byte[]
		{
			1,
			2
		})] Action<object, CancellationToken> callback, object state)
		{
			return this.Register(callback, state, false, false);
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x000D4BAC File Offset: 0x000D2DAC
		private CancellationTokenRegistration Register(Delegate callback, object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			ArgumentNullException.ThrowIfNull(callback, "callback");
			CancellationTokenSource source = this._source;
			if (source == null)
			{
				return default(CancellationTokenRegistration);
			}
			return source.Register(callback, state, useSynchronizationContext ? SynchronizationContext.Current : null, useExecutionContext ? ExecutionContext.Capture() : null);
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x000D4BF7 File Offset: 0x000D2DF7
		public bool Equals(CancellationToken other)
		{
			return this._source == other._source;
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x000D4C07 File Offset: 0x000D2E07
		public override bool Equals([NotNullWhen(true)] object other)
		{
			return other is CancellationToken && this.Equals((CancellationToken)other);
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x000D4C1F File Offset: 0x000D2E1F
		public override int GetHashCode()
		{
			return (this._source ?? CancellationTokenSource.s_neverCanceledSource).GetHashCode();
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x000D4C35 File Offset: 0x000D2E35
		public static bool operator ==(CancellationToken left, CancellationToken right)
		{
			return left.Equals(right);
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x000D4C3F File Offset: 0x000D2E3F
		public static bool operator !=(CancellationToken left, CancellationToken right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x000D4C4C File Offset: 0x000D2E4C
		public void ThrowIfCancellationRequested()
		{
			if (this.IsCancellationRequested)
			{
				this.ThrowOperationCanceledException();
			}
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x000D4C5C File Offset: 0x000D2E5C
		[DoesNotReturn]
		private void ThrowOperationCanceledException()
		{
			throw new OperationCanceledException(SR.OperationCanceled, this);
		}

		// Token: 0x04000D26 RID: 3366
		private readonly CancellationTokenSource _source;
	}
}
