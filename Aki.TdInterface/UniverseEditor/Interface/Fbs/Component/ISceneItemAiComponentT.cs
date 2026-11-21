using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EB7 RID: 24247
	public class ISceneItemAiComponentT
	{
		// Token: 0x1700B327 RID: 45863
		// (get) Token: 0x06028A22 RID: 166434 RVA: 0x0058E355 File Offset: 0x0058C555
		// (set) Token: 0x06028A23 RID: 166435 RVA: 0x0058E35D File Offset: 0x0058C55D
		public bool Disabled { get; set; }

		// Token: 0x1700B328 RID: 45864
		// (get) Token: 0x06028A24 RID: 166436 RVA: 0x0058E366 File Offset: 0x0058C566
		// (set) Token: 0x06028A25 RID: 166437 RVA: 0x0058E36E File Offset: 0x0058C56E
		public ISceneItemPatrolT AiConfig { get; set; }

		// Token: 0x1700B329 RID: 45865
		// (get) Token: 0x06028A26 RID: 166438 RVA: 0x0058E377 File Offset: 0x0058C577
		// (set) Token: 0x06028A27 RID: 166439 RVA: 0x0058E37F File Offset: 0x0058C57F
		public byte NullMask { get; set; }

		// Token: 0x06028A28 RID: 166440 RVA: 0x0058E388 File Offset: 0x0058C588
		public ISceneItemAiComponentT()
		{
			this.Disabled = false;
			this.AiConfig = null;
			this.NullMask = 0;
		}
	}
}
