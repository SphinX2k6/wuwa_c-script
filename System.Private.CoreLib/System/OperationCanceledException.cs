using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System
{
	// Token: 0x02000189 RID: 393
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class OperationCanceledException : SystemException
	{
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00054E32 File Offset: 0x00053032
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x00054E3A File Offset: 0x0005303A
		public CancellationToken CancellationToken
		{
			get
			{
				return this._cancellationToken;
			}
			private set
			{
				this._cancellationToken = value;
			}
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00054E43 File Offset: 0x00053043
		public OperationCanceledException() : base(SR.OperationCanceled)
		{
			base.HResult = -2146233029;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00054E5B File Offset: 0x0005305B
		public OperationCanceledException(string message) : base(message ?? SR.OperationCanceled)
		{
			base.HResult = -2146233029;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00054E78 File Offset: 0x00053078
		public OperationCanceledException(string message, Exception innerException) : base(message ?? SR.OperationCanceled, innerException)
		{
			base.HResult = -2146233029;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00054E96 File Offset: 0x00053096
		public OperationCanceledException(CancellationToken token) : this()
		{
			this.CancellationToken = token;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00054EA5 File Offset: 0x000530A5
		public OperationCanceledException(string message, CancellationToken token) : this(message)
		{
			this.CancellationToken = token;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00054EB5 File Offset: 0x000530B5
		public OperationCanceledException(string message, Exception innerException, CancellationToken token) : this(message, innerException)
		{
			this.CancellationToken = token;
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0001CB01 File Offset: 0x0001AD01
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected OperationCanceledException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0400053A RID: 1338
		[NonSerialized]
		private CancellationToken _cancellationToken;
	}
}
