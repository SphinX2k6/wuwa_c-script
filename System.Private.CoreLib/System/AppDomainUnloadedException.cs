using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000C9 RID: 201
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class AppDomainUnloadedException : SystemException
	{
		// Token: 0x060009B8 RID: 2488 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
		public AppDomainUnloadedException() : base(SR.Arg_AppDomainUnloadedException)
		{
			base.HResult = -2146234348;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0001E100 File Offset: 0x0001C300
		public AppDomainUnloadedException(string message) : base(message ?? SR.Arg_AppDomainUnloadedException)
		{
			base.HResult = -2146234348;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0001E11D File Offset: 0x0001C31D
		public AppDomainUnloadedException(string message, Exception innerException) : base(message ?? SR.Arg_AppDomainUnloadedException, innerException)
		{
			base.HResult = -2146234348;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AppDomainUnloadedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
