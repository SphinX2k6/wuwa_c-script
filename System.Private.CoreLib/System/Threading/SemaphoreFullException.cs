using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x02000409 RID: 1033
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SemaphoreFullException : SystemException
	{
		// Token: 0x06004137 RID: 16695 RVA: 0x000D98DC File Offset: 0x000D7ADC
		public SemaphoreFullException() : base(SR.Threading_SemaphoreFullException)
		{
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x000D98E9 File Offset: 0x000D7AE9
		public SemaphoreFullException(string message) : base(message ?? SR.Threading_SemaphoreFullException)
		{
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x000D98FB File Offset: 0x000D7AFB
		public SemaphoreFullException(string message, Exception innerException) : base(message ?? SR.Threading_SemaphoreFullException, innerException)
		{
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SemaphoreFullException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
