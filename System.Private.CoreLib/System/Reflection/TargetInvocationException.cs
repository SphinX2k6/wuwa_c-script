using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x02000783 RID: 1923
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class TargetInvocationException : ApplicationException
	{
		// Token: 0x06007B11 RID: 31505 RVA: 0x00122117 File Offset: 0x00120317
		public TargetInvocationException(Exception inner) : base(SR.Arg_TargetInvocationException, inner)
		{
			base.HResult = -2146232828;
		}

		// Token: 0x06007B12 RID: 31506 RVA: 0x00122130 File Offset: 0x00120330
		public TargetInvocationException(string message, Exception inner) : base(message ?? SR.Arg_TargetInvocationException, inner)
		{
			base.HResult = -2146232828;
		}

		// Token: 0x06007B13 RID: 31507 RVA: 0x000DFC7C File Offset: 0x000DDE7C
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private TargetInvocationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
