using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200536F RID: 21359
	public class IHitBulletTypeT
	{
		// Token: 0x17009CF5 RID: 40181
		// (get) Token: 0x06022F4E RID: 143182 RVA: 0x004D73F6 File Offset: 0x004D55F6
		// (set) Token: 0x06022F4F RID: 143183 RVA: 0x004D73FE File Offset: 0x004D55FE
		public EHitBulletType Type { get; set; }

		// Token: 0x06022F50 RID: 143184 RVA: 0x004D7407 File Offset: 0x004D5607
		public IHitBulletTypeT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
		}
	}
}
