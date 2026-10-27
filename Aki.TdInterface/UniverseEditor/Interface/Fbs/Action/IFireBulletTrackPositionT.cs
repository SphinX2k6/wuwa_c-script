using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BA RID: 26554
	public class IFireBulletTrackPositionT
	{
		// Token: 0x1700C51C RID: 50460
		// (get) Token: 0x0602E37F RID: 189311 RVA: 0x0064FDEB File Offset: 0x0064DFEB
		// (set) Token: 0x0602E380 RID: 189312 RVA: 0x0064FDF3 File Offset: 0x0064DFF3
		public EFireBulletType Type { get; set; }

		// Token: 0x1700C51D RID: 50461
		// (get) Token: 0x0602E381 RID: 189313 RVA: 0x0064FDFC File Offset: 0x0064DFFC
		// (set) Token: 0x0602E382 RID: 189314 RVA: 0x0064FE04 File Offset: 0x0064E004
		public long BulletId { get; set; }

		// Token: 0x1700C51E RID: 50462
		// (get) Token: 0x0602E383 RID: 189315 RVA: 0x0064FE0D File Offset: 0x0064E00D
		// (set) Token: 0x0602E384 RID: 189316 RVA: 0x0064FE15 File Offset: 0x0064E015
		public TTargetEntityUnion Launcher { get; set; }

		// Token: 0x1700C51F RID: 50463
		// (get) Token: 0x0602E385 RID: 189317 RVA: 0x0064FE1E File Offset: 0x0064E01E
		// (set) Token: 0x0602E386 RID: 189318 RVA: 0x0064FE26 File Offset: 0x0064E026
		public int PositionEntityId { get; set; }

		// Token: 0x0602E387 RID: 189319 RVA: 0x0064FE2F File Offset: 0x0064E02F
		public IFireBulletTrackPositionT()
		{
			this.Type = EFireBulletType.TrackTarget;
			this.BulletId = 0L;
			this.Launcher = null;
			this.PositionEntityId = 0;
		}
	}
}
