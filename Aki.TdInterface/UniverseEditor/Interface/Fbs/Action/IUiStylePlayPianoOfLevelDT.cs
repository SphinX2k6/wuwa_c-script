using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CAB RID: 31915
	public class IUiStylePlayPianoOfLevelDT
	{
		// Token: 0x1700EEEF RID: 61167
		// (get) Token: 0x06039929 RID: 235817 RVA: 0x007C5092 File Offset: 0x007C3292
		// (set) Token: 0x0603992A RID: 235818 RVA: 0x007C509A File Offset: 0x007C329A
		public EUiStyleTypeOfLevelD Type { get; set; }

		// Token: 0x1700EEF0 RID: 61168
		// (get) Token: 0x0603992B RID: 235819 RVA: 0x007C50A3 File Offset: 0x007C32A3
		// (set) Token: 0x0603992C RID: 235820 RVA: 0x007C50AB File Offset: 0x007C32AB
		public IVector2T Position { get; set; }

		// Token: 0x1700EEF1 RID: 61169
		// (get) Token: 0x0603992D RID: 235821 RVA: 0x007C50B4 File Offset: 0x007C32B4
		// (set) Token: 0x0603992E RID: 235822 RVA: 0x007C50BC File Offset: 0x007C32BC
		public IVector2T TextBoxSize { get; set; }

		// Token: 0x1700EEF2 RID: 61170
		// (get) Token: 0x0603992F RID: 235823 RVA: 0x007C50C5 File Offset: 0x007C32C5
		// (set) Token: 0x06039930 RID: 235824 RVA: 0x007C50CD File Offset: 0x007C32CD
		public int FontSize { get; set; }

		// Token: 0x1700EEF3 RID: 61171
		// (get) Token: 0x06039931 RID: 235825 RVA: 0x007C50D6 File Offset: 0x007C32D6
		// (set) Token: 0x06039932 RID: 235826 RVA: 0x007C50DE File Offset: 0x007C32DE
		public float Duration { get; set; }

		// Token: 0x1700EEF4 RID: 61172
		// (get) Token: 0x06039933 RID: 235827 RVA: 0x007C50E7 File Offset: 0x007C32E7
		// (set) Token: 0x06039934 RID: 235828 RVA: 0x007C50EF File Offset: 0x007C32EF
		public EPlayPianoFadeInEffect FadeInEffect { get; set; }

		// Token: 0x1700EEF5 RID: 61173
		// (get) Token: 0x06039935 RID: 235829 RVA: 0x007C50F8 File Offset: 0x007C32F8
		// (set) Token: 0x06039936 RID: 235830 RVA: 0x007C5100 File Offset: 0x007C3300
		public EPlayPianoFadeOutEffect FadeOutEffect { get; set; }

		// Token: 0x1700EEF6 RID: 61174
		// (get) Token: 0x06039937 RID: 235831 RVA: 0x007C5109 File Offset: 0x007C3309
		// (set) Token: 0x06039938 RID: 235832 RVA: 0x007C5111 File Offset: 0x007C3311
		public byte NullMask { get; set; }

		// Token: 0x06039939 RID: 235833 RVA: 0x007C511C File Offset: 0x007C331C
		public IUiStylePlayPianoOfLevelDT()
		{
			this.Type = EUiStyleTypeOfLevelD.GiantSubtitle;
			this.Position = null;
			this.TextBoxSize = null;
			this.FontSize = 0;
			this.Duration = 0f;
			this.FadeInEffect = EPlayPianoFadeInEffect.None;
			this.FadeOutEffect = EPlayPianoFadeOutEffect.None;
			this.NullMask = 0;
		}
	}
}
