using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A68 RID: 23144
	public class IThrowMotionT
	{
		// Token: 0x1700AE2B RID: 44587
		// (get) Token: 0x06027631 RID: 161329 RVA: 0x0056B8BA File Offset: 0x00569ABA
		// (set) Token: 0x06027632 RID: 161330 RVA: 0x0056B8C2 File Offset: 0x00569AC2
		public EThrowMotion Type { get; set; }

		// Token: 0x06027633 RID: 161331 RVA: 0x0056B8CB File Offset: 0x00569ACB
		public IThrowMotionT()
		{
			this.Type = EThrowMotion.Projectile;
		}
	}
}
