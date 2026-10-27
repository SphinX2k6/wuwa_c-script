using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x020013C0 RID: 5056
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewPlayerSupportRewardViewParam : IActivityNewPlayerSupportRewardViewParam
{
	// Token: 0x17000BFB RID: 3067
	// (get) Token: 0x06008E96 RID: 36502 RVA: 0x001EC4A4 File Offset: 0x001EA6A4
	// (set) Token: 0x06008E97 RID: 36503 RVA: 0x001EC4AC File Offset: 0x001EA6AC
	public RewardData<ICommonRewardInfo> RewardData { get; set; }

	// Token: 0x17000BFC RID: 3068
	// (get) Token: 0x06008E98 RID: 36504 RVA: 0x001EC4B5 File Offset: 0x001EA6B5
	// (set) Token: 0x06008E99 RID: 36505 RVA: 0x001EC4BD File Offset: 0x001EA6BD
	public List<int> TrialRoleList { get; set; }
}
