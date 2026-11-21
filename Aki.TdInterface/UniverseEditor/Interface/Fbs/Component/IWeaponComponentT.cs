using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200617F RID: 24959
	public class IWeaponComponentT
	{
		// Token: 0x1700BA13 RID: 47635
		// (get) Token: 0x0602A679 RID: 173689 RVA: 0x005C90B2 File Offset: 0x005C72B2
		// (set) Token: 0x0602A67A RID: 173690 RVA: 0x005C90BA File Offset: 0x005C72BA
		public bool Disabled { get; set; }

		// Token: 0x1700BA14 RID: 47636
		// (get) Token: 0x0602A67B RID: 173691 RVA: 0x005C90C3 File Offset: 0x005C72C3
		// (set) Token: 0x0602A67C RID: 173692 RVA: 0x005C90CB File Offset: 0x005C72CB
		public int WeaponId { get; set; }

		// Token: 0x1700BA15 RID: 47637
		// (get) Token: 0x0602A67D RID: 173693 RVA: 0x005C90D4 File Offset: 0x005C72D4
		// (set) Token: 0x0602A67E RID: 173694 RVA: 0x005C90DC File Offset: 0x005C72DC
		public byte NullMask { get; set; }

		// Token: 0x0602A67F RID: 173695 RVA: 0x005C90E5 File Offset: 0x005C72E5
		public IWeaponComponentT()
		{
			this.Disabled = false;
			this.WeaponId = 0;
			this.NullMask = 0;
		}
	}
}
