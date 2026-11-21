using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200018A RID: 394
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class OutOfMemoryException : SystemException
	{
		// Token: 0x060019FB RID: 6651 RVA: 0x00054EC6 File Offset: 0x000530C6
		public OutOfMemoryException() : base(OutOfMemoryException.GetDefaultMessage())
		{
			base.HResult = -2147024882;
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00054EDE File Offset: 0x000530DE
		public OutOfMemoryException(string message) : base(message ?? OutOfMemoryException.GetDefaultMessage())
		{
			base.HResult = -2147024882;
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00054EFB File Offset: 0x000530FB
		public OutOfMemoryException(string message, Exception innerException) : base(message ?? OutOfMemoryException.GetDefaultMessage(), innerException)
		{
			base.HResult = -2147024882;
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0003ECEF File Offset: 0x0003CEEF
		private static string GetDefaultMessage()
		{
			return SR.Arg_OutOfMemoryException;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected OutOfMemoryException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
