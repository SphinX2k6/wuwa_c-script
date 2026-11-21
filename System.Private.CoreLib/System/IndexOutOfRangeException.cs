using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000145 RID: 325
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class IndexOutOfRangeException : SystemException
	{
		// Token: 0x060013E5 RID: 5093 RVA: 0x0003EBB9 File Offset: 0x0003CDB9
		public IndexOutOfRangeException() : base(SR.Arg_IndexOutOfRangeException)
		{
			base.HResult = -2146233080;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0003EBD1 File Offset: 0x0003CDD1
		public IndexOutOfRangeException(string message) : base(message ?? SR.Arg_IndexOutOfRangeException)
		{
			base.HResult = -2146233080;
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0003EBEE File Offset: 0x0003CDEE
		public IndexOutOfRangeException(string message, Exception innerException) : base(message ?? SR.Arg_IndexOutOfRangeException, innerException)
		{
			base.HResult = -2146233080;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private IndexOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
