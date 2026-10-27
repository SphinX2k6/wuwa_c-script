using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027FE RID: 10238
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevPhantomData : RoleDevPhantomViewItemDataBase
{
	// Token: 0x06015030 RID: 86064 RVA: 0x00552570 File Offset: 0x00550770
	protected override void InitByRoleType(int roleId)
	{
		if (base.RoleDevViewModel != null && !base.RoleDevViewModel.CheckRoleIdIsCreated(base.RoleId))
		{
			int defaultRecommendPlanId = RoleDevPhantomDataUtils.GetDefaultRecommendPlanId(base.RoleId);
			base.RoleDevViewModel.SetRoleRecommendPlanId(base.RoleId, defaultRecommendPlanId);
		}
		this.RefreshSuitDataList();
	}

	// Token: 0x06015031 RID: 86065 RVA: 0x005525BC File Offset: 0x005507BC
	protected override List<RoleDevPhantomSuitItemData> GetSuitDataList()
	{
		return this.SuitDataListInternal;
	}

	// Token: 0x06015032 RID: 86066 RVA: 0x005525C4 File Offset: 0x005507C4
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

	// Token: 0x04009DFE RID: 40446
	private List<RoleDevPhantomSuitItemData> SuitDataListInternal = new List<RoleDevPhantomSuitItemData>();
}
