using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B84 RID: 19332
	public class Record_String_StringT
	{
		// Token: 0x170088AF RID: 34991
		// (get) Token: 0x0601D714 RID: 120596 RVA: 0x0042269E File Offset: 0x0042089E
		// (set) Token: 0x0601D715 RID: 120597 RVA: 0x004226A6 File Offset: 0x004208A6
		public string Key { get; set; }

		// Token: 0x170088B0 RID: 34992
		// (get) Token: 0x0601D716 RID: 120598 RVA: 0x004226AF File Offset: 0x004208AF
		// (set) Token: 0x0601D717 RID: 120599 RVA: 0x004226B7 File Offset: 0x004208B7
		public string Value { get; set; }

		// Token: 0x0601D718 RID: 120600 RVA: 0x004226C0 File Offset: 0x004208C0
		public Record_String_StringT()
		{
			this.Key = null;
			this.Value = null;
		}
	}
}
