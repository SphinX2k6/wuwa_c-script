using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x02000784 RID: 1924
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class TargetParameterCountException : ApplicationException
	{
		// Token: 0x06007B14 RID: 31508 RVA: 0x0012214E File Offset: 0x0012034E
		public TargetParameterCountException() : base(SR.Arg_TargetParameterCountException)
		{
			base.HResult = -2147352562;
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x00122166 File Offset: 0x00120366
		public TargetParameterCountException(string message) : base(message ?? SR.Arg_TargetParameterCountException)
		{
			base.HResult = -2147352562;
		}

		// Token: 0x06007B16 RID: 31510 RVA: 0x00122183 File Offset: 0x00120383
		public TargetParameterCountException(string message, Exception inner) : base(message ?? SR.Arg_TargetParameterCountException, inner)
		{
			base.HResult = -2147352562;
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x000DFC7C File Offset: 0x000DDE7C
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private TargetParameterCountException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
