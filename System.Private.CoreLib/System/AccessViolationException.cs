using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000AE RID: 174
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class AccessViolationException : SystemException
	{
		// Token: 0x060008D7 RID: 2263 RVA: 0x0001CAAE File Offset: 0x0001ACAE
		public AccessViolationException() : base(SR.Arg_AccessViolationException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0001CAC6 File Offset: 0x0001ACC6
		public AccessViolationException(string message) : base(message ?? SR.Arg_AccessViolationException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0001CAE3 File Offset: 0x0001ACE3
		public AccessViolationException(string message, Exception innerException) : base(message ?? SR.Arg_AccessViolationException, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AccessViolationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
