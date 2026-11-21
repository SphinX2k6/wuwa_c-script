using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007667 RID: 30311
	public class IRoguePrefabConfigT
	{
		// Token: 0x1700DE86 RID: 56966
		// (get) Token: 0x060352D7 RID: 217815 RVA: 0x007235E4 File Offset: 0x007217E4
		// (set) Token: 0x060352D8 RID: 217816 RVA: 0x007235EC File Offset: 0x007217EC
		public ECreatePrefabType Type { get; set; }

		// Token: 0x1700DE87 RID: 56967
		// (get) Token: 0x060352D9 RID: 217817 RVA: 0x007235F5 File Offset: 0x007217F5
		// (set) Token: 0x060352DA RID: 217818 RVA: 0x007235FD File Offset: 0x007217FD
		public int Index { get; set; }

		// Token: 0x060352DB RID: 217819 RVA: 0x00723606 File Offset: 0x00721806
		public IRoguePrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
			this.Index = 0;
		}
	}
}
