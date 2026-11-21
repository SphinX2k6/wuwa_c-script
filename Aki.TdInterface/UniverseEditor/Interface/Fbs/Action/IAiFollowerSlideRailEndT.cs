using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E5 RID: 26597
	public class IAiFollowerSlideRailEndT
	{
		// Token: 0x1700C388 RID: 50056
		// (get) Token: 0x0602D6E1 RID: 186081 RVA: 0x00638A68 File Offset: 0x00636C68
		// (set) Token: 0x0602D6E2 RID: 186082 RVA: 0x00638A70 File Offset: 0x00636C70
		public ESlideRailEndType Type { get; set; }

		// Token: 0x1700C389 RID: 50057
		// (get) Token: 0x0602D6E3 RID: 186083 RVA: 0x00638A79 File Offset: 0x00636C79
		// (set) Token: 0x0602D6E4 RID: 186084 RVA: 0x00638A81 File Offset: 0x00636C81
		public int AiEntityId { get; set; }

		// Token: 0x0602D6E5 RID: 186085 RVA: 0x00638A8A File Offset: 0x00636C8A
		public IAiFollowerSlideRailEndT()
		{
			this.Type = ESlideRailEndType.Player;
			this.AiEntityId = 0;
		}
	}
}
