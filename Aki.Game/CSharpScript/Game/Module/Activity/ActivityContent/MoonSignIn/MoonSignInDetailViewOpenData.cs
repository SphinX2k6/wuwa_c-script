using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x020053DF RID: 21471
	internal class MoonSignInDetailViewOpenData : IMoonSignInDetailViewOpenData
	{
		// Token: 0x170067ED RID: 26605
		// (get) Token: 0x06035607 RID: 218631 RVA: 0x00EE8203 File Offset: 0x00EE6403
		// (set) Token: 0x06035608 RID: 218632 RVA: 0x00EE820B File Offset: 0x00EE640B
		public int MoonId { get; set; }

		// Token: 0x170067EE RID: 26606
		// (get) Token: 0x06035609 RID: 218633 RVA: 0x00EE8214 File Offset: 0x00EE6414
		// (set) Token: 0x0603560A RID: 218634 RVA: 0x00EE821C File Offset: 0x00EE641C
		public bool? Wishing { get; set; } = new bool?(false);
	}
}
