using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200619B RID: 24987
	public class IAssistCharacterMoveTypeT
	{
		// Token: 0x1700BA43 RID: 47683
		// (get) Token: 0x0602B0A6 RID: 176294 RVA: 0x005EFB76 File Offset: 0x005EDD76
		// (set) Token: 0x0602B0A7 RID: 176295 RVA: 0x005EFB7E File Offset: 0x005EDD7E
		public EAssistCharacterMoveType Type { get; set; }

		// Token: 0x0602B0A8 RID: 176296 RVA: 0x005EFB87 File Offset: 0x005EDD87
		public IAssistCharacterMoveTypeT()
		{
			this.Type = EAssistCharacterMoveType.Navigation;
		}
	}
}
