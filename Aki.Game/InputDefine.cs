using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;

// Token: 0x02002607 RID: 9735
[NullableContext(1)]
[Nullable(0)]
public static class InputDefine
{
	// Token: 0x0601855E RID: 99678 RVA: 0x0075712C File Offset: 0x0075532C
	// Note: this type is marked as 'beforefieldinit'.
	static InputDefine()
	{
		Dictionary<EInputAction, string> dictionary = new Dictionary<EInputAction, string>();
		dictionary[EInputAction.跳跃] = "跳跃按下";
		dictionary[EInputAction.攀爬] = "攀爬按下";
		dictionary[EInputAction.走跑切换] = "走跑切换按下";
		dictionary[EInputAction.攻击] = "攻击按下";
		dictionary[EInputAction.闪避] = "闪避按下";
		dictionary[EInputAction.技能1] = "技能1按下";
		dictionary[EInputAction.幻象1] = "幻象1按下";
		dictionary[EInputAction.大招] = "大招按下";
		dictionary[EInputAction.幻象2] = "幻象2按下";
		dictionary[EInputAction.切换角色1] = "切换角色1按下";
		dictionary[EInputAction.切换角色2] = "切换角色2按下";
		dictionary[EInputAction.切换角色3] = "切换角色3按下";
		dictionary[EInputAction.锁定目标] = "锁定目标按下";
		dictionary[EInputAction.瞄准] = "瞄准按下";
		dictionary[EInputAction.通用交互] = "通用交互按下";
		dictionary[EInputAction.下降] = "下降按下";
		dictionary[EInputAction.移动输入按键事件] = "移动输入按下";
		InputDefine.InputPressFunctionNames = dictionary;
		Dictionary<EInputAction, string> dictionary2 = new Dictionary<EInputAction, string>();
		dictionary2[EInputAction.跳跃] = "跳跃抬起";
		dictionary2[EInputAction.攀爬] = "攀爬抬起";
		dictionary2[EInputAction.走跑切换] = "走跑切换抬起";
		dictionary2[EInputAction.攻击] = "攻击抬起";
		dictionary2[EInputAction.闪避] = "闪避抬起";
		dictionary2[EInputAction.技能1] = "技能1抬起";
		dictionary2[EInputAction.幻象1] = "幻象1抬起";
		dictionary2[EInputAction.大招] = "大招抬起";
		dictionary2[EInputAction.幻象2] = "幻象2抬起";
		dictionary2[EInputAction.切换角色1] = "切换角色1抬起";
		dictionary2[EInputAction.切换角色2] = "切换角色2抬起";
		dictionary2[EInputAction.切换角色3] = "切换角色3抬起";
		dictionary2[EInputAction.锁定目标] = "锁定目标抬起";
		dictionary2[EInputAction.瞄准] = "瞄准抬起";
		dictionary2[EInputAction.通用交互] = "通用交互抬起";
		dictionary2[EInputAction.下降] = "下降抬起";
		dictionary2[EInputAction.移动输入按键事件] = "移动输入抬起";
		InputDefine.InputReleaseFunctionNames = dictionary2;
		Dictionary<EInputAction, string> dictionary3 = new Dictionary<EInputAction, string>();
		dictionary3[EInputAction.跳跃] = "跳跃长按";
		dictionary3[EInputAction.攀爬] = "攀爬长按";
		dictionary3[EInputAction.走跑切换] = "走跑切换长按";
		dictionary3[EInputAction.攻击] = "攻击长按";
		dictionary3[EInputAction.闪避] = "闪避长按";
		dictionary3[EInputAction.技能1] = "技能1长按";
		dictionary3[EInputAction.幻象1] = "幻象1长按";
		dictionary3[EInputAction.大招] = "大招长按";
		dictionary3[EInputAction.幻象2] = "幻象2长按";
		dictionary3[EInputAction.切换角色1] = "切换角色1长按";
		dictionary3[EInputAction.切换角色2] = "切换角色2长按";
		dictionary3[EInputAction.切换角色3] = "切换角色3长按";
		dictionary3[EInputAction.锁定目标] = "锁定目标长按";
		dictionary3[EInputAction.瞄准] = "瞄准长按";
		dictionary3[EInputAction.通用交互] = "通用交互长按";
		dictionary3[EInputAction.下降] = "下降长按";
		dictionary3[EInputAction.移动输入按键事件] = "移动输入长按";
		InputDefine.InputHoldFunctionNames = dictionary3;
		Dictionary<EInputAction, string> dictionary4 = new Dictionary<EInputAction, string>();
		dictionary4[EInputAction.跳跃] = "跳跃按下事件";
		dictionary4[EInputAction.攀爬] = "攀爬按下事件";
		dictionary4[EInputAction.走跑切换] = "走跑切换按下事件";
		dictionary4[EInputAction.攻击] = "攻击按下事件";
		dictionary4[EInputAction.闪避] = "闪避按下事件";
		dictionary4[EInputAction.技能1] = "技能1按下事件";
		dictionary4[EInputAction.幻象1] = "幻象1按下事件";
		dictionary4[EInputAction.大招] = "大招按下事件";
		dictionary4[EInputAction.幻象2] = "幻象2按下事件";
		dictionary4[EInputAction.切换角色1] = "切换角色1按下事件";
		dictionary4[EInputAction.切换角色2] = "切换角色2按下事件";
		dictionary4[EInputAction.切换角色3] = "切换角色3按下事件";
		dictionary4[EInputAction.锁定目标] = "锁定目标按下事件";
		dictionary4[EInputAction.瞄准] = "瞄准按下事件";
		dictionary4[EInputAction.下降] = "下降按下事件";
		dictionary4[EInputAction.移动输入按键事件] = "移动输入按下事件";
		InputDefine.InputPressEventFunctionNames = dictionary4;
		Dictionary<EInputAction, string> dictionary5 = new Dictionary<EInputAction, string>();
		dictionary5[EInputAction.跳跃] = "跳跃抬起事件";
		dictionary5[EInputAction.攀爬] = "攀爬抬起事件";
		dictionary5[EInputAction.走跑切换] = "走跑切换抬起事件";
		dictionary5[EInputAction.攻击] = "攻击抬起事件";
		dictionary5[EInputAction.闪避] = "闪避抬起事件";
		dictionary5[EInputAction.技能1] = "技能1抬起事件";
		dictionary5[EInputAction.幻象1] = "幻象1抬起事件";
		dictionary5[EInputAction.大招] = "大招抬起事件";
		dictionary5[EInputAction.幻象2] = "幻象2抬起事件";
		dictionary5[EInputAction.切换角色1] = "切换角色1抬起事件";
		dictionary5[EInputAction.切换角色2] = "切换角色2抬起事件";
		dictionary5[EInputAction.切换角色3] = "切换角色3抬起事件";
		dictionary5[EInputAction.锁定目标] = "锁定目标抬起事件";
		dictionary5[EInputAction.瞄准] = "瞄准抬起事件";
		dictionary5[EInputAction.下降] = "下降抬起事件";
		dictionary5[EInputAction.移动输入按键事件] = "移动输入抬起事件";
		InputDefine.InputReleaseEventFunctionNames = dictionary5;
	}

