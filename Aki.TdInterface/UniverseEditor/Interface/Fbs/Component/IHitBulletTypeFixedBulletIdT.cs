using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005378 RID: 21368
	public class IHitBulletTypeFixedBulletIdT
	{
		// Token: 0x17009D03 RID: 40195
		// (get) Token: 0x06022F96 RID: 143254 RVA: 0x004D7BCB File Offset: 0x004D5DCB
		// (set) Token: 0x06022F97 RID: 143255 RVA: 0x004D7BD3 File Offset: 0x004D5DD3
		public EHitBulletType Type { get; set; }

		// Token: 0x17009D04 RID: 40196
		// (get) Token: 0x06022F98 RID: 143256 RVA: 0x004D7BDC File Offset: 0x004D5DDC
		// (set) Token: 0x06022F99 RID: 143257 RVA: 0x004D7BE4 File Offset: 0x004D5DE4
		public List<long> BulletId { get; set; }

		// Token: 0x17009D05 RID: 40197
		// (get) Token: 0x06022F9A RID: 143258 RVA: 0x004D7BED File Offset: 0x004D5DED
		// (set) Token: 0x06022F9B RID: 143259 RVA: 0x004D7BF5 File Offset: 0x004D5DF5
		public bool PlayerAttack { get; set; }

		// Token: 0x17009D06 RID: 40198
		// (get) Token: 0x06022F9C RID: 143260 RVA: 0x004D7BFE File Offset: 0x004D5DFE
		// (set) Token: 0x06022F9D RID: 143261 RVA: 0x004D7C06 File Offset: 0x004D5E06
		public byte NullMask { get; set; }

		// Token: 0x06022F9E RID: 143262 RVA: 0x004D7C0F File Offset: 0x004D5E0F
		public IHitBulletTypeFixedBulletIdT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
			this.BulletId = null;
			this.PlayerAttack = false;
			this.NullMask = 0;
		}
	}
}
