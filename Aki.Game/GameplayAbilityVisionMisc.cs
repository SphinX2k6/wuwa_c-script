using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002718 RID: 10008
[NullableContext(1)]
[Nullable(0)]
public static class GameplayAbilityVisionMisc
{
	// Token: 0x0400DB16 RID: 56086
	public const long ROLE_SUMMON_BUFF_ID = 1900000014L;

	// Token: 0x0400DB17 RID: 56087
	public const long VISION_SUMMON_BUFF_ID = 1900000015L;

	// Token: 0x0400DB18 RID: 56088
	public const long VISION_APPEAR_BUFF_ID = 1900000017L;

	// Token: 0x0400DB19 RID: 56089
	public const int ROLE_DODGE_FORBID_BUFF_ID = 1101004005;

	// Token: 0x0400DB1A RID: 56090
	public const long ROLE_HIDE_CUE_ID = 19000000191L;

	// Token: 0x0400DB1B RID: 56091
	public const long ROLE_APPEAR_CUE_ID = 19000000201L;

	// Token: 0x0400DB1C RID: 56092
	public const long MATERIAL_CUE_ID = 19000000181L;

	// Token: 0x0400DB1D RID: 56093
	public const long MORPH_PARTICLE_CUE_ID = 19000000182L;

	// Token: 0x0400DB1E RID: 56094
	public const long SUMMON_PARTICLE_CUE_ID = 19000000162L;

	// Token: 0x0400DB1F RID: 56095
	public const int CHARACTER_HIDDEN_DELAY = 300;

	// Token: 0x0400DB20 RID: 56096
	public const int VISION_HIDDEN_DELAY = 1000;

	// Token: 0x0400DB21 RID: 56097
	public const int EXPLORE_SKILL_ID = 1200000;

	// Token: 0x0400DB22 RID: 56098
	public const string VISION_END_BULLET = "210000004";

	// Token: 0x0400DB23 RID: 56099
	public const int VISION_MORPH_SKILL_ID = 200001;

	// Token: 0x0400DB24 RID: 56100
	public static readonly EAttributeType controlVisionEnergy = EAttributeType.Life;

	// Token: 0x0400DB25 RID: 56101
	public static readonly int morphTag = GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"];

	// Token: 0x0400DB26 RID: 56102
	public static readonly int summonTag = GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.召唤幻象.激活幻象中"];

	// Token: 0x0400DB27 RID: 56103
	public static readonly int invincibleTag = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.不被子弹命中"];

	// Token: 0x0400DB28 RID: 56104
	public static readonly int skillTag = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"];

	// Token: 0x0400DB29 RID: 56105
	public static readonly int stealthTag = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不被敌方子弹命中.前台不受控制"];

	// Token: 0x0400DB2A RID: 56106
	[StaticVariableRuleIgnore]
	public static readonly global::Rotator tempRotator = global::Rotator.Create();

	// Token: 0x0400DB2B RID: 56107
	[StaticVariableRuleIgnore]
	public static readonly global::Vector tempVector1 = global::Vector.Create();

	// Token: 0x0400DB2C RID: 56108
	[StaticVariableRuleIgnore]
	public static readonly global::Vector tempVector2 = global::Vector.Create();

	// Token: 0x0400DB2D RID: 56109
	public static readonly int newVisionInteractTag = GameplayTagDefine.EGameplayTagId["关卡.新版声骸显像.可用"];

	// Token: 0x0400DB2E RID: 56110
	public static readonly int newShowVisionTag = GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.召唤幻象.显影幻象中"];
}
