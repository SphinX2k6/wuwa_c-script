using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000172 RID: 370
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class MulticastNotSupportedException : SystemException
	{
		// Token: 0x06001899 RID: 6297 RVA: 0x0004CC40 File Offset: 0x0004AE40
		public MulticastNotSupportedException() : base(SR.Arg_MulticastNotSupportedException)
		{
			base.HResult = -2146233068;
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0004CC58 File Offset: 0x0004AE58
		public MulticastNotSupportedException(string message) : base(message ?? SR.Arg_MulticastNotSupportedException)
		{
			base.HResult = -2146233068;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0004CC75 File Offset: 0x0004AE75
		public MulticastNotSupportedException(string message, Exception inner) : base(message ?? SR.Arg_MulticastNotSupportedException, inner)
		{
			base.HResult = -2146233068;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private MulticastNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
