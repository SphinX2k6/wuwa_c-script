using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FF3 RID: 20467
	public class ICheckRoadBuildStateT
	{
		// Token: 0x1700926F RID: 37487
		// (get) Token: 0x0601FEFF RID: 130815 RVA: 0x0046F1A2 File Offset: 0x0046D3A2
		// (set) Token: 0x0601FF00 RID: 130816 RVA: 0x0046F1AA File Offset: 0x0046D3AA
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17009270 RID: 37488
		// (get) Token: 0x0601FF01 RID: 130817 RVA: 0x0046F1B3 File Offset: 0x0046D3B3
		// (set) Token: 0x0601FF02 RID: 130818 RVA: 0x0046F1BB File Offset: 0x0046D3BB
		public int RoadId { get; set; }

		// Token: 0x17009271 RID: 37489
		// (get) Token: 0x0601FF03 RID: 130819 RVA: 0x0046F1C4 File Offset: 0x0046D3C4
		// (set) Token: 0x0601FF04 RID: 130820 RVA: 0x0046F1CC File Offset: 0x0046D3CC
		public bool IsBuilt { get; set; }

		// Token: 0x0601FF05 RID: 130821 RVA: 0x0046F1D5 File Offset: 0x0046D3D5
		public ICheckRoadBuildStateT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.RoadId = 0;
			this.IsBuilt = false;
		}
	}
}
