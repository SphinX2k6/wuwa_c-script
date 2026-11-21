using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x020009D7 RID: 2519
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class KeyNotFoundException : SystemException
	{
		// Token: 0x06009353 RID: 37715 RVA: 0x0016F51B File Offset: 0x0016D71B
		public KeyNotFoundException() : base(SR.Arg_KeyNotFound)
		{
			base.HResult = -2146232969;
		}

		// Token: 0x06009354 RID: 37716 RVA: 0x0016F533 File Offset: 0x0016D733
		public KeyNotFoundException(string message) : base(message ?? SR.Arg_KeyNotFound)
		{
			base.HResult = -2146232969;
		}

		// Token: 0x06009355 RID: 37717 RVA: 0x0016F550 File Offset: 0x0016D750
		public KeyNotFoundException(string message, Exception innerException) : base(message ?? SR.Arg_KeyNotFound, innerException)
		{
			base.HResult = -2146232969;
		}

		// Token: 0x06009356 RID: 37718 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected KeyNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
