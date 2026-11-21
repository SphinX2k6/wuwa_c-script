using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Security.Cryptography
{
	// Token: 0x02000276 RID: 630
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class CryptographicException : SystemException
	{
		// Token: 0x06002E13 RID: 11795 RVA: 0x00093F73 File Offset: 0x00092173
		public CryptographicException() : base(SR.Arg_CryptographyException)
		{
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00093F80 File Offset: 0x00092180
		public CryptographicException(int hr) : base(SR.Arg_CryptographyException)
		{
			base.HResult = hr;
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x00093F94 File Offset: 0x00092194
		[NullableContext(2)]
		public CryptographicException(string message) : base(message ?? SR.Arg_CryptographyException)
		{
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00093FA6 File Offset: 0x000921A6
		[NullableContext(2)]
		public CryptographicException(string message, Exception inner) : base(message ?? SR.Arg_CryptographyException, inner)
		{
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00093FB9 File Offset: 0x000921B9
		public CryptographicException([StringSyntax("CompositeFormat")] string format, [Nullable(2)] string insert) : base(string.Format(format, insert))
		{
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CryptographicException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
