using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F9C RID: 20380
	public class ICheckMoonBuildingStateT
	{
		// Token: 0x170091C2 RID: 37314
		// (get) Token: 0x0601FC07 RID: 130055 RVA: 0x004697DE File Offset: 0x004679DE
		// (set) Token: 0x0601FC08 RID: 130056 RVA: 0x004697E6 File Offset: 0x004679E6
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x170091C3 RID: 37315
		// (get) Token: 0x0601FC09 RID: 130057 RVA: 0x004697EF File Offset: 0x004679EF
		// (set) Token: 0x0601FC0A RID: 130058 RVA: 0x004697F7 File Offset: 0x004679F7
		public int BuildingId { get; set; }

		// Token: 0x170091C4 RID: 37316
		// (get) Token: 0x0601FC0B RID: 130059 RVA: 0x00469800 File Offset: 0x00467A00
		// (set) Token: 0x0601FC0C RID: 130060 RVA: 0x00469808 File Offset: 0x00467A08
		public bool IsBuilt { get; set; }

		// Token: 0x0601FC0D RID: 130061 RVA: 0x00469811 File Offset: 0x00467A11
		public ICheckMoonBuildingStateT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.BuildingId = 0;
			this.IsBuilt = false;
		}
	}
}
