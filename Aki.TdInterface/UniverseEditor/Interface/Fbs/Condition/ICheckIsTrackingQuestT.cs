using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AA6 RID: 19110
	public class ICheckIsTrackingQuestT
	{
		// Token: 0x17008A7D RID: 35453
		// (get) Token: 0x0601DFCA RID: 122826 RVA: 0x00435B06 File Offset: 0x00433D06
		// (set) Token: 0x0601DFCB RID: 122827 RVA: 0x00435B0E File Offset: 0x00433D0E
		public ECondition Type { get; set; }

		// Token: 0x17008A7E RID: 35454
		// (get) Token: 0x0601DFCC RID: 122828 RVA: 0x00435B17 File Offset: 0x00433D17
		// (set) Token: 0x0601DFCD RID: 122829 RVA: 0x00435B1F File Offset: 0x00433D1F
		public int QuestId { get; set; }

		// Token: 0x17008A7F RID: 35455
		// (get) Token: 0x0601DFCE RID: 122830 RVA: 0x00435B28 File Offset: 0x00433D28
		// (set) Token: 0x0601DFCF RID: 122831 RVA: 0x00435B30 File Offset: 0x00433D30
		public bool IsTracking { get; set; }

		// Token: 0x0601DFD0 RID: 122832 RVA: 0x00435B39 File Offset: 0x00433D39
		public ICheckIsTrackingQuestT()
		{
			this.Type = ECondition.CompareVar;
			this.QuestId = 0;
			this.IsTracking = false;
		}
	}
}
