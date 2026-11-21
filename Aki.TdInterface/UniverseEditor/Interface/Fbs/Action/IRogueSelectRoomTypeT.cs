using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007676 RID: 30326
	public class IRogueSelectRoomTypeT
	{
		// Token: 0x1700DEA0 RID: 56992
		// (get) Token: 0x0603534D RID: 217933 RVA: 0x0072424A File Offset: 0x0072244A
		// (set) Token: 0x0603534E RID: 217934 RVA: 0x00724252 File Offset: 0x00722452
		public ERogueSelectRoomType Type { get; set; }

		// Token: 0x0603534F RID: 217935 RVA: 0x0072425B File Offset: 0x0072245B
		public IRogueSelectRoomTypeT()
		{
			this.Type = ERogueSelectRoomType.Role;
		}
	}
}
