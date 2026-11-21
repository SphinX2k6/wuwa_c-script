using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071BA RID: 29114
	public class IMechStuntDiveT
	{
		// Token: 0x1700D53B RID: 54587
		// (get) Token: 0x06032A50 RID: 207440 RVA: 0x006D7C26 File Offset: 0x006D5E26
		// (set) Token: 0x06032A51 RID: 207441 RVA: 0x006D7C2E File Offset: 0x006D5E2E
		public EMechStuntType Type { get; set; }

		// Token: 0x06032A52 RID: 207442 RVA: 0x006D7C37 File Offset: 0x006D5E37
		public IMechStuntDiveT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
