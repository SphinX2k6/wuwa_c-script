using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200545F RID: 21599
	public class IInteractPlayerDiractionToNpcT
	{
		// Token: 0x17009F0C RID: 40716
		// (get) Token: 0x06023891 RID: 145553 RVA: 0x004EA6AA File Offset: 0x004E88AA
		// (set) Token: 0x06023892 RID: 145554 RVA: 0x004EA6B2 File Offset: 0x004E88B2
		public EInteractPlayerDiractionType Type { get; set; }

		// Token: 0x06023893 RID: 145555 RVA: 0x004EA6BB File Offset: 0x004E88BB
		public IInteractPlayerDiractionToNpcT()
		{
			this.Type = EInteractPlayerDiractionType.Npc;
		}
	}
}
