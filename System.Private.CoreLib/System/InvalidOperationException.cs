using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000151 RID: 337
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class InvalidOperationException : SystemException
	{
		// Token: 0x060016F0 RID: 5872 RVA: 0x00045ECC File Offset: 0x000440CC
		public InvalidOperationException() : base(SR.Arg_InvalidOperationException)
		{
			base.HResult = -2146233079;
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00045EE4 File Offset: 0x000440E4
		public InvalidOperationException(string message) : base(message ?? SR.Arg_InvalidOperationException)
		{
			base.HResult = -2146233079;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00045F01 File Offset: 0x00044101
		public InvalidOperationException(string message, Exception innerException) : base(message ?? SR.Arg_InvalidOperationException, innerException)
		{
			base.HResult = -2146233079;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected InvalidOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
