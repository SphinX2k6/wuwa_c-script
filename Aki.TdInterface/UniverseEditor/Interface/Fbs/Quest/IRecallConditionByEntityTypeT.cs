using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044BB RID: 17595
	public class IRecallConditionByEntityTypeT
	{
		// Token: 0x17007A7B RID: 31355
		// (get) Token: 0x0601969C RID: 104092 RVA: 0x003A0772 File Offset: 0x0039E972
		// (set) Token: 0x0601969D RID: 104093 RVA: 0x003A077A File Offset: 0x0039E97A
		public ERecallConditionType Type { get; set; }

		// Token: 0x17007A7C RID: 31356
		// (get) Token: 0x0601969E RID: 104094 RVA: 0x003A0783 File Offset: 0x0039E983
		// (set) Token: 0x0601969F RID: 104095 RVA: 0x003A078B File Offset: 0x0039E98B
		public ERecallOperation Operation { get; set; }

		// Token: 0x17007A7D RID: 31357
		// (get) Token: 0x060196A0 RID: 104096 RVA: 0x003A0794 File Offset: 0x0039E994
		// (set) Token: 0x060196A1 RID: 104097 RVA: 0x003A079C File Offset: 0x0039E99C
		public List<string> EntityTypes { get; set; }

		// Token: 0x17007A7E RID: 31358
		// (get) Token: 0x060196A2 RID: 104098 RVA: 0x003A07A5 File Offset: 0x0039E9A5
		// (set) Token: 0x060196A3 RID: 104099 RVA: 0x003A07AD File Offset: 0x0039E9AD
		public List<int> AreaIds { get; set; }

		// Token: 0x060196A4 RID: 104100 RVA: 0x003A07B6 File Offset: 0x0039E9B6
		public IRecallConditionByEntityTypeT()
		{
			this.Type = ERecallConditionType.ByEntityType;
			this.Operation = ERecallOperation.Include;
			this.EntityTypes = null;
			this.AreaIds = null;
		}
	}
}
