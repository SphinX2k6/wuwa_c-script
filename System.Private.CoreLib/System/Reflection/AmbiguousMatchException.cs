using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x0200071C RID: 1820
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class AmbiguousMatchException : SystemException
	{
		// Token: 0x06007855 RID: 30805 RVA: 0x0011E628 File Offset: 0x0011C828
		public AmbiguousMatchException() : base(SR.Arg_AmbiguousMatchException_NoMessage)
		{
			base.HResult = -2147475171;
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x0011E640 File Offset: 0x0011C840
		public AmbiguousMatchException(string message) : base(message ?? SR.Arg_AmbiguousMatchException_NoMessage)
		{
			base.HResult = -2147475171;
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x0011E65D File Offset: 0x0011C85D
		public AmbiguousMatchException(string message, Exception inner) : base(message ?? SR.Arg_AmbiguousMatchException_NoMessage, inner)
		{
			base.HResult = -2147475171;
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private AmbiguousMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
