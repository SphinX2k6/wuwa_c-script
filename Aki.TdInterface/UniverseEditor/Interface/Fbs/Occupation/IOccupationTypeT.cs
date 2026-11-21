using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004819 RID: 18457
	public class IOccupationTypeT
	{
		// Token: 0x170080D3 RID: 32979
		// (get) Token: 0x0601B50D RID: 111885 RVA: 0x003DEBFA File Offset: 0x003DCDFA
		// (set) Token: 0x0601B50E RID: 111886 RVA: 0x003DEC02 File Offset: 0x003DCE02
		public EOccupationType Type { get; set; }

		// Token: 0x0601B50F RID: 111887 RVA: 0x003DEC0B File Offset: 0x003DCE0B
		public IOccupationTypeT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
