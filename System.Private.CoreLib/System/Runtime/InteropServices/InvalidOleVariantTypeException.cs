using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005DC RID: 1500
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class InvalidOleVariantTypeException : SystemException
	{
		// Token: 0x06007041 RID: 28737 RVA: 0x0010DC64 File Offset: 0x0010BE64
		public InvalidOleVariantTypeException() : base(SR.Arg_InvalidOleVariantTypeException)
		{
			base.HResult = -2146233039;
		}

		// Token: 0x06007042 RID: 28738 RVA: 0x0010DC7C File Offset: 0x0010BE7C
		public InvalidOleVariantTypeException(string message) : base(message ?? SR.Arg_InvalidOleVariantTypeException)
		{
			base.HResult = -2146233039;
		}

		// Token: 0x06007043 RID: 28739 RVA: 0x0010DC99 File Offset: 0x0010BE99
		public InvalidOleVariantTypeException(string message, Exception inner) : base(message ?? SR.Arg_InvalidOleVariantTypeException, inner)
		{
			base.HResult = -2146233039;
		}

		// Token: 0x06007044 RID: 28740 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected InvalidOleVariantTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
