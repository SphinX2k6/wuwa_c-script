using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200715B RID: 29019
	public class ILongPressButtonActionMappingT
	{
		// Token: 0x1700D45C RID: 54364
		// (get) Token: 0x060326A2 RID: 206498 RVA: 0x006D0543 File Offset: 0x006CE743
		// (set) Token: 0x060326A3 RID: 206499 RVA: 0x006D054B File Offset: 0x006CE74B
		public int Id { get; set; }

		// Token: 0x1700D45D RID: 54365
		// (get) Token: 0x060326A4 RID: 206500 RVA: 0x006D0554 File Offset: 0x006CE754
		// (set) Token: 0x060326A5 RID: 206501 RVA: 0x006D055C File Offset: 0x006CE75C
		public string ActionName { get; set; }

		// Token: 0x060326A6 RID: 206502 RVA: 0x006D0565 File Offset: 0x006CE765
		public ILongPressButtonActionMappingT()
		{
			this.Id = 0;
			this.ActionName = null;
		}
	}
}
