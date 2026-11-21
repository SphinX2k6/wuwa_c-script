using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200546D RID: 21613
	public class IBulletCreateConditionT
	{
		// Token: 0x170099B4 RID: 39348
		// (get) Token: 0x06021F39 RID: 139065 RVA: 0x004ADF04 File Offset: 0x004AC104
		// (set) Token: 0x06021F3A RID: 139066 RVA: 0x004ADF0C File Offset: 0x004AC10C
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x170099B5 RID: 39349
		// (get) Token: 0x06021F3B RID: 139067 RVA: 0x004ADF15 File Offset: 0x004AC115
		// (set) Token: 0x06021F3C RID: 139068 RVA: 0x004ADF1D File Offset: 0x004AC11D
		public long BulletId { get; set; }

		// Token: 0x06021F3D RID: 139069 RVA: 0x004ADF26 File Offset: 0x004AC126
		public IBulletCreateConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
		}
	}
}
