using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004011 RID: 16401
	public class IQuestRewardConfigT
	{
		// Token: 0x17007342 RID: 29506
		// (get) Token: 0x06017ACC RID: 96972 RVA: 0x0036A2B3 File Offset: 0x003684B3
		// (set) Token: 0x06017ACD RID: 96973 RVA: 0x0036A2BB File Offset: 0x003684BB
		public int RewardId { get; set; }

		// Token: 0x17007343 RID: 29507
		// (get) Token: 0x06017ACE RID: 96974 RVA: 0x0036A2C4 File Offset: 0x003684C4
		// (set) Token: 0x06017ACF RID: 96975 RVA: 0x0036A2CC File Offset: 0x003684CC
		public EItemGetUiType RewardGetUiType { get; set; }

		// Token: 0x17007344 RID: 29508
		// (get) Token: 0x06017AD0 RID: 96976 RVA: 0x0036A2D5 File Offset: 0x003684D5
		// (set) Token: 0x06017AD1 RID: 96977 RVA: 0x0036A2DD File Offset: 0x003684DD
		public IItemGetUiConfigSpecialQuestT UiConfig { get; set; }

		// Token: 0x17007345 RID: 29509
		// (get) Token: 0x06017AD2 RID: 96978 RVA: 0x0036A2E6 File Offset: 0x003684E6
		// (set) Token: 0x06017AD3 RID: 96979 RVA: 0x0036A2EE File Offset: 0x003684EE
		public byte NullMask { get; set; }

		// Token: 0x06017AD4 RID: 96980 RVA: 0x0036A2F7 File Offset: 0x003684F7
		public IQuestRewardConfigT()
		{
			this.RewardId = 0;
			this.RewardGetUiType = EItemGetUiType.None;
			this.UiConfig = null;
			this.NullMask = 0;
		}
	}
}
