using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading.Tasks
{
	// Token: 0x020004E2 RID: 1250
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class TaskSchedulerException : Exception
	{
		// Token: 0x0600477E RID: 18302 RVA: 0x000EE8DB File Offset: 0x000ECADB
		public TaskSchedulerException() : base(SR.TaskSchedulerException_ctor_DefaultMessage)
		{
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x000EE8E8 File Offset: 0x000ECAE8
		public TaskSchedulerException(string message) : base(message ?? SR.TaskSchedulerException_ctor_DefaultMessage)
		{
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x000EE8FA File Offset: 0x000ECAFA
		public TaskSchedulerException(Exception innerException) : base(SR.TaskSchedulerException_ctor_DefaultMessage, innerException)
		{
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x000EE908 File Offset: 0x000ECB08
		public TaskSchedulerException(string message, Exception innerException) : base(message ?? SR.TaskSchedulerException_ctor_DefaultMessage, innerException)
		{
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x0001E17C File Offset: 0x0001C37C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TaskSchedulerException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
