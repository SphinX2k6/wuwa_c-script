using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading.Tasks
{
	// Token: 0x020004C6 RID: 1222
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class TaskCanceledException : OperationCanceledException
	{
		// Token: 0x0600468F RID: 18063 RVA: 0x000EC3A9 File Offset: 0x000EA5A9
		public TaskCanceledException() : base(SR.TaskCanceledException_ctor_DefaultMessage)
		{
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x000EC3B6 File Offset: 0x000EA5B6
		public TaskCanceledException(string message) : base(message ?? SR.TaskCanceledException_ctor_DefaultMessage)
		{
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x000EC3C8 File Offset: 0x000EA5C8
		public TaskCanceledException(string message, Exception innerException) : base(message ?? SR.TaskCanceledException_ctor_DefaultMessage, innerException)
		{
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x000EC3DB File Offset: 0x000EA5DB
		public TaskCanceledException(string message, Exception innerException, CancellationToken token) : base(message ?? SR.TaskCanceledException_ctor_DefaultMessage, innerException, token)
		{
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x000EC3EF File Offset: 0x000EA5EF
		public TaskCanceledException(Task task) : base(SR.TaskCanceledException_ctor_DefaultMessage, (task != null) ? task.CancellationToken : CancellationToken.None)
		{
			this._canceledTask = task;
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x000EC413 File Offset: 0x000EA613
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TaskCanceledException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06004695 RID: 18069 RVA: 0x000EC41D File Offset: 0x000EA61D
		public Task Task
		{
			get
			{
				return this._canceledTask;
			}
		}

		// Token: 0x0400108D RID: 4237
		[NonSerialized]
		private readonly Task _canceledTask;
	}
}
