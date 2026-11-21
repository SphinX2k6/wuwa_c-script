using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079B4 RID: 31156
	public class IStopNewMoveWithSplineAtCurrentPosT
	{
		// Token: 0x1700E480 RID: 58496
		// (get) Token: 0x06036E5E RID: 224862 RVA: 0x00757992 File Offset: 0x00755B92
		// (set) Token: 0x06036E5F RID: 224863 RVA: 0x0075799A File Offset: 0x00755B9A
		public EStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x06036E60 RID: 224864 RVA: 0x007579A3 File Offset: 0x00755BA3
		public IStopNewMoveWithSplineAtCurrentPosT()
		{
			this.Type = EStopNewMoveWithSplineType.StopAtCurrentPos;
		}
	}
}
