using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001EC RID: 492
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class UnauthorizedAccessException : SystemException
	{
		// Token: 0x060027A8 RID: 10152 RVA: 0x000780D5 File Offset: 0x000762D5
		public UnauthorizedAccessException() : base(SR.Arg_UnauthorizedAccessException)
		{
			base.HResult = -2147024891;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000780ED File Offset: 0x000762ED
		public UnauthorizedAccessException(string message) : base(message ?? SR.Arg_UnauthorizedAccessException)
		{
			base.HResult = -2147024891;
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x0007810A File Offset: 0x0007630A
		public UnauthorizedAccessException(string message, Exception inner) : base(message ?? SR.Arg_UnauthorizedAccessException, inner)
		{
			base.HResult = -2147024891;
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
