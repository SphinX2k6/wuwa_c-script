using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006899 RID: 26777
	public class IBrokenRockT
	{
		// Token: 0x1700C4C5 RID: 50373
		// (get) Token: 0x0602DC69 RID: 187497 RVA: 0x00641D64 File Offset: 0x0063FF64
		// (set) Token: 0x0602DC6A RID: 187498 RVA: 0x00641D6C File Offset: 0x0063FF6C
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C4C6 RID: 50374
		// (get) Token: 0x0602DC6B RID: 187499 RVA: 0x00641D75 File Offset: 0x0063FF75
		// (set) Token: 0x0602DC6C RID: 187500 RVA: 0x00641D7D File Offset: 0x0063FF7D
		public int Id { get; set; }

		// Token: 0x0602DC6D RID: 187501 RVA: 0x00641D86 File Offset: 0x0063FF86
		public IBrokenRockT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Id = 0;
		}
	}
}
