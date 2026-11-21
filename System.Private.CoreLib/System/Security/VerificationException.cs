using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Security
{
	// Token: 0x0200026B RID: 619
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class VerificationException : SystemException
	{
		// Token: 0x06002DE3 RID: 11747 RVA: 0x00093DED File Offset: 0x00091FED
		public VerificationException() : base(SR.Verification_Exception)
		{
			base.HResult = -2146233075;
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00093E05 File Offset: 0x00092005
		public VerificationException(string message) : base(message ?? SR.Verification_Exception)
		{
			base.HResult = -2146233075;
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00093E22 File Offset: 0x00092022
		public VerificationException(string message, Exception innerException) : base(message ?? SR.Verification_Exception, innerException)
		{
			base.HResult = -2146233075;
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected VerificationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
