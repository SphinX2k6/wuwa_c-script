using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049A1 RID: 18849
	public class ICheckClientEventT
	{
		// Token: 0x17008838 RID: 34872
		// (get) Token: 0x0601D682 RID: 120450 RVA: 0x00424EE9 File Offset: 0x004230E9
		// (set) Token: 0x0601D683 RID: 120451 RVA: 0x00424EF1 File Offset: 0x004230F1
		public ECondition Type { get; set; }

		// Token: 0x17008839 RID: 34873
		// (get) Token: 0x0601D684 RID: 120452 RVA: 0x00424EFA File Offset: 0x004230FA
		// (set) Token: 0x0601D685 RID: 120453 RVA: 0x00424F02 File Offset: 0x00423102
		public string EventName { get; set; }

		// Token: 0x1700883A RID: 34874
		// (get) Token: 0x0601D686 RID: 120454 RVA: 0x00424F0B File Offset: 0x0042310B
		// (set) Token: 0x0601D687 RID: 120455 RVA: 0x00424F13 File Offset: 0x00423113
		public ISelfClientEventT ListenerTarget { get; set; }

		// Token: 0x0601D688 RID: 120456 RVA: 0x00424F1C File Offset: 0x0042311C
		public ICheckClientEventT()
		{
			this.Type = ECondition.CompareVar;
			this.EventName = null;
			this.ListenerTarget = null;
		}
	}
}
