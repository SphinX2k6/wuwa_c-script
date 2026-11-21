using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F5A RID: 28506
	public class IGuideTriggerT
	{
		// Token: 0x1700D0E2 RID: 53474
		// (get) Token: 0x06031576 RID: 202102 RVA: 0x006B15B7 File Offset: 0x006AF7B7
		// (set) Token: 0x06031577 RID: 202103 RVA: 0x006B15BF File Offset: 0x006AF7BF
		public EGuideTriggerType Type { get; set; }

		// Token: 0x1700D0E3 RID: 53475
		// (get) Token: 0x06031578 RID: 202104 RVA: 0x006B15C8 File Offset: 0x006AF7C8
		// (set) Token: 0x06031579 RID: 202105 RVA: 0x006B15D0 File Offset: 0x006AF7D0
		public List<ICondition2_UnionUnion> Conditions { get; set; }

		// Token: 0x1700D0E4 RID: 53476
		// (get) Token: 0x0603157A RID: 202106 RVA: 0x006B15D9 File Offset: 0x006AF7D9
		// (set) Token: 0x0603157B RID: 202107 RVA: 0x006B15E1 File Offset: 0x006AF7E1
		public int GuideId { get; set; }

		// Token: 0x1700D0E5 RID: 53477
		// (get) Token: 0x0603157C RID: 202108 RVA: 0x006B15EA File Offset: 0x006AF7EA
		// (set) Token: 0x0603157D RID: 202109 RVA: 0x006B15F2 File Offset: 0x006AF7F2
		public byte NullMask { get; set; }

		// Token: 0x0603157E RID: 202110 RVA: 0x006B15FB File Offset: 0x006AF7FB
		public IGuideTriggerT()
		{
			this.Type = EGuideTriggerType.BeginnerGuide;
			this.Conditions = null;
			this.GuideId = 0;
			this.NullMask = 0;
		}
	}
}
