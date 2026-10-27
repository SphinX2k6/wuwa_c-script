using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F92 RID: 24466
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewViewParam : ITotalTopUpPreviewViewParam
	{
		// Token: 0x17008FE7 RID: 36839
		// (get) Token: 0x0603E123 RID: 254243 RVA: 0x00EFCB4B File Offset: 0x00EFAD4B
		// (set) Token: 0x0603E124 RID: 254244 RVA: 0x00EFCB53 File Offset: 0x00EFAD53
		public TotalTopUpReward RewardConfig { get; set; }

		// Token: 0x17008FE8 RID: 36840
		// (get) Token: 0x0603E125 RID: 254245 RVA: 0x00EFCB5C File Offset: 0x00EFAD5C
		// (set) Token: 0x0603E126 RID: 254246 RVA: 0x00EFCB64 File Offset: 0x00EFAD64
		public TotalTopUpRewardData RewardData { get; set; }
	}
}
