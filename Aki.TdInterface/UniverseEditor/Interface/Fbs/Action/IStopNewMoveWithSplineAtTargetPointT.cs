using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E8 RID: 29160
	public class IStopNewMoveWithSplineAtTargetPointT
	{
		// Token: 0x1700D891 RID: 55441
		// (get) Token: 0x06033B94 RID: 211860 RVA: 0x006F6AFC File Offset: 0x006F4CFC
		// (set) Token: 0x06033B95 RID: 211861 RVA: 0x006F6B04 File Offset: 0x006F4D04
		public EStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x1700D892 RID: 55442
		// (get) Token: 0x06033B96 RID: 211862 RVA: 0x006F6B0D File Offset: 0x006F4D0D
		// (set) Token: 0x06033B97 RID: 211863 RVA: 0x006F6B15 File Offset: 0x006F4D15
		public int PointId { get; set; }

		// Token: 0x06033B98 RID: 211864 RVA: 0x006F6B1E File Offset: 0x006F4D1E
		public IStopNewMoveWithSplineAtTargetPointT()
		{
			this.Type = EStopNewMoveWithSplineType.StopAtCurrentPos;
			this.PointId = 0;
		}
	}
}
