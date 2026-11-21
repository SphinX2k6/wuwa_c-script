using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200723E RID: 29246
	public class IMoraleAreaTipT
	{
		// Token: 0x1700D63F RID: 54847
		// (get) Token: 0x06032EBE RID: 208574 RVA: 0x006DFFDE File Offset: 0x006DE1DE
		// (set) Token: 0x06032EBF RID: 208575 RVA: 0x006DFFE6 File Offset: 0x006DE1E6
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D640 RID: 54848
		// (get) Token: 0x06032EC0 RID: 208576 RVA: 0x006DFFEF File Offset: 0x006DE1EF
		// (set) Token: 0x06032EC1 RID: 208577 RVA: 0x006DFFF7 File Offset: 0x006DE1F7
		public string TidAreaNameText { get; set; }

		// Token: 0x1700D641 RID: 54849
		// (get) Token: 0x06032EC2 RID: 208578 RVA: 0x006E0000 File Offset: 0x006DE200
		// (set) Token: 0x06032EC3 RID: 208579 RVA: 0x006E0008 File Offset: 0x006DE208
		public string TidRecommendText { get; set; }

		// Token: 0x1700D642 RID: 54850
		// (get) Token: 0x06032EC4 RID: 208580 RVA: 0x006E0011 File Offset: 0x006DE211
		// (set) Token: 0x06032EC5 RID: 208581 RVA: 0x006E0019 File Offset: 0x006DE219
		public EMoraleAreaType AreaType { get; set; }

		// Token: 0x1700D643 RID: 54851
		// (get) Token: 0x06032EC6 RID: 208582 RVA: 0x006E0022 File Offset: 0x006DE222
		// (set) Token: 0x06032EC7 RID: 208583 RVA: 0x006E002A File Offset: 0x006DE22A
		public EMoraleUiType UiType { get; set; }

		// Token: 0x1700D644 RID: 54852
		// (get) Token: 0x06032EC8 RID: 208584 RVA: 0x006E0033 File Offset: 0x006DE233
		// (set) Token: 0x06032EC9 RID: 208585 RVA: 0x006E003B File Offset: 0x006DE23B
		public byte NullMask { get; set; }

		// Token: 0x06032ECA RID: 208586 RVA: 0x006E0044 File Offset: 0x006DE244
		public IMoraleAreaTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidAreaNameText = null;
			this.TidRecommendText = null;
			this.AreaType = EMoraleAreaType.MoraleArea1;
			this.UiType = EMoraleUiType.MoraleUi24;
			this.NullMask = 0;
		}
	}
}
