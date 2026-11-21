using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005F1 RID: 1521
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SEHException : ExternalException
	{
		// Token: 0x0600718E RID: 29070 RVA: 0x001106B8 File Offset: 0x0010E8B8
		public SEHException()
		{
			base.HResult = -2147467259;
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x001106CB File Offset: 0x0010E8CB
		public SEHException(string message) : base(message)
		{
			base.HResult = -2147467259;
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x001106DF File Offset: 0x0010E8DF
		public SEHException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2147467259;
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x0010D63B File Offset: 0x0010B83B
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SEHException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool CanResume()
		{
			return false;
		}
	}
}
