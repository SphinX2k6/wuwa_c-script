using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005462 RID: 21602
	public class IInteractPlayerDiractionTypeT
	{
		// Token: 0x17009F0F RID: 40719
		// (get) Token: 0x060238A3 RID: 145571 RVA: 0x004EA822 File Offset: 0x004E8A22
		// (set) Token: 0x060238A4 RID: 145572 RVA: 0x004EA82A File Offset: 0x004E8A2A
		public EInteractPlayerDiractionType Type { get; set; }

		// Token: 0x060238A5 RID: 145573 RVA: 0x004EA833 File Offset: 0x004E8A33
		public IInteractPlayerDiractionTypeT()
		{
			this.Type = EInteractPlayerDiractionType.Npc;
		}
	}
}
