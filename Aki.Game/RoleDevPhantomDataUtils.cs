using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001D7A RID: 7546
[NullableContext(1)]
[Nullable(0)]
public class RoleDevPhantomDataUtils
{
	// Token: 0x06012A34 RID: 76340 RVA: 0x0057D3A4 File Offset: 0x0057B5A4
	public static List<RoleDevPhantomSuitItemData> RefreshSuitDataListByRecommendInfo(int roleId, List<VisionFetterRecommendInfo> recommendInfo, int selectedRecommendPlanId)
	{
		List<RoleDevPhantomSuitItemData> list = new List<RoleDevPhantomSuitItemData>();
		if (recommendInfo == null || recommendInfo.Count == 0)
		{
			return list;
		}
		VisionFetterRecommendInfo visionFetterRecommendInfo = null;
		foreach (VisionFetterRecommendInfo visionFetterRecommendInfo2 in recommendInfo)
		{
			if (visionFetterRecommendInfo2.GetPlanId() == selectedRecommendPlanId)
			{
				visionFetterRecommendInfo = visionFetterRecommendInfo2;
				break;
			}
		}
		if (visionFetterRecommendInfo == null)
		{
			foreach (VisionFetterRecommendInfo visionFetterRecommendInfo3 in recommendInfo)
			{
				if (visionFetterRecommendInfo3.GetRecommendFetterGroupId() == selectedRecommendPlanId)
				{
					visionFetterRecommendInfo = visionFetterRecommendInfo3;
					break;
				}
			}
		}
		if (visionFetterRecommendInfo == null)
		{
			return list;
		}
		int recommendFetterGroupId = visionFetterRecommendInfo.GetRecommendFetterGroupId();
		EFetterGroupType fetterType = visionFetterRecommendInfo.GetFetterType();
		RoleDevConfig instance = RoleDevConfig.Instance;
		RoleDevPhantomJumpGroup? roleDevPhantomJumpGroup = (instance != null) ? instance.GetPhantomJumpGroupConfig(recommendFetterGroupId) : null;
		if (roleDevPhantomJumpGroup == null)
		{
			return list;
		}
		RoleDevPhantomSuitItemData roleDevPhantomSuitItemData = new RoleDevPhantomSuitItemData();
		roleDevPhantomSuitItemData.Init(recommendFetterGroupId, roleId, visionFetterRecommendInfo);
		list.Add(roleDevPhantomSuitItemData);
		if (fetterType == EFetterGroupType.Special)
		{
			int specialFetterSubGroupId = visionFetterRecommendInfo.GetSpecialFetterSubGroupId();
			if (specialFetterSubGroupId > 0)
			{
				RoleDevConfig instance2 = RoleDevConfig.Instance;
				RoleDevPhantomJumpGroup? roleDevPhantomJumpGroup2 = (instance2 != null) ? instance2.GetPhantomJumpGroupConfig(specialFetterSubGroupId) : null;
				if (roleDevPhantomJumpGroup2 != null)
				{
					RoleDevPhantomSuitItemData roleDevPhantomSuitItemData2 = new RoleDevPhantomSuitItemData();
					roleDevPhantomSuitItemData2.Init(specialFetterSubGroupId, roleId, visionFetterRecommendInfo);
					list.Add(roleDevPhantomSuitItemData2);
				}
			}
		}
		return list;
	}

	// Token: 0x06012A35 RID: 76341 RVA: 0x0057D504 File Offset: 0x0057B704
	public static List<VisionFetterRecommendInfo> SortRecommendInfo(List<VisionFetterRecommendInfo> recommendInfo)
	{
		recommendInfo.Sort((VisionFetterRecommendInfo a, VisionFetterRecommendInfo b) => b.GetUsage() - a.GetUsage());
		return recommendInfo;
	}

	// Token: 0x06012A36 RID: 76342 RVA: 0x0057D52C File Offset: 0x0057B72C
	public static List<RoleDevPhantomSuitItemData> RefreshSuitDataListByFetterGroupId(int roleId, int fetterGroupId)
	{
		List<RoleDevPhantomSuitItemData> list = new List<RoleDevPhantomSuitItemData>();
		RoleDevConfig instance = RoleDevConfig.Instance;
		RoleDevPhantomJumpGroup? roleDevPhantomJumpGroup = (instance != null) ? instance.GetPhantomJumpGroupConfig(fetterGroupId) : null;
		if (roleDevPhantomJumpGroup == null)
		{
			return list;
		}
		RoleDevPhantomSuitItemData roleDevPhantomSuitItemData = new RoleDevPhantomSuitItemData();
		roleDevPhantomSuitItemData.Init(fetterGroupId, roleId, null);
		list.Add(roleDevPhantomSuitItemData);
		return list;
	}

	// Token: 0x06012A37 RID: 76343 RVA: 0x0057D57C File Offset: 0x0057B77C
	public static int GetDefaultRecommendPlanId(int roleId)
	{
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(roleId);
		if (roleFetterRecommendInfo == null || roleFetterRecommendInfo.Count == 0)
		{
			return 0;
		}
		RoleDevPhantomDataUtils.SortRecommendInfo(roleFetterRecommendInfo);
		return roleFetterRecommendInfo[0].GetPlanId();
	}
}
