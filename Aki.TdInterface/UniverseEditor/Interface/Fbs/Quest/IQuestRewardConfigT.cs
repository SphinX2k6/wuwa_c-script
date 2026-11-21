using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004452 RID: 17490
	public class IQuestRewardConfigT
	{
		// Token: 0x17007944 RID: 31044
		// (get) Token: 0x06019165 RID: 102757 RVA: 0x003940A7 File Offset: 0x003922A7
		// (set) Token: 0x06019166 RID: 102758 RVA: 0x003940AF File Offset: 0x003922AF
		public int RewardId { get; set; }

		// Token: 0x17007945 RID: 31045
		// (get) Token: 0x06019167 RID: 102759 RVA: 0x003940B8 File Offset: 0x003922B8
		// (set) Token: 0x06019168 RID: 102760 RVA: 0x003940C0 File Offset: 0x003922C0
		public EItemGetUiType RewardGetUiType { get; set; }

		// Token: 0x17007946 RID: 31046
		// (get) Token: 0x06019169 RID: 102761 RVA: 0x003940C9 File Offset: 0x003922C9
		// (set) Token: 0x0601916A RID: 102762 RVA: 0x003940D1 File Offset: 0x003922D1
		public IItemGetUiConfigSpecialQuestT UiConfig { get; set; }

		// Token: 0x17007947 RID: 31047
		// (get) Token: 0x0601916B RID: 102763 RVA: 0x003940DA File Offset: 0x003922DA
		// (set) Token: 0x0601916C RID: 102764 RVA: 0x003940E2 File Offset: 0x003922E2
		public byte NullMask { get; set; }

		// Token: 0x0601916D RID: 102765 RVA: 0x003940EB File Offset: 0x003922EB
		public IQuestRewardConfigT()
		{
			this.RewardId = 0;
			this.RewardGetUiType = EItemGetUiType.None;
			this.UiConfig = null;
			this.NullMask = 0;
		}
	}
}
