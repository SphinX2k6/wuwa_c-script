using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C4 RID: 22468
	public class IFireBulletAddBuffT
	{
		// Token: 0x1700A26B RID: 41579
		// (get) Token: 0x0602445F RID: 148575 RVA: 0x004FC21D File Offset: 0x004FA41D
		// (set) Token: 0x06024460 RID: 148576 RVA: 0x004FC225 File Offset: 0x004FA425
		public EBuffProducerMode Type { get; set; }

		// Token: 0x1700A26C RID: 41580
		// (get) Token: 0x06024461 RID: 148577 RVA: 0x004FC22E File Offset: 0x004FA42E
		// (set) Token: 0x06024462 RID: 148578 RVA: 0x004FC236 File Offset: 0x004FA436
		public long BulletId { get; set; }

		// Token: 0x1700A26D RID: 41581
		// (get) Token: 0x06024463 RID: 148579 RVA: 0x004FC23F File Offset: 0x004FA43F
		// (set) Token: 0x06024464 RID: 148580 RVA: 0x004FC247 File Offset: 0x004FA447
		public IVectorInfoT BulletOffset { get; set; }

		// Token: 0x06024465 RID: 148581 RVA: 0x004FC250 File Offset: 0x004FA450
		public IFireBulletAddBuffT()
		{
			this.Type = EBuffProducerMode.Immediate;
			this.BulletId = 0L;
			this.BulletOffset = null;
		}
	}
}
