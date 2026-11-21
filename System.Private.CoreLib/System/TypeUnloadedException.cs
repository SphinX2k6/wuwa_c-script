using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001E6 RID: 486
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class TypeUnloadedException : SystemException
	{
		// Token: 0x060024A8 RID: 9384 RVA: 0x00071E70 File Offset: 0x00070070
		public TypeUnloadedException() : base(SR.Arg_TypeUnloadedException)
		{
			base.HResult = -2146234349;
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00071E88 File Offset: 0x00070088
		public TypeUnloadedException(string message) : base(message ?? SR.Arg_TypeUnloadedException)
		{
			base.HResult = -2146234349;
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00071EA5 File Offset: 0x000700A5
		public TypeUnloadedException(string message, Exception innerException) : base(message ?? SR.Arg_TypeUnloadedException, innerException)
		{
			base.HResult = -2146234349;
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TypeUnloadedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
