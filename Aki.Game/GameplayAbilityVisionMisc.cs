using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020031A9 RID: 12713
[NullableContext(1)]
[Nullable(0)]
public static class GameplayAbilityVisionMisc
{
	// Token: 0x0400D690 RID: 54928
	public const long ROLE_SUMMON_BUFF_ID = 1900000014L;

	// Token: 0x0400D691 RID: 54929
	public const long VISION_SUMMON_BUFF_ID = 1900000015L;

	// Token: 0x0400D692 RID: 54930
	public const long VISION_APPEAR_BUFF_ID = 1900000017L;

	// Token: 0x0400D693 RID: 54931
	public const int ROLE_DODGE_FORBID_BUFF_ID = 1101004005;

	// Token: 0x0400D694 RID: 54932
	public const long ROLE_HIDE_CUE_ID = 19000000191L;

	// Token: 0x0400D695 RID: 54933
	public const long ROLE_APPEAR_CUE_ID = 19000000201L;

	// Token: 0x0400D696 RID: 54934
	public const long MATERIAL_CUE_ID = 19000000181L;

	// Token: 0x0400D697 RID: 54935
	public const long MORPH_PARTICLE_CUE_ID = 19000000182L;

	// Token: 0x0400D698 RID: 54936
	public const long SUMMON_PARTICLE_CUE_ID = 19000000162L;

	// Token: 0x0400D699 RID: 54937
	public const int CHARACTER_HIDDEN_DELAY = 300;

	// Token: 0x0400D69A RID: 54938
	public const int VISION_HIDDEN_DELAY = 1000;

	// Token: 0x0400D69B RID: 54939
	public const int EXPLORE_SKILL_ID = 1200000;

	// Token: 0x0400D69C RID: 54940
	public const string VISION_END_BULLET = "210000004";

	// Token: 0x0400D69D RID: 54941
	public static readonly EAttributeType controlVisionEnergy = EAttributeType.Life;

	// Token: 0x0400D69E RID: 54942
	public static readonly int morphTag = GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"];

	// Token: 0x0400D69F RID: 54943
	public static readonly int summonTag = GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.召唤幻象.激活幻象中"];

	// Token: 0x0400D6A0 RID: 54944
	public static readonly int invincibleTag = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.不被子弹命中"];

	// Token: 0x0400D6A1 RID: 54945
	public static readonly int skillTag = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"];

	// Token: 0x0400D6A2 RID: 54946
	public static readonly int stealthTag = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不被敌方子弹命中.前台不受控制"];

	// Token: 0x0400D6A3 RID: 54947
	[StaticVariableRuleIgnore]
	public static readonly global::Rotator tempRotator = global::Rotator.Create();

	// Token: 0x0400D6A4 RID: 54948
	[StaticVariableRuleIgnore]
	public static readonly global::Vector tempVector1 = global::Vector.Create();

	// Token: 0x0400D6A5 RID: 54949
	[StaticVariableRuleIgnore]
	public static readonly global::Vector tempVector2 = global::Vector.Create();

	// Token: 0x0400D6A6 RID: 54950
	public static readonly int newVisionInteractTag = GameplayTagDefine.EGameplayTagId["关卡.新版声骸显像.可用"];

	// Token: 0x0400D6A7 RID: 54951
	public static readonly int newShowVisionTag = GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.召唤幻象.显影幻象中"];
}
