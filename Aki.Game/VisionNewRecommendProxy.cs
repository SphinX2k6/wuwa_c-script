using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020019CC RID: 6604
[NullableContext(2)]
[Nullable(0)]
public class VisionNewRecommendProxy
{
	// Token: 0x060104A0 RID: 66720 RVA: 0x004C1C31 File Offset: 0x004BFE31
	public VisionFetterRecommendInfo GetCurrentSelectRecommendInfo()
	{
		return this.CurrentSelectFetterRecommendInfo;
	}

	// Token: 0x060104A1 RID: 66721 RVA: 0x004C1C39 File Offset: 0x004BFE39
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionFetterRecommendInfo> GetSystemRecommendInfoList()
	{
		return VisionRecommendModel.Instance.GetRoleSystemFetterRecommendList(this.CurrentSelectRoleId);
	}

	// Token: 0x060104A2 RID: 66722 RVA: 0x004C1C4B File Offset: 0x004BFE4B
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionFetterRecommendInfo> GetUsageRecommendInfoList()
	{
		return VisionRecommendModel.Instance.GetRoleUsageFetterRecommendList(this.CurrentSelectRoleId);
	}

	// Token: 0x04009036 RID: 36918
	public bool IsFromRoleDev;

	// Token: 0x04009037 RID: 36919
	public int CurrentSelectRoleId;

	// Token: 0x04009038 RID: 36920
	public VisionFetterRecommendInfo CurrentSelectFetterRecommendInfo;

	// Token: 0x04009039 RID: 36921
	public bool IsSimpleMode = true;

	// Token: 0x0400903A RID: 36922
	public int CurrentSelectFirstVisionMonsterId;

	// Token: 0x0400903B RID: 36923
	public Func<int, int> GetSelectedPlanIdCallBack;

	// Token: 0x0400903C RID: 36924
	public Func<int, int> GetSelectedFirstVisionMonsterIdCallBack;

	// Token: 0x0400903D RID: 36925
	public Action<Action> RefreshSelectedRecommendDetail;

	// Token: 0x0400903E RID: 36926
	public bool IsFromRoleDevFirstSelect;

	// Token: 0x0400903F RID: 36927
	public UiBehaviorLevelSequence MainViewSequence;
}
