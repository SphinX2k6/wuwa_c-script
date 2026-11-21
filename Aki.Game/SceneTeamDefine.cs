using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001ECC RID: 7884
[NullableContext(1)]
[Nullable(0)]
public static class SceneTeamDefine
{
	// Token: 0x0400A690 RID: 42640
	public const int SCENE_TEAM_MAX_NUM = 4;

	// Token: 0x0400A691 RID: 42641
	public const float DATA_LAYER_CHANGE_RADIUS = 20000f;

	// Token: 0x0400A692 RID: 42642
	public const float SPECIAL_CHANGE_DIS_LAND = 200f;

	// Token: 0x0400A693 RID: 42643
	public const float SPECIAL_CHANGE_DIS_AIR = 150f;

	// Token: 0x0400A694 RID: 42644
	public const float SPECIAL_CHANGE_ANGLE_LAND = 80f;

	// Token: 0x0400A695 RID: 42645
	public const float SPECIAL_CHANGE_ANGLE_AIR = 35f;

	// Token: 0x0400A696 RID: 42646
	public const float SPECIAL_CHANGE_HEIGHT_LAND = 0f;

	// Token: 0x0400A697 RID: 42647
	public const float SPECIAL_CHANGE_HEIGHT_AIR = -100f;

	// Token: 0x0400A698 RID: 42648
	public const string GO_BATTLE_MATERIAL = "GoBattleMaterial";

	// Token: 0x0400A699 RID: 42649
	public const string GO_BATTLE_EFFECT = "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_ChangeRole_Play.DA_Fx_Group_ChangeRole_Play";

	// Token: 0x0400A69A RID: 42650
	public const string GO_DOWN_MATERIAL = "GoDownMaterial";

	// Token: 0x0400A69B RID: 42651
	public const int EFFECT_DELAY = 100;

	// Token: 0x0400A69C RID: 42652
	public const int EFFECT_DELAY_QUIT = 300;

	// Token: 0x0400A69D RID: 42653
	public const int CHECK_ROLE_INTERVAL = 30000;

	// Token: 0x0400A69E RID: 42654
	[StaticVariableRuleIgnore]
	public static readonly int[] beHitTagList = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被弹反"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.轻击"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.重击"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.击飞"]
	};

	// Token: 0x0400A69F RID: 42655
	[StaticVariableRuleIgnore]
	public static IReadOnlySet<ETeamGroupType> needInheritTypeSet = new HashSet<ETeamGroupType>(new <>z__ReadOnlyArray<ETeamGroupType>(new ETeamGroupType[]
	{
		ETeamGroupType.VisionControl,
		ETeamGroupType.Plot,
		ETeamGroupType.Performance
	}));

	// Token: 0x0400A6A0 RID: 42656
	[StaticVariableRuleIgnore]
	public static readonly ETeamGroupType[] innerGroupType = new ETeamGroupType[]
	{
		ETeamGroupType.VisionControl,
		ETeamGroupType.Plot
	};

	// Token: 0x0400A6A1 RID: 42657
	[StaticVariableRuleIgnore]
	public static readonly int[] needFixLocationTagList = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑坡.普通滑坡"],
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑雪.正常滑雪"]
	};

	// Token: 0x0400A6A2 RID: 42658
	public const float AUTO_ROLE_OFFSET_DISTANCE = 150f;

	// Token: 0x0400A6A3 RID: 42659
	public const int CHANGING_ROLE_TIMEOUT = 2000;

	// Token: 0x0400A6A4 RID: 42660
	public const int SEAMLESS_UPDATE_TEAM_TIMEOUT = 30000;
}
