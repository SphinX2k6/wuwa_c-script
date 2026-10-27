using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005381 RID: 21377
	public class IHitBulletTypePlayerOrThrenodianAttackT
	{
		// Token: 0x17009D0F RID: 40207
		// (get) Token: 0x06022FD2 RID: 143314 RVA: 0x004D80B2 File Offset: 0x004D62B2
		// (set) Token: 0x06022FD3 RID: 143315 RVA: 0x004D80BA File Offset: 0x004D62BA
		public EHitBulletType Type { get; set; }

		// Token: 0x06022FD4 RID: 143316 RVA: 0x004D80C3 File Offset: 0x004D62C3
		public IHitBulletTypePlayerOrThrenodianAttackT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
		}
	}
}
