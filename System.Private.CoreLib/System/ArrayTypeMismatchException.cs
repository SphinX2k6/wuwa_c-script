using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000D7 RID: 215
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ArrayTypeMismatchException : SystemException
	{
		// Token: 0x06000A40 RID: 2624 RVA: 0x0001EFEA File Offset: 0x0001D1EA
		public ArrayTypeMismatchException() : base(SR.Arg_ArrayTypeMismatchException)
		{
			base.HResult = -2146233085;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0001F002 File Offset: 0x0001D202
		public ArrayTypeMismatchException(string message) : base(message ?? SR.Arg_ArrayTypeMismatchException)
		{
			base.HResult = -2146233085;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0001F01F File Offset: 0x0001D21F
		public ArrayTypeMismatchException(string message, Exception innerException) : base(message ?? SR.Arg_ArrayTypeMismatchException, innerException)
		{
			base.HResult = -2146233085;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ArrayTypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
