using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200525C RID: 21084
	public class IFireBulletAddBuffT
	{
		// Token: 0x17009A6F RID: 39535
		// (get) Token: 0x060224C9 RID: 140489 RVA: 0x004C1759 File Offset: 0x004BF959
		// (set) Token: 0x060224CA RID: 140490 RVA: 0x004C1761 File Offset: 0x004BF961
		public EBuffProducerMode Type { get; set; }

		// Token: 0x17009A70 RID: 39536
		// (get) Token: 0x060224CB RID: 140491 RVA: 0x004C176A File Offset: 0x004BF96A
		// (set) Token: 0x060224CC RID: 140492 RVA: 0x004C1772 File Offset: 0x004BF972
		public long BulletId { get; set; }

		// Token: 0x17009A71 RID: 39537
		// (get) Token: 0x060224CD RID: 140493 RVA: 0x004C177B File Offset: 0x004BF97B
		// (set) Token: 0x060224CE RID: 140494 RVA: 0x004C1783 File Offset: 0x004BF983
		public IVectorInfoT BulletOffset { get; set; }

		// Token: 0x060224CF RID: 140495 RVA: 0x004C178C File Offset: 0x004BF98C
		public IFireBulletAddBuffT()
		{
			this.Type = EBuffProducerMode.Immediate;
			this.BulletId = 0L;
			this.BulletOffset = null;
		}
	}
}
