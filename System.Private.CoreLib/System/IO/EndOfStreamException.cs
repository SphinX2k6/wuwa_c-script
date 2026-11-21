using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x020007E6 RID: 2022
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class EndOfStreamException : IOException
	{
		// Token: 0x060081AF RID: 33199 RVA: 0x00133EBC File Offset: 0x001320BC
		public EndOfStreamException() : base(SR.Arg_EndOfStreamException)
		{
			base.HResult = -2147024858;
		}

		// Token: 0x060081B0 RID: 33200 RVA: 0x00133ED4 File Offset: 0x001320D4
		public EndOfStreamException(string message) : base(message ?? SR.Arg_EndOfStreamException)
		{
			base.HResult = -2147024858;
		}

		// Token: 0x060081B1 RID: 33201 RVA: 0x00133EF1 File Offset: 0x001320F1
		public EndOfStreamException(string message, Exception innerException) : base(message ?? SR.Arg_EndOfStreamException, innerException)
		{
			base.HResult = -2147024858;
		}

		// Token: 0x060081B2 RID: 33202 RVA: 0x00133D57 File Offset: 0x00131F57
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected EndOfStreamException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
