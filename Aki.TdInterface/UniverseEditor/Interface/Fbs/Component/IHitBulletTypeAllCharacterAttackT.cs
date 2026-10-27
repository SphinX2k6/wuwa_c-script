using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005372 RID: 21362
	public class IHitBulletTypeAllCharacterAttackT
	{
		// Token: 0x17009CF8 RID: 40184
		// (get) Token: 0x06022F60 RID: 143200 RVA: 0x004D756E File Offset: 0x004D576E
		// (set) Token: 0x06022F61 RID: 143201 RVA: 0x004D7576 File Offset: 0x004D5776
		public EHitBulletType Type { get; set; }

		// Token: 0x06022F62 RID: 143202 RVA: 0x004D757F File Offset: 0x004D577F
		public IHitBulletTypeAllCharacterAttackT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
		}
	}
}
