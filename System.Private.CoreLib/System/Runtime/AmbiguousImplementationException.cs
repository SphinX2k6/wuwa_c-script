using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Runtime
{
	// Token: 0x02000500 RID: 1280
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Serializable]
	public sealed class AmbiguousImplementationException : Exception
	{
		// Token: 0x0600482B RID: 18475 RVA: 0x000F069E File Offset: 0x000EE89E
		public AmbiguousImplementationException() : base(SR.Arg_AmbiguousImplementationException_NoMessage)
		{
			base.HResult = -2146234262;
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x000F06B6 File Offset: 0x000EE8B6
		public AmbiguousImplementationException(string message) : base(message ?? SR.Arg_AmbiguousImplementationException_NoMessage)
		{
			base.HResult = -2146234262;
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x000F06D3 File Offset: 0x000EE8D3
		public AmbiguousImplementationException(string message, Exception innerException) : base(message ?? SR.Arg_AmbiguousImplementationException_NoMessage, innerException)
		{
			base.HResult = -2146234262;
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x0001E17C File Offset: 0x0001C37C
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private AmbiguousImplementationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
