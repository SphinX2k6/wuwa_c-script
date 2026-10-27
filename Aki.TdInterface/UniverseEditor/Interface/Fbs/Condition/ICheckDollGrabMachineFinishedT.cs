using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049CE RID: 18894
	public class ICheckDollGrabMachineFinishedT
	{
		// Token: 0x1700889D RID: 34973
		// (get) Token: 0x0601D812 RID: 120850 RVA: 0x00427B9B File Offset: 0x00425D9B
		// (set) Token: 0x0601D813 RID: 120851 RVA: 0x00427BA3 File Offset: 0x00425DA3
		public ECondition Type { get; set; }

		// Token: 0x1700889E RID: 34974
		// (get) Token: 0x0601D814 RID: 120852 RVA: 0x00427BAC File Offset: 0x00425DAC
		// (set) Token: 0x0601D815 RID: 120853 RVA: 0x00427BB4 File Offset: 0x00425DB4
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x0601D816 RID: 120854 RVA: 0x00427BBD File Offset: 0x00425DBD
		public ICheckDollGrabMachineFinishedT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
		}
	}
}
