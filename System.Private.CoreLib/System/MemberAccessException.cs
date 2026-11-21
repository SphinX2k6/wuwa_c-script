using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000166 RID: 358
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class MemberAccessException : SystemException
	{
		// Token: 0x06001758 RID: 5976 RVA: 0x000469B1 File Offset: 0x00044BB1
		public MemberAccessException() : base(SR.Arg_AccessException)
		{
			base.HResult = -2146233062;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000469C9 File Offset: 0x00044BC9
		public MemberAccessException(string message) : base(message ?? SR.Arg_AccessException)
		{
			base.HResult = -2146233062;
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x000469E6 File Offset: 0x00044BE6
		public MemberAccessException(string message, Exception inner) : base(message ?? SR.Arg_AccessException, inner)
		{
			base.HResult = -2146233062;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MemberAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
