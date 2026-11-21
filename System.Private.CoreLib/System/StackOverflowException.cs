using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001B3 RID: 435
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class StackOverflowException : SystemException
	{
		// Token: 0x0600215A RID: 8538 RVA: 0x00065D80 File Offset: 0x00063F80
		public StackOverflowException() : base(SR.Arg_StackOverflowException)
		{
			base.HResult = -2147023895;
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00065D98 File Offset: 0x00063F98
		public StackOverflowException(string message) : base(message ?? SR.Arg_StackOverflowException)
		{
			base.HResult = -2147023895;
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00065DB5 File Offset: 0x00063FB5
		public StackOverflowException(string message, Exception innerException) : base(message ?? SR.Arg_StackOverflowException, innerException)
		{
			base.HResult = -2147023895;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private StackOverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
