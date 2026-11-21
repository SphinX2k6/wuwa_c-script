using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000906 RID: 2310
	[NullableContext(2)]
	[Nullable(0)]
	[Serializable]
	public class EventSourceException : Exception
	{
		// Token: 0x06008D15 RID: 36117 RVA: 0x0015B717 File Offset: 0x00159917
		public EventSourceException() : base(SR.EventSource_ListenerWriteFailure)
		{
		}

		// Token: 0x06008D16 RID: 36118 RVA: 0x0015B724 File Offset: 0x00159924
		public EventSourceException(string message) : base(message ?? SR.EventSource_ListenerWriteFailure)
		{
		}

		// Token: 0x06008D17 RID: 36119 RVA: 0x0015B736 File Offset: 0x00159936
		public EventSourceException(string message, Exception innerException) : base(message ?? SR.EventSource_ListenerWriteFailure, innerException)
		{
		}

		// Token: 0x06008D18 RID: 36120 RVA: 0x0001E17C File Offset: 0x0001C37C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected EventSourceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008D19 RID: 36121 RVA: 0x0015B749 File Offset: 0x00159949
		internal EventSourceException(Exception innerException) : base(SR.EventSource_ListenerWriteFailure, innerException)
		{
		}
	}
}
