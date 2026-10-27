using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057B5 RID: 22453
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardInfo : IRewardInfo
	{
		// Token: 0x17008927 RID: 35111
		// (get) Token: 0x0603914C RID: 233804 RVA: 0x00D8FC19 File Offset: 0x00D8DE19
		// (set) Token: 0x0603914D RID: 233805 RVA: 0x00D8FC21 File Offset: 0x00D8DE21
		public ERewardInfoType Type { get; set; }

		// Token: 0x17008928 RID: 35112
		// (get) Token: 0x0603914E RID: 233806 RVA: 0x00D8FC2A File Offset: 0x00D8DE2A
		// (set) Token: 0x0603914F RID: 233807 RVA: 0x00D8FC32 File Offset: 0x00D8DE32
		public EUiViewName ViewName { get; set; }

		// Token: 0x17008929 RID: 35113
		// (get) Token: 0x06039150 RID: 233808 RVA: 0x00D8FC3B File Offset: 0x00D8DE3B
		// (set) Token: 0x06039151 RID: 233809 RVA: 0x00D8FC43 File Offset: 0x00D8DE43
		public string AudioId { get; set; }
	}
}
