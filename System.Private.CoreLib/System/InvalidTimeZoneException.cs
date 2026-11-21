using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000153 RID: 339
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class InvalidTimeZoneException : Exception
	{
		// Token: 0x060016F8 RID: 5880 RVA: 0x00045F72 File Offset: 0x00044172
		public InvalidTimeZoneException()
		{
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00045F7A File Offset: 0x0004417A
		public InvalidTimeZoneException(string message) : base(message)
		{
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00045F83 File Offset: 0x00044183
		public InvalidTimeZoneException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0001E17C File Offset: 0x0001C37C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected InvalidTimeZoneException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
