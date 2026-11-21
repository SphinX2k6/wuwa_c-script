using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C4E RID: 31822
	public class ITrapDefensePlayerOperationConstraintT
	{
		// Token: 0x1700EE3F RID: 60991
		// (get) Token: 0x060395D3 RID: 234963 RVA: 0x007BED5D File Offset: 0x007BCF5D
		// (set) Token: 0x060395D4 RID: 234964 RVA: 0x007BED65 File Offset: 0x007BCF65
		public TTrapDefensePlayerOperationTypeUnion DisableOperation { get; set; }

		// Token: 0x1700EE40 RID: 60992
		// (get) Token: 0x060395D5 RID: 234965 RVA: 0x007BED6E File Offset: 0x007BCF6E
		// (set) Token: 0x060395D6 RID: 234966 RVA: 0x007BED76 File Offset: 0x007BCF76
		public bool IsConstrained { get; set; }

		// Token: 0x1700EE41 RID: 60993
		// (get) Token: 0x060395D7 RID: 234967 RVA: 0x007BED7F File Offset: 0x007BCF7F
		// (set) Token: 0x060395D8 RID: 234968 RVA: 0x007BED87 File Offset: 0x007BCF87
		public string TidPromptTxt { get; set; }

		// Token: 0x060395D9 RID: 234969 RVA: 0x007BED90 File Offset: 0x007BCF90
		public ITrapDefensePlayerOperationConstraintT()
		{
			this.DisableOperation = null;
			this.IsConstrained = false;
			this.TidPromptTxt = null;
		}
	}
}
