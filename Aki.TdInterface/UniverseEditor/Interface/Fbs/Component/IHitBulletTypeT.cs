using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F5 RID: 22773
	public class IHitBulletTypeT
	{
		// Token: 0x1700A52D RID: 42285
		// (get) Token: 0x06025002 RID: 151554 RVA: 0x005142CA File Offset: 0x005124CA
		// (set) Token: 0x06025003 RID: 151555 RVA: 0x005142D2 File Offset: 0x005124D2
		public EHitBulletType Type { get; set; }

		// Token: 0x06025004 RID: 151556 RVA: 0x005142DB File Offset: 0x005124DB
		public IHitBulletTypeT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
		}
	}
}
