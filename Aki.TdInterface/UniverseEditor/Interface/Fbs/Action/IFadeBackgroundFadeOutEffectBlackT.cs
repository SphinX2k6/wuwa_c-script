using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DEF RID: 28143
	public class IFadeBackgroundFadeOutEffectBlackT
	{
		// Token: 0x1700CE43 RID: 52803
		// (get) Token: 0x06030955 RID: 198997 RVA: 0x00698BFA File Offset: 0x00696DFA
		// (set) Token: 0x06030956 RID: 198998 RVA: 0x00698C02 File Offset: 0x00696E02
		public EFadeBackgroundFadeOutEffectType Type { get; set; }

		// Token: 0x1700CE44 RID: 52804
		// (get) Token: 0x06030957 RID: 198999 RVA: 0x00698C0B File Offset: 0x00696E0B
		// (set) Token: 0x06030958 RID: 199000 RVA: 0x00698C13 File Offset: 0x00696E13
		public EFadeInScreenShowType FadeColor { get; set; }

		// Token: 0x1700CE45 RID: 52805
		// (get) Token: 0x06030959 RID: 199001 RVA: 0x00698C1C File Offset: 0x00696E1C
		// (set) Token: 0x0603095A RID: 199002 RVA: 0x00698C24 File Offset: 0x00696E24
		public float FadeInTime { get; set; }

		// Token: 0x1700CE46 RID: 52806
		// (get) Token: 0x0603095B RID: 199003 RVA: 0x00698C2D File Offset: 0x00696E2D
		// (set) Token: 0x0603095C RID: 199004 RVA: 0x00698C35 File Offset: 0x00696E35
		public float FadeOutTime { get; set; }

		// Token: 0x1700CE47 RID: 52807
		// (get) Token: 0x0603095D RID: 199005 RVA: 0x00698C3E File Offset: 0x00696E3E
		// (set) Token: 0x0603095E RID: 199006 RVA: 0x00698C46 File Offset: 0x00696E46
		public byte NullMask { get; set; }

		// Token: 0x0603095F RID: 199007 RVA: 0x00698C4F File Offset: 0x00696E4F
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
