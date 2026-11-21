using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200018B RID: 395
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class OverflowException : ArithmeticException
	{
		// Token: 0x06001A00 RID: 6656 RVA: 0x00054F19 File Offset: 0x00053119
		public OverflowException() : base(SR.Arg_OverflowException)
		{
			base.HResult = -2146233066;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00054F31 File Offset: 0x00053131
		public OverflowException(string message) : base(message ?? SR.Arg_OverflowException)
		{
			base.HResult = -2146233066;
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00054F4E File Offset: 0x0005314E
		public OverflowException(string message, Exception innerException) : base(message ?? SR.Arg_OverflowException, innerException)
		{
			base.HResult = -2146233066;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0002E5C0 File Offset: 0x0002C7C0
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected OverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
