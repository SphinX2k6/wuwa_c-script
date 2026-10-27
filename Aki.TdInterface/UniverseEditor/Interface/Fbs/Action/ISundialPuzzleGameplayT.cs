using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200723C RID: 29244
	public class ISundialPuzzleGameplayT
	{
		// Token: 0x1700D903 RID: 55555
		// (get) Token: 0x06033DEE RID: 212462 RVA: 0x006FA82E File Offset: 0x006F8A2E
		// (set) Token: 0x06033DEF RID: 212463 RVA: 0x006FA836 File Offset: 0x006F8A36
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x06033DF0 RID: 212464 RVA: 0x006FA83F File Offset: 0x006F8A3F
		public ISundialPuzzleGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
