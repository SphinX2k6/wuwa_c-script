using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045E2 RID: 17890
	public class ITwoDimensionLevelT
	{
		// Token: 0x17007F31 RID: 32561
		// (get) Token: 0x0601B163 RID: 110947 RVA: 0x003DC36D File Offset: 0x003DA56D
		// (set) Token: 0x0601B164 RID: 110948 RVA: 0x003DC375 File Offset: 0x003DA575
		public int Id { get; set; }

		// Token: 0x17007F32 RID: 32562
		// (get) Token: 0x0601B165 RID: 110949 RVA: 0x003DC37E File Offset: 0x003DA57E
		// (set) Token: 0x0601B166 RID: 110950 RVA: 0x003DC386 File Offset: 0x003DA586
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17007F33 RID: 32563
		// (get) Token: 0x0601B167 RID: 110951 RVA: 0x003DC38F File Offset: 0x003DA58F
		// (set) Token: 0x0601B168 RID: 110952 RVA: 0x003DC397 File Offset: 0x003DA597
		public List<TTwoDimensionItemUnion> ItemList { get; set; }

		// Token: 0x0601B169 RID: 110953 RVA: 0x003DC3A0 File Offset: 0x003DA5A0
		public ITwoDimensionLevelT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.ItemList = null;
		}
	}
}
