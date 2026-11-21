using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079C0 RID: 31168
	public class IStopNewMoveWithSplineTypeT
	{
		// Token: 0x1700E48E RID: 58510
		// (get) Token: 0x06036EAA RID: 224938 RVA: 0x00757FFA File Offset: 0x007561FA
		// (set) Token: 0x06036EAB RID: 224939 RVA: 0x00758002 File Offset: 0x00756202
		public EStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x06036EAC RID: 224940 RVA: 0x0075800B File Offset: 0x0075620B
		public IStopNewMoveWithSplineTypeT()
		{
			this.Type = EStopNewMoveWithSplineType.StopAtCurrentPos;
		}
	}
}
