using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079B7 RID: 31159
	public class IStopNewMoveWithSplineAtEndPointT
	{
		// Token: 0x1700E483 RID: 58499
		// (get) Token: 0x06036E70 RID: 224880 RVA: 0x00757B0A File Offset: 0x00755D0A
		// (set) Token: 0x06036E71 RID: 224881 RVA: 0x00757B12 File Offset: 0x00755D12
		public EStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x06036E72 RID: 224882 RVA: 0x00757B1B File Offset: 0x00755D1B
		public IStopNewMoveWithSplineAtEndPointT()
		{
			this.Type = EStopNewMoveWithSplineType.StopAtCurrentPos;
		}
	}
}
