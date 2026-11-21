using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001D4 RID: 468
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class TimeZoneNotFoundException : Exception
	{
		// Token: 0x060023A1 RID: 9121 RVA: 0x00045F72 File Offset: 0x00044172
		public TimeZoneNotFoundException()
		{
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x00045F7A File Offset: 0x0004417A
		public TimeZoneNotFoundException(string message) : base(message)
		{
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x00045F83 File Offset: 0x00044183
		public TimeZoneNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0001E17C File Offset: 0x0001C37C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TimeZoneNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
