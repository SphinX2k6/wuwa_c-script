using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004212 RID: 16914
	public class IDisableTrackAnimT
	{
		// Token: 0x17007334 RID: 29492
		// (get) Token: 0x060177DA RID: 96218 RVA: 0x0035AAF1 File Offset: 0x00358CF1
		// (set) Token: 0x060177DB RID: 96219 RVA: 0x0035AAF9 File Offset: 0x00358CF9
		public IConditionGroupT Condition { get; set; }

		// Token: 0x060177DC RID: 96220 RVA: 0x0035AB02 File Offset: 0x00358D02
		public IDisableTrackAnimT()
		{
			this.Condition = null;
		}
	}
}
