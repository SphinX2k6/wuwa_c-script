using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F2 RID: 22770
	public class IHitBulletGroupT
	{
		// Token: 0x1700A529 RID: 42281
		// (get) Token: 0x06024FEE RID: 151534 RVA: 0x0051412F File Offset: 0x0051232F
		// (set) Token: 0x06024FEF RID: 151535 RVA: 0x00514137 File Offset: 0x00512337
		public bool MatchAny { get; set; }

		// Token: 0x1700A52A RID: 42282
		// (get) Token: 0x06024FF0 RID: 151536 RVA: 0x00514140 File Offset: 0x00512340
		// (set) Token: 0x06024FF1 RID: 151537 RVA: 0x00514148 File Offset: 0x00512348
		public List<THitBulletTypeUnion> HitBullets { get; set; }

		// Token: 0x06024FF2 RID: 151538 RVA: 0x00514151 File Offset: 0x00512351
		public IHitBulletGroupT()
		{
			this.MatchAny = false;
			this.HitBullets = null;
		}
	}
}
