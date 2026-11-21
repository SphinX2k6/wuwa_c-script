using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001C7 RID: 455
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class TimeoutException : SystemException
	{
		// Token: 0x06002279 RID: 8825 RVA: 0x0006830B File Offset: 0x0006650B
		public TimeoutException() : base(SR.Arg_TimeoutException)
		{
			base.HResult = -2146233083;
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00068323 File Offset: 0x00066523
		public TimeoutException(string message) : base(message ?? SR.Arg_TimeoutException)
		{
			base.HResult = -2146233083;
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x00068340 File Offset: 0x00066540
		public TimeoutException(string message, Exception innerException) : base(message ?? SR.Arg_TimeoutException, innerException)
		{
			base.HResult = -2146233083;
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TimeoutException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
