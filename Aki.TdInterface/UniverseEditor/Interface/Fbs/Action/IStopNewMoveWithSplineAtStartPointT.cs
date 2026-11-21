using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079BA RID: 31162
	public class IStopNewMoveWithSplineAtStartPointT
	{
		// Token: 0x1700E486 RID: 58502
		// (get) Token: 0x06036E82 RID: 224898 RVA: 0x00757C82 File Offset: 0x00755E82
		// (set) Token: 0x06036E83 RID: 224899 RVA: 0x00757C8A File Offset: 0x00755E8A
		public EStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x06036E84 RID: 224900 RVA: 0x00757C93 File Offset: 0x00755E93
		public IStopNewMoveWithSplineAtStartPointT()
		{
			this.Type = EStopNewMoveWithSplineType.StopAtCurrentPos;
		}
	}
}
