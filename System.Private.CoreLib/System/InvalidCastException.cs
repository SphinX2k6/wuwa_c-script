using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000150 RID: 336
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class InvalidCastException : SystemException
	{
		// Token: 0x060016EB RID: 5867 RVA: 0x00045E60 File Offset: 0x00044060
		public InvalidCastException() : base(SR.Arg_InvalidCastException)
		{
			base.HResult = -2147467262;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00045E78 File Offset: 0x00044078
		public InvalidCastException(string message) : base(message ?? SR.Arg_InvalidCastException)
		{
			base.HResult = -2147467262;
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00045E95 File Offset: 0x00044095
		public InvalidCastException(string message, Exception innerException) : base(message ?? SR.Arg_InvalidCastException, innerException)
		{
			base.HResult = -2147467262;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00045EB3 File Offset: 0x000440B3
		public InvalidCastException(string message, int errorCode) : base(message ?? SR.Arg_InvalidCastException)
		{
			base.HResult = errorCode;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected InvalidCastException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
