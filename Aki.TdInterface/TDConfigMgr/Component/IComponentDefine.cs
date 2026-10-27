using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200025E RID: 606
	[NullableContext(1)]
	[Nullable(0)]
	public static class IComponentDefine
	{
		// Token: 0x06000B02 RID: 2818 RVA: 0x0002CBF0 File Offset: 0x0002ADF0
		// Note: this type is marked as 'beforefieldinit'.
		static IComponentDefine()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["MonsterMatchType"] = "怪物类型";
			dictionary["ControlMatchType"] = "控物类型";
			dictionary["ItemFoundation"] = "底座类型";
			dictionary["DestructibleType"] = "可破坏物";
			IComponentDefine.entityCategoryConfig = dictionary;
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2["[ERuntimePlatformType.PC]"] = "PC";
			dictionary2["[ERuntimePlatformType.Mobile]"] = "移动端";
			IComponentDefine.runtimePlatformCnMap = dictionary2;
			Dictionary<EStateRepPerfType, string> dictionary3 = new Dictionary<EStateRepPerfType, string>();
			dictionary3[EStateRepPerfType.MontagePath] = "替换蒙太奇";
			dictionary3[EStateRepPerfType.SkillId] = "替换技能";
			dictionary3[EStateRepPerfType.Effects] = "替换特效";
			IComponentDefine.StateRepPerfType2TagLastPart = dictionary3;
			Dictionary<EAoiLayer, bool> dictionary4 = new Dictionary<EAoiLayer, bool>();
			dictionary4[EAoiLayer.Default] = true;
			dictionary4[EAoiLayer.Layer3] = true;
			dictionary4[EAoiLayer.Layer2] = true;
			dictionary4[EAoiLayer.Layer5] = true;
			dictionary4[EAoiLayer.Layer6] = true;
			dictionary4[EAoiLayer.Large] = false;
			dictionary4[EAoiLayer.Layer4] = true;
			dictionary4[EAoiLayer.Layer7] = false;
			IComponentDefine.AoiLayersValidInGroup = dictionary4;
			Dictionary<EAoiLayer, int> dictionary5 = new Dictionary<EAoiLayer, int>();
			dictionary5[EAoiLayer.Default] = 6000;
			dictionary5[EAoiLayer.Layer3] = 24000;
			dictionary5[EAoiLayer.Large] = 99000;
			dictionary5[EAoiLayer.Layer2] = 11000;
			dictionary5[EAoiLayer.Layer4] = 3000;
			dictionary5[EAoiLayer.Layer5] = 9000;
			dictionary5[EAoiLayer.Layer6] = 14000;
			dictionary5[EAoiLayer.Layer7] = 49000;
			IComponentDefine.AoiXyLayerValues = dictionary5;
			Dictionary<AoiZRadius, int> dictionary6 = new Dictionary<AoiZRadius, int>();
			dictionary6[AoiZRadius.Default] = -1;
			dictionary6[AoiZRadius.Layer1] = 24000;
			dictionary6[AoiZRadius.Layer2] = 6000;
			dictionary6[AoiZRadius.Layer3] = 3000;
			dictionary6[AoiZRadius.Layer4] = 50000;
			IComponentDefine.AoizLayerValues = dictionary6;
			Dictionary<ERewardType, string> dictionary7 = new Dictionary<ERewardType, string>();
			dictionary7[ERewardType.Nearby] = "附近掉落";
			dictionary7[ERewardType.Owner] = "房主掉落";
			dictionary7[ERewardType.Collect] = "采集物掉落";
			dictionary7[ERewardType.HostInteract] = "实体行为发放";
			IComponentDefine.RewardTypeCnMap = dictionary7;
			Dictionary<EPatrolMoveState, string> dictionary8 = new Dictionary<EPatrolMoveState, string>();
			dictionary8[EPatrolMoveState.Walk] = "走";
			dictionary8[EPatrolMoveState.Run] = "跑";
			dictionary8[EPatrolMoveState.Sprint] = "冲刺";
			IComponentDefine.PatrolMoveStateNameByValue = dictionary8;
			Dictionary<EDollGrabShowcaseBelongType, string> dictionary9 = new Dictionary<EDollGrabShowcaseBelongType, string>();
			dictionary9[EDollGrabShowcaseBelongType.LandOfXuanfang] = "玄方地界展示柜";
			IComponentDefine.DollGrabShowcaseBelongTypeCnMapper = dictionary9;
		}

		// Token: 0x04000AB8 RID: 2744
		public static readonly IReadOnlyDictionary<string, string> entityCategoryConfig;

		// Token: 0x04000AB9 RID: 2745
		public static readonly IReadOnlyDictionary<string, string> runtimePlatformCnMap;

		// Token: 0x04000ABA RID: 2746
		public static readonly IReadOnlyDictionary<EStateRepPerfType, string> StateRepPerfType2TagLastPart;

		// Token: 0x04000ABB RID: 2747
		public static readonly IReadOnlyDictionary<EAoiLayer, bool> AoiLayersValidInGroup;

		// Token: 0x04000ABC RID: 2748
		public static readonly IReadOnlyDictionary<EAoiLayer, int> AoiXyLayerValues;

		// Token: 0x04000ABD RID: 2749
		public static readonly IReadOnlyDictionary<AoiZRadius, int> AoizLayerValues;

		// Token: 0x04000ABE RID: 2750
		public static readonly IReadOnlyDictionary<ERewardType, string> RewardTypeCnMap;

		// Token: 0x04000ABF RID: 2751
		public static readonly IReadOnlyDictionary<EPatrolMoveState, string> PatrolMoveStateNameByValue;

		// Token: 0x04000AC0 RID: 2752
		public static readonly IReadOnlyDictionary<EDollGrabShowcaseBelongType, string> DollGrabShowcaseBelongTypeCnMapper;
	}
}
