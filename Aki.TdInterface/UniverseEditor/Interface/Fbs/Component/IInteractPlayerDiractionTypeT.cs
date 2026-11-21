using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E8 RID: 23016
	public class IInteractPlayerDiractionTypeT
	{
		// Token: 0x1700A749 RID: 42825
		// (get) Token: 0x0602595B RID: 153947 RVA: 0x00527896 File Offset: 0x00525A96
		// (set) Token: 0x0602595C RID: 153948 RVA: 0x0052789E File Offset: 0x00525A9E
		public EInteractPlayerDiractionType Type { get; set; }

		// Token: 0x0602595D RID: 153949 RVA: 0x005278A7 File Offset: 0x00525AA7
		public IInteractPlayerDiractionTypeT()
		{
			this.Type = EInteractPlayerDiractionType.Npc;
		}
	}
}
