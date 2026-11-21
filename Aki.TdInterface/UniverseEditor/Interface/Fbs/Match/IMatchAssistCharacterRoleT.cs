using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004860 RID: 18528
	public class IMatchAssistCharacterRoleT
	{
		// Token: 0x17008104 RID: 33028
		// (get) Token: 0x0601B63B RID: 112187 RVA: 0x003E0DCB File Offset: 0x003DEFCB
		// (set) Token: 0x0601B63C RID: 112188 RVA: 0x003E0DD3 File Offset: 0x003DEFD3
		public EMatchRoleType Type { get; set; }

		// Token: 0x17008105 RID: 33029
		// (get) Token: 0x0601B63D RID: 112189 RVA: 0x003E0DDC File Offset: 0x003DEFDC
		// (set) Token: 0x0601B63E RID: 112190 RVA: 0x003E0DE4 File Offset: 0x003DEFE4
		public List<int> Characters { get; set; }

		// Token: 0x0601B63F RID: 112191 RVA: 0x003E0DED File Offset: 0x003DEFED
		public IMatchAssistCharacterRoleT()
		{
			this.Type = EMatchRoleType.Player;
			this.Characters = null;
		}
	}
}
