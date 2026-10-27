using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047F4 RID: 18420
	public class Record_String_IBlueprintItemT
	{
		// Token: 0x17008461 RID: 33889
		// (get) Token: 0x0601C7DE RID: 116702 RVA: 0x00407C6F File Offset: 0x00405E6F
		// (set) Token: 0x0601C7DF RID: 116703 RVA: 0x00407C77 File Offset: 0x00405E77
		public string Key { get; set; }

		// Token: 0x17008462 RID: 33890
		// (get) Token: 0x0601C7E0 RID: 116704 RVA: 0x00407C80 File Offset: 0x00405E80
		// (set) Token: 0x0601C7E1 RID: 116705 RVA: 0x00407C88 File Offset: 0x00405E88
		public IBlueprintItemT Value { get; set; }

		// Token: 0x0601C7E2 RID: 116706 RVA: 0x00407C91 File Offset: 0x00405E91
		public Record_String_IBlueprintItemT()
		{
			this.Key = null;
			this.Value = null;
		}
	}
}
