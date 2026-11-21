using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE6 RID: 28134
	public class IFadeBackgroundFadeInEffectTypeBaseT
	{
		// Token: 0x1700CE37 RID: 52791
		// (get) Token: 0x06030917 RID: 198935 RVA: 0x006984A2 File Offset: 0x006966A2
		// (set) Token: 0x06030918 RID: 198936 RVA: 0x006984AA File Offset: 0x006966AA
		public EFadeBackgroundFadeInEffectType Type { get; set; }

		// Token: 0x06030919 RID: 198937 RVA: 0x006984B3 File Offset: 0x006966B3
		public IFadeBackgroundFadeInEffectTypeBaseT()
		{
			this.Type = EFadeBackgroundFadeInEffectType.Black;
		}
	}
}
