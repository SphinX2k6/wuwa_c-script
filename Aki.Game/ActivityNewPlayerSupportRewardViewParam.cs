using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02000874 RID: 2164
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewPlayerSupportRewardViewParam : IActivityNewPlayerSupportRewardViewParam
{
	// Token: 0x17000C1B RID: 3099
	// (get) Token: 0x0600622B RID: 25131 RVA: 0x001F4FC4 File Offset: 0x001F31C4
	// (set) Token: 0x0600622C RID: 25132 RVA: 0x001F4FCC File Offset: 0x001F31CC
	public RewardData<ICommonRewardInfo> RewardData { get; set; }

	// Token: 0x17000C1C RID: 3100
	// (get) Token: 0x0600622D RID: 25133 RVA: 0x001F4FD5 File Offset: 0x001F31D5
	// (set) Token: 0x0600622E RID: 25134 RVA: 0x001F4FDD File Offset: 0x001F31DD
	public List<int> TrialRoleList { get; set; }
}
