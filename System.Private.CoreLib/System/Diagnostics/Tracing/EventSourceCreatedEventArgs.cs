using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008F5 RID: 2293
	[NullableContext(2)]
	[Nullable(0)]
	public class EventSourceCreatedEventArgs : EventArgs
	{
		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06008CA6 RID: 36006 RVA: 0x001593A0 File Offset: 0x001575A0
		// (set) Token: 0x06008CA7 RID: 36007 RVA: 0x001593A8 File Offset: 0x001575A8
		public EventSource EventSource { get; internal set; }
	}
}
