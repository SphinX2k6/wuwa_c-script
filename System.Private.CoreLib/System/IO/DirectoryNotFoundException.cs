using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x020007E3 RID: 2019
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class DirectoryNotFoundException : IOException
	{
		// Token: 0x06008194 RID: 33172 RVA: 0x00133D04 File Offset: 0x00131F04
		public DirectoryNotFoundException() : base(SR.Arg_DirectoryNotFoundException)
		{
			base.HResult = -2147024893;
		}

		// Token: 0x06008195 RID: 33173 RVA: 0x00133D1C File Offset: 0x00131F1C
		public DirectoryNotFoundException(string message) : base(message ?? SR.Arg_DirectoryNotFoundException)
		{
			base.HResult = -2147024893;
		}

		// Token: 0x06008196 RID: 33174 RVA: 0x00133D39 File Offset: 0x00131F39
		public DirectoryNotFoundException(string message, Exception innerException) : base(message ?? SR.Arg_DirectoryNotFoundException, innerException)
		{
			base.HResult = -2147024893;
		}

		// Token: 0x06008197 RID: 33175 RVA: 0x00133D57 File Offset: 0x00131F57
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DirectoryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
