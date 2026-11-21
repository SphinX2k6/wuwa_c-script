using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005EE RID: 1518
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SafeArrayRankMismatchException : SystemException
	{
		// Token: 0x06007173 RID: 29043 RVA: 0x001101EC File Offset: 0x0010E3EC
		public SafeArrayRankMismatchException() : base(SR.Arg_SafeArrayRankMismatchException)
		{
			base.HResult = -2146233032;
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x00110204 File Offset: 0x0010E404
		public SafeArrayRankMismatchException(string message) : base(message ?? SR.Arg_SafeArrayRankMismatchException)
		{
			base.HResult = -2146233032;
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x00110221 File Offset: 0x0010E421
		public SafeArrayRankMismatchException(string message, Exception inner) : base(message ?? SR.Arg_SafeArrayRankMismatchException, inner)
		{
			base.HResult = -2146233032;
		}

		// Token: 0x06007176 RID: 29046 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SafeArrayRankMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
