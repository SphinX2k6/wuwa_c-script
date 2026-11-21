using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D43 RID: 19779
	public class Record_String_BooleanT
	{
		// Token: 0x17008DB4 RID: 36276
		// (get) Token: 0x0601EACB RID: 125643 RVA: 0x0044AC57 File Offset: 0x00448E57
		// (set) Token: 0x0601EACC RID: 125644 RVA: 0x0044AC5F File Offset: 0x00448E5F
		public string Key { get; set; }

		// Token: 0x17008DB5 RID: 36277
		// (get) Token: 0x0601EACD RID: 125645 RVA: 0x0044AC68 File Offset: 0x00448E68
		// (set) Token: 0x0601EACE RID: 125646 RVA: 0x0044AC70 File Offset: 0x00448E70
		public bool Value { get; set; }

		// Token: 0x0601EACF RID: 125647 RVA: 0x0044AC79 File Offset: 0x00448E79
		public Record_String_BooleanT()
		{
			this.Key = null;
			this.Value = false;
		}
	}
}
