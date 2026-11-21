using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200740D RID: 29709
	public class IPetalGrabMoveTypeT
	{
		// Token: 0x1700DA48 RID: 55880
		// (get) Token: 0x06033FC6 RID: 212934 RVA: 0x00701EF2 File Offset: 0x007000F2
		// (set) Token: 0x06033FC7 RID: 212935 RVA: 0x00701EFA File Offset: 0x007000FA
		public EPetalGrabMoveType Type { get; set; }

		// Token: 0x06033FC8 RID: 212936 RVA: 0x00701F03 File Offset: 0x00700103
		public IPetalGrabMoveTypeT()
		{
			this.Type = EPetalGrabMoveType.Linear;
		}
	}
}
