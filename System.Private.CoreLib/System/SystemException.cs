using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001BE RID: 446
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SystemException : Exception
	{
		// Token: 0x060021A5 RID: 8613 RVA: 0x0006686D File Offset: 0x00064A6D
		public SystemException() : base(SR.Arg_SystemException)
		{
			base.HResult = -2146233087;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00066885 File Offset: 0x00064A85
		public SystemException(string message) : base(message)
		{
			base.HResult = -2146233087;
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00066899 File Offset: 0x00064A99
		public SystemException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233087;
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x0001E17C File Offset: 0x0001C37C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SystemException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
