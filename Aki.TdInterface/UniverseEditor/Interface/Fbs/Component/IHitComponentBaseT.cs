using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200538A RID: 21386
	public class IHitComponentBaseT
	{
		// Token: 0x17009D28 RID: 40232
		// (get) Token: 0x06023050 RID: 143440 RVA: 0x004D97D7 File Offset: 0x004D79D7
		// (set) Token: 0x06023051 RID: 143441 RVA: 0x004D97DF File Offset: 0x004D79DF
		public bool Disabled { get; set; }

		// Token: 0x17009D29 RID: 40233
		// (get) Token: 0x06023052 RID: 143442 RVA: 0x004D97E8 File Offset: 0x004D79E8
		// (set) Token: 0x06023053 RID: 143443 RVA: 0x004D97F0 File Offset: 0x004D79F0
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x17009D2A RID: 40234
		// (get) Token: 0x06023054 RID: 143444 RVA: 0x004D97F9 File Offset: 0x004D79F9
		// (set) Token: 0x06023055 RID: 143445 RVA: 0x004D9801 File Offset: 0x004D7A01
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x17009D2B RID: 40235
		// (get) Token: 0x06023056 RID: 143446 RVA: 0x004D980A File Offset: 0x004D7A0A
		// (set) Token: 0x06023057 RID: 143447 RVA: 0x004D9812 File Offset: 0x004D7A12
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x17009D2C RID: 40236
		// (get) Token: 0x06023058 RID: 143448 RVA: 0x004D981B File Offset: 0x004D7A1B
		// (set) Token: 0x06023059 RID: 143449 RVA: 0x004D9823 File Offset: 0x004D7A23
		public List<IAimPartT> AimParts { get; set; }

		// Token: 0x17009D2D RID: 40237
		// (get) Token: 0x0602305A RID: 143450 RVA: 0x004D982C File Offset: 0x004D7A2C
		// (set) Token: 0x0602305B RID: 143451 RVA: 0x004D9834 File Offset: 0x004D7A34
		public byte NullMask { get; set; }

		// Token: 0x0602305C RID: 143452 RVA: 0x004D983D File Offset: 0x004D7A3D
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
