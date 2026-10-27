using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B75 RID: 19317
	public class ICheckVillageInfrTreeBuildStateT
	{
		// Token: 0x17008C31 RID: 35889
		// (get) Token: 0x0601E713 RID: 124691 RVA: 0x004435AA File Offset: 0x004417AA
		// (set) Token: 0x0601E714 RID: 124692 RVA: 0x004435B2 File Offset: 0x004417B2
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008C32 RID: 35890
		// (get) Token: 0x0601E715 RID: 124693 RVA: 0x004435BB File Offset: 0x004417BB
		// (set) Token: 0x0601E716 RID: 124694 RVA: 0x004435C3 File Offset: 0x004417C3
		public int Id { get; set; }

		// Token: 0x17008C33 RID: 35891
		// (get) Token: 0x0601E717 RID: 124695 RVA: 0x004435CC File Offset: 0x004417CC
		// (set) Token: 0x0601E718 RID: 124696 RVA: 0x004435D4 File Offset: 0x004417D4
		public bool IsBuilt { get; set; }

		// Token: 0x0601E719 RID: 124697 RVA: 0x004435DD File Offset: 0x004417DD
		public ICheckVillageInfrTreeBuildStateT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Id = 0;
			this.IsBuilt = false;
		}
	}
}
