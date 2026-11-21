using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200505C RID: 20572
	public class ICheckVillageInfrTreeBuildStateT
	{
		// Token: 0x17009341 RID: 37697
		// (get) Token: 0x060202A1 RID: 131745 RVA: 0x00475DF6 File Offset: 0x00473FF6
		// (set) Token: 0x060202A2 RID: 131746 RVA: 0x00475DFE File Offset: 0x00473FFE
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17009342 RID: 37698
		// (get) Token: 0x060202A3 RID: 131747 RVA: 0x00475E07 File Offset: 0x00474007
		// (set) Token: 0x060202A4 RID: 131748 RVA: 0x00475E0F File Offset: 0x0047400F
		public int Id { get; set; }

		// Token: 0x17009343 RID: 37699
		// (get) Token: 0x060202A5 RID: 131749 RVA: 0x00475E18 File Offset: 0x00474018
		// (set) Token: 0x060202A6 RID: 131750 RVA: 0x00475E20 File Offset: 0x00474020
		public bool IsBuilt { get; set; }

		// Token: 0x060202A7 RID: 131751 RVA: 0x00475E29 File Offset: 0x00474029
		public ICheckVillageInfrTreeBuildStateT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Id = 0;
			this.IsBuilt = false;
		}
	}
}
