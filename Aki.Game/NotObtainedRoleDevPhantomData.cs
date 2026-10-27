using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027FD RID: 10237
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevPhantomData : RoleDevPhantomViewItemDataBase
{
	// Token: 0x0601502C RID: 86060 RVA: 0x005524B0 File Offset: 0x005506B0
	protected override void InitByRoleType(int roleId)
	{
		if (base.RoleDevViewModel != null && !base.RoleDevViewModel.CheckRoleIdIsCreated(base.RoleId))
		{
			int defaultRecommendPlanId = RoleDevPhantomDataUtils.GetDefaultRecommendPlanId(base.RoleId);
			base.RoleDevViewModel.SetRoleRecommendPlanId(base.RoleId, defaultRecommendPlanId);
		}
		this.RefreshSuitDataList();
	}

	// Token: 0x0601502D RID: 86061 RVA: 0x005524FC File Offset: 0x005506FC
	protected override List<RoleDevPhantomSuitItemData> GetSuitDataList()
	{
		return this.SuitDataListInternal;
	}

	// Token: 0x0601502E RID: 86062 RVA: 0x00552504 File Offset: 0x00550704
	public override void RefreshSuitDataList()
	{
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(base.RoleId);
		if (roleFetterRecommendInfo == null)
		{
			return;
		}
		if (base.RoleDevViewModel != null)
		{
			RoleDevPhantomDataUtils.SortRecommendInfo(roleFetterRecommendInfo);
			int roleRecommendPlanId = base.RoleDevViewModel.GetRoleRecommendPlanId(base.RoleId);
			this.SuitDataListInternal = RoleDevPhantomDataUtils.RefreshSuitDataListByRecommendInfo(base.RoleId, roleFetterRecommendInfo, roleRecommendPlanId);
		}
	}

	// Token: 0x04009DFD RID: 40445
	private List<RoleDevPhantomSuitItemData> SuitDataListInternal = new List<RoleDevPhantomSuitItemData>();
}
