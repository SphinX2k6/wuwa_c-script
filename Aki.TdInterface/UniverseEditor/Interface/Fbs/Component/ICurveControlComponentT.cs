using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005049 RID: 20553
	public class ICurveControlComponentT
	{
		// Token: 0x17009526 RID: 38182
		// (get) Token: 0x06020F01 RID: 134913 RVA: 0x004943CD File Offset: 0x004925CD
		// (set) Token: 0x06020F02 RID: 134914 RVA: 0x004943D5 File Offset: 0x004925D5
		public bool Disabled { get; set; }

		// Token: 0x17009527 RID: 38183
		// (get) Token: 0x06020F03 RID: 134915 RVA: 0x004943DE File Offset: 0x004925DE
		// (set) Token: 0x06020F04 RID: 134916 RVA: 0x004943E6 File Offset: 0x004925E6
		public IChargeSlashControlT CurveControlConfig { get; set; }

		// Token: 0x17009528 RID: 38184
		// (get) Token: 0x06020F05 RID: 134917 RVA: 0x004943EF File Offset: 0x004925EF
		// (set) Token: 0x06020F06 RID: 134918 RVA: 0x004943F7 File Offset: 0x004925F7
		public byte NullMask { get; set; }

		// Token: 0x06020F07 RID: 134919 RVA: 0x00494400 File Offset: 0x00492600
		public ICurveControlComponentT()
		{
			this.Disabled = false;
			this.CurveControlConfig = null;
			this.NullMask = 0;
		}
	}
}
