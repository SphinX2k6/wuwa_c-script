using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077DD RID: 30685
	public class ISetJigsawItemTypeT
	{
		// Token: 0x1700E0E4 RID: 57572
		// (get) Token: 0x06035E65 RID: 220773 RVA: 0x00738926 File Offset: 0x00736B26
		// (set) Token: 0x06035E66 RID: 220774 RVA: 0x0073892E File Offset: 0x00736B2E
		public ESetJigsawItemType Type { get; set; }

		// Token: 0x06035E67 RID: 220775 RVA: 0x00738937 File Offset: 0x00736B37
		public ISetJigsawItemTypeT()
		{
			this.Type = ESetJigsawItemType.MoveJigsawItem;
		}
	}
}
