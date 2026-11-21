using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace System
{
	// Token: 0x0200015C RID: 348
	internal sealed class LazyHelper
	{
		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x00045F8D File Offset: 0x0004418D
		internal LazyState State { get; }

		// Token: 0x0600170C RID: 5900 RVA: 0x00045F95 File Offset: 0x00044195
		internal LazyHelper(LazyState state)
		{
			this.State = state;
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00045FA4 File Offset: 0x000441A4
		internal LazyHelper(LazyThreadSafetyMode mode, Exception exception)
		{
			switch (mode)
			{
			case LazyThreadSafetyMode.None:
				this.State = 2;
				break;
			case LazyThreadSafetyMode.PublicationOnly:
				this.State = 6;
				break;
			case LazyThreadSafetyMode.ExecutionAndPublication:
				this.State = 9;
				break;
			}
			this._exceptionDispatch = ExceptionDispatchInfo.Capture(exception);
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00045FF1 File Offset: 0x000441F1
		[DoesNotReturn]
		internal void ThrowException()
		{
			this._exceptionDispatch.Throw();
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00046000 File Offset: 0x00044200
		private LazyThreadSafetyMode GetMode()
		{
			switch (this.State)
			{
			case LazyState.NoneViaConstructor:
			case LazyState.NoneViaFactory:
			case LazyState.NoneException:
				return LazyThreadSafetyMode.None;
			case LazyState.PublicationOnlyViaConstructor:
			case LazyState.PublicationOnlyViaFactory:
			case LazyState.PublicationOnlyWait:
			case LazyState.PublicationOnlyException:
				return LazyThreadSafetyMode.PublicationOnly;
			case LazyState.ExecutionAndPublicationViaConstructor:
			case LazyState.ExecutionAndPublicationViaFactory:
			case LazyState.ExecutionAndPublicationException:
				return LazyThreadSafetyMode.ExecutionAndPublication;
			default:
				return LazyThreadSafetyMode.None;
			}
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0004604C File Offset: 0x0004424C
		internal static LazyThreadSafetyMode? GetMode(LazyHelper state)
		{
			if (state == null)
			{
				return null;
			}
			return new LazyThreadSafetyMode?(state.GetMode());
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00046071 File Offset: 0x00044271
		internal static bool GetIsValueFaulted(LazyHelper state)
		{
			return ((state != null) ? state._exceptionDispatch : null) != null;
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00046084 File Offset: 0x00044284
		internal static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor)
		{
			switch (mode)
			{
			case LazyThreadSafetyMode.None:
				if (!useDefaultConstructor)
				{
					return LazyHelper.NoneViaFactory;
				}
				return LazyHelper.NoneViaConstructor;
			case LazyThreadSafetyMode.PublicationOnly:
				if (!useDefaultConstructor)
				{
					return LazyHelper.PublicationOnlyViaFactory;
				}
				return LazyHelper.PublicationOnlyViaConstructor;
			case LazyThreadSafetyMode.ExecutionAndPublication:
				return new LazyHelper(useDefaultConstructor ? LazyState.ExecutionAndPublicationViaConstructor : LazyState.ExecutionAndPublicationViaFactory);
			default:
				throw new ArgumentOutOfRangeException("mode", SR.Lazy_ctor_ModeInvalid);
			}
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x000460E0 File Offset: 0x000442E0
		internal static T CreateViaDefaultConstructor<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T>()
		{
			T result;
			try
			{
				result = Activator.CreateInstance<T>();
			}
			catch (MissingMethodException)
			{
				throw new MissingMemberException(SR.Lazy_CreateValue_NoParameterlessCtorForT);
			}
			return result;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00046114 File Offset: 0x00044314
		internal static LazyThreadSafetyMode GetModeFromIsThreadSafe(bool isThreadSafe)
		{
			if (!isThreadSafe)
			{
				return LazyThreadSafetyMode.None;
			}
			return LazyThreadSafetyMode.ExecutionAndPublication;
		}

		// Token: 0x040004D4 RID: 1236
		internal static readonly LazyHelper NoneViaConstructor = new LazyHelper(LazyState.NoneViaConstructor);

		// Token: 0x040004D5 RID: 1237
		internal static readonly LazyHelper NoneViaFactory = new LazyHelper(LazyState.NoneViaFactory);

		// Token: 0x040004D6 RID: 1238
		internal static readonly LazyHelper PublicationOnlyViaConstructor = new LazyHelper(LazyState.PublicationOnlyViaConstructor);

		// Token: 0x040004D7 RID: 1239
		internal static readonly LazyHelper PublicationOnlyViaFactory = new LazyHelper(LazyState.PublicationOnlyViaFactory);

		// Token: 0x040004D8 RID: 1240
		internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish = new LazyHelper(LazyState.PublicationOnlyWait);

		// Token: 0x040004DA RID: 1242
		private readonly ExceptionDispatchInfo _exceptionDispatch;
	}
}
