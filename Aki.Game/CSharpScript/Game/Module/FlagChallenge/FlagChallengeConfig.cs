using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A06 RID: 18950
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class FlagChallengeConfig : ConfigBase
	{
		// Token: 0x0602F859 RID: 194649 RVA: 0x00D40A0B File Offset: 0x00D3EC0B
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602F85A RID: 194650 RVA: 0x00D40A0E File Offset: 0x00D3EC0E
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x0602F85B RID: 194651 RVA: 0x00D40A14 File Offset: 0x00D3EC14
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

		// Token: 0x0602F85C RID: 194652 RVA: 0x00D40A64 File Offset: 0x00D3EC64
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

		// Token: 0x0602F85D RID: 194653 RVA: 0x00D40AB4 File Offset: 0x00D3ECB4
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

		// Token: 0x0602F85E RID: 194654 RVA: 0x00D40B04 File Offset: 0x00D3ED04
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

		// Token: 0x0602F85F RID: 194655 RVA: 0x00D40B54 File Offset: 0x00D3ED54
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

		// Token: 0x0602F860 RID: 194656 RVA: 0x00D40BA4 File Offset: 0x00D3EDA4
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

		// Token: 0x0602F861 RID: 194657 RVA: 0x00D40BEC File Offset: 0x00D3EDEC
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

		// Token: 0x0602F862 RID: 194658 RVA: 0x00D40C3C File Offset: 0x00D3EE3C
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

		// Token: 0x0602F863 RID: 194659 RVA: 0x00D40CBC File Offset: 0x00D3EEBC
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

		// Token: 0x0602F864 RID: 194660 RVA: 0x00D40D04 File Offset: 0x00D3EF04
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

		// Token: 0x0602F865 RID: 194661 RVA: 0x00D40D3C File Offset: 0x00D3EF3C
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

		// Token: 0x0602F866 RID: 194662 RVA: 0x00D40D8C File Offset: 0x00D3EF8C
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

		// Token: 0x0602F867 RID: 194663 RVA: 0x00D40DC4 File Offset: 0x00D3EFC4
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

		// Token: 0x0602F868 RID: 194664 RVA: 0x00D40DFC File Offset: 0x00D3EFFC
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

		// Token: 0x0602F869 RID: 194665 RVA: 0x00D40E4C File Offset: 0x00D3F04C
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

		// Token: 0x0602F86A RID: 194666 RVA: 0x00D40E94 File Offset: 0x00D3F094
		public int GetRewardHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeRewardHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0602F86B RID: 194667 RVA: 0x00D40EC0 File Offset: 0x00D3F0C0
		public int GetFormationHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeFormationHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0602F86C RID: 194668 RVA: 0x00D40EEC File Offset: 0x00D3F0EC
		public int GetBuffHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeBuffHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0602F86D RID: 194669 RVA: 0x00D40F18 File Offset: 0x00D3F118
		public int GetRoleLevelHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeRoleLevelHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0602F86E RID: 194670 RVA: 0x00D40F44 File Offset: 0x00D3F144
		public int GetMainViewHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeMainViewHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0602F86F RID: 194671 RVA: 0x00D40F70 File Offset: 0x00D3F170
		public int GetAreaDetailViewHelpId()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlagChallengeAreaDetailViewHelpId");
			if (intConfig == null)
			{
				return 0;
			}
			return intConfig.Value;
		}

		// Token: 0x0602F870 RID: 194672 RVA: 0x00D40F9C File Offset: 0x00D3F19C
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

		// Token: 0x0602F871 RID: 194673 RVA: 0x00D40FE0 File Offset: 0x00D3F1E0
		public int GetTempExpItemInterval()
		{
			return ConfigCommonParamById.GetIntConfig("FlagChallengeTempExpUnitInterval").GetValueOrDefault(20);
		}

		// Token: 0x0602F872 RID: 194674 RVA: 0x00D41004 File Offset: 0x00D3F204
		public int GetTempExpCrossLevel()
		{
			return ConfigCommonParamById.GetIntConfig("FlagChallengeTempExpCrossLevel").GetValueOrDefault(3);
		}

		// Token: 0x0602F873 RID: 194675 RVA: 0x00D41024 File Offset: 0x00D3F224
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

		// Token: 0x0602F874 RID: 194676 RVA: 0x00D41068 File Offset: 0x00D3F268
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

		// Token: 0x0602F875 RID: 194677 RVA: 0x00D410AC File Offset: 0x00D3F2AC
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

		// Token: 0x0602F876 RID: 194678 RVA: 0x00D410F0 File Offset: 0x00D3F2F0
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

		// Token: 0x0602F877 RID: 194679 RVA: 0x00D41134 File Offset: 0x00D3F334
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

		// Token: 0x0602F878 RID: 194680 RVA: 0x00D41190 File Offset: 0x00D3F390
		public int GetBuffShowTime()
		{
			return ConfigCommonParamById.GetIntConfig("FlagChallengeBuffShowTime").GetValueOrDefault(1);
		}

		// Token: 0x17005FA8 RID: 24488
		// (get) Token: 0x0602F879 RID: 194681 RVA: 0x00D411B0 File Offset: 0x00D3F3B0
		public static FlagChallengeConfig Instance
		{
			get
			{
				return FlagChallengeConfig._Instance;
			}
		}

		// Token: 0x0602F87A RID: 194682 RVA: 0x00D411B7 File Offset: 0x00D3F3B7
		public static FlagChallengeConfig GetOrCreateInstance()
		{
			if (FlagChallengeConfig._Instance == null)
			{
				FlagChallengeConfig.CreateInstance();
			}
			return FlagChallengeConfig._Instance;
		}

		// Token: 0x0602F87B RID: 194683 RVA: 0x00D411CB File Offset: 0x00D3F3CB
		public static bool CreateInstance()
		{
			if (FlagChallengeConfig._Instance != null)
			{
				return true;
			}
			FlagChallengeConfig._Instance = new FlagChallengeConfig();
			return true;
		}

		// Token: 0x0602F87C RID: 194684 RVA: 0x00D411E1 File Offset: 0x00D3F3E1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F87D RID: 194685 RVA: 0x00D411E3 File Offset: 0x00D3F3E3
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeConfig._Instance = null;
		}

		// Token: 0x0602F87E RID: 194686 RVA: 0x00D411EB File Offset: 0x00D3F3EB
		static FlagChallengeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeConfig.CreateStaticDefaultValue), new Action(FlagChallengeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401928A RID: 103050
		[Nullable(2)]
		private static FlagChallengeConfig _Instance;
	}
}
