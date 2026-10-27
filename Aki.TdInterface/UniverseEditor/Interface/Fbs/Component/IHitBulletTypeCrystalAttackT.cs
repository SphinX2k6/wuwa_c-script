using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005375 RID: 21365
	public class IHitBulletTypeCrystalAttackT
	{
		// Token: 0x17009CFC RID: 40188
		// (get) Token: 0x06022F74 RID: 143220 RVA: 0x004D77B3 File Offset: 0x004D59B3
		// (set) Token: 0x06022F75 RID: 143221 RVA: 0x004D77BB File Offset: 0x004D59BB
		public EHitBulletType Type { get; set; }

		// Token: 0x17009CFD RID: 40189
		// (get) Token: 0x06022F76 RID: 143222 RVA: 0x004D77C4 File Offset: 0x004D59C4
		// (set) Token: 0x06022F77 RID: 143223 RVA: 0x004D77CC File Offset: 0x004D59CC
		public IVectorInfoT TrackOffset { get; set; }

		// Token: 0x06022F78 RID: 143224 RVA: 0x004D77D5 File Offset: 0x004D59D5
		public IHitBulletTypeCrystalAttackT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
			this.TrackOffset = null;
		}
	}
}
