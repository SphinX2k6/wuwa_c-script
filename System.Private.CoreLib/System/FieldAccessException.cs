using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200010A RID: 266
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class FieldAccessException : MemberAccessException
	{
		// Token: 0x06001140 RID: 4416 RVA: 0x00030B10 File Offset: 0x0002ED10
		public FieldAccessException() : base(SR.Arg_FieldAccessException)
		{
			base.HResult = -2146233081;
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00030B28 File Offset: 0x0002ED28
		public FieldAccessException(string message) : base(message ?? SR.Arg_FieldAccessException)
		{
			base.HResult = -2146233081;
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00030B45 File Offset: 0x0002ED45
		public FieldAccessException(string message, Exception inner) : base(message ?? SR.Arg_FieldAccessException, inner)
		{
			base.HResult = -2146233081;
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00030B63 File Offset: 0x0002ED63
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected FieldAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
