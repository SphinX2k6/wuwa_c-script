using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x02000800 RID: 2048
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class IOException : SystemException
	{
		// Token: 0x06008333 RID: 33587 RVA: 0x00138CE8 File Offset: 0x00136EE8
		public IOException() : base(SR.Arg_IOException)
		{
			base.HResult = -2146232800;
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x00138D00 File Offset: 0x00136F00
		public IOException(string message) : base(message)
		{
			base.HResult = -2146232800;
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x00138D14 File Offset: 0x00136F14
		public IOException(string message, int hresult) : base(message)
		{
			base.HResult = hresult;
		}

		// Token: 0x06008336 RID: 33590 RVA: 0x00138D24 File Offset: 0x00136F24
		public IOException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232800;
		}

		// Token: 0x06008337 RID: 33591 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected IOException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
