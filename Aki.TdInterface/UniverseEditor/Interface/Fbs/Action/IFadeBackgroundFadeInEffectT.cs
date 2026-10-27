using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675D RID: 26461
	public class IFadeBackgroundFadeInEffectT
	{
		// Token: 0x1700C46E RID: 50286
		// (get) Token: 0x0602E085 RID: 188549 RVA: 0x0064A5B5 File Offset: 0x006487B5
		// (set) Token: 0x0602E086 RID: 188550 RVA: 0x0064A5BD File Offset: 0x006487BD
		public TFadeBackgroundFadeInEffectUnion FadeInEffect { get; set; }

		// Token: 0x0602E087 RID: 188551 RVA: 0x0064A5C6 File Offset: 0x006487C6
		public IFadeBackgroundFadeInEffectT()
		{
			this.FadeInEffect = null;
		}
	}
}
