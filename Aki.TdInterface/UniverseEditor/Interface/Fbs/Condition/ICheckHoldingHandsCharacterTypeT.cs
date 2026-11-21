using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F12 RID: 20242
	public class ICheckHoldingHandsCharacterTypeT
	{
		// Token: 0x1700908E RID: 37006
		// (get) Token: 0x0601F739 RID: 128825 RVA: 0x00461152 File Offset: 0x0045F352
		// (set) Token: 0x0601F73A RID: 128826 RVA: 0x0046115A File Offset: 0x0045F35A
		public ECheckHoldingHandsCharacter Type { get; set; }

		// Token: 0x0601F73B RID: 128827 RVA: 0x00461163 File Offset: 0x0045F363
		public ICheckHoldingHandsCharacterTypeT()
		{
			this.Type = ECheckHoldingHandsCharacter.Player;
		}
	}
}
