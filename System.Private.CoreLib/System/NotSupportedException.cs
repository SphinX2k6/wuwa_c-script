using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000176 RID: 374
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class NotSupportedException : SystemException
	{
		// Token: 0x060018AB RID: 6315 RVA: 0x0004CE07 File Offset: 0x0004B007
		public NotSupportedException() : base(SR.Arg_NotSupportedException)
		{
			base.HResult = -2146233067;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0004CE1F File Offset: 0x0004B01F
		public NotSupportedException(string message) : base(message ?? SR.Arg_NotSupportedException)
		{
			base.HResult = -2146233067;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0004CE3C File Offset: 0x0004B03C
		public NotSupportedException(string message, Exception innerException) : base(message ?? SR.Arg_NotSupportedException, innerException)
		{
			base.HResult = -2146233067;
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected NotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
