using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000287 RID: 647
[NullableContext(2)]
[Nullable(0)]
public class GameSettingsDeviceRenderDefine : IStaticVariableResetter
{
	// Token: 0x060027DC RID: 10204 RVA: 0x000F5EEA File Offset: 0x000F40EA
	static GameSettingsDeviceRenderDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsDeviceRenderDefine.CreateStaticDefaultValue), new Action(GameSettingsDeviceRenderDefine.ResetStaticDefaultValue));
	}

	// Token: 0x1700060F RID: 1551
	// (get) Token: 0x060027DD RID: 10205 RVA: 0x000F5F09 File Offset: 0x000F4109
	[Nullable(1)]
	public static Dictionary<string, IPerformanceLimitConfig> PerformanceLimitConfigs
	{
		[NullableContext(1)]
		get
		{
			return GameSettingsDeviceRenderDefine.performanceLimitConfigs;
		}
	}

	// Token: 0x060027DE RID: 10206 RVA: 0x000F5F10 File Offset: 0x000F4110
	public static void CreateStaticDefaultValue()
	{
		GameSettingsDeviceRenderDefine.FrameRateListPc = new int[]
		{
			30,
			45,
			60,
			120
		};
		GameSettingsDeviceRenderDefine.FrameRateListIos = new int[]
		{
			30,
			60,
			120
		};
		GameSettingsDeviceRenderDefine.FrameRateListAndroid = new int[]
		{
			24,
			30,
			45,
			60
		};
		GameSettingsDeviceRenderDefine.FrameRateListAndroidForRedMagicLow = new int[]
		{
			30,
			60,
			90
		};
		GameSettingsDeviceRenderDefine.FrameRateListAndroidForRedMagicHigh = new int[]
		{
			30,
			60,
			120
		};
		GameSettingsDeviceRenderDefine.FrameRateListAndroidForRedMagic = GameSettingsDeviceRenderDefine.FrameRateListAndroidForRedMagicHigh;
		GameSettingsDeviceRenderDefine.FrameRateListOpenHarmony = new int[]
		{
			24,
			30,
			45,
			60
		};
		GameSettingsDeviceRenderDefine.FrameRateListXSX = new int[]
		{
			60
		};
		GameSettingsDeviceRenderDefine.MaxRoleShadowNumWithGameGraphQualityPc = new int[]
		{
			0,
			0,
			10,
			15,
			15,
			15
		};
		GameSettingsDeviceRenderDefine.MaxRoleShadowNumWithGameGraphQualityMobile = new int[]
		{
			0,
			0,
			3,
			6,
			6,
			6
		};
		GameSettingsDeviceRenderDefine.MaxRoleShadowDistanceWithGameGraphQualityPc = new int[]
		{
			0,
			0,
			2500,
			5000,
			5000,
			5000
		};
		GameSettingsDeviceRenderDefine.MaxRoleShadowDistanceWithGameGraphQualityMobile = new int[]
		{
			0,
			0,
			1500,
			3000,
			3000,
			3000
		};
		GameSettingsDeviceRenderDefine.MaxDecalShadowDistanceWithGameGraphQualityPc = new int[]
		{
			2000,
			2000,
			4000,
			6000,
			6000,
			6000
		};
		GameSettingsDeviceRenderDefine.MaxDecalShadowDistanceWithGameGraphQualityMobile = new int[]
		{
			1500,
			1500,
			2500,
			3500,
			3500,
			3500
		};
		GameSettingsDeviceRenderDefine.MainPlayerRealShadow = new int[]
		{
			0,
			1,
			1,
			1,
			1,
			1
		};
		Dictionary<string, IPerformanceLimitConfig> dictionary = new Dictionary<string, IPerformanceLimitConfig>();
		dictionary["RoleRootView"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = false
		};
		dictionary["RoleLevelUpView"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = false
		};
		dictionary["HandBookEntranceView"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = false
		};
		dictionary["AchievementMainView"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = false
		};
		dictionary["CommonActivityView"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = false
		};
		dictionary["VideoView"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["GachaScanView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = false
		};
		dictionary["DrawMainView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = false
		};
		dictionary["GachaResultView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = false
		};
		dictionary["WorldMapView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["CalabashRootView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = false
		};
		dictionary["BattlePassMainView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = false
		};
		dictionary["GachaMainView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["PayShopRootView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["AdventureGuideView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["TutorialView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["QuestView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["FriendView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["TimeOfDaySecondView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["EditFormationView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["InventoryView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["MailBoxView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["MenuView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["FunctionView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["DreamLinkMainView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["FishingQteView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["ShipTowerView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["MapRogueMainView_Seq"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		dictionary["FunctionView_Special"] = new PerformanceLimitConfig
		{
			FrameLimit = false,
			CacheWorldFrame = true
		};
		GameSettingsDeviceRenderDefine.performanceLimitConfigs = dictionary;
	}

	// Token: 0x060027DF RID: 10207 RVA: 0x000F63C8 File Offset: 0x000F45C8
	public static void ResetStaticDefaultValue()
	{
		GameSettingsDeviceRenderDefine.FrameRateListPc = null;
		GameSettingsDeviceRenderDefine.FrameRateListIos = null;
		GameSettingsDeviceRenderDefine.FrameRateListAndroid = null;
		GameSettingsDeviceRenderDefine.FrameRateListAndroidForRedMagicLow = null;
		GameSettingsDeviceRenderDefine.FrameRateListAndroidForRedMagicHigh = null;
		GameSettingsDeviceRenderDefine.FrameRateListAndroidForRedMagic = null;
		GameSettingsDeviceRenderDefine.FrameRateListOpenHarmony = null;
		GameSettingsDeviceRenderDefine.FrameRateListXSX = null;
		GameSettingsDeviceRenderDefine.MaxRoleShadowNumWithGameGraphQualityPc = null;
		GameSettingsDeviceRenderDefine.MaxRoleShadowNumWithGameGraphQualityMobile = null;
		GameSettingsDeviceRenderDefine.MaxRoleShadowDistanceWithGameGraphQualityPc = null;
		GameSettingsDeviceRenderDefine.MaxRoleShadowDistanceWithGameGraphQualityMobile = null;
		GameSettingsDeviceRenderDefine.MaxDecalShadowDistanceWithGameGraphQualityPc = null;
		GameSettingsDeviceRenderDefine.MaxDecalShadowDistanceWithGameGraphQualityMobile = null;
		GameSettingsDeviceRenderDefine.MainPlayerRealShadow = null;
		GameSettingsDeviceRenderDefine.performanceLimitConfigs = null;
	}

	// Token: 0x0400270F RID: 9999
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListPc;

	// Token: 0x04002710 RID: 10000
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListIos;

	// Token: 0x04002711 RID: 10001
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListAndroid;

	// Token: 0x04002712 RID: 10002
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListAndroidForRedMagicLow;

	// Token: 0x04002713 RID: 10003
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListAndroidForRedMagicHigh;

	// Token: 0x04002714 RID: 10004
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListAndroidForRedMagic;

	// Token: 0x04002715 RID: 10005
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListOpenHarmony;

	// Token: 0x04002716 RID: 10006
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListXSX;

	// Token: 0x04002717 RID: 10007
	[Nullable(1)]
	public const string PERFORMENCELIMIT_SEQ_TAIL = "_Seq";

	// Token: 0x04002718 RID: 10008
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, IPerformanceLimitConfig> performanceLimitConfigs;

	// Token: 0x04002719 RID: 10009
	public const int HD_SCREEN_WIDTH = 2000;

	// Token: 0x0400271A RID: 10010
	public const int HD_SCREEN_HEIGHT = 1100;

	// Token: 0x0400271B RID: 10011
	[StaticVariableRuleIgnore]
	public static int[] MaxRoleShadowNumWithGameGraphQualityPc;

	// Token: 0x0400271C RID: 10012
	[StaticVariableRuleIgnore]
	public static int[] MaxRoleShadowNumWithGameGraphQualityMobile;

	// Token: 0x0400271D RID: 10013
	[StaticVariableRuleIgnore]
	public static int[] MaxRoleShadowDistanceWithGameGraphQualityPc;

	// Token: 0x0400271E RID: 10014
	[StaticVariableRuleIgnore]
	public static int[] MaxRoleShadowDistanceWithGameGraphQualityMobile;

	// Token: 0x0400271F RID: 10015
	[StaticVariableRuleIgnore]
	public static int[] MaxDecalShadowDistanceWithGameGraphQualityPc;

	// Token: 0x04002720 RID: 10016
	[StaticVariableRuleIgnore]
	public static int[] MaxDecalShadowDistanceWithGameGraphQualityMobile;

	// Token: 0x04002721 RID: 10017
	[StaticVariableRuleIgnore]
	public static int[] MainPlayerRealShadow;

	// Token: 0x04002722 RID: 10018
	public const int WHOLE_SHADOW_CACHE_DELAY_TIME = 1000;
}
