using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A2A RID: 23082
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class FlagChallengeConfig : ConfigBase
	{
		// Token: 0x0603A910 RID: 239888 RVA: 0x00DF0487 File Offset: 0x00DEE687
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603A911 RID: 239889 RVA: 0x00DF048A File Offset: 0x00DEE68A
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x0603A912 RID: 239890 RVA: 0x00DF0490 File Offset: 0x00DEE690
		public FlagChallengeActivity? GetActivityConfig(int id)
		{
			FlagChallengeActivity? config = ConfigFlagChallengeActivityByActivityId.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "活动配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603A913 RID: 239891 RVA: 0x00DF04E0 File Offset: 0x00DEE6E0
		public FlagChallengeTask? GetTaskConfig(int id)
		{
			FlagChallengeTask? config = ConfigFlagChallengeTaskById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "任务配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603A914 RID: 239892 RVA: 0x00DF0530 File Offset: 0x00DEE730
		public FlagChallengeLevel? GetLevelConfig(int id)
		{
			FlagChallengeLevel? config = ConfigFlagChallengeLevelById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "关卡配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603A915 RID: 239893 RVA: 0x00DF0580 File Offset: 0x00DEE780
		public FlagStronghold? GetStrongholdConfig(int id)
		{
			FlagStronghold? config = ConfigFlagStrongholdById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "据点配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603A916 RID: 239894 RVA: 0x00DF05D0 File Offset: 0x00DEE7D0
		public FlagChallengeRoleBuff? GetRoleBuffConfig(int id)
		{
			FlagChallengeRoleBuff? config = ConfigFlagChallengeRoleBuffById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "角色Buff配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603A917 RID: 239895 RVA: 0x00DF0620 File Offset: 0x00DEE820
		[NullableContext(2)]
		public IReadOnlyList<FlagChallengeRoleBuff> GetRoleBuffConfigListByActivityId(int activityId)
		{
			IReadOnlyList<FlagChallengeRoleBuff> configList = ConfigFlagChallengeRoleBuffByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "活动角色Buff配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x0603A918 RID: 239896 RVA: 0x00DF0668 File Offset: 0x00DEE868
		public FlagChallengeRoleLevel? GetRoleLevelConfig(int id)
		{
			FlagChallengeRoleLevel? config = ConfigFlagChallengeRoleLevelById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "角色等级配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603A919 RID: 239897 RVA: 0x00DF06B8 File Offset: 0x00DEE8B8
		public unsafe FlagChallengeRoleLevel? GetRoleLevelConfigByActivityIdAndLevel(int activityId, int level)
		{
			FlagChallengeRoleLevel? config = ConfigFlagChallengeRoleLevelByActivityIdAndLevel.GetConfig(activityId, level, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "角色等级配置为空";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActivityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Level", level);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return config;
		}

		// Token: 0x0603A91A RID: 239898 RVA: 0x00DF0738 File Offset: 0x00DEE938
		[NullableContext(2)]
		public IReadOnlyList<FlagChallengeRoleLevel> GetRoleLevelConfigListByActivityId(int activityId)
		{
			IReadOnlyList<FlagChallengeRoleLevel> configList = ConfigFlagChallengeRoleLevelByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "角色等级配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x0603A91B RID: 239899 RVA: 0x00DF0780 File Offset: 0x00DEE980
		[NullableContext(2)]
		public IReadOnlyList<FlagChallengeLevelDiffShow> GetLevelDiffShowConfigList()
		{
			IReadOnlyList<FlagChallengeLevelDiffShow> configList = ConfigFlagChallengeLevelDiffShowAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.FlagChallenge, ELogAuthor.LJS, "插旗等级差表现配置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0603A91C RID: 239900 RVA: 0x00DF07B8 File Offset: 0x00DEE9B8
		public FlagChallengeArea? GetAreaConfig(int id)
		{
			FlagChallengeArea? config = ConfigFlagChallengeAreaById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "插旗区域配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603A91D RID: 239901 RVA: 0x00DF0808 File Offset: 0x00DEEA08
		[NullableContext(2)]
		public IReadOnlyList<FlagChallengeArea> GetAreaConfigList()
		{
			IReadOnlyList<FlagChallengeArea> configList = ConfigFlagChallengeAreaAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.FlagChallenge, ELogAuthor.LJS, "插旗区域配置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0603A91E RID: 239902 RVA: 0x00DF0840 File Offset: 0x00DEEA40
		[NullableContext(2)]
		public IReadOnlyList<FlagChallengeArea> GetAreaConfigListByLevelId(int levelId)
		{
			IReadOnlyList<FlagChallengeArea> configList = ConfigFlagChallengeAreaByLevelId.GetConfigList(levelId, true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.FlagChallenge, ELogAuthor.LJS, "插旗区域配置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0603A91F RID: 239903 RVA: 0x00DF0878 File Offset: 0x00DEEA78
		public FlagChallengeMonLevel? GetMonsterLevelConfigById(int id)
		{
			FlagChallengeMonLevel? config = ConfigFlagChallengeMonLevelById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "插旗局内怪物等级配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603A920 RID: 239904 RVA: 0x00DF08C8 File Offset: 0x00DEEAC8
		[NullableContext(2)]
		public IReadOnlyList<FlagChallengeRoleGrowth> GetRoleGrowthConfigListByActivityId(int activityId)
		{
			IReadOnlyList<FlagChallengeRoleGrowth> configList = ConfigFlagChallengeRoleGrowthByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "插旗局内角色成长配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x0603A921 RID: 239905 RVA: 0x00DF0910 File Offset: 0x00DEEB10
		public int GetRewardHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeRewardHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0603A922 RID: 239906 RVA: 0x00DF093C File Offset: 0x00DEEB3C
		public int GetFormationHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeFormationHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0603A923 RID: 239907 RVA: 0x00DF0968 File Offset: 0x00DEEB68
		public int GetBuffHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeBuffHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0603A924 RID: 239908 RVA: 0x00DF0994 File Offset: 0x00DEEB94
		public int GetRoleLevelHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeRoleLevelHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0603A925 RID: 239909 RVA: 0x00DF09C0 File Offset: 0x00DEEBC0
		public int GetMainViewHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeMainViewHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0603A926 RID: 239910 RVA: 0x00DF09EC File Offset: 0x00DEEBEC
		public int GetAreaDetailViewHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeAreaDetailViewHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0603A927 RID: 239911 RVA: 0x00DF0A18 File Offset: 0x00DEEC18
		public IReadOnlyList<int> GetAllAttrAddIdList()
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("FlagChallengeRoleAttrAddIdList");
			if (intArrayConfig == null)
			{
				Log.Instance.Error(ELogModule.FlagChallenge, ELogAuthor.LJS, "属性加成id列表为空 - FlagChallengeRoleAttrAddIdList", default(ReadOnlySpan<ValueTuple<string, object>>));
				return new List<int>();
			}
			return intArrayConfig;
		}

		// Token: 0x0603A928 RID: 239912 RVA: 0x00DF0A5C File Offset: 0x00DEEC5C
		public int GetTempExpItemInterval()
		{
			return ConfigCommonParamById.GetIntConfig("FlagChallengeTempExpUnitInterval").GetValueOrDefault(20);
		}

		// Token: 0x0603A929 RID: 239913 RVA: 0x00DF0A80 File Offset: 0x00DEEC80
		public int GetTempExpCrossLevel()
		{
			return ConfigCommonParamById.GetIntConfig("FlagChallengeTempExpCrossLevel").GetValueOrDefault(3);
		}

		// Token: 0x0603A92A RID: 239914 RVA: 0x00DF0AA0 File Offset: 0x00DEECA0
		public string GetMainViewLevelButtonIcon()
		{
			string stringConfig = ConfigCommonParamById.GetStringConfig("FlagChallengeLevelButtonIcon");
			if (stringConfig == null)
			{
				Log.Instance.Error(ELogModule.FlagChallenge, ELogAuthor.LJS, "主界面关卡按钮图标路径配置为空 - FlagChallengeLevelButtonIcon", default(ReadOnlySpan<ValueTuple<string, object>>));
				return "";
			}
			return stringConfig;
		}

		// Token: 0x0603A92B RID: 239915 RVA: 0x00DF0AE4 File Offset: 0x00DEECE4
		public string GetMainViewBuffButtonIcon()
		{
			string stringConfig = ConfigCommonParamById.GetStringConfig("FlagChallengeBuffButtonIcon");
			if (stringConfig == null)
			{
				Log.Instance.Error(ELogModule.FlagChallenge, ELogAuthor.LJS, "主界面增益按钮图标路径配置为空 - FlagChallengeBuffButtonIcon", default(ReadOnlySpan<ValueTuple<string, object>>));
				return "";
			}
			return stringConfig;
		}

		// Token: 0x0603A92C RID: 239916 RVA: 0x00DF0B28 File Offset: 0x00DEED28
		public string GetMainViewPauseButtonIcon()
		{
			string stringConfig = ConfigCommonParamById.GetStringConfig("FlagChallengePauseButtonIcon");
			if (stringConfig == null)
			{
				Log.Instance.Error(ELogModule.FlagChallenge, ELogAuthor.LJS, "主界面暂停按钮图标路径配置为空 - FlagChallengePauseButtonIcon", default(ReadOnlySpan<ValueTuple<string, object>>));
				return "";
			}
			return stringConfig;
		}

		// Token: 0x0603A92D RID: 239917 RVA: 0x00DF0B6C File Offset: 0x00DEED6C
		public string GetMainViewVideoPath()
		{
			string stringConfig = ConfigCommonParamById.GetStringConfig("FlagChallengeMainViewVideoPath");
			if (stringConfig == null)
			{
				Log.Instance.Error(ELogModule.FlagChallenge, ELogAuthor.LJS, "主界面视频路径配置为空 - FlagChallengeMainViewVideoPath", default(ReadOnlySpan<ValueTuple<string, object>>));
				return "";
			}
			return stringConfig;
		}

		// Token: 0x0603A92E RID: 239918 RVA: 0x00DF0BB0 File Offset: 0x00DEEDB0
		public string GetViewVideoPathByStyle(EFlagChallengeUiStyleType style)
		{
			string text;
			if (!FlagChallengeDefine.Instance.flagChallengeStyleVideoPath.TryGetValue(style, out text) || text == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "界面视频路径配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("style", style);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return "";
			}
			return text;
		}

		// Token: 0x0603A92F RID: 239919 RVA: 0x00DF0C0C File Offset: 0x00DEEE0C
		public int GetBuffShowTime()
		{
			return ConfigCommonParamById.GetIntConfig("FlagChallengeBuffShowTime").GetValueOrDefault(1);
		}

		// Token: 0x17008BDA RID: 35802
		// (get) Token: 0x0603A930 RID: 239920 RVA: 0x00DF0C2C File Offset: 0x00DEEE2C
		public static FlagChallengeConfig Instance
		{
			get
			{
				return FlagChallengeConfig._Instance;
			}
		}

		// Token: 0x0603A931 RID: 239921 RVA: 0x00DF0C33 File Offset: 0x00DEEE33
		public static FlagChallengeConfig GetOrCreateInstance()
		{
			if (FlagChallengeConfig._Instance == null)
			{
				FlagChallengeConfig.CreateInstance();
			}
			return FlagChallengeConfig._Instance;
		}

		// Token: 0x0603A932 RID: 239922 RVA: 0x00DF0C47 File Offset: 0x00DEEE47
		public static bool CreateInstance()
		{
			if (FlagChallengeConfig._Instance != null)
			{
				return true;
			}
			FlagChallengeConfig._Instance = new FlagChallengeConfig();
			return true;
		}

		// Token: 0x0603A933 RID: 239923 RVA: 0x00DF0C5D File Offset: 0x00DEEE5D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A934 RID: 239924 RVA: 0x00DF0C5F File Offset: 0x00DEEE5F
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeConfig._Instance = null;
		}

		// Token: 0x0603A935 RID: 239925 RVA: 0x00DF0C67 File Offset: 0x00DEEE67
		static FlagChallengeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeConfig.CreateStaticDefaultValue), new Action(FlagChallengeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401E7E3 RID: 124899
		[Nullable(2)]
		private static FlagChallengeConfig _Instance;
	}
}
