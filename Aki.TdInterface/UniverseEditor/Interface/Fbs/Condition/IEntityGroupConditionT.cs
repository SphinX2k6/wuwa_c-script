using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C17 RID: 19479
	public class IEntityGroupConditionT
	{
		// Token: 0x17008D82 RID: 36226
		// (get) Token: 0x0601EDBB RID: 126395 RVA: 0x00451F3F File Offset: 0x0045013F
		// (set) Token: 0x0601EDBC RID: 126396 RVA: 0x00451F47 File Offset: 0x00450147
		public int Count { get; set; }

		// Token: 0x17008D83 RID: 36227
		// (get) Token: 0x0601EDBD RID: 126397 RVA: 0x00451F50 File Offset: 0x00450150
		// (set) Token: 0x0601EDBE RID: 126398 RVA: 0x00451F58 File Offset: 0x00450158
		public ECompare Compare { get; set; }

		// Token: 0x17008D84 RID: 36228
		// (get) Token: 0x0601EDBF RID: 126399 RVA: 0x00451F61 File Offset: 0x00450161
		// (set) Token: 0x0601EDC0 RID: 126400 RVA: 0x00451F69 File Offset: 0x00450169
		public List<IEntityEventConditionT> Conditions { get; set; }

		// Token: 0x17008D85 RID: 36229
		// (get) Token: 0x0601EDC1 RID: 126401 RVA: 0x00451F72 File Offset: 0x00450172
		// (set) Token: 0x0601EDC2 RID: 126402 RVA: 0x00451F7A File Offset: 0x0045017A
		public byte NullMask { get; set; }

		// Token: 0x0601EDC3 RID: 126403 RVA: 0x00451F83 File Offset: 0x00450183
		public IEntityGroupConditionT()
		{
			this.Count = 0;
			this.Compare = ECompare.Eq;
			this.Conditions = null;
			this.NullMask = 0;
		}
	}
}
