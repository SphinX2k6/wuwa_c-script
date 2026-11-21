using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000600 RID: 1536
	[NullableContext(1)]
	[Nullable(0)]
	[SupportedOSPlatform("windows")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ComEventsHelper
	{
		// Token: 0x060071B3 RID: 29107 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		public static void Combine(object rcw, Guid iid, int dispid, Delegate d)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		public static Delegate Remove(object rcw, Guid iid, int dispid, Delegate d)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
		}
	}
}
