using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008F4 RID: 2292
	public class EventCommandEventArgs : EventArgs
	{
		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06008C9F RID: 35999 RVA: 0x001592BB File Offset: 0x001574BB
		// (set) Token: 0x06008CA0 RID: 36000 RVA: 0x001592C3 File Offset: 0x001574C3
		public EventCommand Command { get; internal set; }

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06008CA1 RID: 36001 RVA: 0x001592CC File Offset: 0x001574CC
		// (set) Token: 0x06008CA2 RID: 36002 RVA: 0x001592D4 File Offset: 0x001574D4
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public IDictionary<string, string> Arguments { [return: Nullable(new byte[]
		{
			2,
			1,
			2
		})] get; internal set; }

		// Token: 0x06008CA3 RID: 36003 RVA: 0x001592DD File Offset: 0x001574DD
		public bool EnableEvent(int eventId)
		{
			if (this.Command != EventCommand.Enable && this.Command != EventCommand.Disable)
			{
				throw new InvalidOperationException();
			}
			return this.eventSource.EnableEventForDispatcher(this.dispatcher, this.eventProviderType, eventId, true);
		}

		// Token: 0x06008CA4 RID: 36004 RVA: 0x00159312 File Offset: 0x00157512
		public bool DisableEvent(int eventId)
		{
			if (this.Command != EventCommand.Enable && this.Command != EventCommand.Disable)
			{
				throw new InvalidOperationException();
			}
			return this.eventSource.EnableEventForDispatcher(this.dispatcher, this.eventProviderType, eventId, false);
		}

		// Token: 0x06008CA5 RID: 36005 RVA: 0x00159348 File Offset: 0x00157548
		internal EventCommandEventArgs(EventCommand command, IDictionary<string, string> arguments, EventSource eventSource, EventListener listener, EventProviderType eventProviderType, int perEventSourceSessionId, bool enable, EventLevel level, EventKeywords matchAnyKeyword)
		{
			this.Command = command;
			this.Arguments = arguments;
			this.eventSource = eventSource;
			this.listener = listener;
			this.eventProviderType = eventProviderType;
			this.perEventSourceSessionId = perEventSourceSessionId;
			this.enable = enable;
			this.level = level;
			this.matchAnyKeyword = matchAnyKeyword;
		}

		// Token: 0x04001FFC RID: 8188
		internal EventSource eventSource;

		// Token: 0x04001FFD RID: 8189
		internal EventDispatcher dispatcher;

		// Token: 0x04001FFE RID: 8190
		internal EventProviderType eventProviderType;

		// Token: 0x04001FFF RID: 8191
		internal EventListener listener;

		// Token: 0x04002000 RID: 8192
		internal int perEventSourceSessionId;

		// Token: 0x04002001 RID: 8193
		internal bool enable;

		// Token: 0x04002002 RID: 8194
		internal EventLevel level;

		// Token: 0x04002003 RID: 8195
		internal EventKeywords matchAnyKeyword;

		// Token: 0x04002004 RID: 8196
		internal EventCommandEventArgs nextCommand;
	}
}
