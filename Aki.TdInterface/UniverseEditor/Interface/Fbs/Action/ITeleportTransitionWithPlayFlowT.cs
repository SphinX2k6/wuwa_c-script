using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073BF RID: 29631
	public class ITeleportTransitionWithPlayFlowT
	{
		// Token: 0x1700E104 RID: 57604
		// (get) Token: 0x06035CEE RID: 220398 RVA: 0x00752E48 File Offset: 0x00751048
		// (set) Token: 0x06035CEF RID: 220399 RVA: 0x00752E50 File Offset: 0x00751050
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E105 RID: 57605
		// (get) Token: 0x06035CF0 RID: 220400 RVA: 0x00752E59 File Offset: 0x00751059
		// (set) Token: 0x06035CF1 RID: 220401 RVA: 0x00752E61 File Offset: 0x00751061
		public IPlayFlowT Flow { get; set; }

		// Token: 0x1700E106 RID: 57606
		// (get) Token: 0x06035CF2 RID: 220402 RVA: 0x00752E6A File Offset: 0x0075106A
		// (set) Token: 0x06035CF3 RID: 220403 RVA: 0x00752E72 File Offset: 0x00751072
		public IFadeBackgroundFadeInEffectT FadeInEffect { get; set; }

		// Token: 0x1700E107 RID: 57607
		// (get) Token: 0x06035CF4 RID: 220404 RVA: 0x00752E7B File Offset: 0x0075107B
		// (set) Token: 0x06035CF5 RID: 220405 RVA: 0x00752E83 File Offset: 0x00751083
		public IFadeBackgroundFadeOutEffectT FadeOutEffect { get; set; }

		// Token: 0x06035CF6 RID: 220406 RVA: 0x00752E8C File Offset: 0x0075108C
		public ITeleportTransitionWithPlayFlowT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.Flow = null;
			this.FadeInEffect = null;
			this.FadeOutEffect = null;
		}
	}
}
