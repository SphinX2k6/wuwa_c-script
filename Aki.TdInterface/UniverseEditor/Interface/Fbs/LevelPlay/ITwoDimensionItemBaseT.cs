using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045DC RID: 17884
	public class ITwoDimensionItemBaseT
	{
		// Token: 0x17007F27 RID: 32551
		// (get) Token: 0x0601B123 RID: 110883 RVA: 0x003DBA35 File Offset: 0x003D9C35
		// (set) Token: 0x0601B124 RID: 110884 RVA: 0x003DBA3D File Offset: 0x003D9C3D
		public int Id { get; set; }

		// Token: 0x17007F28 RID: 32552
		// (get) Token: 0x0601B125 RID: 110885 RVA: 0x003DBA46 File Offset: 0x003D9C46
		// (set) Token: 0x0601B126 RID: 110886 RVA: 0x003DBA4E File Offset: 0x003D9C4E
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17007F29 RID: 32553
		// (get) Token: 0x0601B127 RID: 110887 RVA: 0x003DBA57 File Offset: 0x003D9C57
		// (set) Token: 0x0601B128 RID: 110888 RVA: 0x003DBA5F File Offset: 0x003D9C5F
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x0601B129 RID: 110889 RVA: 0x003DBA68 File Offset: 0x003D9C68
		public ITwoDimensionItemBaseT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.Transform = null;
		}
	}
}
