using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F63 RID: 20323
	public class ICheckIsPlayerHoldingHandsT
	{
		// Token: 0x1700913E RID: 37182
		// (get) Token: 0x0601FA09 RID: 129545 RVA: 0x00465F2A File Offset: 0x0046412A
		// (set) Token: 0x0601FA0A RID: 129546 RVA: 0x00465F32 File Offset: 0x00464132
		public ECheckHoldingHandsCharacter Type { get; set; }

		// Token: 0x0601FA0B RID: 129547 RVA: 0x00465F3B File Offset: 0x0046413B
		public ICheckIsPlayerHoldingHandsT()
		{
			this.Type = ECheckHoldingHandsCharacter.Player;
		}
	}
}
