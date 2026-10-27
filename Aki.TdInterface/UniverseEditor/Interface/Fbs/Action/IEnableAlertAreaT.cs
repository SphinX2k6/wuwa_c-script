using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006643 RID: 26179
	public class IEnableAlertAreaT
	{
		// Token: 0x1700C284 RID: 49796
		// (get) Token: 0x0602D793 RID: 186259 RVA: 0x0063A88B File Offset: 0x00638A8B
		// (set) Token: 0x0602D794 RID: 186260 RVA: 0x0063A893 File Offset: 0x00638A93
		public EAlertSystemOption Type { get; set; }

		// Token: 0x1700C285 RID: 49797
		// (get) Token: 0x0602D795 RID: 186261 RVA: 0x0063A89C File Offset: 0x00638A9C
		// (set) Token: 0x0602D796 RID: 186262 RVA: 0x0063A8A4 File Offset: 0x00638AA4
		public int AreaId { get; set; }

		// Token: 0x1700C286 RID: 49798
		// (get) Token: 0x0602D797 RID: 186263 RVA: 0x0063A8AD File Offset: 0x00638AAD
		// (set) Token: 0x0602D798 RID: 186264 RVA: 0x0063A8B5 File Offset: 0x00638AB5
		public bool IsEnable { get; set; }

		// Token: 0x1700C287 RID: 49799
		// (get) Token: 0x0602D799 RID: 186265 RVA: 0x0063A8BE File Offset: 0x00638ABE
		// (set) Token: 0x0602D79A RID: 186266 RVA: 0x0063A8C6 File Offset: 0x00638AC6
		public TDisableAlertConditionUnion AutoDisableCondition { get; set; }

		// Token: 0x0602D79B RID: 186267 RVA: 0x0063A8CF File Offset: 0x00638ACF
		public IEnableAlertAreaT()
		{
			this.Type = EAlertSystemOption.EnableAlertArea;
			this.AreaId = 0;
			this.IsEnable = false;
			this.AutoDisableCondition = null;
		}
	}
}
