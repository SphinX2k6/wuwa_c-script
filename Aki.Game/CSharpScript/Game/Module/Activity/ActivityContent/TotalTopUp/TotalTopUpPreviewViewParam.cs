using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F79 RID: 20345
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewViewParam : ITotalTopUpPreviewViewParam
	{
		// Token: 0x170063B9 RID: 25529
		// (get) Token: 0x060330BD RID: 209085 RVA: 0x00E4E803 File Offset: 0x00E4CA03
		// (set) Token: 0x060330BE RID: 209086 RVA: 0x00E4E80B File Offset: 0x00E4CA0B
		public TotalTopUpReward RewardConfig { get; set; }

		// Token: 0x170063BA RID: 25530
		// (get) Token: 0x060330BF RID: 209087 RVA: 0x00E4E814 File Offset: 0x00E4CA14
		// (set) Token: 0x060330C0 RID: 209088 RVA: 0x00E4E81C File Offset: 0x00E4CA1C
		public TotalTopUpRewardData RewardData { get; set; }
	}
}
