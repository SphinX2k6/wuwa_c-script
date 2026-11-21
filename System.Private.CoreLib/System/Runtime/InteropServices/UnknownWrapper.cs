using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005F6 RID: 1526
	[NullableContext(2)]
	[Nullable(0)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class UnknownWrapper
	{
		// Token: 0x0600719B RID: 29083 RVA: 0x00110731 File Offset: 0x0010E931
		public UnknownWrapper(object obj)
		{
			this.WrappedObject = obj;
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x0600719C RID: 29084 RVA: 0x00110740 File Offset: 0x0010E940
		public object WrappedObject { get; }
	}
}
