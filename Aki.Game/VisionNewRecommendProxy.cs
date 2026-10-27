using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020024E5 RID: 9445
[NullableContext(2)]
[Nullable(0)]
public class VisionNewRecommendProxy
{
	// Token: 0x06012FE1 RID: 77793 RVA: 0x004B4099 File Offset: 0x004B2299
	public VisionFetterRecommendInfo GetCurrentSelectRecommendInfo()
	{
		return this.CurrentSelectFetterRecommendInfo;
	}

	// Token: 0x06012FE2 RID: 77794 RVA: 0x004B40A1 File Offset: 0x004B22A1
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionFetterRecommendInfo> GetSystemRecommendInfoList()
	{
		return VisionRecommendModel.Instance.GetRoleSystemFetterRecommendList(this.CurrentSelectRoleId);
	}

	// Token: 0x06012FE3 RID: 77795 RVA: 0x004B40B3 File Offset: 0x004B22B3
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionFetterRecommendInfo> GetUsageRecommendInfoList()
	{
		return VisionRecommendModel.Instance.GetRoleUsageFetterRecommendList(this.CurrentSelectRoleId);
	}

	// Token: 0x04008EEC RID: 36588
	public bool IsFromRoleDev;

	// Token: 0x04008EED RID: 36589
	public int CurrentSelectRoleId;

	// Token: 0x04008EEE RID: 36590
	public VisionFetterRecommendInfo CurrentSelectFetterRecommendInfo;

	// Token: 0x04008EEF RID: 36591
	public bool IsSimpleMode = true;

	// Token: 0x04008EF0 RID: 36592
	public int CurrentSelectFirstVisionMonsterId;

	// Token: 0x04008EF1 RID: 36593
	public Func<int, int> GetSelectedPlanIdCallBack;

	// Token: 0x04008EF2 RID: 36594
	public Func<int, int> GetSelectedFirstVisionMonsterIdCallBack;

	// Token: 0x04008EF3 RID: 36595
	public Action<Action> RefreshSelectedRecommendDetail;

	// Token: 0x04008EF4 RID: 36596
	public bool IsFromRoleDevFirstSelect;

	// Token: 0x04008EF5 RID: 36597
	public UiBehaviorLevelSequence MainViewSequence;
}
