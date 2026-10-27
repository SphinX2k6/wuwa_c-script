using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676C RID: 26476
	public class IFadeBackgroundFadeOutEffectT
	{
		// Token: 0x1700C486 RID: 50310
		// (get) Token: 0x0602E0F5 RID: 188661 RVA: 0x0064B169 File Offset: 0x00649369
		// (set) Token: 0x0602E0F6 RID: 188662 RVA: 0x0064B171 File Offset: 0x00649371
		public TFadeBackgroundFadeOutEffectUnion FadeOutEffect { get; set; }

		// Token: 0x0602E0F7 RID: 188663 RVA: 0x0064B17A File Offset: 0x0064937A
		public IFadeBackgroundFadeOutEffectT()
		{
			this.FadeOutEffect = null;
		}
	}
}
