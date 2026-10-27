using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004507 RID: 17671
	public class ILevelPlayMarkT
	{
		// Token: 0x17007D49 RID: 32073
		// (get) Token: 0x0601A8C1 RID: 108737 RVA: 0x003CA857 File Offset: 0x003C8A57
		// (set) Token: 0x0601A8C2 RID: 108738 RVA: 0x003CA85F File Offset: 0x003C8A5F
		public int MarkId { get; set; }

		// Token: 0x17007D4A RID: 32074
		// (get) Token: 0x0601A8C3 RID: 108739 RVA: 0x003CA868 File Offset: 0x003C8A68
		// (set) Token: 0x0601A8C4 RID: 108740 RVA: 0x003CA870 File Offset: 0x003C8A70
		public string MapBgPath { get; set; }

		// Token: 0x0601A8C5 RID: 108741 RVA: 0x003CA879 File Offset: 0x003C8A79
		public ILevelPlayMarkT()
		{
			this.MarkId = 0;
			this.MapBgPath = null;
		}
	}
}
