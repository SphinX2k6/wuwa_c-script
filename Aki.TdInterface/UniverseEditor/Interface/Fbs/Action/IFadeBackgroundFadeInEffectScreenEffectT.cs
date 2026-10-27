using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006763 RID: 26467
	public class IFadeBackgroundFadeInEffectScreenEffectT
	{
		// Token: 0x1700C47D RID: 50301
		// (get) Token: 0x0602E0BD RID: 188605 RVA: 0x0064ABC3 File Offset: 0x00648DC3
		// (set) Token: 0x0602E0BE RID: 188606 RVA: 0x0064ABCB File Offset: 0x00648DCB
		public EFadeBackgroundFadeInEffectType Type { get; set; }

		// Token: 0x1700C47E RID: 50302
		// (get) Token: 0x0602E0BF RID: 188607 RVA: 0x0064ABD4 File Offset: 0x00648DD4
		// (set) Token: 0x0602E0C0 RID: 188608 RVA: 0x0064ABDC File Offset: 0x00648DDC
		public string ScreenEffect { get; set; }

		// Token: 0x0602E0C1 RID: 188609 RVA: 0x0064ABE5 File Offset: 0x00648DE5
		public IFadeBackgroundFadeInEffectScreenEffectT()
		{
			this.Type = EFadeBackgroundFadeInEffectType.Black;
			this.ScreenEffect = null;
		}
	}
}
