using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C2 RID: 29634
	public class ITeleportTransitionWithSpecialCustomLoadingT
	{
		// Token: 0x1700E10B RID: 57611
		// (get) Token: 0x06035D08 RID: 220424 RVA: 0x00753153 File Offset: 0x00751353
		// (set) Token: 0x06035D09 RID: 220425 RVA: 0x0075315B File Offset: 0x0075135B
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E10C RID: 57612
		// (get) Token: 0x06035D0A RID: 220426 RVA: 0x00753164 File Offset: 0x00751364
		// (set) Token: 0x06035D0B RID: 220427 RVA: 0x0075316C File Offset: 0x0075136C
		public IHonamiStoryCustomLoadingT LoadingType { get; set; }

		// Token: 0x06035D0C RID: 220428 RVA: 0x00753175 File Offset: 0x00751375
		public ITeleportTransitionWithSpecialCustomLoadingT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.LoadingType = null;
		}
	}
}
