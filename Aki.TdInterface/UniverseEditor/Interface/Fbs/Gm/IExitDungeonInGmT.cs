using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004649 RID: 17993
	public class IExitDungeonInGmT
	{
		// Token: 0x17007FA8 RID: 32680
		// (get) Token: 0x0601B41D RID: 111645 RVA: 0x003E0F02 File Offset: 0x003DF102
		// (set) Token: 0x0601B41E RID: 111646 RVA: 0x003E0F0A File Offset: 0x003DF10A
		public EGmCommand Type { get; set; }

		// Token: 0x0601B41F RID: 111647 RVA: 0x003E0F13 File Offset: 0x003DF113
		public IExitDungeonInGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
