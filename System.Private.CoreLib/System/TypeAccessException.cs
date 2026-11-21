using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001E3 RID: 483
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class TypeAccessException : TypeLoadException
	{
		// Token: 0x0600249E RID: 9374 RVA: 0x00071D75 File Offset: 0x0006FF75
		public TypeAccessException() : base(SR.Arg_TypeAccessException)
		{
			base.HResult = -2146233021;
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00071D8D File Offset: 0x0006FF8D
		public TypeAccessException(string message) : base(message ?? SR.Arg_TypeAccessException)
		{
			base.HResult = -2146233021;
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00071DAA File Offset: 0x0006FFAA
		public TypeAccessException(string message, Exception inner) : base(message ?? SR.Arg_TypeAccessException, inner)
		{
			base.HResult = -2146233021;
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0002E61D File Offset: 0x0002C81D
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TypeAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
