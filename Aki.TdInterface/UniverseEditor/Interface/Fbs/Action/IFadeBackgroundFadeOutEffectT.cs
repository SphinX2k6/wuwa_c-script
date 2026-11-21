using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DEC RID: 28140
	public class IFadeBackgroundFadeOutEffectT
	{
		// Token: 0x1700CE3C RID: 52796
		// (get) Token: 0x0603093B RID: 198971 RVA: 0x006988AD File Offset: 0x00696AAD
		// (set) Token: 0x0603093C RID: 198972 RVA: 0x006988B5 File Offset: 0x00696AB5
		public TFadeBackgroundFadeOutEffectUnion FadeOutEffect { get; set; }

		// Token: 0x0603093D RID: 198973 RVA: 0x006988BE File Offset: 0x00696ABE
		public IFadeBackgroundFadeOutEffectT()
		{
			this.FadeOutEffect = null;
		}
	}
}
