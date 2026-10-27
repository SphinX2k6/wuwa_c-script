using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Common.Event
{
	// Token: 0x02007297 RID: 29335
	[NullableContext(1)]
	[Nullable(0)]
	internal class EventSystemCacheKeyNode : IEventSystemCacheKeyNode
	{
		// Token: 0x17009EFE RID: 40702
		// (get) Token: 0x06047EE1 RID: 294625 RVA: 0x0126E25C File Offset: 0x0126C45C
		// (set) Token: 0x06047EE2 RID: 294626 RVA: 0x0126E264 File Offset: 0x0126C464
		public object Key { get; set; }

		// Token: 0x17009EFF RID: 40703
		// (get) Token: 0x06047EE3 RID: 294627 RVA: 0x0126E26D File Offset: 0x0126C46D
		// (set) Token: 0x06047EE4 RID: 294628 RVA: 0x0126E275 File Offset: 0x0126C475
		public object Target { get; set; }

		// Token: 0x17009F00 RID: 40704
		// (get) Token: 0x06047EE5 RID: 294629 RVA: 0x0126E27E File Offset: 0x0126C47E
		// (set) Token: 0x06047EE6 RID: 294630 RVA: 0x0126E286 File Offset: 0x0126C486
		public Delegate Handle { get; set; }

		// Token: 0x17009F01 RID: 40705
		// (get) Token: 0x06047EE7 RID: 294631 RVA: 0x0126E28F File Offset: 0x0126C48F
		// (set) Token: 0x06047EE8 RID: 294632 RVA: 0x0126E297 File Offset: 0x0126C497
		public EEventName EventName { get; set; }
	}
}
