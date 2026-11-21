using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200016D RID: 365
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class MethodAccessException : MemberAccessException
	{
		// Token: 0x06001882 RID: 6274 RVA: 0x0004C954 File Offset: 0x0004AB54
		public MethodAccessException() : base(SR.Arg_MethodAccessException)
		{
			base.HResult = -2146233072;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0004C96C File Offset: 0x0004AB6C
		public MethodAccessException(string message) : base(message ?? SR.Arg_MethodAccessException)
		{
			base.HResult = -2146233072;
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0004C989 File Offset: 0x0004AB89
		public MethodAccessException(string message, Exception inner) : base(message ?? SR.Arg_MethodAccessException, inner)
		{
			base.HResult = -2146233072;
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00030B63 File Offset: 0x0002ED63
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MethodAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
