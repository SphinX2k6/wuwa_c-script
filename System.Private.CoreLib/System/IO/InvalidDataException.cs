using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x020007FF RID: 2047
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class InvalidDataException : SystemException
	{
		// Token: 0x0600832F RID: 33583 RVA: 0x00138CB6 File Offset: 0x00136EB6
		public InvalidDataException() : base(SR.GenericInvalidData)
		{
		}

		// Token: 0x06008330 RID: 33584 RVA: 0x00138CC3 File Offset: 0x00136EC3
		public InvalidDataException(string message) : base(message ?? SR.GenericInvalidData)
		{
		}

		// Token: 0x06008331 RID: 33585 RVA: 0x00138CD5 File Offset: 0x00136ED5
		public InvalidDataException(string message, Exception innerException) : base(message ?? SR.GenericInvalidData, innerException)
		{
		}

		// Token: 0x06008332 RID: 33586 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private InvalidDataException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
