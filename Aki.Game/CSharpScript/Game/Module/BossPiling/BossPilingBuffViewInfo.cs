using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005C04 RID: 23556
	public class BossPilingBuffViewInfo : IBossPilingBuffViewInfo
	{
		// Token: 0x17008D97 RID: 36247
		// (get) Token: 0x0603B88E RID: 243854 RVA: 0x00E321D6 File Offset: 0x00E303D6
		// (set) Token: 0x0603B88F RID: 243855 RVA: 0x00E321DE File Offset: 0x00E303DE
		public int LevelId { get; set; }

		// Token: 0x17008D98 RID: 36248
		// (get) Token: 0x0603B890 RID: 243856 RVA: 0x00E321E7 File Offset: 0x00E303E7
		// (set) Token: 0x0603B891 RID: 243857 RVA: 0x00E321EF File Offset: 0x00E303EF
		public bool InGame { get; set; }
	}
}
