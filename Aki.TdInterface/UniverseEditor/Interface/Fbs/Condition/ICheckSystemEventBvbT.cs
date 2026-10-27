using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B3C RID: 19260
	public class ICheckSystemEventBvbT
	{
		// Token: 0x17008BBD RID: 35773
		// (get) Token: 0x0601E502 RID: 124162 RVA: 0x0043F450 File Offset: 0x0043D650
		// (set) Token: 0x0601E503 RID: 124163 RVA: 0x0043F458 File Offset: 0x0043D658
		public ECondition Type { get; set; }

		// Token: 0x17008BBE RID: 35774
		// (get) Token: 0x0601E504 RID: 124164 RVA: 0x0043F461 File Offset: 0x0043D661
		// (set) Token: 0x0601E505 RID: 124165 RVA: 0x0043F469 File Offset: 0x0043D669
		public EBvbEventName EventName { get; set; }

		// Token: 0x0601E506 RID: 124166 RVA: 0x0043F472 File Offset: 0x0043D672
		public ICheckSystemEventBvbT()
		{
			this.Type = ECondition.CompareVar;
			this.EventName = EBvbEventName.AIEvolution;
		}
	}
}
