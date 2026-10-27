using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005387 RID: 21383
	public class IHitComponentT
	{
		// Token: 0x17009D1A RID: 40218
		// (get) Token: 0x0602301A RID: 143386 RVA: 0x004D8DA4 File Offset: 0x004D6FA4
		// (set) Token: 0x0602301B RID: 143387 RVA: 0x004D8DAC File Offset: 0x004D6FAC
		public bool Disabled { get; set; }

		// Token: 0x17009D1B RID: 40219
		// (get) Token: 0x0602301C RID: 143388 RVA: 0x004D8DB5 File Offset: 0x004D6FB5
		// (set) Token: 0x0602301D RID: 143389 RVA: 0x004D8DBD File Offset: 0x004D6FBD
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x17009D1C RID: 40220
		// (get) Token: 0x0602301E RID: 143390 RVA: 0x004D8DC6 File Offset: 0x004D6FC6
		// (set) Token: 0x0602301F RID: 143391 RVA: 0x004D8DCE File Offset: 0x004D6FCE
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x17009D1D RID: 40221
		// (get) Token: 0x06023020 RID: 143392 RVA: 0x004D8DD7 File Offset: 0x004D6FD7
		// (set) Token: 0x06023021 RID: 143393 RVA: 0x004D8DDF File Offset: 0x004D6FDF
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x17009D1E RID: 40222
		// (get) Token: 0x06023022 RID: 143394 RVA: 0x004D8DE8 File Offset: 0x004D6FE8
		// (set) Token: 0x06023023 RID: 143395 RVA: 0x004D8DF0 File Offset: 0x004D6FF0
		public List<IAimPartT> AimParts { get; set; }

		// Token: 0x17009D1F RID: 40223
		// (get) Token: 0x06023024 RID: 143396 RVA: 0x004D8DF9 File Offset: 0x004D6FF9
		// (set) Token: 0x06023025 RID: 143397 RVA: 0x004D8E01 File Offset: 0x004D7001
		public List<IBulletHitConfigT> BulletHitConfigs { get; set; }

		// Token: 0x17009D20 RID: 40224
		// (get) Token: 0x06023026 RID: 143398 RVA: 0x004D8E0A File Offset: 0x004D700A
		// (set) Token: 0x06023027 RID: 143399 RVA: 0x004D8E12 File Offset: 0x004D7012
		public byte NullMask { get; set; }

		// Token: 0x06023028 RID: 143400 RVA: 0x004D8E1B File Offset: 0x004D701B
		public IHitComponentT()
		{
			this.Disabled = false;
			this.HitBullet = null;
			this.AttackerHitTimeScaleRatio = null;
			this.VictimHitTimeScaleRatio = null;
			this.AimParts = null;
			this.BulletHitConfigs = null;
			this.NullMask = 0;
		}
	}
}
