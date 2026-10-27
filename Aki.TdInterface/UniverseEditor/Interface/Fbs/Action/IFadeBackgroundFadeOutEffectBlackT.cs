using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676F RID: 26479
	public class IFadeBackgroundFadeOutEffectBlackT
	{
		// Token: 0x1700C48D RID: 50317
		// (get) Token: 0x0602E10F RID: 188687 RVA: 0x0064B4B6 File Offset: 0x006496B6
		// (set) Token: 0x0602E110 RID: 188688 RVA: 0x0064B4BE File Offset: 0x006496BE
		public EFadeBackgroundFadeOutEffectType Type { get; set; }

		// Token: 0x1700C48E RID: 50318
		// (get) Token: 0x0602E111 RID: 188689 RVA: 0x0064B4C7 File Offset: 0x006496C7
		// (set) Token: 0x0602E112 RID: 188690 RVA: 0x0064B4CF File Offset: 0x006496CF
		public EFadeInScreenShowType FadeColor { get; set; }

		// Token: 0x1700C48F RID: 50319
		// (get) Token: 0x0602E113 RID: 188691 RVA: 0x0064B4D8 File Offset: 0x006496D8
		// (set) Token: 0x0602E114 RID: 188692 RVA: 0x0064B4E0 File Offset: 0x006496E0
		public float FadeInTime { get; set; }

		// Token: 0x1700C490 RID: 50320
		// (get) Token: 0x0602E115 RID: 188693 RVA: 0x0064B4E9 File Offset: 0x006496E9
		// (set) Token: 0x0602E116 RID: 188694 RVA: 0x0064B4F1 File Offset: 0x006496F1
		public float FadeOutTime { get; set; }

		// Token: 0x1700C491 RID: 50321
		// (get) Token: 0x0602E117 RID: 188695 RVA: 0x0064B4FA File Offset: 0x006496FA
		// (set) Token: 0x0602E118 RID: 188696 RVA: 0x0064B502 File Offset: 0x00649702
		public byte NullMask { get; set; }

		// Token: 0x0602E119 RID: 188697 RVA: 0x0064B50B File Offset: 0x0064970B
		public IFadeBackgroundFadeOutEffectBlackT()
		{
			this.Type = EFadeBackgroundFadeOutEffectType.Black;
			this.FadeColor = EFadeInScreenShowType.White;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
			this.NullMask = 0;
		}
	}
}
