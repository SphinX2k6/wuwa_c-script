using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE3 RID: 28131
	public class IFadeBackgroundFadeInEffectScreenEffectT
	{
		// Token: 0x1700CE33 RID: 52787
		// (get) Token: 0x06030903 RID: 198915 RVA: 0x00698307 File Offset: 0x00696507
		// (set) Token: 0x06030904 RID: 198916 RVA: 0x0069830F File Offset: 0x0069650F
		public EFadeBackgroundFadeInEffectType Type { get; set; }

		// Token: 0x1700CE34 RID: 52788
		// (get) Token: 0x06030905 RID: 198917 RVA: 0x00698318 File Offset: 0x00696518
		// (set) Token: 0x06030906 RID: 198918 RVA: 0x00698320 File Offset: 0x00696520
		public string ScreenEffect { get; set; }

		// Token: 0x06030907 RID: 198919 RVA: 0x00698329 File Offset: 0x00696529
		public IFadeBackgroundFadeInEffectScreenEffectT()
		{
			this.Type = EFadeBackgroundFadeInEffectType.Black;
			this.ScreenEffect = null;
		}
	}
}
