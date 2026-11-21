using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E93 RID: 24211
	public class IRollBlockFloorComponentT
	{
		// Token: 0x1700B2AA RID: 45738
		// (get) Token: 0x06028858 RID: 165976 RVA: 0x0058A41C File Offset: 0x0058861C
		// (set) Token: 0x06028859 RID: 165977 RVA: 0x0058A424 File Offset: 0x00588624
		public bool Disabled { get; set; }

		// Token: 0x1700B2AB RID: 45739
		// (get) Token: 0x0602885A RID: 165978 RVA: 0x0058A42D File Offset: 0x0058862D
		// (set) Token: 0x0602885B RID: 165979 RVA: 0x0058A435 File Offset: 0x00588635
		public byte NullMask { get; set; }

		// Token: 0x0602885C RID: 165980 RVA: 0x0058A43E File Offset: 0x0058863E
		public IRollBlockFloorComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
