using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Resources
{
	// Token: 0x0200027C RID: 636
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	public class MissingManifestResourceException : SystemException
	{
		// Token: 0x06002E3A RID: 11834 RVA: 0x000949F4 File Offset: 0x00092BF4
		public MissingManifestResourceException() : base(SR.Arg_MissingManifestResourceException)
		{
			base.HResult = -2146233038;
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x00094A0C File Offset: 0x00092C0C
		public MissingManifestResourceException(string message) : base(message ?? SR.Arg_MissingManifestResourceException)
		{
			base.HResult = -2146233038;
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00094A29 File Offset: 0x00092C29
		public MissingManifestResourceException(string message, Exception inner) : base(message ?? SR.Arg_MissingManifestResourceException, inner)
		{
			base.HResult = -2146233038;
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		protected MissingManifestResourceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
