using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D29 RID: 15657
	public class IAwakeAndLoadEntityConditionT
	{
		// Token: 0x17006B63 RID: 27491
		// (get) Token: 0x060159CD RID: 88525 RVA: 0x0031EBDA File Offset: 0x0031CDDA
		// (set) Token: 0x060159CE RID: 88526 RVA: 0x0031EBE2 File Offset: 0x0031CDE2
		public EChildQuest Type { get; set; }

		// Token: 0x17006B64 RID: 27492
		// (get) Token: 0x060159CF RID: 88527 RVA: 0x0031EBEB File Offset: 0x0031CDEB
		// (set) Token: 0x060159D0 RID: 88528 RVA: 0x0031EBF3 File Offset: 0x0031CDF3
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006B65 RID: 27493
		// (get) Token: 0x060159D1 RID: 88529 RVA: 0x0031EBFC File Offset: 0x0031CDFC
		// (set) Token: 0x060159D2 RID: 88530 RVA: 0x0031EC04 File Offset: 0x0031CE04
		public List<int> EntityIds { get; set; }

		// Token: 0x17006B66 RID: 27494
		// (get) Token: 0x060159D3 RID: 88531 RVA: 0x0031EC0D File Offset: 0x0031CE0D
		// (set) Token: 0x060159D4 RID: 88532 RVA: 0x0031EC15 File Offset: 0x0031CE15
		public bool IsWaitForShow { get; set; }

		// Token: 0x17006B67 RID: 27495
		// (get) Token: 0x060159D5 RID: 88533 RVA: 0x0031EC1E File Offset: 0x0031CE1E
		// (set) Token: 0x060159D6 RID: 88534 RVA: 0x0031EC26 File Offset: 0x0031CE26
		public byte NullMask { get; set; }

		// Token: 0x060159D7 RID: 88535 RVA: 0x0031EC2F File Offset: 0x0031CE2F
		public IAwakeAndLoadEntityConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EntityIds = null;
			this.IsWaitForShow = false;
			this.NullMask = 0;
		}
	}
}
