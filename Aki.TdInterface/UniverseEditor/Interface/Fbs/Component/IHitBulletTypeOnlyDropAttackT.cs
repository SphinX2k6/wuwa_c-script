using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005901 RID: 22785
	public class IHitBulletTypeOnlyDropAttackT
	{
		// Token: 0x1700A541 RID: 42305
		// (get) Token: 0x06025062 RID: 151650 RVA: 0x00514C96 File Offset: 0x00512E96
		// (set) Token: 0x06025063 RID: 151651 RVA: 0x00514C9E File Offset: 0x00512E9E
		public EHitBulletType Type { get; set; }

		// Token: 0x06025064 RID: 151652 RVA: 0x00514CA7 File Offset: 0x00512EA7
		public IHitBulletTypeOnlyDropAttackT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
		}
	}
}
