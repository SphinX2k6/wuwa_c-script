using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E2 RID: 29154
	public class IStopNewMoveWithSplineAtEndPointT
	{
		// Token: 0x1700D88A RID: 55434
		// (get) Token: 0x06033B6E RID: 211822 RVA: 0x006F67AA File Offset: 0x006F49AA
		// (set) Token: 0x06033B6F RID: 211823 RVA: 0x006F67B2 File Offset: 0x006F49B2
		public EStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x06033B70 RID: 211824 RVA: 0x006F67BB File Offset: 0x006F49BB
		public IStopNewMoveWithSplineAtEndPointT()
		{
			this.Type = EStopNewMoveWithSplineType.StopAtCurrentPos;
		}
	}
}
