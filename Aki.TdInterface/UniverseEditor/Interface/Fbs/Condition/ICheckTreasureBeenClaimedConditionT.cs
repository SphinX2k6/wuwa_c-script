using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B66 RID: 19302
	public class ICheckTreasureBeenClaimedConditionT
	{
		// Token: 0x17008C13 RID: 35859
		// (get) Token: 0x0601E695 RID: 124565 RVA: 0x004427C4 File Offset: 0x004409C4
		// (set) Token: 0x0601E696 RID: 124566 RVA: 0x004427CC File Offset: 0x004409CC
		public ECondition Type { get; set; }

		// Token: 0x17008C14 RID: 35860
		// (get) Token: 0x0601E697 RID: 124567 RVA: 0x004427D5 File Offset: 0x004409D5
		// (set) Token: 0x0601E698 RID: 124568 RVA: 0x004427DD File Offset: 0x004409DD
		public int EntityId { get; set; }

		// Token: 0x0601E699 RID: 124569 RVA: 0x004427E6 File Offset: 0x004409E6
		public ICheckTreasureBeenClaimedConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
		}
	}
}
