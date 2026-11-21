using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005104 RID: 20740
	public class IEntityGroupConditionT
	{
		// Token: 0x170094A6 RID: 38054
		// (get) Token: 0x060209A1 RID: 133537 RVA: 0x004855A7 File Offset: 0x004837A7
		// (set) Token: 0x060209A2 RID: 133538 RVA: 0x004855AF File Offset: 0x004837AF
		public int Count { get; set; }

		// Token: 0x170094A7 RID: 38055
		// (get) Token: 0x060209A3 RID: 133539 RVA: 0x004855B8 File Offset: 0x004837B8
		// (set) Token: 0x060209A4 RID: 133540 RVA: 0x004855C0 File Offset: 0x004837C0
		public ECompare Compare { get; set; }

		// Token: 0x170094A8 RID: 38056
		// (get) Token: 0x060209A5 RID: 133541 RVA: 0x004855C9 File Offset: 0x004837C9
		// (set) Token: 0x060209A6 RID: 133542 RVA: 0x004855D1 File Offset: 0x004837D1
		public List<IEntityEventConditionT> Conditions { get; set; }

		// Token: 0x170094A9 RID: 38057
		// (get) Token: 0x060209A7 RID: 133543 RVA: 0x004855DA File Offset: 0x004837DA
		// (set) Token: 0x060209A8 RID: 133544 RVA: 0x004855E2 File Offset: 0x004837E2
		public byte NullMask { get; set; }

		// Token: 0x060209A9 RID: 133545 RVA: 0x004855EB File Offset: 0x004837EB
		public IEntityGroupConditionT()
		{
			this.Count = 0;
			this.Compare = ECompare.Eq;
			this.Conditions = null;
			this.NullMask = 0;
		}
	}
}
