using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B13 RID: 31507
	public class ITalkOptionPreConditionBaseT
	{
		// Token: 0x1700EC08 RID: 60424
		// (get) Token: 0x06038BC3 RID: 232387 RVA: 0x007AC902 File Offset: 0x007AAB02
		// (set) Token: 0x06038BC4 RID: 232388 RVA: 0x007AC90A File Offset: 0x007AAB0A
		public ETalkOptionPreConditionType Type { get; set; }

		// Token: 0x06038BC5 RID: 232389 RVA: 0x007AC913 File Offset: 0x007AAB13
		public ITalkOptionPreConditionBaseT()
		{
			this.Type = ETalkOptionPreConditionType.PreOption;
		}
	}
}
