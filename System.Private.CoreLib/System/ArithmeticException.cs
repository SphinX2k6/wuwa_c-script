using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000CF RID: 207
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ArithmeticException : SystemException
	{
		// Token: 0x060009FD RID: 2557 RVA: 0x0001E972 File Offset: 0x0001CB72
		public ArithmeticException() : base(SR.Arg_ArithmeticException)
		{
			base.HResult = -2147024362;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0001E98A File Offset: 0x0001CB8A
		public ArithmeticException(string message) : base(message ?? SR.Arg_ArithmeticException)
		{
			base.HResult = -2147024362;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0001E9A7 File Offset: 0x0001CBA7
		public ArithmeticException(string message, Exception innerException) : base(message ?? SR.Arg_ArithmeticException, innerException)
		{
			base.HResult = -2147024362;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ArithmeticException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
