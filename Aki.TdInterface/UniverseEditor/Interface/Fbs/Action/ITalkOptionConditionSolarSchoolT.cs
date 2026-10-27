using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007326 RID: 29478
	public class ITalkOptionConditionSolarSchoolT
	{
		// Token: 0x1700DFF4 RID: 57332
		// (get) Token: 0x06035808 RID: 219144 RVA: 0x0074A158 File Offset: 0x00748358
		// (set) Token: 0x06035809 RID: 219145 RVA: 0x0074A160 File Offset: 0x00748360
		public ETalkOptionConditionSystem Type { get; set; }

		// Token: 0x1700DFF5 RID: 57333
		// (get) Token: 0x0603580A RID: 219146 RVA: 0x0074A169 File Offset: 0x00748369
		// (set) Token: 0x0603580B RID: 219147 RVA: 0x0074A171 File Offset: 0x00748371
		public int ConditionGroupId { get; set; }

		// Token: 0x0603580C RID: 219148 RVA: 0x0074A17A File Offset: 0x0074837A
		public ITalkOptionConditionSolarSchoolT()
		{
			this.Type = ETalkOptionConditionSystem.SolarSchool;
			this.ConditionGroupId = 0;
		}
	}
}
