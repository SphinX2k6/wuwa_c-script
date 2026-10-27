using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007329 RID: 29481
	public class ITalkOptionConditionSystemConfigBaseT
	{
		// Token: 0x1700DFF8 RID: 57336
		// (get) Token: 0x0603581C RID: 219164 RVA: 0x0074A2F6 File Offset: 0x007484F6
		// (set) Token: 0x0603581D RID: 219165 RVA: 0x0074A2FE File Offset: 0x007484FE
		public ETalkOptionConditionSystem Type { get; set; }

		// Token: 0x0603581E RID: 219166 RVA: 0x0074A307 File Offset: 0x00748507
		public ITalkOptionConditionSystemConfigBaseT()
		{
			this.Type = ETalkOptionConditionSystem.SolarSchool;
		}
	}
}
