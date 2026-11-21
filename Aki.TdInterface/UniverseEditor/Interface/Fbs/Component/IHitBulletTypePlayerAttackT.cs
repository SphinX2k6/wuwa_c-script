using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005904 RID: 22788
	public class IHitBulletTypePlayerAttackT
	{
		// Token: 0x1700A544 RID: 42308
		// (get) Token: 0x06025074 RID: 151668 RVA: 0x00514E0E File Offset: 0x0051300E
		// (set) Token: 0x06025075 RID: 151669 RVA: 0x00514E16 File Offset: 0x00513016
		public EHitBulletType Type { get; set; }

		// Token: 0x06025076 RID: 151670 RVA: 0x00514E1F File Offset: 0x0051301F
		public IHitBulletTypePlayerAttackT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
		}
	}
}
