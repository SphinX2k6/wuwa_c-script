using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A5E RID: 19038
	public class ICheckHonamiStoryLifeSupportLevelT
	{
		// Token: 0x170089D6 RID: 35286
		// (get) Token: 0x0601DD24 RID: 122148 RVA: 0x00430DE4 File Offset: 0x0042EFE4
		// (set) Token: 0x0601DD25 RID: 122149 RVA: 0x00430DEC File Offset: 0x0042EFEC
		public ECondition Type { get; set; }

		// Token: 0x170089D7 RID: 35287
		// (get) Token: 0x0601DD26 RID: 122150 RVA: 0x00430DF5 File Offset: 0x0042EFF5
		// (set) Token: 0x0601DD27 RID: 122151 RVA: 0x00430DFD File Offset: 0x0042EFFD
		public int ActivityId { get; set; }

		// Token: 0x170089D8 RID: 35288
		// (get) Token: 0x0601DD28 RID: 122152 RVA: 0x00430E06 File Offset: 0x0042F006
		// (set) Token: 0x0601DD29 RID: 122153 RVA: 0x00430E0E File Offset: 0x0042F00E
		public ECompare Compare { get; set; }

		// Token: 0x170089D9 RID: 35289
		// (get) Token: 0x0601DD2A RID: 122154 RVA: 0x00430E17 File Offset: 0x0042F017
		// (set) Token: 0x0601DD2B RID: 122155 RVA: 0x00430E1F File Offset: 0x0042F01F
		public int Level { get; set; }

		// Token: 0x0601DD2C RID: 122156 RVA: 0x00430E28 File Offset: 0x0042F028
		public ICheckHonamiStoryLifeSupportLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.ActivityId = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
