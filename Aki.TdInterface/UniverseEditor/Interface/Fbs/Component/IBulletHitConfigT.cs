using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F41 RID: 20289
	public class IBulletHitConfigT
	{
		// Token: 0x1700923A RID: 37434
		// (get) Token: 0x060201FD RID: 131581 RVA: 0x0047837E File Offset: 0x0047657E
		// (set) Token: 0x060201FE RID: 131582 RVA: 0x00478386 File Offset: 0x00476586
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x1700923B RID: 37435
		// (get) Token: 0x060201FF RID: 131583 RVA: 0x0047838F File Offset: 0x0047658F
		// (set) Token: 0x06020200 RID: 131584 RVA: 0x00478397 File Offset: 0x00476597
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x1700923C RID: 37436
		// (get) Token: 0x06020201 RID: 131585 RVA: 0x004783A0 File Offset: 0x004765A0
		// (set) Token: 0x06020202 RID: 131586 RVA: 0x004783A8 File Offset: 0x004765A8
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x06020203 RID: 131587 RVA: 0x004783B1 File Offset: 0x004765B1
		public IBulletHitConfigT()
		{
			this.HitBullet = null;
			this.AttackerHitTimeScaleRatio = null;
			this.VictimHitTimeScaleRatio = null;
		}
	}
}
