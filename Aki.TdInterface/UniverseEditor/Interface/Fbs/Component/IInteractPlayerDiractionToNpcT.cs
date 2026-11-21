using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E5 RID: 23013
	public class IInteractPlayerDiractionToNpcT
	{
		// Token: 0x1700A746 RID: 42822
		// (get) Token: 0x06025949 RID: 153929 RVA: 0x0052771E File Offset: 0x0052591E
		// (set) Token: 0x0602594A RID: 153930 RVA: 0x00527726 File Offset: 0x00525926
		public EInteractPlayerDiractionType Type { get; set; }

		// Token: 0x0602594B RID: 153931 RVA: 0x0052772F File Offset: 0x0052592F
		public IInteractPlayerDiractionToNpcT()
		{
			this.Type = EInteractPlayerDiractionType.Npc;
		}
	}
}
