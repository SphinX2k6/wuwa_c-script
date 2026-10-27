using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040EC RID: 16620
	public class IRollBlockLaunchMethodInteractT
	{
		// Token: 0x17007526 RID: 29990
		// (get) Token: 0x0601838F RID: 99215 RVA: 0x0037CDB8 File Offset: 0x0037AFB8
		// (set) Token: 0x06018390 RID: 99216 RVA: 0x0037CDC0 File Offset: 0x0037AFC0
		public ERollBlockLaunchMethod Type { get; set; }

		// Token: 0x17007527 RID: 29991
		// (get) Token: 0x06018391 RID: 99217 RVA: 0x0037CDC9 File Offset: 0x0037AFC9
		// (set) Token: 0x06018392 RID: 99218 RVA: 0x0037CDD1 File Offset: 0x0037AFD1
		public int TargetId { get; set; }

		// Token: 0x06018393 RID: 99219 RVA: 0x0037CDDA File Offset: 0x0037AFDA
		public IRollBlockLaunchMethodInteractT()
		{
			this.Type = ERollBlockLaunchMethod.Interact;
			this.TargetId = 0;
		}
	}
}
