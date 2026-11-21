using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000EC RID: 236
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class DataMisalignedException : SystemException
	{
		// Token: 0x06000DA0 RID: 3488 RVA: 0x0002508C File Offset: 0x0002328C
		public DataMisalignedException() : base(SR.Arg_DataMisalignedException)
		{
			base.HResult = -2146233023;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000250A4 File Offset: 0x000232A4
		public DataMisalignedException(string message) : base(message ?? SR.Arg_DataMisalignedException)
		{
			base.HResult = -2146233023;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000250C1 File Offset: 0x000232C1
		public DataMisalignedException(string message, Exception innerException) : base(message ?? SR.Arg_DataMisalignedException, innerException)
		{
			base.HResult = -2146233023;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		private DataMisalignedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
