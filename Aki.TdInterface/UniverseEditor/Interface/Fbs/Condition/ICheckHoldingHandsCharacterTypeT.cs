using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A4C RID: 19020
	public class ICheckHoldingHandsCharacterTypeT
	{
		// Token: 0x170089B2 RID: 35250
		// (get) Token: 0x0601DC96 RID: 122006 RVA: 0x0042FFC6 File Offset: 0x0042E1C6
		// (set) Token: 0x0601DC97 RID: 122007 RVA: 0x0042FFCE File Offset: 0x0042E1CE
		public ECheckHoldingHandsCharacter Type { get; set; }

		// Token: 0x0601DC98 RID: 122008 RVA: 0x0042FFD7 File Offset: 0x0042E1D7
		public ICheckHoldingHandsCharacterTypeT()
		{
			this.Type = ECheckHoldingHandsCharacter.Player;
		}
	}
}
