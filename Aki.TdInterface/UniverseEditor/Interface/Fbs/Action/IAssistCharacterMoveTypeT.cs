using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006806 RID: 26630
	public class IAssistCharacterMoveTypeT
	{
		// Token: 0x1700C3C1 RID: 50113
		// (get) Token: 0x0602D7D7 RID: 186327 RVA: 0x0063A3EA File Offset: 0x006385EA
		// (set) Token: 0x0602D7D8 RID: 186328 RVA: 0x0063A3F2 File Offset: 0x006385F2
		public EAssistCharacterMoveType Type { get; set; }

		// Token: 0x0602D7D9 RID: 186329 RVA: 0x0063A3FB File Offset: 0x006385FB
		public IAssistCharacterMoveTypeT()
		{
			this.Type = EAssistCharacterMoveType.Navigation;
		}
	}
}
