using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02005395 RID: 21397
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MoraleConfig : ConfigBase
	{
		// Token: 0x06036AA7 RID: 223911 RVA: 0x00CF0308 File Offset: 0x00CEE508
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06036AA8 RID: 223912 RVA: 0x00CF030B File Offset: 0x00CEE50B
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06036AA9 RID: 223913 RVA: 0x00CF030E File Offset: 0x00CEE50E
		public IReadOnlyList<OccupyScore> GetAllScoreConfigList()
		{
			return ConfigOccupyScoreAll.GetConfigList(true) ?? Array.Empty<OccupyScore>();
		}

		// Token: 0x06036AAA RID: 223914 RVA: 0x00CF031F File Offset: 0x00CEE51F
		public IReadOnlyList<FlagArea> GetFlagConfigListByAreaId(int areaId)
		{
			return ConfigFlagAreaByAreaId.GetConfigList(areaId, true) ?? Array.Empty<FlagArea>();
		}

		// Token: 0x06036AAB RID: 223915 RVA: 0x00CF0331 File Offset: 0x00CEE531
		public MoraleFlagType? GetFlagTypeConfig(int flagTypeId)
		{
			return ConfigMoraleFlagTypeByType.GetConfig(flagTypeId, true);
		}

		// Token: 0x06036AAC RID: 223916 RVA: 0x00CF033A File Offset: 0x00CEE53A
		public IReadOnlyList<MoraleLvPower> GetAllMoraleLvPowerConfigList()
		{
			return ConfigMoraleLvPowerAll.GetConfigList(true) ?? Array.Empty<MoraleLvPower>();
		}

		// Token: 0x06036AAD RID: 223917 RVA: 0x00CF034B File Offset: 0x00CEE54B
		public IReadOnlyList<MoraleArea> GetAllAreaConfigList()
		{
			return ConfigMoraleAreaAll.GetConfigList(true) ?? Array.Empty<MoraleArea>();
		}

		// Token: 0x06036AAE RID: 223918 RVA: 0x00CF035C File Offset: 0x00CEE55C
		public IReadOnlyList<int> GetAllAttrAddIdList()
		{
			return ConfigCommonParamById.GetIntArrayConfig("MoraleRoleAttrAddIdList") ?? Array.Empty<int>();
		}

		// Token: 0x06036AAF RID: 223919 RVA: 0x00CF0371 File Offset: 0x00CEE571
		public MoraleRoleGrowth? GetRoleAttrAddConfigByLv(int lv)
		{
			return ConfigMoraleRoleGrowthByLevel.GetConfig(lv, true);
		}

		// Token: 0x06036AB0 RID: 223920 RVA: 0x00CF037C File Offset: 0x00CEE57C
		public int GetScoreProgressRichValue()
		{
			return ConfigCommonParamById.GetIntConfig("MoraleScoreProgressRichValue").GetValueOrDefault();
		}

		// Token: 0x06036AB1 RID: 223921 RVA: 0x00CF039C File Offset: 0x00CEE59C
		public int GetMoraleGameOverQuestId()
		{
			return ConfigCommonParamById.GetIntConfig("MoraleGameOver").GetValueOrDefault();
		}

		// Token: 0x06036AB2 RID: 223922 RVA: 0x00CF03BC File Offset: 0x00CEE5BC
		public bool GetMoraleMarkIsAutoTrack()
		{
			return ConfigCommonParamById.GetBoolConfig("MoraleMarkIsAutoTrack").GetValueOrDefault();
		}

		// Token: 0x06036AB3 RID: 223923 RVA: 0x00CF03DC File Offset: 0x00CEE5DC
		public int GetMoraleBuffShowTime()
		{
			return ConfigCommonParamById.GetIntConfig("MoraleBuffShowTime").GetValueOrDefault(1);
		}

		// Token: 0x06036AB4 RID: 223924 RVA: 0x00CF03FC File Offset: 0x00CEE5FC
		public bool GetMoraleSelectHighLevelFlag()
		{
			return ConfigCommonParamById.GetBoolConfig("MoraleSelectHighLevelFlag").GetValueOrDefault();
		}

		// Token: 0x06036AB5 RID: 223925 RVA: 0x00CF041C File Offset: 0x00CEE61C
		public bool GetMoraleIsShowSmallFlagProgress()
		{
			return ConfigCommonParamById.GetBoolConfig("MoraleIsShowSmallFlagProgress").GetValueOrDefault();
		}

		// Token: 0x06036AB6 RID: 223926 RVA: 0x00CF043C File Offset: 0x00CEE63C
		public bool GetMoraleHighFlagUnFinishIsShowExploreBoxProgress()
		{
			return ConfigCommonParamById.GetBoolConfig("MoraleHighFlagUnFinishIsShowExploreBoxProgress").GetValueOrDefault();
		}

		// Token: 0x170083AB RID: 33707
		// (get) Token: 0x06036AB7 RID: 223927 RVA: 0x00CF045B File Offset: 0x00CEE65B
		public static MoraleConfig Instance
		{
			get
			{
				return MoraleConfig._Instance;
			}
		}

		// Token: 0x06036AB8 RID: 223928 RVA: 0x00CF0462 File Offset: 0x00CEE662
		public static MoraleConfig GetOrCreateInstance()
		{
			if (MoraleConfig._Instance == null)
			{
				MoraleConfig.CreateInstance();
			}
			return MoraleConfig._Instance;
		}

		// Token: 0x06036AB9 RID: 223929 RVA: 0x00CF0476 File Offset: 0x00CEE676
		public static bool CreateInstance()
		{
			if (MoraleConfig._Instance != null)
			{
				return true;
			}
			MoraleConfig._Instance = new MoraleConfig();
			return true;
		}

		// Token: 0x06036ABA RID: 223930 RVA: 0x00CF048C File Offset: 0x00CEE68C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036ABB RID: 223931 RVA: 0x00CF048E File Offset: 0x00CEE68E
		public static void ResetStaticDefaultValue()
		{
			MoraleConfig._Instance = null;
		}

		// Token: 0x06036ABC RID: 223932 RVA: 0x00CF0496 File Offset: 0x00CEE696
		static MoraleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoraleConfig.CreateStaticDefaultValue), new Action(MoraleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401CE11 RID: 118289
		[Nullable(2)]
		private static MoraleConfig _Instance;
	}
}
