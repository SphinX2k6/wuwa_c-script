using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043CD RID: 17357
	[NullableContext(1)]
	[Nullable(0)]
	public static class MenuDefine
	{
		// Token: 0x04017A21 RID: 96801
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

		// Token: 0x04017A22 RID: 96802
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

		// Token: 0x04017A23 RID: 96803
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
			EFunction.PSSR,
			EFunction.LOADINGRANGESCALELEVEL
		};

		// Token: 0x04017A24 RID: 96804
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

		// Token: 0x04017A25 RID: 96805
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

		// Token: 0x04017A26 RID: 96806
		public const int DEFAULT_FILTER_SETTING_INTENSITY_VALUE = 1;

		// Token: 0x04017A27 RID: 96807
		public const double DEFAULT_FILTER_SETTING_VALUE = 0.5;

		// Token: 0x04017A28 RID: 96808
		public const int DEFAULT_FILTER_SENIOR_SETTING_VALUE = 0;

		// Token: 0x04017A29 RID: 96809
		public const string SEETING_LOAD_FLUID = "Text_SettingLoadFluid_text";

		// Token: 0x04017A2A RID: 96810
		public const string SEETING_LOAD_LAGGY = "Text_SettingLoadLaggy_text";

		// Token: 0x04017A2B RID: 96811
		public const string SEETING_LOAD_OVER = "Text_SettingLoadOver_text";

		// Token: 0x04017A2C RID: 96812
		public const string SEETING_LOAD_FLUID_COLOR = "/Game/Aki/UI/UIResources/UiSet/Atlas/SP_BarGreen.SP_BarGreen";

		// Token: 0x04017A2D RID: 96813
		public const string SEETING_LOAD_LAGGY_COLOR = "/Game/Aki/UI/UIResources/UiSet/Atlas/SP_BarOrange.SP_BarOrange";

		// Token: 0x04017A2E RID: 96814
		public const string SEETING_LOAD_OVER_COLOR = "/Game/Aki/UI/UIResources/UiSet/Atlas/SP_BarRed.SP_BarRed";

		// Token: 0x04017A2F RID: 96815
		[StaticVariableRuleIgnore]
		public static readonly int[] qualityLevelScores = new int[]
		{
			120,
			135,
			143,
			150,
			160
		};

		// Token: 0x04017A30 RID: 96816
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

		// Token: 0x04017A31 RID: 96817
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

		// Token: 0x04017A32 RID: 96818
		[StaticVariableRuleIgnore]
		public static readonly float[] mobileResolutionScores = new float[]
		{
			0.49f,
			0.64f,
			0.7225f,
			1f
		};

		// Token: 0x04017A33 RID: 96819
		[StaticVariableRuleIgnore]
		public static readonly int[] shadowQualityScores = new int[]
		{
			0,
			6,
			10,
			12
		};

		// Token: 0x04017A34 RID: 96820
		[StaticVariableRuleIgnore]
		public static readonly int[] niagaraQualityScores = new int[]
		{
			0,
			4,
			6
		};

		// Token: 0x04017A35 RID: 96821
		[StaticVariableRuleIgnore]
		public static readonly int[] imageDetailScores = new int[]
		{
			0,
			6,
			12,
			20
		};

		// Token: 0x04017A36 RID: 96822
		[StaticVariableRuleIgnore]
		public static readonly int[] sceneAoScores = new int[]
		{
			0,
			6,
			8,
			10
		};

		// Token: 0x04017A37 RID: 96823
		[StaticVariableRuleIgnore]
		public static readonly int[] antiAliasingScores = new int[]
		{
			0,
			10
		};

		// Token: 0x04017A38 RID: 96824
		[StaticVariableRuleIgnore]
		public static readonly int[] volumeFogScores = new int[]
		{
			0,
			3,
			6,
			10
		};

		// Token: 0x04017A39 RID: 96825
		[StaticVariableRuleIgnore]
		public static readonly int[] volumeLightScores = new int[]
		{
			0,
			2
		};

		// Token: 0x04017A3A RID: 96826
		[StaticVariableRuleIgnore]
		public static readonly int[] motionBlurScores = new int[]
		{
			0,
			6
		};

		// Token: 0x04017A3B RID: 96827
		[StaticVariableRuleIgnore]
		public static readonly int[] amdFsrScores = new int[]
		{
			0,
			10
		};

		// Token: 0x04017A3C RID: 96828
		[StaticVariableRuleIgnore]
		public static readonly int[] harmonySuperResolutionScores = new int[]
		{
			0,
			5
		};

		// Token: 0x04017A3D RID: 96829
		[StaticVariableRuleIgnore]
		public static readonly int[] metalFxScores = new int[]
		{
			0,
			3
		};

		// Token: 0x04017A3E RID: 96830
		[StaticVariableRuleIgnore]
		public static readonly int[] bloomScores = new int[]
		{
			0,
			3
		};

		// Token: 0x04017A3F RID: 96831
		[StaticVariableRuleIgnore]
		public static readonly int[] npcDensityScores = new int[]
		{
			0,
			3,
			6
		};

		// Token: 0x04017A40 RID: 96832
		[StaticVariableRuleIgnore]
		public static readonly int[] vegetationDensityScores = new int[]
		{
			0,
			3,
			6,
			10
		};

		// Token: 0x04017A41 RID: 96833
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

		// Token: 0x04017A42 RID: 96834
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

		// Token: 0x04017A43 RID: 96835
		[StaticVariableRuleIgnore]
		public static readonly int[] rayTracingGIScores = new int[]
		{
			0,
			8,
			15,
			15
		};

		// Token: 0x04017A44 RID: 96836
		[StaticVariableRuleIgnore]
		public static readonly int[] rayTracingReflectionScores = new int[]
		{
			0,
			7,
			15,
			25
		};

		// Token: 0x04017A45 RID: 96837
		[StaticVariableRuleIgnore]
		public static readonly int[] rayTracedShadowScores = new int[]
		{
			0,
			5,
			5,
			10
		};

		// Token: 0x04017A46 RID: 96838
		[StaticVariableRuleIgnore]
		public static readonly int[] pcLoadingRangeScores = new int[]
		{
			0,
			40,
			80
		};

		// Token: 0x04017A47 RID: 96839
		[StaticVariableRuleIgnore]
		public static readonly int[] mobileLoadingRangeScores = new int[]
		{
			0,
			80,
			160
		};

		// Token: 0x04017A48 RID: 96840
		[StaticVariableRuleIgnore]
		public static readonly int[] anisotropyScores = new int[]
		{
			0,
			1,
			2,
			4,
			8
		};

		// Token: 0x04017A49 RID: 96841
		public const string STOP_GUIDE_TAG = "MenuView";

		// Token: 0x04017A4A RID: 96842
		public const string CUSTOM_TEXT_ID = "MenuConfig_5_OptionsName_4";

		// Token: 0x04017A4B RID: 96843
		public const string TARGET_HIT_ITEM_FOR_FILTER = "TexFilter";

		// Token: 0x04017A4C RID: 96844
		public const string TARGET_HIT_ITEM_FOR_LEFT_ARROW = "TexArrowL";

		// Token: 0x04017A4D RID: 96845
		public const string TARGET_HIT_ITEM_FOR_RIGHT_ARROW = "TexArrowR";

		// Token: 0x04017A4E RID: 96846
		public const int FILTER_SETTING_HELP_ID = 323;

		// Token: 0x04017A4F RID: 96847
		public const string FILTER_SETTING_TITLE_TEXT_ID = "PrefabTextItem_3846974633_Text";

		// Token: 0x04017A50 RID: 96848
		public const int EYE_PROTECT_SETTING_HELP_ID = 390;

		// Token: 0x04017A51 RID: 96849
		public const string FILTER_SETTING_TITLE_ICON_RESOURCE_ID = "TexFilterIcon";

		// Token: 0x04017A52 RID: 96850
		public const string FILTER_SETTING_COORDINATE_TEXT_ID = "PrefabTextItem_2070808429_Text";

		// Token: 0x04017A53 RID: 96851
		public const int FILTER_SETTING_FILTER_TEXTURE_COUNT = 5;

		// Token: 0x04017A54 RID: 96852
		public const int FILTER_SETTING_DEFAULT_FILTER_ID = 1;

		// Token: 0x04017A55 RID: 96853
		public const string MENU_DETAIL_SPRITE_TEXT = "SP_BtnMenuDetailText";

		// Token: 0x04017A56 RID: 96854
		public const string MENU_DETAIL_SPRITE_LOCK = "SP_BtnMenuDetailLock";

		// Token: 0x04017A57 RID: 96855
		public const string MENU_DETAIL_SPRITE_POP = "SP_BtnMenuDetailPop";

		// Token: 0x04017A58 RID: 96856
		public const string DETAIL_SPRITE_VISIBLE_COLOR_SRGB = "FFF7B6FF";
	}
}
