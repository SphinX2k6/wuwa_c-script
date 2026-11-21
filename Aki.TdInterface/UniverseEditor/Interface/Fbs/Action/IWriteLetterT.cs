using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E25 RID: 32293
	public class IWriteLetterT
	{
		// Token: 0x1700F1D4 RID: 61908
		// (get) Token: 0x0603A5B1 RID: 239025 RVA: 0x007DC23C File Offset: 0x007DA43C
		// (set) Token: 0x0603A5B2 RID: 239026 RVA: 0x007DC244 File Offset: 0x007DA444
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700F1D5 RID: 61909
		// (get) Token: 0x0603A5B3 RID: 239027 RVA: 0x007DC24D File Offset: 0x007DA44D
		// (set) Token: 0x0603A5B4 RID: 239028 RVA: 0x007DC255 File Offset: 0x007DA455
		public int Id { get; set; }

		// Token: 0x0603A5B5 RID: 239029 RVA: 0x007DC25E File Offset: 0x007DA45E
		public IWriteLetterT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Id = 0;
		}
	}
}
