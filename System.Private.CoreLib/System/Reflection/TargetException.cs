using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x02000782 RID: 1922
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class TargetException : ApplicationException
	{
		// Token: 0x06007B0D RID: 31501 RVA: 0x001220EF File Offset: 0x001202EF
		public TargetException() : this(null)
		{
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x001220F8 File Offset: 0x001202F8
		public TargetException(string message) : this(message, null)
		{
		}

		// Token: 0x06007B0F RID: 31503 RVA: 0x00122102 File Offset: 0x00120302
		public TargetException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232829;
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x000DFC7C File Offset: 0x000DDE7C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TargetException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
