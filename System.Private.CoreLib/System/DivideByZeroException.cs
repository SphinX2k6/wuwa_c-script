using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000FF RID: 255
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class DivideByZeroException : ArithmeticException
	{
		// Token: 0x0600103A RID: 4154 RVA: 0x0002E56D File Offset: 0x0002C76D
		public DivideByZeroException() : base(SR.Arg_DivideByZero)
		{
			base.HResult = -2147352558;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0002E585 File Offset: 0x0002C785
		public DivideByZeroException(string message) : base(message ?? SR.Arg_DivideByZero)
		{
			base.HResult = -2147352558;
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0002E5A2 File Offset: 0x0002C7A2
		public DivideByZeroException(string message, Exception innerException) : base(message ?? SR.Arg_DivideByZero, innerException)
		{
			base.HResult = -2147352558;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0002E5C0 File Offset: 0x0002C7C0
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DivideByZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
