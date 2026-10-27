using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCC RID: 28108
	public class IPromptStyleBattleT
	{
		// Token: 0x1700D193 RID: 53651
		// (get) Token: 0x06031A6B RID: 203371 RVA: 0x006B9E4E File Offset: 0x006B804E
		// (set) Token: 0x06031A6C RID: 203372 RVA: 0x006B9E56 File Offset: 0x006B8056
		public EPromptStyle Type { get; set; }

		// Token: 0x06031A6D RID: 203373 RVA: 0x006B9E5F File Offset: 0x006B805F
		public IPromptStyleBattleT()
		{
			this.Type = EPromptStyle.Default;
		}
	}
}
