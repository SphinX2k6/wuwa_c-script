using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x02000749 RID: 1865
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class InvalidFilterCriteriaException : ApplicationException
	{
		// Token: 0x0600790F RID: 30991 RVA: 0x0011F55F File Offset: 0x0011D75F
		public InvalidFilterCriteriaException() : this(SR.Arg_InvalidFilterCriteriaException)
		{
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x0011F56C File Offset: 0x0011D76C
		public InvalidFilterCriteriaException(string message) : this(message, null)
		{
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x0011F576 File Offset: 0x0011D776
		public InvalidFilterCriteriaException(string message, Exception inner) : base(message ?? SR.Arg_InvalidFilterCriteriaException, inner)
		{
			base.HResult = -2146232831;
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x000DFC7C File Offset: 0x000DDE7C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected InvalidFilterCriteriaException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
