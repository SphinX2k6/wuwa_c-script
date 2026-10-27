using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049DD RID: 18909
	public class ICheckDungeonHasSaveConfigT
	{
		// Token: 0x170088C1 RID: 35009
		// (get) Token: 0x0601D896 RID: 120982 RVA: 0x004288F2 File Offset: 0x00426AF2
		// (set) Token: 0x0601D897 RID: 120983 RVA: 0x004288FA File Offset: 0x00426AFA
		public ECondition Type { get; set; }

		// Token: 0x170088C2 RID: 35010
		// (get) Token: 0x0601D898 RID: 120984 RVA: 0x00428903 File Offset: 0x00426B03
		// (set) Token: 0x0601D899 RID: 120985 RVA: 0x0042890B File Offset: 0x00426B0B
		public int DungeonId { get; set; }

		// Token: 0x170088C3 RID: 35011
		// (get) Token: 0x0601D89A RID: 120986 RVA: 0x00428914 File Offset: 0x00426B14
		// (set) Token: 0x0601D89B RID: 120987 RVA: 0x0042891C File Offset: 0x00426B1C
		public bool IsHasSaveConfig { get; set; }

		// Token: 0x0601D89C RID: 120988 RVA: 0x00428925 File Offset: 0x00426B25
		public ICheckDungeonHasSaveConfigT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.IsHasSaveConfig = false;
		}
	}
}
