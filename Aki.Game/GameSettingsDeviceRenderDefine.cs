using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000DD5 RID: 3541
[NullableContext(2)]
[Nullable(0)]
public class GameSettingsDeviceRenderDefine : IStaticVariableResetter
{
	// Token: 0x06005455 RID: 21589 RVA: 0x000EF19B File Offset: 0x000ED39B
	static GameSettingsDeviceRenderDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsDeviceRenderDefine.CreateStaticDefaultValue), new Action(GameSettingsDeviceRenderDefine.ResetStaticDefaultValue));
	}

	// Token: 0x170005E9 RID: 1513
	// (get) Token: 0x06005456 RID: 21590 RVA: 0x000EF1BA File Offset: 0x000ED3BA
	[Nullable(1)]
	public static Dictionary<string, IPerformanceLimitConfig> PerformanceLimitConfigs
	{
		[NullableContext(1)]
		get
		{
			return GameSettingsDeviceRenderDefine.performanceLimitConfigs;
		}
	}

	// Token: 0x06005457 RID: 21591 RVA: 0x000EF1C4 File Offset: 0x000ED3C4
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
			60,
			90,
			120
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

	// Token: 0x06005458 RID: 21592 RVA: 0x000EF680 File Offset: 0x000ED880
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

	// Token: 0x04002684 RID: 9860
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListPc;

	// Token: 0x04002685 RID: 9861
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListIos;

	// Token: 0x04002686 RID: 9862
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListAndroid;

	// Token: 0x04002687 RID: 9863
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListAndroidForRedMagicLow;

	// Token: 0x04002688 RID: 9864
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListAndroidForRedMagicHigh;

	// Token: 0x04002689 RID: 9865
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListAndroidForRedMagic;

	// Token: 0x0400268A RID: 9866
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListOpenHarmony;

	// Token: 0x0400268B RID: 9867
	[StaticVariableRuleIgnore]
	public static int[] FrameRateListXSX;

	// Token: 0x0400268C RID: 9868
	[Nullable(1)]
	public const string PERFORMENCELIMIT_SEQ_TAIL = "_Seq";

	// Token: 0x0400268D RID: 9869
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, IPerformanceLimitConfig> performanceLimitConfigs;

	// Token: 0x0400268E RID: 9870
	public const int HD_SCREEN_WIDTH = 2000;

	// Token: 0x0400268F RID: 9871
	public const int HD_SCREEN_HEIGHT = 1100;

	// Token: 0x04002690 RID: 9872
	[StaticVariableRuleIgnore]
	public static int[] MaxRoleShadowNumWithGameGraphQualityPc;

	// Token: 0x04002691 RID: 9873
	[StaticVariableRuleIgnore]
	public static int[] MaxRoleShadowNumWithGameGraphQualityMobile;

	// Token: 0x04002692 RID: 9874
	[StaticVariableRuleIgnore]
	public static int[] MaxRoleShadowDistanceWithGameGraphQualityPc;

	// Token: 0x04002693 RID: 9875
	[StaticVariableRuleIgnore]
	public static int[] MaxRoleShadowDistanceWithGameGraphQualityMobile;

	// Token: 0x04002694 RID: 9876
	[StaticVariableRuleIgnore]
	public static int[] MaxDecalShadowDistanceWithGameGraphQualityPc;

	// Token: 0x04002695 RID: 9877
	[StaticVariableRuleIgnore]
	public static int[] MaxDecalShadowDistanceWithGameGraphQualityMobile;

	// Token: 0x04002696 RID: 9878
	[StaticVariableRuleIgnore]
	public static int[] MainPlayerRealShadow;

	// Token: 0x04002697 RID: 9879
	public const int WHOLE_SHADOW_CACHE_DELAY_TIME = 1000;
}
