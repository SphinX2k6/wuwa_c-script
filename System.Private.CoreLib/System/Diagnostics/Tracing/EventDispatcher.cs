using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008FF RID: 2303
	internal sealed class EventDispatcher
	{
		// Token: 0x06008CF0 RID: 36080 RVA: 0x00159859 File Offset: 0x00157A59
		internal EventDispatcher(EventDispatcher next, bool[] eventEnabled, EventListener listener)
		{
			this.m_Next = next;
			this.m_EventEnabled = eventEnabled;
			this.m_Listener = listener;
		}

		// Token: 0x04002030 RID: 8240
		internal readonly EventListener m_Listener;

		// Token: 0x04002031 RID: 8241
		internal bool[] m_EventEnabled;

		// Token: 0x04002032 RID: 8242
		internal EventDispatcher m_Next;
	}
}
