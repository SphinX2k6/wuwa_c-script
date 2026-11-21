using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200014A RID: 330
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class InsufficientMemoryException : OutOfMemoryException
	{
		// Token: 0x060013EF RID: 5103 RVA: 0x0003EC9C File Offset: 0x0003CE9C
		public InsufficientMemoryException() : base(InsufficientMemoryException.GetDefaultMessage())
		{
			base.HResult = -2146233027;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0003ECB4 File Offset: 0x0003CEB4
		public InsufficientMemoryException(string message) : base(message ?? InsufficientMemoryException.GetDefaultMessage())
		{
			base.HResult = -2146233027;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0003ECD1 File Offset: 0x0003CED1
		public InsufficientMemoryException(string message, Exception innerException) : base(message ?? InsufficientMemoryException.GetDefaultMessage(), innerException)
		{
			base.HResult = -2146233027;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0003ECEF File Offset: 0x0003CEEF
		private static string GetDefaultMessage()
		{
			return SR.Arg_OutOfMemoryException;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0003ECF6 File Offset: 0x0003CEF6
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private InsufficientMemoryException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
