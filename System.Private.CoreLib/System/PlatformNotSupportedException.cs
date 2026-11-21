using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000190 RID: 400
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class PlatformNotSupportedException : NotSupportedException
	{
		// Token: 0x06001A10 RID: 6672 RVA: 0x00055734 File Offset: 0x00053934
		public PlatformNotSupportedException() : base(SR.Arg_PlatformNotSupported)
		{
			base.HResult = -2146233031;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0005574C File Offset: 0x0005394C
		public PlatformNotSupportedException(string message) : base(message ?? SR.Arg_PlatformNotSupported)
		{
			base.HResult = -2146233031;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00055769 File Offset: 0x00053969
		public PlatformNotSupportedException(string message, Exception inner) : base(message ?? SR.Arg_PlatformNotSupported, inner)
		{
			base.HResult = -2146233031;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00055787 File Offset: 0x00053987
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
