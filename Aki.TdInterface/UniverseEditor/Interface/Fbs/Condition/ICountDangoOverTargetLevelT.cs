using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BF0 RID: 19440
	public class ICountDangoOverTargetLevelT
	{
		// Token: 0x17008D35 RID: 36149
		// (get) Token: 0x0601EC6B RID: 126059 RVA: 0x0044FC02 File Offset: 0x0044DE02
		// (set) Token: 0x0601EC6C RID: 126060 RVA: 0x0044FC0A File Offset: 0x0044DE0A
		public ECheckDangoCultivationProgressType Type { get; set; }

		// Token: 0x17008D36 RID: 36150
		// (get) Token: 0x0601EC6D RID: 126061 RVA: 0x0044FC13 File Offset: 0x0044DE13
		// (set) Token: 0x0601EC6E RID: 126062 RVA: 0x0044FC1B File Offset: 0x0044DE1B
		public int TargetNumber { get; set; }

		// Token: 0x17008D37 RID: 36151
		// (get) Token: 0x0601EC6F RID: 126063 RVA: 0x0044FC24 File Offset: 0x0044DE24
		// (set) Token: 0x0601EC70 RID: 126064 RVA: 0x0044FC2C File Offset: 0x0044DE2C
		public int TargetLevel { get; set; }

		// Token: 0x0601EC71 RID: 126065 RVA: 0x0044FC35 File Offset: 0x0044DE35
		public ICountDangoOverTargetLevelT()
		{
			this.Type = ECheckDangoCultivationProgressType.CountDangoOverTargetLevel;
			this.TargetNumber = 0;
			this.TargetLevel = 0;
		}
	}
}
