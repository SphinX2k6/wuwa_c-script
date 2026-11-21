using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005CD RID: 1485
	[NullableContext(1)]
	[Nullable(0)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class ErrorWrapper
	{
		// Token: 0x0600701A RID: 28698 RVA: 0x0010DA28 File Offset: 0x0010BC28
		public ErrorWrapper(int errorCode)
		{
			this.ErrorCode = errorCode;
		}

		// Token: 0x0600701B RID: 28699 RVA: 0x0010DA38 File Offset: 0x0010BC38
		public ErrorWrapper(object errorCode)
		{
			if (errorCode is int)
			{
				int num = (int)errorCode;
				this.ErrorCode = num;
				return;
			}
			throw new ArgumentException(SR.Arg_MustBeInt32, "errorCode");
		}

		// Token: 0x0600701C RID: 28700 RVA: 0x0010DA73 File Offset: 0x0010BC73
		public ErrorWrapper(Exception e)
		{
			this.ErrorCode = Marshal.GetHRForException(e);
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x0600701D RID: 28701 RVA: 0x0010DA87 File Offset: 0x0010BC87
		public int ErrorCode { get; }
	}
}
