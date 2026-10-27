using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006772 RID: 26482
	public class IFadeBackgroundFadeOutEffectScreenEffectT
	{
		// Token: 0x1700C495 RID: 50325
		// (get) Token: 0x0602E12D RID: 188717 RVA: 0x0064B777 File Offset: 0x00649977
		// (set) Token: 0x0602E12E RID: 188718 RVA: 0x0064B77F File Offset: 0x0064997F
		public EFadeBackgroundFadeOutEffectType Type { get; set; }

		// Token: 0x1700C496 RID: 50326
		// (get) Token: 0x0602E12F RID: 188719 RVA: 0x0064B788 File Offset: 0x00649988
		// (set) Token: 0x0602E130 RID: 188720 RVA: 0x0064B790 File Offset: 0x00649990
		public string ScreenEffect { get; set; }

		// Token: 0x0602E131 RID: 188721 RVA: 0x0064B799 File Offset: 0x00649999
		public IFadeBackgroundFadeOutEffectScreenEffectT()
		{
			this.Type = EFadeBackgroundFadeOutEffectType.Black;
			this.ScreenEffect = null;
		}
	}
}
