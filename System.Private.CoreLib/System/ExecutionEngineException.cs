using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000109 RID: 265
	[NullableContext(2)]
	[Nullable(0)]
	[Obsolete("ExecutionEngineException previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class ExecutionEngineException : SystemException
	{
		// Token: 0x0600113C RID: 4412 RVA: 0x00030ABD File Offset: 0x0002ECBD
		public ExecutionEngineException() : base(SR.Arg_ExecutionEngineException)
		{
			base.HResult = -2146233082;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00030AD5 File Offset: 0x0002ECD5
		public ExecutionEngineException(string message) : base(message ?? SR.Arg_ExecutionEngineException)
		{
			base.HResult = -2146233082;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00030AF2 File Offset: 0x0002ECF2
		public ExecutionEngineException(string message, Exception innerException) : base(message ?? SR.Arg_ExecutionEngineException, innerException)
		{
			base.HResult = -2146233082;
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0001CB01 File Offset: 0x0001AD01
		private ExecutionEngineException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
