using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B07 RID: 27399
	public class IMoraleAreaTipT
	{
		// Token: 0x1700CB70 RID: 52080
		// (get) Token: 0x060300EA RID: 196842 RVA: 0x00688926 File Offset: 0x00686B26
		// (set) Token: 0x060300EB RID: 196843 RVA: 0x0068892E File Offset: 0x00686B2E
		public ECommonTipType Type { get; set; }

		// Token: 0x1700CB71 RID: 52081
		// (get) Token: 0x060300EC RID: 196844 RVA: 0x00688937 File Offset: 0x00686B37
		// (set) Token: 0x060300ED RID: 196845 RVA: 0x0068893F File Offset: 0x00686B3F
		public string TidAreaNameText { get; set; }

		// Token: 0x1700CB72 RID: 52082
		// (get) Token: 0x060300EE RID: 196846 RVA: 0x00688948 File Offset: 0x00686B48
		// (set) Token: 0x060300EF RID: 196847 RVA: 0x00688950 File Offset: 0x00686B50
		public string TidRecommendText { get; set; }

		// Token: 0x1700CB73 RID: 52083
		// (get) Token: 0x060300F0 RID: 196848 RVA: 0x00688959 File Offset: 0x00686B59
		// (set) Token: 0x060300F1 RID: 196849 RVA: 0x00688961 File Offset: 0x00686B61
		public EMoraleAreaType AreaType { get; set; }

		// Token: 0x1700CB74 RID: 52084
		// (get) Token: 0x060300F2 RID: 196850 RVA: 0x0068896A File Offset: 0x00686B6A
		// (set) Token: 0x060300F3 RID: 196851 RVA: 0x00688972 File Offset: 0x00686B72
		public EMoraleUiType UiType { get; set; }

		// Token: 0x1700CB75 RID: 52085
		// (get) Token: 0x060300F4 RID: 196852 RVA: 0x0068897B File Offset: 0x00686B7B
		// (set) Token: 0x060300F5 RID: 196853 RVA: 0x00688983 File Offset: 0x00686B83
		public byte NullMask { get; set; }

		// Token: 0x060300F6 RID: 196854 RVA: 0x0068898C File Offset: 0x00686B8C
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
