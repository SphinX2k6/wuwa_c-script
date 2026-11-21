using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BF3 RID: 19443
	public class IEffectConfigMonsterDeathT
	{
		// Token: 0x1700899E RID: 35230
		// (get) Token: 0x0601DB20 RID: 121632 RVA: 0x0042A970 File Offset: 0x00428B70
		// (set) Token: 0x0601DB21 RID: 121633 RVA: 0x0042A978 File Offset: 0x00428B78
		public EEffectConfigType Type { get; set; }

		// Token: 0x1700899F RID: 35231
		// (get) Token: 0x0601DB22 RID: 121634 RVA: 0x0042A981 File Offset: 0x00428B81
		// (set) Token: 0x0601DB23 RID: 121635 RVA: 0x0042A989 File Offset: 0x00428B89
		public string ParticleEffect { get; set; }

		// Token: 0x170089A0 RID: 35232
		// (get) Token: 0x0601DB24 RID: 121636 RVA: 0x0042A992 File Offset: 0x00428B92
		// (set) Token: 0x0601DB25 RID: 121637 RVA: 0x0042A99A File Offset: 0x00428B9A
		public string MaterialEffect { get; set; }

		// Token: 0x170089A1 RID: 35233
		// (get) Token: 0x0601DB26 RID: 121638 RVA: 0x0042A9A3 File Offset: 0x00428BA3
		// (set) Token: 0x0601DB27 RID: 121639 RVA: 0x0042A9AB File Offset: 0x00428BAB
		public EMonsterDeathEffectEndRule EndRule { get; set; }

		// Token: 0x170089A2 RID: 35234
		// (get) Token: 0x0601DB28 RID: 121640 RVA: 0x0042A9B4 File Offset: 0x00428BB4
		// (set) Token: 0x0601DB29 RID: 121641 RVA: 0x0042A9BC File Offset: 0x00428BBC
		public byte NullMask { get; set; }

		// Token: 0x0601DB2A RID: 121642 RVA: 0x0042A9C5 File Offset: 0x00428BC5
		public IEffectConfigMonsterDeathT()
		{
			this.Type = EEffectConfigType.Death;
			this.ParticleEffect = null;
			this.MaterialEffect = null;
			this.EndRule = EMonsterDeathEffectEndRule.Any;
			this.NullMask = 0;
		}
	}
}
