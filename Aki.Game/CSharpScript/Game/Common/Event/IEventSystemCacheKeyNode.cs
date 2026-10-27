using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Common.Event
{
	// Token: 0x02007296 RID: 29334
	[NullableContext(1)]
	internal interface IEventSystemCacheKeyNode
	{
		// Token: 0x17009EFA RID: 40698
		// (get) Token: 0x06047ED9 RID: 294617
		// (set) Token: 0x06047EDA RID: 294618
		object Key { get; set; }

		// Token: 0x17009EFB RID: 40699
		// (get) Token: 0x06047EDB RID: 294619
		// (set) Token: 0x06047EDC RID: 294620
		object Target { get; set; }

		// Token: 0x17009EFC RID: 40700
		// (get) Token: 0x06047EDD RID: 294621
		// (set) Token: 0x06047EDE RID: 294622
		Delegate Handle { get; set; }

		// Token: 0x17009EFD RID: 40701
		// (get) Token: 0x06047EDF RID: 294623
		// (set) Token: 0x06047EE0 RID: 294624
		EEventName EventName { get; set; }
	}
}
