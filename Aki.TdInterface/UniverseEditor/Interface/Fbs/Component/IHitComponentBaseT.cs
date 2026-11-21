using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005910 RID: 22800
	public class IHitComponentBaseT
	{
		// Token: 0x1700A560 RID: 42336
		// (get) Token: 0x06025104 RID: 151812 RVA: 0x005166AB File Offset: 0x005148AB
		// (set) Token: 0x06025105 RID: 151813 RVA: 0x005166B3 File Offset: 0x005148B3
		public bool Disabled { get; set; }

		// Token: 0x1700A561 RID: 42337
		// (get) Token: 0x06025106 RID: 151814 RVA: 0x005166BC File Offset: 0x005148BC
		// (set) Token: 0x06025107 RID: 151815 RVA: 0x005166C4 File Offset: 0x005148C4
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x1700A562 RID: 42338
		// (get) Token: 0x06025108 RID: 151816 RVA: 0x005166CD File Offset: 0x005148CD
		// (set) Token: 0x06025109 RID: 151817 RVA: 0x005166D5 File Offset: 0x005148D5
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x1700A563 RID: 42339
		// (get) Token: 0x0602510A RID: 151818 RVA: 0x005166DE File Offset: 0x005148DE
		// (set) Token: 0x0602510B RID: 151819 RVA: 0x005166E6 File Offset: 0x005148E6
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x1700A564 RID: 42340
		// (get) Token: 0x0602510C RID: 151820 RVA: 0x005166EF File Offset: 0x005148EF
		// (set) Token: 0x0602510D RID: 151821 RVA: 0x005166F7 File Offset: 0x005148F7
		public List<IAimPartT> AimParts { get; set; }

		// Token: 0x1700A565 RID: 42341
		// (get) Token: 0x0602510E RID: 151822 RVA: 0x00516700 File Offset: 0x00514900
		// (set) Token: 0x0602510F RID: 151823 RVA: 0x00516708 File Offset: 0x00514908
		public byte NullMask { get; set; }

		// Token: 0x06025110 RID: 151824 RVA: 0x00516711 File Offset: 0x00514911
		public IHitComponentBaseT()
		{
			this.Disabled = false;
			this.HitBullet = null;
			this.AttackerHitTimeScaleRatio = null;
			this.VictimHitTimeScaleRatio = null;
			this.AimParts = null;
			this.NullMask = 0;
		}
	}
}
