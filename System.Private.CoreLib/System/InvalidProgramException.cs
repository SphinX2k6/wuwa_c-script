using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000152 RID: 338
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class InvalidProgramException : SystemException
	{
		// Token: 0x060016F4 RID: 5876 RVA: 0x00045F1F File Offset: 0x0004411F
		public InvalidProgramException() : base(SR.InvalidProgram_Default)
		{
			base.HResult = -2146233030;
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00045F37 File Offset: 0x00044137
		public InvalidProgramException(string message) : base(message ?? SR.InvalidProgram_Default)
		{
			base.HResult = -2146233030;
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00045F54 File Offset: 0x00044154
		public InvalidProgramException(string message, Exception inner) : base(message ?? SR.InvalidProgram_Default, inner)
		{
			base.HResult = -2146233030;
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private InvalidProgramException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
