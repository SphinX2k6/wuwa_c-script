using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005C9 RID: 1481
	[NullableContext(2)]
	[Nullable(0)]
	[SupportedOSPlatform("windows")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class DispatchWrapper
	{
		// Token: 0x06007014 RID: 28692 RVA: 0x0010D9D4 File Offset: 0x0010BBD4
		public DispatchWrapper(object obj)
		{
			if (obj != null)
			{
				Marshal.Release(Marshal.GetIDispatchForObject(obj));
				this.WrappedObject = obj;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06007015 RID: 28693 RVA: 0x0010D9F2 File Offset: 0x0010BBF2
		public object WrappedObject { get; }
	}
}
