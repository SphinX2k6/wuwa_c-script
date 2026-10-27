using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002951 RID: 10577
[NullableContext(1)]
[Nullable(0)]
public static class SceneTeamDefine
{
	// Token: 0x0400A2A6 RID: 41638
	public const int SCENE_TEAM_MAX_NUM = 4;

	// Token: 0x0400A2A7 RID: 41639
	public const float DATA_LAYER_CHANGE_RADIUS = 20000f;

	// Token: 0x0400A2A8 RID: 41640
	public const float SPECIAL_CHANGE_DIS_LAND = 200f;

	// Token: 0x0400A2A9 RID: 41641
	public const float SPECIAL_CHANGE_DIS_AIR = 150f;

	// Token: 0x0400A2AA RID: 41642
	public const float SPECIAL_CHANGE_ANGLE_LAND = 80f;

	// Token: 0x0400A2AB RID: 41643
	public const float SPECIAL_CHANGE_ANGLE_AIR = 35f;

	// Token: 0x0400A2AC RID: 41644
	public const float SPECIAL_CHANGE_HEIGHT_LAND = 0f;

	// Token: 0x0400A2AD RID: 41645
	public const float SPECIAL_CHANGE_HEIGHT_AIR = -100f;

	// Token: 0x0400A2AE RID: 41646
	public const string GO_BATTLE_MATERIAL = "GoBattleMaterial";

	// Token: 0x0400A2AF RID: 41647
	public const string GO_BATTLE_EFFECT = "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_ChangeRole_Play.DA_Fx_Group_ChangeRole_Play";

	// Token: 0x0400A2B0 RID: 41648
	public const string GO_DOWN_MATERIAL = "GoDownMaterial";

	// Token: 0x0400A2B1 RID: 41649
	public const int EFFECT_DELAY = 100;

	// Token: 0x0400A2B2 RID: 41650
	public const int EFFECT_DELAY_QUIT = 300;

	// Token: 0x0400A2B3 RID: 41651
	public const int CHECK_ROLE_INTERVAL = 30000;

	// Token: 0x0400A2B4 RID: 41652
	[StaticVariableRuleIgnore]
	public static readonly int[] beHitTagList = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被弹反"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.轻击"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.重击"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.击飞"]
	};

	// Token: 0x0400A2B5 RID: 41653
	[StaticVariableRuleIgnore]
	public static IReadOnlySet<ETeamGroupType> needInheritTypeSet = new HashSet<ETeamGroupType>(new <>z__ReadOnlyArray<ETeamGroupType>(new ETeamGroupType[]
	{
		ETeamGroupType.VisionControl,
		ETeamGroupType.Plot,
		ETeamGroupType.Performance
	}));

	// Token: 0x0400A2B6 RID: 41654
	[StaticVariableRuleIgnore]
	public static readonly ETeamGroupType[] innerGroupType = new ETeamGroupType[]
	{
		ETeamGroupType.VisionControl,
		ETeamGroupType.Plot
	};

	// Token: 0x0400A2B7 RID: 41655
	[StaticVariableRuleIgnore]
	public static readonly int[] needFixLocationTagList = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑坡.普通滑坡"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑雪.正常滑雪"]
	};

	// Token: 0x0400A2B8 RID: 41656
	public const float AUTO_ROLE_OFFSET_DISTANCE = 150f;

	// Token: 0x0400A2B9 RID: 41657
	public const int CHANGING_ROLE_TIMEOUT = 2000;

	// Token: 0x0400A2BA RID: 41658
	public const int SEAMLESS_UPDATE_TEAM_TIMEOUT = 30000;
}
