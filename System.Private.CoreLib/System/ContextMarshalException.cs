using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000E7 RID: 231
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ContextMarshalException : SystemException
	{
		// Token: 0x06000C34 RID: 3124 RVA: 0x000227EA File Offset: 0x000209EA
		public ContextMarshalException() : this(SR.Arg_ContextMarshalException, null)
		{
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000227F8 File Offset: 0x000209F8
		public ContextMarshalException(string message) : this(message, null)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00022802 File Offset: 0x00020A02
		public ContextMarshalException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233084;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ContextMarshalException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
