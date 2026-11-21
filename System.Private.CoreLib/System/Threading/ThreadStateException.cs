using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x0200043E RID: 1086
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ThreadStateException : SystemException
	{
		// Token: 0x06004262 RID: 16994 RVA: 0x000DD7C0 File Offset: 0x000DB9C0
		public ThreadStateException() : base(SR.Arg_ThreadStateException)
		{
			base.HResult = -2146233056;
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x000DD7D8 File Offset: 0x000DB9D8
		public ThreadStateException(string message) : base(message ?? SR.Arg_ThreadStateException)
		{
			base.HResult = -2146233056;
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x000DD7F5 File Offset: 0x000DB9F5
		public ThreadStateException(string message, Exception innerException) : base(message ?? SR.Arg_ThreadStateException, innerException)
		{
			base.HResult = -2146233056;
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ThreadStateException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
