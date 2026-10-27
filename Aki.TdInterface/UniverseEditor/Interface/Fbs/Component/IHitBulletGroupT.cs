using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200536C RID: 21356
	public class IHitBulletGroupT
	{
		// Token: 0x17009CF1 RID: 40177
		// (get) Token: 0x06022F3A RID: 143162 RVA: 0x004D725B File Offset: 0x004D545B
		// (set) Token: 0x06022F3B RID: 143163 RVA: 0x004D7263 File Offset: 0x004D5463
		public bool MatchAny { get; set; }

		// Token: 0x17009CF2 RID: 40178
		// (get) Token: 0x06022F3C RID: 143164 RVA: 0x004D726C File Offset: 0x004D546C
		// (set) Token: 0x06022F3D RID: 143165 RVA: 0x004D7274 File Offset: 0x004D5474
		public List<THitBulletTypeUnion> HitBullets { get; set; }

		// Token: 0x06022F3E RID: 143166 RVA: 0x004D727D File Offset: 0x004D547D
		public IHitBulletGroupT()
		{
			this.MatchAny = false;
			this.HitBullets = null;
		}
	}
}
