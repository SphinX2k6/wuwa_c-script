using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537B RID: 21371
	public class IHitBulletTypeOnlyDropAttackT
	{
		// Token: 0x17009D09 RID: 40201
		// (get) Token: 0x06022FAE RID: 143278 RVA: 0x004D7DC2 File Offset: 0x004D5FC2
		// (set) Token: 0x06022FAF RID: 143279 RVA: 0x004D7DCA File Offset: 0x004D5FCA
		public EHitBulletType Type { get; set; }

		// Token: 0x06022FB0 RID: 143280 RVA: 0x004D7DD3 File Offset: 0x004D5FD3
		public IHitBulletTypeOnlyDropAttackT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
		}
	}
}
