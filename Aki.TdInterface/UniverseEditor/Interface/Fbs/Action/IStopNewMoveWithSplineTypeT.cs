using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071EB RID: 29163
	public class IStopNewMoveWithSplineTypeT
	{
		// Token: 0x1700D895 RID: 55445
		// (get) Token: 0x06033BA8 RID: 211880 RVA: 0x006F6C9A File Offset: 0x006F4E9A
		// (set) Token: 0x06033BA9 RID: 211881 RVA: 0x006F6CA2 File Offset: 0x006F4EA2
		public EStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x06033BAA RID: 211882 RVA: 0x006F6CAB File Offset: 0x006F4EAB
		public IStopNewMoveWithSplineTypeT()
		{
			this.Type = EStopNewMoveWithSplineType.StopAtCurrentPos;
		}
	}
}
