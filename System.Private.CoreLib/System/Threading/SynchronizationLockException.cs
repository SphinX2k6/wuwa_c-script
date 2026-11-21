using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x02000413 RID: 1043
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SynchronizationLockException : SystemException
	{
		// Token: 0x0600418A RID: 16778 RVA: 0x000DABB0 File Offset: 0x000D8DB0
		public SynchronizationLockException() : base(SR.Arg_SynchronizationLockException)
		{
			base.HResult = -2146233064;
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x000DABC8 File Offset: 0x000D8DC8
		public SynchronizationLockException(string message) : base(message ?? SR.Arg_SynchronizationLockException)
		{
			base.HResult = -2146233064;
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x000DABE5 File Offset: 0x000D8DE5
		public SynchronizationLockException(string message, Exception innerException) : base(message ?? SR.Arg_SynchronizationLockException, innerException)
		{
			base.HResult = -2146233064;
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SynchronizationLockException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
