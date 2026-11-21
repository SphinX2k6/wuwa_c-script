using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000CA RID: 202
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ApplicationException : Exception
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x0001E13B File Offset: 0x0001C33B
		public ApplicationException() : base(SR.Arg_ApplicationException)
		{
			base.HResult = -2146232832;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0001E153 File Offset: 0x0001C353
		public ApplicationException(string message) : base(message)
		{
			base.HResult = -2146232832;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0001E167 File Offset: 0x0001C367
		public ApplicationException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232832;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0001E17C File Offset: 0x0001C37C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ApplicationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
