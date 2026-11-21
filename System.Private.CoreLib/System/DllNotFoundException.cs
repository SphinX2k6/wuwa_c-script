using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000100 RID: 256
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class DllNotFoundException : TypeLoadException
	{
		// Token: 0x0600103E RID: 4158 RVA: 0x0002E5CA File Offset: 0x0002C7CA
		public DllNotFoundException() : base(SR.Arg_DllNotFoundException)
		{
			base.HResult = -2146233052;
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0002E5E2 File Offset: 0x0002C7E2
		public DllNotFoundException(string message) : base(message ?? SR.Arg_DllNotFoundException)
		{
			base.HResult = -2146233052;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0002E5FF File Offset: 0x0002C7FF
		public DllNotFoundException(string message, Exception inner) : base(message ?? SR.Arg_DllNotFoundException, inner)
		{
			base.HResult = -2146233052;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0002E61D File Offset: 0x0002C81D
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DllNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
