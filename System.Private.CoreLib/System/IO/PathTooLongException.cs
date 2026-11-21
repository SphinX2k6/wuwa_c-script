using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x02000808 RID: 2056
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class PathTooLongException : IOException
	{
		// Token: 0x060083B1 RID: 33713 RVA: 0x0013B4C0 File Offset: 0x001396C0
		public PathTooLongException() : base(SR.IO_PathTooLong)
		{
			base.HResult = -2147024690;
		}

		// Token: 0x060083B2 RID: 33714 RVA: 0x0013B4D8 File Offset: 0x001396D8
		public PathTooLongException(string message) : base(message ?? SR.IO_PathTooLong)
		{
			base.HResult = -2147024690;
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x0013B4F5 File Offset: 0x001396F5
		public PathTooLongException(string message, Exception innerException) : base(message ?? SR.IO_PathTooLong, innerException)
		{
			base.HResult = -2147024690;
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x00133D57 File Offset: 0x00131F57
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected PathTooLongException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
