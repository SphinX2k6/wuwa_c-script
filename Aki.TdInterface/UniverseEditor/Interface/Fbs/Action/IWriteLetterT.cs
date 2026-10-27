using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007617 RID: 30231
	public class IWriteLetterT
	{
		// Token: 0x1700E596 RID: 58774
		// (get) Token: 0x0603710C RID: 225548 RVA: 0x00778140 File Offset: 0x00776340
		// (set) Token: 0x0603710D RID: 225549 RVA: 0x00778148 File Offset: 0x00776348
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700E597 RID: 58775
		// (get) Token: 0x0603710E RID: 225550 RVA: 0x00778151 File Offset: 0x00776351
		// (set) Token: 0x0603710F RID: 225551 RVA: 0x00778159 File Offset: 0x00776359
		public int Id { get; set; }

		// Token: 0x06037110 RID: 225552 RVA: 0x00778162 File Offset: 0x00776362
		public IWriteLetterT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Id = 0;
		}
	}
}
