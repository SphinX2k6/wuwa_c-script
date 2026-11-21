using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200010C RID: 268
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class FormatException : SystemException
	{
		// Token: 0x06001145 RID: 4421 RVA: 0x00030B6D File Offset: 0x0002ED6D
		public FormatException() : base(SR.Arg_FormatException)
		{
			base.HResult = -2146233033;
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00030B85 File Offset: 0x0002ED85
		public FormatException(string message) : base(message ?? SR.Arg_FormatException)
		{
			base.HResult = -2146233033;
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00030BA2 File Offset: 0x0002EDA2
		public FormatException(string message, Exception innerException) : base(message ?? SR.Arg_FormatException, innerException)
		{
			base.HResult = -2146233033;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected FormatException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
