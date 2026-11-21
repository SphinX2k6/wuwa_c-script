using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Collections
{
	// Token: 0x02000006 RID: 6
	internal static class ThrowHelper
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00003A94 File Offset: 0x00001C94
		[DoesNotReturn]
		internal static void ThrowKeyNotFound<TKey>(TKey key)
		{
			throw new KeyNotFoundException(SR.Format(SR.Arg_KeyNotFoundWithKey, key));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003AAB File Offset: 0x00001CAB
		[DoesNotReturn]
		internal static void ThrowDuplicateKey<TKey>(TKey key)
		{
			throw new ArgumentException(SR.Format(SR.Argument_AddingDuplicate, key), "key");
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003AC7 File Offset: 0x00001CC7
		[DoesNotReturn]
		internal static void ThrowConcurrentOperation()
		{
			throw new InvalidOperationException(SR.InvalidOperation_ConcurrentOperationsNotSupported);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003AD3 File Offset: 0x00001CD3
		[DoesNotReturn]
		internal static void ThrowIndexArgumentOutOfRange()
		{
			throw new ArgumentOutOfRangeException("index");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003ADF File Offset: 0x00001CDF
		[DoesNotReturn]
		internal static void ThrowVersionCheckFailed()
		{
			throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
		}
	}
}
