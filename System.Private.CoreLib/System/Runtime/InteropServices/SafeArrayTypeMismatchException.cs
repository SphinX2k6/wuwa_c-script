using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005EF RID: 1519
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SafeArrayTypeMismatchException : SystemException
	{
		// Token: 0x06007177 RID: 29047 RVA: 0x0011023F File Offset: 0x0010E43F
		public SafeArrayTypeMismatchException() : base(SR.Arg_SafeArrayTypeMismatchException)
		{
			base.HResult = -2146233037;
		}

		// Token: 0x06007178 RID: 29048 RVA: 0x00110257 File Offset: 0x0010E457
		public SafeArrayTypeMismatchException(string message) : base(message ?? SR.Arg_SafeArrayTypeMismatchException)
		{
			base.HResult = -2146233037;
		}

		// Token: 0x06007179 RID: 29049 RVA: 0x00110274 File Offset: 0x0010E474
		public SafeArrayTypeMismatchException(string message, Exception inner) : base(message ?? SR.Arg_SafeArrayTypeMismatchException, inner)
		{
			base.HResult = -2146233037;
		}

		// Token: 0x0600717A RID: 29050 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SafeArrayTypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
