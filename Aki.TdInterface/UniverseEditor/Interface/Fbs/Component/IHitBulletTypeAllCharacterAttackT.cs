using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F8 RID: 22776
	public class IHitBulletTypeAllCharacterAttackT
	{
		// Token: 0x1700A530 RID: 42288
		// (get) Token: 0x06025014 RID: 151572 RVA: 0x00514442 File Offset: 0x00512642
		// (set) Token: 0x06025015 RID: 151573 RVA: 0x0051444A File Offset: 0x0051264A
		public EHitBulletType Type { get; set; }

		// Token: 0x06025016 RID: 151574 RVA: 0x00514453 File Offset: 0x00512653
		public IHitBulletTypeAllCharacterAttackT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
		}
	}
}
