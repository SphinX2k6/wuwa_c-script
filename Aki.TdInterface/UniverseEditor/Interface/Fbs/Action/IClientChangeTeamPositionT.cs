using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069FD RID: 27133
	public class IClientChangeTeamPositionT
	{
		// Token: 0x1700C785 RID: 51077
		// (get) Token: 0x0602E8B4 RID: 190644 RVA: 0x00658FD6 File Offset: 0x006571D6
		// (set) Token: 0x0602E8B5 RID: 190645 RVA: 0x00658FDE File Offset: 0x006571DE
		public int PositionId { get; set; }

		// Token: 0x0602E8B6 RID: 190646 RVA: 0x00658FE7 File Offset: 0x006571E7
		public IClientChangeTeamPositionT()
		{
			this.PositionId = 0;
		}
	}
}