	// Token: 0x0400D205 RID: 53765
	public const int SKILL_ID_FIX_HOOK_1 = 100020;

	// Token: 0x0400D206 RID: 53766
	public const int SKILL_ID_FIX_HOOK_2 = 100021;

	// Token: 0x0400D207 RID: 53767
	public const int SKILL_ID_SUIGUANG_HOOK = 100022;

	// Token: 0x0400D208 RID: 53768
	public const int SKILL_ID_LUOKEKE_QTE_ITEM = 100031;

	// Token: 0x0400D209 RID: 53769
	public const int SKILL_ID_RAG_DOLL = 200004;

	// Token: 0x0400D20A RID: 53770
	public const int SKILL_ID_HOOK = 210001;

	// Token: 0x0400D20B RID: 53771
	public const int SKILL_ID_MANIPULATE = 210003;

	// Token: 0x0400D20C RID: 53772
	public const int SKILL_ID_MANIPULATE_CANCEL = 210006;

	// Token: 0x0400D20D RID: 53773
	public const int SKILL_ID_SHOW_VISION = 210008;

	// Token: 0x0400D20E RID: 53774
	public const int SKILL_ID_YUANNIAOZE_TORNADO = 210014;

	// Token: 0x0400D20F RID: 53775
	public const int SKILL_ID_FOLLOWSHOOTER_AIM_START = 210020;

	// Token: 0x0400D210 RID: 53776
	public const int SKILL_ID_CHENGXIAOSHAN_TIMEDILATION = 210023;

	// Token: 0x0400D211 RID: 53777
	public const int SKILL_ID_CHENGXIAOSHAN_TIMEDILATION_STOP = 210024;

	// Token: 0x0400D212 RID: 53778
	public const int SKILL_ID_XA = 210030;

	// Token: 0x0400D213 RID: 53779
	public const int SKILL_ID_XA_GROUND = 210031;

	// Token: 0x0400D214 RID: 53780
	public const int SKILL_ID_XA_KITE = 210130;

