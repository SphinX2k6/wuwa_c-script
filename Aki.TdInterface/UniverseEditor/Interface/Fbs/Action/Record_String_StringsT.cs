using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007626 RID: 30246
	public class Record_String_StringsT
	{
		// Token: 0x1700E5AD RID: 58797
		// (get) Token: 0x06037184 RID: 225668 RVA: 0x00778E78 File Offset: 0x00777078
		// (set) Token: 0x06037185 RID: 225669 RVA: 0x00778E80 File Offset: 0x00777080
		public string Key { get; set; }

		// Token: 0x1700E5AE RID: 58798
		// (get) Token: 0x06037186 RID: 225670 RVA: 0x00778E89 File Offset: 0x00777089
		// (set) Token: 0x06037187 RID: 225671 RVA: 0x00778E91 File Offset: 0x00777091
		public List<string> Values { get; set; }

		// Token: 0x06037188 RID: 225672 RVA: 0x00778E9A File Offset: 0x0077709A
		public Record_String_StringsT()
		{
			this.Key = null;
			this.Values = null;
		}
	}
}
