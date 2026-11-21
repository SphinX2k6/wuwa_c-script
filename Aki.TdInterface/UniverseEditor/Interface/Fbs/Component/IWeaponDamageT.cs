using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006182 RID: 24962
	public class IWeaponDamageT
	{
		// Token: 0x1700BA1E RID: 47646
		// (get) Token: 0x0602A69B RID: 173723 RVA: 0x005C94EE File Offset: 0x005C76EE
		// (set) Token: 0x0602A69C RID: 173724 RVA: 0x005C94F6 File Offset: 0x005C76F6
		public int DefaultValue { get; set; }

		// Token: 0x1700BA1F RID: 47647
		// (get) Token: 0x0602A69D RID: 173725 RVA: 0x005C94FF File Offset: 0x005C76FF
		// (set) Token: 0x0602A69E RID: 173726 RVA: 0x005C9507 File Offset: 0x005C7707
		public int GreatSword { get; set; }

		// Token: 0x1700BA20 RID: 47648
		// (get) Token: 0x0602A69F RID: 173727 RVA: 0x005C9510 File Offset: 0x005C7710
		// (set) Token: 0x0602A6A0 RID: 173728 RVA: 0x005C9518 File Offset: 0x005C7718
		public int Dagger { get; set; }

		// Token: 0x1700BA21 RID: 47649
		// (get) Token: 0x0602A6A1 RID: 173729 RVA: 0x005C9521 File Offset: 0x005C7721
		// (set) Token: 0x0602A6A2 RID: 173730 RVA: 0x005C9529 File Offset: 0x005C7729
		public int Pistol { get; set; }

		// Token: 0x1700BA22 RID: 47650
		// (get) Token: 0x0602A6A3 RID: 173731 RVA: 0x005C9532 File Offset: 0x005C7732
		// (set) Token: 0x0602A6A4 RID: 173732 RVA: 0x005C953A File Offset: 0x005C773A
		public int Pugilism { get; set; }

		// Token: 0x1700BA23 RID: 47651
		// (get) Token: 0x0602A6A5 RID: 173733 RVA: 0x005C9543 File Offset: 0x005C7743
		// (set) Token: 0x0602A6A6 RID: 173734 RVA: 0x005C954B File Offset: 0x005C774B
		public int Ring { get; set; }

		// Token: 0x1700BA24 RID: 47652
		// (get) Token: 0x0602A6A7 RID: 173735 RVA: 0x005C9554 File Offset: 0x005C7754
		// (set) Token: 0x0602A6A8 RID: 173736 RVA: 0x005C955C File Offset: 0x005C775C
		public byte NullMask { get; set; }

		// Token: 0x0602A6A9 RID: 173737 RVA: 0x005C9565 File Offset: 0x005C7765
		public IWeaponDamageT()
		{
			this.DefaultValue = 0;
			this.GreatSword = 0;
			this.Dagger = 0;
			this.Pistol = 0;
			this.Pugilism = 0;
			this.Ring = 0;
			this.NullMask = 0;
		}
	}
}
