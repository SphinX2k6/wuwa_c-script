using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DF RID: 29151
	public class IStopNewMoveWithSplineAtCurrentPosT
	{
		// Token: 0x1700D887 RID: 55431
		// (get) Token: 0x06033B5C RID: 211804 RVA: 0x006F6632 File Offset: 0x006F4832
		// (set) Token: 0x06033B5D RID: 211805 RVA: 0x006F663A File Offset: 0x006F483A
		public EStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x06033B5E RID: 211806 RVA: 0x006F6643 File Offset: 0x006F4843
		public IStopNewMoveWithSplineAtCurrentPosT()
		{
			this.Type = EStopNewMoveWithSplineType.StopAtCurrentPos;
		}
	}
}
