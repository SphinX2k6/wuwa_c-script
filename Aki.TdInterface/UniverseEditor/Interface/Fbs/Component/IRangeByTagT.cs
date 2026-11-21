using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E01 RID: 24065
	public class IRangeByTagT
	{
		// Token: 0x1700B163 RID: 45411
		// (get) Token: 0x060282D8 RID: 164568 RVA: 0x0057EADC File Offset: 0x0057CCDC
		// (set) Token: 0x060282D9 RID: 164569 RVA: 0x0057EAE4 File Offset: 0x0057CCE4
		public int Tag { get; set; }

		// Token: 0x1700B164 RID: 45412
		// (get) Token: 0x060282DA RID: 164570 RVA: 0x0057EAED File Offset: 0x0057CCED
		// (set) Token: 0x060282DB RID: 164571 RVA: 0x0057EAF5 File Offset: 0x0057CCF5
		public float Range { get; set; }

		// Token: 0x1700B165 RID: 45413
		// (get) Token: 0x060282DC RID: 164572 RVA: 0x0057EAFE File Offset: 0x0057CCFE
		// (set) Token: 0x060282DD RID: 164573 RVA: 0x0057EB06 File Offset: 0x0057CD06
		public float ExitRange { get; set; }

		// Token: 0x1700B166 RID: 45414
		// (get) Token: 0x060282DE RID: 164574 RVA: 0x0057EB0F File Offset: 0x0057CD0F
		// (set) Token: 0x060282DF RID: 164575 RVA: 0x0057EB17 File Offset: 0x0057CD17
		public byte NullMask { get; set; }

		// Token: 0x060282E0 RID: 164576 RVA: 0x0057EB20 File Offset: 0x0057CD20
		public IRangeByTagT()
		{
			this.Tag = 0;
			this.Range = 0f;
			this.ExitRange = 0f;
			this.NullMask = 0;
		}
	}
}
