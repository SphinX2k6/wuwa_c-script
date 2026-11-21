using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E90 RID: 24208
	public class IRollBlockComponentT
	{
		// Token: 0x1700B2A5 RID: 45733
		// (get) Token: 0x06028842 RID: 165954 RVA: 0x0058A218 File Offset: 0x00588418
		// (set) Token: 0x06028843 RID: 165955 RVA: 0x0058A220 File Offset: 0x00588420
		public bool Disabled { get; set; }

		// Token: 0x1700B2A6 RID: 45734
		// (get) Token: 0x06028844 RID: 165956 RVA: 0x0058A229 File Offset: 0x00588429
		// (set) Token: 0x06028845 RID: 165957 RVA: 0x0058A231 File Offset: 0x00588431
		public byte NullMask { get; set; }

		// Token: 0x06028846 RID: 165958 RVA: 0x0058A23A File Offset: 0x0058843A
		public IRollBlockComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
