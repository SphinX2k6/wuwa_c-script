using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044C1 RID: 17601
	public class IRecallConditionByTemplateT
	{
		// Token: 0x17007A8B RID: 31371
		// (get) Token: 0x060196EA RID: 104170 RVA: 0x003A10AE File Offset: 0x0039F2AE
		// (set) Token: 0x060196EB RID: 104171 RVA: 0x003A10B6 File Offset: 0x0039F2B6
		public ERecallConditionType Type { get; set; }

		// Token: 0x17007A8C RID: 31372
		// (get) Token: 0x060196EC RID: 104172 RVA: 0x003A10BF File Offset: 0x0039F2BF
		// (set) Token: 0x060196ED RID: 104173 RVA: 0x003A10C7 File Offset: 0x0039F2C7
		public ERecallOperation Operation { get; set; }

		// Token: 0x17007A8D RID: 31373
		// (get) Token: 0x060196EE RID: 104174 RVA: 0x003A10D0 File Offset: 0x0039F2D0
		// (set) Token: 0x060196EF RID: 104175 RVA: 0x003A10D8 File Offset: 0x0039F2D8
		public List<string> Templates { get; set; }

		// Token: 0x17007A8E RID: 31374
		// (get) Token: 0x060196F0 RID: 104176 RVA: 0x003A10E1 File Offset: 0x0039F2E1
		// (set) Token: 0x060196F1 RID: 104177 RVA: 0x003A10E9 File Offset: 0x0039F2E9
		public List<int> AreaIds { get; set; }

		// Token: 0x060196F2 RID: 104178 RVA: 0x003A10F2 File Offset: 0x0039F2F2
		public IRecallConditionByTemplateT()
		{
			this.Type = ERecallConditionType.ByEntityType;
			this.Operation = ERecallOperation.Include;
			this.Templates = null;
			this.AreaIds = null;
		}
	}
}
