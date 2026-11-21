using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000178 RID: 376
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class NullReferenceException : SystemException
	{
		// Token: 0x060018B3 RID: 6323 RVA: 0x0004CF0D File Offset: 0x0004B10D
		public NullReferenceException() : base(SR.Arg_NullReferenceException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0004CF25 File Offset: 0x0004B125
		public NullReferenceException(string message) : base(message ?? SR.Arg_NullReferenceException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0004CF42 File Offset: 0x0004B142
		public NullReferenceException(string message, Exception innerException) : base(message ?? SR.Arg_NullReferenceException, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected NullReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
