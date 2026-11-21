using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EBD RID: 24253
	public class ISceneItemAiPatrolTypeT
	{
		// Token: 0x1700B331 RID: 45873
		// (get) Token: 0x06028A4E RID: 166478 RVA: 0x0058E73E File Offset: 0x0058C93E
		// (set) Token: 0x06028A4F RID: 166479 RVA: 0x0058E746 File Offset: 0x0058C946
		public ESceneItemAiPatrolType Type { get; set; }

		// Token: 0x06028A50 RID: 166480 RVA: 0x0058E74F File Offset: 0x0058C94F
		public ISceneItemAiPatrolTypeT()
		{
			this.Type = ESceneItemAiPatrolType.ByGameTime;
		}
	}
}
