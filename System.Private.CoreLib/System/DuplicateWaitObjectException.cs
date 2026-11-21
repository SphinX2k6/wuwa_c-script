using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000102 RID: 258
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class DuplicateWaitObjectException : ArgumentException
	{
		// Token: 0x06001126 RID: 4390 RVA: 0x000309E5 File Offset: 0x0002EBE5
		public DuplicateWaitObjectException() : base(SR.Arg_DuplicateWaitObjectException)
		{
			base.HResult = -2146233047;
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x000309FD File Offset: 0x0002EBFD
		public DuplicateWaitObjectException(string parameterName) : base(SR.Arg_DuplicateWaitObjectException, parameterName)
		{
			base.HResult = -2146233047;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00030A16 File Offset: 0x0002EC16
		public DuplicateWaitObjectException(string parameterName, string message) : base(message ?? SR.Arg_DuplicateWaitObjectException, parameterName)
		{
			base.HResult = -2146233047;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00030A34 File Offset: 0x0002EC34
		public DuplicateWaitObjectException(string message, Exception innerException) : base(message ?? SR.Arg_DuplicateWaitObjectException, innerException)
		{
			base.HResult = -2146233047;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0001E5B9 File Offset: 0x0001C7B9
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DuplicateWaitObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
