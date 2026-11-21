using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ED2 RID: 24274
	public class ISceneItemInhalationT
	{
		// Token: 0x1700B358 RID: 45912
		// (get) Token: 0x06028B00 RID: 166656 RVA: 0x0058FC02 File Offset: 0x0058DE02
		// (set) Token: 0x06028B01 RID: 166657 RVA: 0x0058FC0A File Offset: 0x0058DE0A
		public EInhalationPerformanceType Type { get; set; }

		// Token: 0x06028B02 RID: 166658 RVA: 0x0058FC13 File Offset: 0x0058DE13
		public ISceneItemInhalationT()
		{
			this.Type = EInhalationPerformanceType.Role;
		}
	}
}
