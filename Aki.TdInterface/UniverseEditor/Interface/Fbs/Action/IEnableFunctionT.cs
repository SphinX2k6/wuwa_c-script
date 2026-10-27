using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006664 RID: 26212
	public class IEnableFunctionT
	{
		// Token: 0x1700C2BF RID: 49855
		// (get) Token: 0x0602D897 RID: 186519 RVA: 0x0063C37A File Offset: 0x0063A57A
		// (set) Token: 0x0602D898 RID: 186520 RVA: 0x0063C382 File Offset: 0x0063A582
		public EEnableFunctionType Type { get; set; }

		// Token: 0x0602D899 RID: 186521 RVA: 0x0063C38B File Offset: 0x0063A58B
		public IEnableFunctionT()
		{
			this.Type = EEnableFunctionType.TeleportDungeon;
		}
	}
}
