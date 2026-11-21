using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001D78 RID: 7544
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevPhantomData : RoleDevPhantomViewItemDataBase
{
	// Token: 0x06012A2C RID: 76332 RVA: 0x0057D224 File Offset: 0x0057B424
	protected override void InitByRoleType(int roleId)
	{
		if (base.RoleDevViewModel != null && !base.RoleDevViewModel.CheckRoleIdIsCreated(base.RoleId))
		{
			int defaultRecommendPlanId = RoleDevPhantomDataUtils.GetDefaultRecommendPlanId(base.RoleId);
			base.RoleDevViewModel.SetRoleRecommendPlanId(base.RoleId, defaultRecommendPlanId);
		}
		this.RefreshSuitDataList();
	}

	// Token: 0x06012A2D RID: 76333 RVA: 0x0057D270 File Offset: 0x0057B470
	protected override List<RoleDevPhantomSuitItemData> GetSuitDataList()
	{
		return this.SuitDataListInternal;
	}

	// Token: 0x06012A2E RID: 76334 RVA: 0x0057D278 File Offset: 0x0057B478
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

	// Token: 0x0400A1E6 RID: 41446
	private List<RoleDevPhantomSuitItemData> SuitDataListInternal = new List<RoleDevPhantomSuitItemData>();
}
