using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006872 RID: 26738
	public class IBehaviorTreeFragmentContextT
	{
		// Token: 0x1700C48F RID: 50319
		// (get) Token: 0x0602DB60 RID: 187232 RVA: 0x00640380 File Offset: 0x0063E580
		// (set) Token: 0x0602DB61 RID: 187233 RVA: 0x00640388 File Offset: 0x0063E588
		public EVarContext Type { get; set; }

		// Token: 0x1700C490 RID: 50320
		// (get) Token: 0x0602DB62 RID: 187234 RVA: 0x00640391 File Offset: 0x0063E591
		// (set) Token: 0x0602DB63 RID: 187235 RVA: 0x00640399 File Offset: 0x0063E599
		public int Id { get; set; }

		// Token: 0x0602DB64 RID: 187236 RVA: 0x006403A2 File Offset: 0x0063E5A2
		public IBehaviorTreeFragmentContextT()
		{
			this.Type = EVarContext.None;
			this.Id = 0;
		}
	}
}
