using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005E0 RID: 1504
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class MarshalDirectiveException : SystemException
	{
		// Token: 0x06007051 RID: 28753 RVA: 0x0010DD29 File Offset: 0x0010BF29
		public MarshalDirectiveException() : base(SR.Arg_MarshalDirectiveException)
		{
			base.HResult = -2146233035;
		}

		// Token: 0x06007052 RID: 28754 RVA: 0x0010DD41 File Offset: 0x0010BF41
		public MarshalDirectiveException(string message) : base(message ?? SR.Arg_MarshalDirectiveException)
		{
			base.HResult = -2146233035;
		}

		// Token: 0x06007053 RID: 28755 RVA: 0x0010DD5E File Offset: 0x0010BF5E
		public MarshalDirectiveException(string message, Exception inner) : base(message ?? SR.Arg_MarshalDirectiveException, inner)
		{
			base.HResult = -2146233035;
		}

		// Token: 0x06007054 RID: 28756 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MarshalDirectiveException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
