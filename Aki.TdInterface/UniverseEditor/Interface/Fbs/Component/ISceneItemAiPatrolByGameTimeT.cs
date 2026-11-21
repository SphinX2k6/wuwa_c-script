using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EBA RID: 24250
	public class ISceneItemAiPatrolByGameTimeT
	{
		// Token: 0x1700B32D RID: 45869
		// (get) Token: 0x06028A3A RID: 166458 RVA: 0x0058E5A0 File Offset: 0x0058C7A0
		// (set) Token: 0x06028A3B RID: 166459 RVA: 0x0058E5A8 File Offset: 0x0058C7A8
		public ESceneItemAiPatrolType Type { get; set; }

		// Token: 0x1700B32E RID: 45870
		// (get) Token: 0x06028A3C RID: 166460 RVA: 0x0058E5B1 File Offset: 0x0058C7B1
		// (set) Token: 0x06028A3D RID: 166461 RVA: 0x0058E5B9 File Offset: 0x0058C7B9
		public int Spline { get; set; }

		// Token: 0x06028A3E RID: 166462 RVA: 0x0058E5C2 File Offset: 0x0058C7C2
		public ISceneItemAiPatrolByGameTimeT()
		{
			this.Type = ESceneItemAiPatrolType.ByGameTime;
			this.Spline = 0;
		}
	}
}
