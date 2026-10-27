using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A97 RID: 19095
	public class ICheckIsPlayerHoldingHandsT
	{
		// Token: 0x17008A58 RID: 35416
		// (get) Token: 0x0601DF3A RID: 122682 RVA: 0x0043499E File Offset: 0x00432B9E
		// (set) Token: 0x0601DF3B RID: 122683 RVA: 0x004349A6 File Offset: 0x00432BA6
		public ECheckHoldingHandsCharacter Type { get; set; }

		// Token: 0x0601DF3C RID: 122684 RVA: 0x004349AF File Offset: 0x00432BAF
		public ICheckIsPlayerHoldingHandsT()
		{
			this.Type = ECheckHoldingHandsCharacter.Player;
		}
	}
}
