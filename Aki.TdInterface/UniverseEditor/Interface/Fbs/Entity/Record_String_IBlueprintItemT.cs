using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C5C RID: 19548
	public class Record_String_IBlueprintItemT
	{
		// Token: 0x17008AAC RID: 35500
		// (get) Token: 0x0601DFDB RID: 122843 RVA: 0x004345BF File Offset: 0x004327BF
		// (set) Token: 0x0601DFDC RID: 122844 RVA: 0x004345C7 File Offset: 0x004327C7
		public string Key { get; set; }

		// Token: 0x17008AAD RID: 35501
		// (get) Token: 0x0601DFDD RID: 122845 RVA: 0x004345D0 File Offset: 0x004327D0
		// (set) Token: 0x0601DFDE RID: 122846 RVA: 0x004345D8 File Offset: 0x004327D8
		public IBlueprintItemT Value { get; set; }

		// Token: 0x0601DFDF RID: 122847 RVA: 0x004345E1 File Offset: 0x004327E1
		public Record_String_IBlueprintItemT()
		{
			this.Key = null;
			this.Value = null;
		}
	}
}
