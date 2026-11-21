using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200478C RID: 18316
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardInfo : IRewardInfo
	{
		// Token: 0x17005CEF RID: 23791
		// (get) Token: 0x0602E05C RID: 188508 RVA: 0x00CDEA51 File Offset: 0x00CDCC51
		// (set) Token: 0x0602E05D RID: 188509 RVA: 0x00CDEA59 File Offset: 0x00CDCC59
		public ERewardInfoType Type { get; set; }

		// Token: 0x17005CF0 RID: 23792
		// (get) Token: 0x0602E05E RID: 188510 RVA: 0x00CDEA62 File Offset: 0x00CDCC62
		// (set) Token: 0x0602E05F RID: 188511 RVA: 0x00CDEA6A File Offset: 0x00CDCC6A
		public EUiViewName ViewName { get; set; }

		// Token: 0x17005CF1 RID: 23793
		// (get) Token: 0x0602E060 RID: 188512 RVA: 0x00CDEA73 File Offset: 0x00CDCC73
		// (set) Token: 0x0602E061 RID: 188513 RVA: 0x00CDEA7B File Offset: 0x00CDCC7B
		public string AudioId { get; set; }
	}
}
