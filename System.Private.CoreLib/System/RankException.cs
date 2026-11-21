using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200019B RID: 411
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class RankException : SystemException
	{
		// Token: 0x06001A89 RID: 6793 RVA: 0x00056827 File Offset: 0x00054A27
		public RankException() : base(SR.Arg_RankException)
		{
			base.HResult = -2146233065;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0005683F File Offset: 0x00054A3F
		public RankException(string message) : base(message ?? SR.Arg_RankException)
		{
			base.HResult = -2146233065;
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0005685C File Offset: 0x00054A5C
		public RankException(string message, Exception innerException) : base(message ?? SR.Arg_RankException, innerException)
		{
			base.HResult = -2146233065;
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected RankException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
