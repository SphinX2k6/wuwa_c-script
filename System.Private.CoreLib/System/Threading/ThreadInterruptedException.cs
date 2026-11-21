using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x0200041E RID: 1054
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ThreadInterruptedException : SystemException
	{
		// Token: 0x060041B0 RID: 16816 RVA: 0x000DB168 File Offset: 0x000D9368
		public ThreadInterruptedException() : base(ThreadInterruptedException.GetDefaultMessage())
		{
			base.HResult = -2146233063;
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x000DB180 File Offset: 0x000D9380
		public ThreadInterruptedException(string message) : base(message ?? ThreadInterruptedException.GetDefaultMessage())
		{
			base.HResult = -2146233063;
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x000DB19D File Offset: 0x000D939D
		public ThreadInterruptedException(string message, Exception innerException) : base(message ?? ThreadInterruptedException.GetDefaultMessage(), innerException)
		{
			base.HResult = -2146233063;
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x000DB1BB File Offset: 0x000D93BB
		private static string GetDefaultMessage()
		{
			return SR.Threading_ThreadInterrupted;
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ThreadInterruptedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
