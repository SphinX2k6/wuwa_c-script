using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758A RID: 30090
	public class IVisualNovelMainRoleActionConfigBaseT
	{
		// Token: 0x1700E42D RID: 58413
		// (get) Token: 0x06036BD2 RID: 224210 RVA: 0x0076E60A File Offset: 0x0076C80A
		// (set) Token: 0x06036BD3 RID: 224211 RVA: 0x0076E612 File Offset: 0x0076C812
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x06036BD4 RID: 224212 RVA: 0x0076E61B File Offset: 0x0076C81B
		public IVisualNovelMainRoleActionConfigBaseT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
		}
	}
}
