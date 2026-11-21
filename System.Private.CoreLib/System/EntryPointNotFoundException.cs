using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000104 RID: 260
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class EntryPointNotFoundException : TypeLoadException
	{
		// Token: 0x0600112E RID: 4398 RVA: 0x00030A5E File Offset: 0x0002EC5E
		public EntryPointNotFoundException() : base(SR.Arg_EntryPointNotFoundException)
		{
			base.HResult = -2146233053;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00030A76 File Offset: 0x0002EC76
		public EntryPointNotFoundException(string message) : base(message ?? SR.Arg_EntryPointNotFoundException)
		{
			base.HResult = -2146233053;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00030A93 File Offset: 0x0002EC93
		public EntryPointNotFoundException(string message, Exception inner) : base(message ?? SR.Arg_EntryPointNotFoundException, inner)
		{
			base.HResult = -2146233053;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0002E61D File Offset: 0x0002C81D
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
