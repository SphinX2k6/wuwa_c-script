using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B01 RID: 31489
	public class ITalkOptionConditionSystemConfigBaseT
	{
		// Token: 0x1700EBF4 RID: 60404
		// (get) Token: 0x06038B4F RID: 232271 RVA: 0x007ABE7E File Offset: 0x007AA07E
		// (set) Token: 0x06038B50 RID: 232272 RVA: 0x007ABE86 File Offset: 0x007AA086
		public ETalkOptionConditionSystem Type { get; set; }

		// Token: 0x06038B51 RID: 232273 RVA: 0x007ABE8F File Offset: 0x007AA08F
		public ITalkOptionConditionSystemConfigBaseT()
		{
			this.Type = ETalkOptionConditionSystem.SolarSchool;
		}
	}
}
