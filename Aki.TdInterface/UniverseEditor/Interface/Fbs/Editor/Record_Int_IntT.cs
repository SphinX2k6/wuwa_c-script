using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D3A RID: 19770
	public class Record_Int_IntT
	{
		// Token: 0x17008DA5 RID: 36261
		// (get) Token: 0x0601EA79 RID: 125561 RVA: 0x0044A3B0 File Offset: 0x004485B0
		// (set) Token: 0x0601EA7A RID: 125562 RVA: 0x0044A3B8 File Offset: 0x004485B8
		public int Key { get; set; }

		// Token: 0x17008DA6 RID: 36262
		// (get) Token: 0x0601EA7B RID: 125563 RVA: 0x0044A3C1 File Offset: 0x004485C1
		// (set) Token: 0x0601EA7C RID: 125564 RVA: 0x0044A3C9 File Offset: 0x004485C9
		public int Value { get; set; }

		// Token: 0x0601EA7D RID: 125565 RVA: 0x0044A3D2 File Offset: 0x004485D2
		public Record_Int_IntT()
		{
			this.Key = 0;
			this.Value = 0;
		}
	}
}
