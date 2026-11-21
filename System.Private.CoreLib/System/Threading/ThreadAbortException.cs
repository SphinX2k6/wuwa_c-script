using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x02000415 RID: 1045
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class ThreadAbortException : SystemException
	{
		// Token: 0x06004193 RID: 16787 RVA: 0x000DAD98 File Offset: 0x000D8F98
		internal ThreadAbortException()
		{
			base.HResult = -2146233040;
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06004194 RID: 16788 RVA: 0x0001A4BA File Offset: 0x000186BA
		public object ExceptionState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private ThreadAbortException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
