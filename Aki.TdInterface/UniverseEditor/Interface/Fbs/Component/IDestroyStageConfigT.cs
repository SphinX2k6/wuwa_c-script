using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005085 RID: 20613
	public class IDestroyStageConfigT
	{
		// Token: 0x17009593 RID: 38291
		// (get) Token: 0x060210EB RID: 135403 RVA: 0x00497887 File Offset: 0x00495A87
		// (set) Token: 0x060210EC RID: 135404 RVA: 0x0049788F File Offset: 0x00495A8F
		public float PerformDuration { get; set; }

		// Token: 0x17009594 RID: 38292
		// (get) Token: 0x060210ED RID: 135405 RVA: 0x00497898 File Offset: 0x00495A98
		// (set) Token: 0x060210EE RID: 135406 RVA: 0x004978A0 File Offset: 0x00495AA0
		public long BulletId { get; set; }

		// Token: 0x17009595 RID: 38293
		// (get) Token: 0x060210EF RID: 135407 RVA: 0x004978A9 File Offset: 0x00495AA9
		// (set) Token: 0x060210F0 RID: 135408 RVA: 0x004978B1 File Offset: 0x00495AB1
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009596 RID: 38294
		// (get) Token: 0x060210F1 RID: 135409 RVA: 0x004978BA File Offset: 0x00495ABA
		// (set) Token: 0x060210F2 RID: 135410 RVA: 0x004978C2 File Offset: 0x00495AC2
		public byte NullMask { get; set; }

		// Token: 0x060210F3 RID: 135411 RVA: 0x004978CB File Offset: 0x00495ACB
		public IDestroyStageConfigT()
		{
			this.PerformDuration = 0f;
			this.BulletId = 0L;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
