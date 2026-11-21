using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E34 RID: 32308
	public class Record_String_StringsT
	{
		// Token: 0x1700F1EB RID: 61931
		// (get) Token: 0x0603A629 RID: 239145 RVA: 0x007DCF74 File Offset: 0x007DB174
		// (set) Token: 0x0603A62A RID: 239146 RVA: 0x007DCF7C File Offset: 0x007DB17C
		public string Key { get; set; }

		// Token: 0x1700F1EC RID: 61932
		// (get) Token: 0x0603A62B RID: 239147 RVA: 0x007DCF85 File Offset: 0x007DB185
		// (set) Token: 0x0603A62C RID: 239148 RVA: 0x007DCF8D File Offset: 0x007DB18D
		public List<string> Values { get; set; }

		// Token: 0x0603A62D RID: 239149 RVA: 0x007DCF96 File Offset: 0x007DB196
		public Record_String_StringsT()
		{
			this.Key = null;
			this.Values = null;
		}
	}
}
