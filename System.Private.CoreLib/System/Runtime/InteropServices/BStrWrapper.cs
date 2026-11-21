using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005AC RID: 1452
	[NullableContext(2)]
	[Nullable(0)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class BStrWrapper
	{
		// Token: 0x06006FC2 RID: 28610 RVA: 0x0010D3F0 File Offset: 0x0010B5F0
		public BStrWrapper(string value)
		{
			this.WrappedObject = value;
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x0010D3FF File Offset: 0x0010B5FF
		public BStrWrapper(object value)
		{
			this.WrappedObject = (string)value;
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06006FC4 RID: 28612 RVA: 0x0010D413 File Offset: 0x0010B613
		public string WrappedObject { get; }
	}
}
