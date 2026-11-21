using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F3C RID: 20284
	public class ICheckInfrActivityExpT
	{
		// Token: 0x170090ED RID: 37101
		// (get) Token: 0x0601F8A9 RID: 129193 RVA: 0x00463746 File Offset: 0x00461946
		// (set) Token: 0x0601F8AA RID: 129194 RVA: 0x0046374E File Offset: 0x0046194E
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x170090EE RID: 37102
		// (get) Token: 0x0601F8AB RID: 129195 RVA: 0x00463757 File Offset: 0x00461957
		// (set) Token: 0x0601F8AC RID: 129196 RVA: 0x0046375F File Offset: 0x0046195F
		public ECompare Compare { get; set; }

		// Token: 0x170090EF RID: 37103
		// (get) Token: 0x0601F8AD RID: 129197 RVA: 0x00463768 File Offset: 0x00461968
		// (set) Token: 0x0601F8AE RID: 129198 RVA: 0x00463770 File Offset: 0x00461970
		public int Exp { get; set; }

		// Token: 0x0601F8AF RID: 129199 RVA: 0x00463779 File Offset: 0x00461979
		public ICheckInfrActivityExpT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Compare = ECompare.Eq;
			this.Exp = 0;
		}
	}
}
