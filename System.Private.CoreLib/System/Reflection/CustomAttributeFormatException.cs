using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x0200073B RID: 1851
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class CustomAttributeFormatException : FormatException
	{
		// Token: 0x060078CC RID: 30924 RVA: 0x0011ED50 File Offset: 0x0011CF50
		public CustomAttributeFormatException() : this(SR.Arg_CustomAttributeFormatException)
		{
		}

		// Token: 0x060078CD RID: 30925 RVA: 0x0011ED5D File Offset: 0x0011CF5D
		public CustomAttributeFormatException(string message) : this(message, null)
		{
		}

		// Token: 0x060078CE RID: 30926 RVA: 0x0011ED67 File Offset: 0x0011CF67
		public CustomAttributeFormatException(string message, Exception inner) : base(message ?? SR.Arg_CustomAttributeFormatException, inner)
		{
			base.HResult = -2146232827;
		}

		// Token: 0x060078CF RID: 30927 RVA: 0x0011ED85 File Offset: 0x0011CF85
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CustomAttributeFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
