using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E5 RID: 29157
	public class IStopNewMoveWithSplineAtStartPointT
	{
		// Token: 0x1700D88D RID: 55437
		// (get) Token: 0x06033B80 RID: 211840 RVA: 0x006F6922 File Offset: 0x006F4B22
		// (set) Token: 0x06033B81 RID: 211841 RVA: 0x006F692A File Offset: 0x006F4B2A
		public EStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x06033B82 RID: 211842 RVA: 0x006F6933 File Offset: 0x006F4B33
		public IStopNewMoveWithSplineAtStartPointT()
		{
			this.Type = EStopNewMoveWithSplineType.StopAtCurrentPos;
		}
	}
}
