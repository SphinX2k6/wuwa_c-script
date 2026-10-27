using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B69 RID: 23401
	public class IWeaponComponentT
	{
		// Token: 0x1700B0CB RID: 45259
		// (get) Token: 0x060280B5 RID: 164021 RVA: 0x00581622 File Offset: 0x0057F822
		// (set) Token: 0x060280B6 RID: 164022 RVA: 0x0058162A File Offset: 0x0057F82A
		public bool Disabled { get; set; }

		// Token: 0x1700B0CC RID: 45260
		// (get) Token: 0x060280B7 RID: 164023 RVA: 0x00581633 File Offset: 0x0057F833
		// (set) Token: 0x060280B8 RID: 164024 RVA: 0x0058163B File Offset: 0x0057F83B
		public int WeaponId { get; set; }

		// Token: 0x1700B0CD RID: 45261
		// (get) Token: 0x060280B9 RID: 164025 RVA: 0x00581644 File Offset: 0x0057F844
		// (set) Token: 0x060280BA RID: 164026 RVA: 0x0058164C File Offset: 0x0057F84C
		public byte NullMask { get; set; }

		// Token: 0x060280BB RID: 164027 RVA: 0x00581655 File Offset: 0x0057F855
		public IWeaponComponentT()
		{
			this.Disabled = false;
			this.WeaponId = 0;
			this.NullMask = 0;
		}
	}
}
