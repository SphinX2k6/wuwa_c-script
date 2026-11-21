using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007371 RID: 29553
	public class IOpenLevelQteT
	{
		// Token: 0x1700D8C7 RID: 55495
		// (get) Token: 0x06033961 RID: 211297 RVA: 0x006F405B File Offset: 0x006F225B
		// (set) Token: 0x06033962 RID: 211298 RVA: 0x006F4063 File Offset: 0x006F2263
		public EOpenQteType Type { get; set; }

		// Token: 0x1700D8C8 RID: 55496
		// (get) Token: 0x06033963 RID: 211299 RVA: 0x006F406C File Offset: 0x006F226C
		// (set) Token: 0x06033964 RID: 211300 RVA: 0x006F4074 File Offset: 0x006F2274
		public TTargetEntityUnion LevelQteEntity { get; set; }

		// Token: 0x06033965 RID: 211301 RVA: 0x006F407D File Offset: 0x006F227D
		public IOpenLevelQteT()
		{
			this.Type = EOpenQteType.PanelQte;
			this.LevelQteEntity = null;
		}
	}
}
