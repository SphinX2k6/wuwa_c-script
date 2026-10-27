using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020027FF RID: 10239
[NullableContext(1)]
[Nullable(0)]
public class RoleDevPhantomDataUtils
{
	// Token: 0x06015034 RID: 86068 RVA: 0x00552630 File Offset: 0x00550830
	public static List<RoleDevPhantomSuitItemData> RefreshSuitDataListByRecommendInfo(int roleId, List<VisionFetterRecommendInfo> recommendInfo, int selectedRecommendPlanId)
	{
		List<RoleDevPhantomSuitItemData> list = new List<RoleDevPhantomSuitItemData>();
		if (recommendInfo == null || recommendInfo.Count == 0)
		{
			return list;
		}
		VisionFetterRecommendInfo visionFetterRecommendInfo = recommendInfo.FirstOrDefault((VisionFetterRecommendInfo recommend) => recommend.GetPlanId() == selectedRecommendPlanId);
		if (visionFetterRecommendInfo == null)
		{
			visionFetterRecommendInfo = recommendInfo.FirstOrDefault((VisionFetterRecommendInfo recommend) => recommend.GetRecommendFetterGroupId() == selectedRecommendPlanId);
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

	// Token: 0x06015035 RID: 86069 RVA: 0x0055272F File Offset: 0x0055092F
	public static List<VisionFetterRecommendInfo> SortRecommendInfo(List<VisionFetterRecommendInfo> recommendInfo)
	{
		recommendInfo.Sort((VisionFetterRecommendInfo a, VisionFetterRecommendInfo b) => b.GetUsage() - a.GetUsage());
		return recommendInfo;
	}

	// Token: 0x06015036 RID: 86070 RVA: 0x00552758 File Offset: 0x00550958
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

	// Token: 0x06015037 RID: 86071 RVA: 0x005527A8 File Offset: 0x005509A8
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
