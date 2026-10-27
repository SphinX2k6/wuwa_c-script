using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053EA RID: 21482
	[NullableContext(1)]
	[Nullable(0)]
	public static class MenuDefine
	{
		// Token: 0x0401CF88 RID: 118664
		[StaticVariableRuleIgnore]
		public static readonly HashSet<EFunction> cloudGameImageShowSettingsSet = new HashSet<EFunction>
		{
			EFunction.MOTIONBLUR,
			EFunction.EnemyHitDisplayMode,
			EFunction.ShowDamage,
			EFunction.DynamicBones,
			EFunction.FlowAdaptation,
			EFunction.TeammateFx,
			EFunction.SkinDamageMode,
			EFunction.BasicGraphicSetting,
			EFunction.AutoExposure,
			EFunction.ImageDisplayMode,
			EFunction.Filter,
			EFunction.EyeProtection
		};

		// Token: 0x0401CF89 RID: 118665
		[StaticVariableRuleIgnore]
		public static readonly HashSet<EFunction> noticeConfigSet = new HashSet<EFunction>
		{
			EFunction.IMAGEQUALITY,
			EFunction.MOBILERESOLUTION,
			EFunction.RESOLUTION,
			EFunction.HIGHESTFPS,
			EFunction.SHADOWQUALITY,
			EFunction.NIAGARAQUALITY,
			EFunction.IMAGEDETAIL,
			EFunction.SCENEAO,
			EFunction.ANTIALISING,
			EFunction.VOLUMEFOG,
			EFunction.VOLUMELIGHT,
			EFunction.MOTIONBLUR,
			EFunction.FSR,
			EFunction.HarmonySuperResolution,
			EFunction.METALFX,
			EFunction.BLOOM,
			EFunction.NPCDENSITY,
			EFunction.VegetationDensity,
			EFunction.NVIDIADLSS,
			EFunction.NVIDIADLSSQUALITY,
			EFunction.XESS2,
			EFunction.XESS2_QUALITY,
			EFunction.FSR3,
			EFunction.FSR3_QUALITY,
			EFunction.RayTracing,
			EFunction.RayTracedReflection,
			EFunction.RayTracedGI,
			EFunction.RayTracedShadow,
			EFunction.LOADINGRANGESCALELEVEL,
			EFunction.AnisoLevel
		};

		// Token: 0x0401CF8A RID: 118666
		[StaticVariableRuleIgnore]
		public static readonly HashSet<EFunction> makeImageQualityCustomSet = new HashSet<EFunction>
		{
			EFunction.HIGHESTFPS,
			EFunction.SHADOWQUALITY,
			EFunction.NIAGARAQUALITY,
			EFunction.IMAGEDETAIL,
			EFunction.ANTIALISING,
			EFunction.SCENEAO,
			EFunction.VOLUMEFOG,
			EFunction.VOLUMELIGHT,
			EFunction.MOTIONBLUR,
			EFunction.PCVSYNC,
			EFunction.MOBILERESOLUTION,
			EFunction.NPCDENSITY,
			EFunction.VegetationDensity,
			EFunction.BLOOM,
			EFunction.FSR,
			EFunction.NVIDIADLSS,
			EFunction.NVIDIADLSSQUALITY,
			EFunction.XESS2,
			EFunction.XESS2_QUALITY,
			EFunction.FSR3,
			EFunction.FSR3_QUALITY,
			EFunction.LOADINGRANGESCALELEVEL
		};

		// Token: 0x0401CF8B RID: 118667
		[StaticVariableRuleIgnore]
		public static readonly HashSet<EFunction> mobileQualityUnRelativeSet = new HashSet<EFunction>
		{
			EFunction.FSR,
			EFunction.NVIDIADLSS,
			EFunction.NVIDIADLSSQUALITY,
			EFunction.XESS2,
			EFunction.XESS2_QUALITY,
			EFunction.FSR3,
			EFunction.FSR3_QUALITY
		};

		// Token: 0x0401CF8C RID: 118668
		[StaticVariableRuleIgnore]
		public static readonly EFilterSettingValueIndex[] filterSettingParams = new EFilterSettingValueIndex[]
		{
			EFilterSettingValueIndex.Horizontal,
			EFilterSettingValueIndex.Vertical,
			EFilterSettingValueIndex.Intensity,
			EFilterSettingValueIndex.SharpenIntensity,
			EFilterSettingValueIndex.Brightness,
			EFilterSettingValueIndex.Contrast,
			EFilterSettingValueIndex.ColorTemperature,
			EFilterSettingValueIndex.Saturation,
			EFilterSettingValueIndex.Bloom,
			EFilterSettingValueIndex.Gamma,
			EFilterSettingValueIndex.ShadowIntensity,
			EFilterSettingValueIndex.NoiseIntensity,
			EFilterSettingValueIndex.Halation
		};

		// Token: 0x0401CF8D RID: 118669
		public const int DEFAULT_FILTER_SETTING_INTENSITY_VALUE = 1;

		// Token: 0x0401CF8E RID: 118670
		public const double DEFAULT_FILTER_SETTING_VALUE = 0.5;

		// Token: 0x0401CF8F RID: 118671
		public const int DEFAULT_FILTER_SENIOR_SETTING_VALUE = 0;

		// Token: 0x0401CF90 RID: 118672
		public const string SEETING_LOAD_FLUID = "Text_SettingLoadFluid_text";

		// Token: 0x0401CF91 RID: 118673
		public const string SEETING_LOAD_LAGGY = "Text_SettingLoadLaggy_text";

		// Token: 0x0401CF92 RID: 118674
		public const string SEETING_LOAD_OVER = "Text_SettingLoadOver_text";

		// Token: 0x0401CF93 RID: 118675
		public const string SEETING_LOAD_FLUID_COLOR = "/Game/Aki/UI/UIResources/UiSet/Atlas/SP_BarGreen.SP_BarGreen";

		// Token: 0x0401CF94 RID: 118676
		public const string SEETING_LOAD_LAGGY_COLOR = "/Game/Aki/UI/UIResources/UiSet/Atlas/SP_BarOrange.SP_BarOrange";

		// Token: 0x0401CF95 RID: 118677
		public const string SEETING_LOAD_OVER_COLOR = "/Game/Aki/UI/UIResources/UiSet/Atlas/SP_BarRed.SP_BarRed";

		// Token: 0x0401CF96 RID: 118678
		[StaticVariableRuleIgnore]
		public static readonly int[] qualityLevelScores = new int[]
		{
			120,
			135,
			143,
			150,
			160
		};

		// Token: 0x0401CF97 RID: 118679
		[StaticVariableRuleIgnore]
		public static readonly int[] pcQualityLevelScores = new int[]
		{
			0,
			25,
			50,
			70,
			85,
			100
		};

		// Token: 0x0401CF98 RID: 118680
		[StaticVariableRuleIgnore]
		public static readonly float[] pcQualityLevelWeights = new float[]
		{
			1.35f,
			1.15f,
			1f,
			0.8f,
			0.65f,
			0.45f
		};

		// Token: 0x0401CF99 RID: 118681
		[StaticVariableRuleIgnore]
		public static readonly float[] mobileResolutionScores = new float[]
		{
			0.49f,
			0.64f,
			0.7225f,
			1f
		};

		// Token: 0x0401CF9A RID: 118682
		[StaticVariableRuleIgnore]
		public static readonly int[] shadowQualityScores = new int[]
		{
			0,
			6,
			10,
			12
		};

		// Token: 0x0401CF9B RID: 118683
		[StaticVariableRuleIgnore]
		public static readonly int[] niagaraQualityScores = new int[]
		{
			0,
			4,
			6
		};

		// Token: 0x0401CF9C RID: 118684
		[StaticVariableRuleIgnore]
		public static readonly int[] imageDetailScores = new int[]
		{
			0,
			6,
			12,
			20
		};

		// Token: 0x0401CF9D RID: 118685
		[StaticVariableRuleIgnore]
		public static readonly int[] sceneAoScores = new int[]
		{
			0,
			6,
			8,
			10
		};

		// Token: 0x0401CF9E RID: 118686
		[StaticVariableRuleIgnore]
		public static readonly int[] antiAliasingScores = new int[]
		{
			0,
			10
		};

		// Token: 0x0401CF9F RID: 118687
		[StaticVariableRuleIgnore]
		public static readonly int[] volumeFogScores = new int[]
		{
			0,
			3,
			6,
			10
		};

		// Token: 0x0401CFA0 RID: 118688
		[StaticVariableRuleIgnore]
		public static readonly int[] volumeLightScores = new int[]
		{
			0,
			2
		};

		// Token: 0x0401CFA1 RID: 118689
		[StaticVariableRuleIgnore]
		public static readonly int[] motionBlurScores = new int[]
		{
			0,
			6
		};

		// Token: 0x0401CFA2 RID: 118690
		[StaticVariableRuleIgnore]
		public static readonly int[] amdFsrScores = new int[]
		{
			0,
			10
		};

		// Token: 0x0401CFA3 RID: 118691
		[StaticVariableRuleIgnore]
		public static readonly int[] harmonySuperResolutionScores = new int[]
		{
			0,
			5
		};

		// Token: 0x0401CFA4 RID: 118692
		[StaticVariableRuleIgnore]
		public static readonly int[] metalFxScores = new int[]
		{
			0,
			3
		};

		// Token: 0x0401CFA5 RID: 118693
		[StaticVariableRuleIgnore]
		public static readonly int[] bloomScores = new int[]
		{
			0,
			3
		};

		// Token: 0x0401CFA6 RID: 118694
		[StaticVariableRuleIgnore]
		public static readonly int[] npcDensityScores = new int[]
		{
			0,
			3,
			6
		};

		// Token: 0x0401CFA7 RID: 118695
		[StaticVariableRuleIgnore]
		public static readonly int[] vegetationDensityScores = new int[]
		{
			0,
			3,
			6,
			10
		};

		// Token: 0x0401CFA8 RID: 118696
		[StaticVariableRuleIgnore]
		public static readonly int[] superResolutionScores = new int[]
		{
			-70,
			-55,
			-45,
			-35,
			-10,
			-7,
			-3,
			0
		};

		// Token: 0x0401CFA9 RID: 118697
		[StaticVariableRuleIgnore]
		public static readonly int[] nvidiaSuperResolutionScores = new int[]
		{
			-70,
			-62,
			-57,
			-46,
			-27,
			28,
			0
		};

		// Token: 0x0401CFAA RID: 118698
		[StaticVariableRuleIgnore]
		public static readonly int[] rayTracingGIScores = new int[]
		{
			0,
			8,
			15,
			15
		};

		// Token: 0x0401CFAB RID: 118699
		[StaticVariableRuleIgnore]
		public static readonly int[] rayTracingReflectionScores = new int[]
		{
			0,
			7,
			15,
			25
		};

		// Token: 0x0401CFAC RID: 118700
		[StaticVariableRuleIgnore]
		public static readonly int[] rayTracedShadowScores = new int[]
		{
			0,
			5,
			5,
			10
		};

		// Token: 0x0401CFAD RID: 118701
		[StaticVariableRuleIgnore]
		public static readonly int[] pcLoadingRangeScores = new int[]
		{
			0,
			40,
			80
		};

		// Token: 0x0401CFAE RID: 118702
		[StaticVariableRuleIgnore]
		public static readonly int[] mobileLoadingRangeScores = new int[]
		{
			0,
			80,
			160
		};

		// Token: 0x0401CFAF RID: 118703
		[StaticVariableRuleIgnore]
		public static readonly int[] anisotropyScores = new int[]
		{
			0,
			1,
			2,
			4,
			8
		};

		// Token: 0x0401CFB0 RID: 118704
		public const string STOP_GUIDE_TAG = "MenuView";

		// Token: 0x0401CFB1 RID: 118705
		public const string CUSTOM_TEXT_ID = "MenuConfig_5_OptionsName_4";

		// Token: 0x0401CFB2 RID: 118706
		public const string TARGET_HIT_ITEM_FOR_FILTER = "TexFilter";

		// Token: 0x0401CFB3 RID: 118707
		public const string TARGET_HIT_ITEM_FOR_LEFT_ARROW = "TexArrowL";

		// Token: 0x0401CFB4 RID: 118708
		public const string TARGET_HIT_ITEM_FOR_RIGHT_ARROW = "TexArrowR";

		// Token: 0x0401CFB5 RID: 118709
		public const int FILTER_SETTING_HELP_ID = 323;

		// Token: 0x0401CFB6 RID: 118710
		public const string FILTER_SETTING_TITLE_TEXT_ID = "PrefabTextItem_3846974633_Text";

		// Token: 0x0401CFB7 RID: 118711
		public const int EYE_PROTECT_SETTING_HELP_ID = 390;

		// Token: 0x0401CFB8 RID: 118712
		public const string FILTER_SETTING_TITLE_ICON_RESOURCE_ID = "TexFilterIcon";

		// Token: 0x0401CFB9 RID: 118713
		public const string FILTER_SETTING_COORDINATE_TEXT_ID = "PrefabTextItem_2070808429_Text";

		// Token: 0x0401CFBA RID: 118714
		public const int FILTER_SETTING_FILTER_TEXTURE_COUNT = 5;

		// Token: 0x0401CFBB RID: 118715
		public const int FILTER_SETTING_DEFAULT_FILTER_ID = 1;

		// Token: 0x0401CFBC RID: 118716
		public const string MENU_DETAIL_SPRITE_TEXT = "SP_BtnMenuDetailText";

		// Token: 0x0401CFBD RID: 118717
		public const string MENU_DETAIL_SPRITE_LOCK = "SP_BtnMenuDetailLock";

		// Token: 0x0401CFBE RID: 118718
		public const string MENU_DETAIL_SPRITE_POP = "SP_BtnMenuDetailPop";

		// Token: 0x0401CFBF RID: 118719
		public const string DETAIL_SPRITE_VISIBLE_COLOR_SRGB = "FFF7B6FF";
	}
}
