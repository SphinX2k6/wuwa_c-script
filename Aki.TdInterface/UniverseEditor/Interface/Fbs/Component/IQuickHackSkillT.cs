using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DD7 RID: 24023
	public class IQuickHackSkillT
	{
		// Token: 0x1700B0F9 RID: 45305
		// (get) Token: 0x06028108 RID: 164104 RVA: 0x0057AA23 File Offset: 0x00578C23
		// (set) Token: 0x06028109 RID: 164105 RVA: 0x0057AA2B File Offset: 0x00578C2B
		public int Id { get; set; }

		// Token: 0x1700B0FA RID: 45306
		// (get) Token: 0x0602810A RID: 164106 RVA: 0x0057AA34 File Offset: 0x00578C34
		// (set) Token: 0x0602810B RID: 164107 RVA: 0x0057AA3C File Offset: 0x00578C3C
		public List<IQuickHackSkillContentT> Content { get; set; }

		// Token: 0x0602810C RID: 164108 RVA: 0x0057AA45 File Offset: 0x00578C45
		public IQuickHackSkillT()
		{
			this.Id = 0;
			this.Content = null;
		}
	}
}
