using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000175 RID: 373
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class NotImplementedException : SystemException
	{
		// Token: 0x060018A7 RID: 6311 RVA: 0x0004CDB4 File Offset: 0x0004AFB4
		public NotImplementedException() : base(SR.Arg_NotImplementedException)
		{
			base.HResult = -2147467263;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0004CDCC File Offset: 0x0004AFCC
		public NotImplementedException(string message) : base(message ?? SR.Arg_NotImplementedException)
		{
			base.HResult = -2147467263;
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0004CDE9 File Offset: 0x0004AFE9
		public NotImplementedException(string message, Exception inner) : base(message ?? SR.Arg_NotImplementedException, inner)
		{
			base.HResult = -2147467263;
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected NotImplementedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
