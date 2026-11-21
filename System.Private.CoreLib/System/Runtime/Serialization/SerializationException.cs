using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x02000526 RID: 1318
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SerializationException : SystemException
	{
		// Token: 0x06004899 RID: 18585 RVA: 0x000F1374 File Offset: 0x000EF574
		public SerializationException() : base(SR.SerializationException)
		{
			base.HResult = -2146233076;
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x000F138C File Offset: 0x000EF58C
		public SerializationException(string message) : base(message ?? SR.SerializationException)
		{
			base.HResult = -2146233076;
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x000F13A9 File Offset: 0x000EF5A9
		public SerializationException(string message, Exception innerException) : base(message ?? SR.SerializationException, innerException)
		{
			base.HResult = -2146233076;
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SerializationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
