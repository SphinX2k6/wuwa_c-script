using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E8E RID: 20110
	public class ICheckDollGrabMachineFinishedT
	{
		// Token: 0x17008F6D RID: 36717
		// (get) Token: 0x0601F285 RID: 127621 RVA: 0x00458807 File Offset: 0x00456A07
		// (set) Token: 0x0601F286 RID: 127622 RVA: 0x0045880F File Offset: 0x00456A0F
		public ECondition Type { get; set; }

		// Token: 0x17008F6E RID: 36718
		// (get) Token: 0x0601F287 RID: 127623 RVA: 0x00458818 File Offset: 0x00456A18
		// (set) Token: 0x0601F288 RID: 127624 RVA: 0x00458820 File Offset: 0x00456A20
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x0601F289 RID: 127625 RVA: 0x00458829 File Offset: 0x00456A29
		public ICheckDollGrabMachineFinishedT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
		}
	}
}
