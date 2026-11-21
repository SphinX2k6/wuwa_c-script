using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000149 RID: 329
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class InsufficientExecutionStackException : SystemException
	{
		// Token: 0x060013EB RID: 5099 RVA: 0x0003EC49 File Offset: 0x0003CE49
		public InsufficientExecutionStackException() : base(SR.Arg_InsufficientExecutionStackException)
		{
			base.HResult = -2146232968;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0003EC61 File Offset: 0x0003CE61
		public InsufficientExecutionStackException(string message) : base(message ?? SR.Arg_InsufficientExecutionStackException)
		{
			base.HResult = -2146232968;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0003EC7E File Offset: 0x0003CE7E
		public InsufficientExecutionStackException(string message, Exception innerException) : base(message ?? SR.Arg_InsufficientExecutionStackException, innerException)
		{
			base.HResult = -2146232968;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private InsufficientExecutionStackException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
