using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005DB RID: 1499
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class InvalidComObjectException : SystemException
	{
		// Token: 0x0600703D RID: 28733 RVA: 0x0010DC11 File Offset: 0x0010BE11
		public InvalidComObjectException() : base(SR.Arg_InvalidComObjectException)
		{
			base.HResult = -2146233049;
		}

		// Token: 0x0600703E RID: 28734 RVA: 0x0010DC29 File Offset: 0x0010BE29
		public InvalidComObjectException(string message) : base(message ?? SR.Arg_InvalidComObjectException)
		{
			base.HResult = -2146233049;
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x0010DC46 File Offset: 0x0010BE46
		public InvalidComObjectException(string message, Exception inner) : base(message ?? SR.Arg_InvalidComObjectException, inner)
		{
			base.HResult = -2146233049;
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected InvalidComObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
