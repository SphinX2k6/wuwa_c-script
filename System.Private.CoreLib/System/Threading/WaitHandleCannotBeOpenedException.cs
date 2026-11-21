using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x0200045D RID: 1117
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class WaitHandleCannotBeOpenedException : ApplicationException
	{
		// Token: 0x0600431D RID: 17181 RVA: 0x000DFC29 File Offset: 0x000DDE29
		public WaitHandleCannotBeOpenedException() : base(SR.Threading_WaitHandleCannotBeOpenedException)
		{
			base.HResult = -2146233044;
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x000DFC41 File Offset: 0x000DDE41
		public WaitHandleCannotBeOpenedException(string message) : base(message ?? SR.Threading_WaitHandleCannotBeOpenedException)
		{
			base.HResult = -2146233044;
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x000DFC5E File Offset: 0x000DDE5E
		public WaitHandleCannotBeOpenedException(string message, Exception innerException) : base(message ?? SR.Threading_WaitHandleCannotBeOpenedException, innerException)
		{
			base.HResult = -2146233044;
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x000DFC7C File Offset: 0x000DDE7C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
