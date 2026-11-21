using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200754A RID: 30026
	public class IPromptStyleBattle2T
	{
		// Token: 0x1700DCDE RID: 56542
		// (get) Token: 0x06034A79 RID: 215673 RVA: 0x007156AE File Offset: 0x007138AE
		// (set) Token: 0x06034A7A RID: 215674 RVA: 0x007156B6 File Offset: 0x007138B6
		public EPromptStyle Type { get; set; }

		// Token: 0x06034A7B RID: 215675 RVA: 0x007156BF File Offset: 0x007138BF
		public IPromptStyleBattle2T()
		{
			this.Type = EPromptStyle.Default;
		}
	}
}
