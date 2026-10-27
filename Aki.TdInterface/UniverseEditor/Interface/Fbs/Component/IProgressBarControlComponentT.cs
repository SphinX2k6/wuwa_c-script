using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A0 RID: 22432
	public class IProgressBarControlComponentT
	{
		// Token: 0x1700A763 RID: 42851
		// (get) Token: 0x06025A1C RID: 154140 RVA: 0x00531010 File Offset: 0x0052F210
		// (set) Token: 0x06025A1D RID: 154141 RVA: 0x00531018 File Offset: 0x0052F218
		public bool Disabled { get; set; }

		// Token: 0x1700A764 RID: 42852
		// (get) Token: 0x06025A1E RID: 154142 RVA: 0x00531021 File Offset: 0x0052F221
		// (set) Token: 0x06025A1F RID: 154143 RVA: 0x00531029 File Offset: 0x0052F229
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x1700A765 RID: 42853
		// (get) Token: 0x06025A20 RID: 154144 RVA: 0x00531032 File Offset: 0x0052F232
		// (set) Token: 0x06025A21 RID: 154145 RVA: 0x0053103A File Offset: 0x0052F23A
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x1700A766 RID: 42854
		// (get) Token: 0x06025A22 RID: 154146 RVA: 0x00531043 File Offset: 0x0052F243
		// (set) Token: 0x06025A23 RID: 154147 RVA: 0x0053104B File Offset: 0x0052F24B
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x1700A767 RID: 42855
		// (get) Token: 0x06025A24 RID: 154148 RVA: 0x00531054 File Offset: 0x0052F254
		// (set) Token: 0x06025A25 RID: 154149 RVA: 0x0053105C File Offset: 0x0052F25C
		public List<IAimPartT> AimParts { get; set; }

		// Token: 0x1700A768 RID: 42856
		// (get) Token: 0x06025A26 RID: 154150 RVA: 0x00531065 File Offset: 0x0052F265
		// (set) Token: 0x06025A27 RID: 154151 RVA: 0x0053106D File Offset: 0x0052F26D
		public TProgressBarControlUnion Control { get; set; }

		// Token: 0x1700A769 RID: 42857
		// (get) Token: 0x06025A28 RID: 154152 RVA: 0x00531076 File Offset: 0x0052F276
		// (set) Token: 0x06025A29 RID: 154153 RVA: 0x0053107E File Offset: 0x0052F27E
		public byte NullMask { get; set; }

		// Token: 0x06025A2A RID: 154154 RVA: 0x00531087 File Offset: 0x0052F287
		public IProgressBarControlComponentT()
		{
			this.Disabled = false;
			this.HitBullet = null;
			this.AttackerHitTimeScaleRatio = null;
			this.VictimHitTimeScaleRatio = null;
			this.AimParts = null;
			this.Control = null;
			this.NullMask = 0;
		}
	}
}
