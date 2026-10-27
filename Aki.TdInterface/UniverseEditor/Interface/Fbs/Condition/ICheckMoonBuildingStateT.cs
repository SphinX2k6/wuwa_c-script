using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ACA RID: 19146
	public class ICheckMoonBuildingStateT
	{
		// Token: 0x17008AD0 RID: 35536
		// (get) Token: 0x0601E108 RID: 123144 RVA: 0x00437D32 File Offset: 0x00435F32
		// (set) Token: 0x0601E109 RID: 123145 RVA: 0x00437D3A File Offset: 0x00435F3A
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008AD1 RID: 35537
		// (get) Token: 0x0601E10A RID: 123146 RVA: 0x00437D43 File Offset: 0x00435F43
		// (set) Token: 0x0601E10B RID: 123147 RVA: 0x00437D4B File Offset: 0x00435F4B
		public int BuildingId { get; set; }

		// Token: 0x17008AD2 RID: 35538
		// (get) Token: 0x0601E10C RID: 123148 RVA: 0x00437D54 File Offset: 0x00435F54
		// (set) Token: 0x0601E10D RID: 123149 RVA: 0x00437D5C File Offset: 0x00435F5C
		public bool IsBuilt { get; set; }

		// Token: 0x0601E10E RID: 123150 RVA: 0x00437D65 File Offset: 0x00435F65
		public ICheckMoonBuildingStateT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.BuildingId = 0;
			this.IsBuilt = false;
		}
	}
}
