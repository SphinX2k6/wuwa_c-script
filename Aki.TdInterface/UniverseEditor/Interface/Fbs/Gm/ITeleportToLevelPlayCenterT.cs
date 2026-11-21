using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B29 RID: 19241
	public class ITeleportToLevelPlayCenterT
	{
		// Token: 0x170086F5 RID: 34549
		// (get) Token: 0x0601D064 RID: 118884 RVA: 0x00414648 File Offset: 0x00412848
		// (set) Token: 0x0601D065 RID: 118885 RVA: 0x00414650 File Offset: 0x00412850
		public EGmCommand Type { get; set; }

		// Token: 0x170086F6 RID: 34550
		// (get) Token: 0x0601D066 RID: 118886 RVA: 0x00414659 File Offset: 0x00412859
		// (set) Token: 0x0601D067 RID: 118887 RVA: 0x00414661 File Offset: 0x00412861
		public int LevelPlayId { get; set; }

		// Token: 0x0601D068 RID: 118888 RVA: 0x0041466A File Offset: 0x0041286A
		public ITeleportToLevelPlayCenterT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
		}
	}
}
