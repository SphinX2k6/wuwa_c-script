using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x0200043C RID: 1084
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class ThreadStartException : SystemException
	{
		// Token: 0x0600425F RID: 16991 RVA: 0x000DD78F File Offset: 0x000DB98F
		internal ThreadStartException() : base(SR.Arg_ThreadStartException)
		{
			base.HResult = -2146233051;
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x000DD7A7 File Offset: 0x000DB9A7
		internal ThreadStartException(Exception reason) : base(SR.Arg_ThreadStartException, reason)
		{
			base.HResult = -2146233051;
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private ThreadStartException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
