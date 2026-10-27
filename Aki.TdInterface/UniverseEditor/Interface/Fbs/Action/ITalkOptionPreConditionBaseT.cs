using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733B RID: 29499
	public class ITalkOptionPreConditionBaseT
	{
		// Token: 0x1700E00C RID: 57356
		// (get) Token: 0x06035890 RID: 219280 RVA: 0x0074AD7A File Offset: 0x00748F7A
		// (set) Token: 0x06035891 RID: 219281 RVA: 0x0074AD82 File Offset: 0x00748F82
		public ETalkOptionPreConditionType Type { get; set; }

		// Token: 0x06035892 RID: 219282 RVA: 0x0074AD8B File Offset: 0x00748F8B
		public ITalkOptionPreConditionBaseT()
		{
			this.Type = ETalkOptionPreConditionType.PreOption;
		}
	}
}
