using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DA7 RID: 23975
	public class IProgressBarControlComponentT
	{
		// Token: 0x1700B087 RID: 45191
		// (get) Token: 0x06027F3C RID: 163644 RVA: 0x0057719C File Offset: 0x0057539C
		// (set) Token: 0x06027F3D RID: 163645 RVA: 0x005771A4 File Offset: 0x005753A4
		public bool Disabled { get; set; }

		// Token: 0x1700B088 RID: 45192
		// (get) Token: 0x06027F3E RID: 163646 RVA: 0x005771AD File Offset: 0x005753AD
		// (set) Token: 0x06027F3F RID: 163647 RVA: 0x005771B5 File Offset: 0x005753B5
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x1700B089 RID: 45193
		// (get) Token: 0x06027F40 RID: 163648 RVA: 0x005771BE File Offset: 0x005753BE
		// (set) Token: 0x06027F41 RID: 163649 RVA: 0x005771C6 File Offset: 0x005753C6
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x1700B08A RID: 45194
		// (get) Token: 0x06027F42 RID: 163650 RVA: 0x005771CF File Offset: 0x005753CF
		// (set) Token: 0x06027F43 RID: 163651 RVA: 0x005771D7 File Offset: 0x005753D7
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x1700B08B RID: 45195
		// (get) Token: 0x06027F44 RID: 163652 RVA: 0x005771E0 File Offset: 0x005753E0
		// (set) Token: 0x06027F45 RID: 163653 RVA: 0x005771E8 File Offset: 0x005753E8
		public List<IAimPartT> AimParts { get; set; }

		// Token: 0x1700B08C RID: 45196
		// (get) Token: 0x06027F46 RID: 163654 RVA: 0x005771F1 File Offset: 0x005753F1
		// (set) Token: 0x06027F47 RID: 163655 RVA: 0x005771F9 File Offset: 0x005753F9
		public TProgressBarControlUnion Control { get; set; }

		// Token: 0x1700B08D RID: 45197
		// (get) Token: 0x06027F48 RID: 163656 RVA: 0x00577202 File Offset: 0x00575402
		// (set) Token: 0x06027F49 RID: 163657 RVA: 0x0057720A File Offset: 0x0057540A
		public byte NullMask { get; set; }

		// Token: 0x06027F4A RID: 163658 RVA: 0x00577213 File Offset: 0x00575413
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
