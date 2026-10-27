using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048DE RID: 18654
	public class Record_String_BooleanT
	{
		// Token: 0x1700876C RID: 34668
		// (get) Token: 0x0601D2DE RID: 119518 RVA: 0x0041E4BB File Offset: 0x0041C6BB
		// (set) Token: 0x0601D2DF RID: 119519 RVA: 0x0041E4C3 File Offset: 0x0041C6C3
		public string Key { get; set; }

		// Token: 0x1700876D RID: 34669
		// (get) Token: 0x0601D2E0 RID: 119520 RVA: 0x0041E4CC File Offset: 0x0041C6CC
		// (set) Token: 0x0601D2E1 RID: 119521 RVA: 0x0041E4D4 File Offset: 0x0041C6D4
		public bool Value { get; set; }

		// Token: 0x0601D2E2 RID: 119522 RVA: 0x0041E4DD File Offset: 0x0041C6DD
		public Record_String_BooleanT()
		{
			this.Key = null;
			this.Value = false;
		}
	}
}
