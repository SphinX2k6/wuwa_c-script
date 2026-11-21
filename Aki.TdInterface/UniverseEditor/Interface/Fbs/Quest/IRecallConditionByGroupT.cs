using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044BE RID: 17598
	public class IRecallConditionByGroupT
	{
		// Token: 0x17007A83 RID: 31363
		// (get) Token: 0x060196C0 RID: 104128 RVA: 0x003A0B55 File Offset: 0x0039ED55
		// (set) Token: 0x060196C1 RID: 104129 RVA: 0x003A0B5D File Offset: 0x0039ED5D
		public ERecallConditionType Type { get; set; }

		// Token: 0x17007A84 RID: 31364
		// (get) Token: 0x060196C2 RID: 104130 RVA: 0x003A0B66 File Offset: 0x0039ED66
		// (set) Token: 0x060196C3 RID: 104131 RVA: 0x003A0B6E File Offset: 0x0039ED6E
		public ERecallOperation Operation { get; set; }

		// Token: 0x17007A85 RID: 31365
		// (get) Token: 0x060196C4 RID: 104132 RVA: 0x003A0B77 File Offset: 0x0039ED77
		// (set) Token: 0x060196C5 RID: 104133 RVA: 0x003A0B7F File Offset: 0x0039ED7F
		public List<int> GroupIds { get; set; }

		// Token: 0x060196C6 RID: 104134 RVA: 0x003A0B88 File Offset: 0x0039ED88
		public IRecallConditionByGroupT()
		{
			this.Type = ERecallConditionType.ByEntityType;
			this.Operation = ERecallOperation.Include;
			this.GroupIds = null;
		}
	}
}
