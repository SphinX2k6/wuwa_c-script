using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005428 RID: 21544
	public class IBatchBulletCasterT
	{
		// Token: 0x170098EA RID: 39146
		// (get) Token: 0x06021C2E RID: 138286 RVA: 0x004A7A20 File Offset: 0x004A5C20
		// (set) Token: 0x06021C2F RID: 138287 RVA: 0x004A7A28 File Offset: 0x004A5C28
		public int BulletIndex { get; set; }

		// Token: 0x170098EB RID: 39147
		// (get) Token: 0x06021C30 RID: 138288 RVA: 0x004A7A31 File Offset: 0x004A5C31
		// (set) Token: 0x06021C31 RID: 138289 RVA: 0x004A7A39 File Offset: 0x004A5C39
		public long BulletType { get; set; }

		// Token: 0x170098EC RID: 39148
		// (get) Token: 0x06021C32 RID: 138290 RVA: 0x004A7A42 File Offset: 0x004A5C42
		// (set) Token: 0x06021C33 RID: 138291 RVA: 0x004A7A4A File Offset: 0x004A5C4A
		public int DelayTime { get; set; }

		// Token: 0x170098ED RID: 39149
		// (get) Token: 0x06021C34 RID: 138292 RVA: 0x004A7A53 File Offset: 0x004A5C53
		// (set) Token: 0x06021C35 RID: 138293 RVA: 0x004A7A5B File Offset: 0x004A5C5B
		public int FlyTime { get; set; }

		// Token: 0x170098EE RID: 39150
		// (get) Token: 0x06021C36 RID: 138294 RVA: 0x004A7A64 File Offset: 0x004A5C64
		// (set) Token: 0x06021C37 RID: 138295 RVA: 0x004A7A6C File Offset: 0x004A5C6C
		public int FlyDistance { get; set; }

		// Token: 0x170098EF RID: 39151
		// (get) Token: 0x06021C38 RID: 138296 RVA: 0x004A7A75 File Offset: 0x004A5C75
		// (set) Token: 0x06021C39 RID: 138297 RVA: 0x004A7A7D File Offset: 0x004A5C7D
		public int WarningTime { get; set; }

		// Token: 0x170098F0 RID: 39152
		// (get) Token: 0x06021C3A RID: 138298 RVA: 0x004A7A86 File Offset: 0x004A5C86
		// (set) Token: 0x06021C3B RID: 138299 RVA: 0x004A7A8E File Offset: 0x004A5C8E
		public int WarningWidth { get; set; }

		// Token: 0x170098F1 RID: 39153
		// (get) Token: 0x06021C3C RID: 138300 RVA: 0x004A7A97 File Offset: 0x004A5C97
		// (set) Token: 0x06021C3D RID: 138301 RVA: 0x004A7A9F File Offset: 0x004A5C9F
		public byte NullMask { get; set; }

		// Token: 0x06021C3E RID: 138302 RVA: 0x004A7AA8 File Offset: 0x004A5CA8
		public IBatchBulletCasterT()
		{
			this.BulletIndex = 0;
			this.BulletType = 0L;
			this.DelayTime = 0;
			this.FlyTime = 0;
			this.FlyDistance = 0;
			this.WarningTime = 0;
			this.WarningWidth = 0;
			this.NullMask = 0;
		}
	}
}
