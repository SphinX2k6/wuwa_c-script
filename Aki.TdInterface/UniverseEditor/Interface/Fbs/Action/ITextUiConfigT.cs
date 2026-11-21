using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BBB RID: 31675
	public class ITextUiConfigT
	{
		// Token: 0x1700ED54 RID: 60756
		// (get) Token: 0x06039188 RID: 233864 RVA: 0x007B78D8 File Offset: 0x007B5AD8
		// (set) Token: 0x06039189 RID: 233865 RVA: 0x007B78E0 File Offset: 0x007B5AE0
		public ETextUiType Type { get; set; }

		// Token: 0x1700ED55 RID: 60757
		// (get) Token: 0x0603918A RID: 233866 RVA: 0x007B78E9 File Offset: 0x007B5AE9
		// (set) Token: 0x0603918B RID: 233867 RVA: 0x007B78F1 File Offset: 0x007B5AF1
		public string InitTipText { get; set; }

		// Token: 0x1700ED56 RID: 60758
		// (get) Token: 0x0603918C RID: 233868 RVA: 0x007B78FA File Offset: 0x007B5AFA
		// (set) Token: 0x0603918D RID: 233869 RVA: 0x007B7902 File Offset: 0x007B5B02
		public string ProgressTipText { get; set; }

		// Token: 0x1700ED57 RID: 60759
		// (get) Token: 0x0603918E RID: 233870 RVA: 0x007B790B File Offset: 0x007B5B0B
		// (set) Token: 0x0603918F RID: 233871 RVA: 0x007B7913 File Offset: 0x007B5B13
		public string SkipText { get; set; }

		// Token: 0x1700ED58 RID: 60760
		// (get) Token: 0x06039190 RID: 233872 RVA: 0x007B791C File Offset: 0x007B5B1C
		// (set) Token: 0x06039191 RID: 233873 RVA: 0x007B7924 File Offset: 0x007B5B24
		public string FinishText { get; set; }

		// Token: 0x1700ED59 RID: 60761
		// (get) Token: 0x06039192 RID: 233874 RVA: 0x007B792D File Offset: 0x007B5B2D
		// (set) Token: 0x06039193 RID: 233875 RVA: 0x007B7935 File Offset: 0x007B5B35
		public List<string> InitDialogues { get; set; }

		// Token: 0x1700ED5A RID: 60762
		// (get) Token: 0x06039194 RID: 233876 RVA: 0x007B793E File Offset: 0x007B5B3E
		// (set) Token: 0x06039195 RID: 233877 RVA: 0x007B7946 File Offset: 0x007B5B46
		public int SkipConfirmBoxId { get; set; }

		// Token: 0x1700ED5B RID: 60763
		// (get) Token: 0x06039196 RID: 233878 RVA: 0x007B794F File Offset: 0x007B5B4F
		// (set) Token: 0x06039197 RID: 233879 RVA: 0x007B7957 File Offset: 0x007B5B57
		public string LoopAudioEvent { get; set; }

		// Token: 0x1700ED5C RID: 60764
		// (get) Token: 0x06039198 RID: 233880 RVA: 0x007B7960 File Offset: 0x007B5B60
		// (set) Token: 0x06039199 RID: 233881 RVA: 0x007B7968 File Offset: 0x007B5B68
		public byte NullMask { get; set; }

		// Token: 0x0603919A RID: 233882 RVA: 0x007B7974 File Offset: 0x007B5B74
		public ITextUiConfigT()
		{
			this.Type = ETextUiType.Astrology;
			this.InitTipText = null;
			this.ProgressTipText = null;
			this.SkipText = null;
			this.FinishText = null;
			this.InitDialogues = null;
			this.SkipConfirmBoxId = 0;
			this.LoopAudioEvent = null;
			this.NullMask = 0;
		}
	}
}
