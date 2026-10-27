using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537E RID: 21374
	public class IHitBulletTypePlayerAttackT
	{
		// Token: 0x17009D0C RID: 40204
		// (get) Token: 0x06022FC0 RID: 143296 RVA: 0x004D7F3A File Offset: 0x004D613A
		// (set) Token: 0x06022FC1 RID: 143297 RVA: 0x004D7F42 File Offset: 0x004D6142
		public EHitBulletType Type { get; set; }

		// Token: 0x06022FC2 RID: 143298 RVA: 0x004D7F4B File Offset: 0x004D614B
		public IHitBulletTypePlayerAttackT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
		}
	}
}