	// Token: 0x0400D215 RID: 53781
	public const int SKILL_ID_XA_MOVABLE = 100024;

	// Token: 0x0400D216 RID: 53782
	public const int SKILL_ID_MANIPULATE_EX = 2100031;

	// Token: 0x0400D217 RID: 53783
	public const int SKILL_ID_STATUE_INTERACT = 2100033;

	// Token: 0x0400D218 RID: 53784
	public const int SKILL_ID_BULLET_RUN = 100027;

	// Token: 0x0400D219 RID: 53785
	public const int SKILL_ID_VISION_CONTROL = 200010;

	// Token: 0x0400D21A RID: 53786
	public const int SKILL_ID_VISION_ROGUE_1 = 230002;

	// Token: 0x0400D21B RID: 53787
	public const int SKILL_ID_VISION_ROGUE_2 = 23000201;

	// Token: 0x0400D21C RID: 53788
	public const int SKILL_ID_VISION_ROGUE_LIN_REN_1 = 280001116;

	// Token: 0x0400D21D RID: 53789
	public const int SKILL_ID_VISION_ROGUE_LIN_REN_2 = 280001110;

	// Token: 0x0400D21E RID: 53790
	public const int SKILL_ID_MANIPULATE_PARABOLA = 240001;

	// Token: 0x0400D21F RID: 53791
	public const int SKILL_ID_MISS_DOLL_TRANSFORM = 200005;

	// Token: 0x0400D220 RID: 53792
	public const int SKILL_ID_RAG_DOLL_QTE = 50170007;

	// Token: 0x0400D221 RID: 53793
	public const int SKILL_ID_FLYING_FEATHER = 1208713;

	// Token: 0x0400D222 RID: 53794
	public const int SKILL_ID_SUMMON_PARK_MOTOCYCLE = 800002;

	// Token: 0x0400D223 RID: 53795
	public const int SKILL_ID_ROLE_EJECT_START = 800017;

	// Token: 0x0400D224 RID: 53796
	public const int SKILL_ID_MOTORCYCLE_PULL_COLLECTION = 10001006;

	// Token: 0x0400D225 RID: 53797
	public const int SKILL_ID_MOTORCYCLE_FIX_HOOK = 10001027;

	// Token: 0x0400D226 RID: 53798
	public const int SKILL_ID_MOTORCYCLE_CABLE_WAY = 10001028;

	// Token: 0x0400D227 RID: 53799
	public const int SKILL_ID_MOTORCYCLE_PILOT_THROW = 10001029;

	// Token: 0x0400D228 RID: 53800
	public const int SKILL_ID_MOTORCYCLE_DRONE_SHOOT = 100011016;

	// Token: 0x0400D229 RID: 53801
	public const int SKILL_ID_SHOW_VISION_ENTRY = 2100081;

	// Token: 0x0400D22A RID: 53802
	public const int SKILL_ID_SUMMON_MOTOCYCLE = 800001;

	// Token: 0x0400D22B RID: 53803
	public const int SKILL_ID_MOTORCYCLE_SHOW_VISION_ENTRY = 10001012;

	// Token: 0x0400D22C RID: 53804
	public const int SKILL_ID_MOTORCYCLE_CRUISE = 10001007;

	// Token: 0x0400D22D RID: 53805
	public const int SKILL_ID_MOTOCYCLE_PHOTOGRAPH = 10001013;

	// Token: 0x0400D22E RID: 53806
	public const int SKILL_ID_MOTOCYCLE_EAGLE_EYE = 10001011;

	// Token: 0x0400D22F RID: 53807
	public const int SKILL_ID_SUMMON_MOTOCYCLE_AUTOPILOT = 800003;

	// Token: 0x0400D230 RID: 53808
	public const int SKILL_ID_MOTORCYCLE_EJECT = 10002001;

	// Token: 0x0400D231 RID: 53809
	public const int SKILL_ID_MOTORCYCLE_KITE_HOOK = 10001035;

	// Token: 0x0400D232 RID: 53810
	public const int SKILL_ID_MOTORCYCLE_PLATFORM_IDLE = 10002002;

	// Token: 0x0400D233 RID: 53811
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EInputAction, string> InputPressFunctionNames;

	// Token: 0x0400D234 RID: 53812
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EInputAction, string> InputReleaseFunctionNames;

	// Token: 0x0400D235 RID: 53813
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EInputAction, string> InputHoldFunctionNames;

	// Token: 0x0400D236 RID: 53814
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EInputAction, string> InputPressEventFunctionNames;

	// Token: 0x0400D237 RID: 53815
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EInputAction, string> InputReleaseEventFunctionNames;
}
