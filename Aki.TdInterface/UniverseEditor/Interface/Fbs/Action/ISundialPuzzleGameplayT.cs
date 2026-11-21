using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A11 RID: 31249
	public class ISundialPuzzleGameplayT
	{
		// Token: 0x1700E4FC RID: 58620
		// (get) Token: 0x060370F0 RID: 225520 RVA: 0x0075BB8E File Offset: 0x00759D8E
		// (set) Token: 0x060370F1 RID: 225521 RVA: 0x0075BB96 File Offset: 0x00759D96
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x060370F2 RID: 225522 RVA: 0x0075BB9F File Offset: 0x00759D9F
		public ISundialPuzzleGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
