using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000E2 RID: 226
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class CannotUnloadAppDomainException : SystemException
	{
		// Token: 0x06000B61 RID: 2913 RVA: 0x00020E20 File Offset: 0x0001F020
		public CannotUnloadAppDomainException() : base(SR.Arg_CannotUnloadAppDomainException)
		{
			base.HResult = -2146234347;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00020E38 File Offset: 0x0001F038
		public CannotUnloadAppDomainException(string message) : base(message ?? SR.Arg_CannotUnloadAppDomainException)
		{
			base.HResult = -2146234347;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00020E55 File Offset: 0x0001F055
		public CannotUnloadAppDomainException(string message, Exception innerException) : base(message ?? SR.Arg_CannotUnloadAppDomainException, innerException)
		{
			base.HResult = -2146234347;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
