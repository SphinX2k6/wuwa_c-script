using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004378 RID: 17272
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MoraleConfig : ConfigBase
	{
		// Token: 0x0602B9ED RID: 178669 RVA: 0x00C3F3B0 File Offset: 0x00C3D5B0
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602B9EE RID: 178670 RVA: 0x00C3F3B3 File Offset: 0x00C3D5B3
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x0602B9EF RID: 178671 RVA: 0x00C3F3B6 File Offset: 0x00C3D5B6
		public IReadOnlyList<OccupyScore> GetAllScoreConfigList()
		{
			return ConfigOccupyScoreAll.GetConfigList(true) ?? Array.Empty<OccupyScore>();
		}

		// Token: 0x0602B9F0 RID: 178672 RVA: 0x00C3F3C7 File Offset: 0x00C3D5C7
		public IReadOnlyList<FlagArea> GetFlagConfigListByAreaId(int areaId)
		{
			return ConfigFlagAreaByAreaId.GetConfigList(areaId, true) ?? Array.Empty<FlagArea>();
		}

		// Token: 0x0602B9F1 RID: 178673 RVA: 0x00C3F3D9 File Offset: 0x00C3D5D9
		public MoraleFlagType? GetFlagTypeConfig(int flagTypeId)
		{
			return ConfigMoraleFlagTypeByType.GetConfig(flagTypeId, true);
		}

		// Token: 0x0602B9F2 RID: 178674 RVA: 0x00C3F3E2 File Offset: 0x00C3D5E2
		public IReadOnlyList<MoraleLvPower> GetAllMoraleLvPowerConfigList()
		{
			return ConfigMoraleLvPowerAll.GetConfigList(true) ?? Array.Empty<MoraleLvPower>();
		}

		// Token: 0x0602B9F3 RID: 178675 RVA: 0x00C3F3F3 File Offset: 0x00C3D5F3
		public IReadOnlyList<MoraleArea> GetAllAreaConfigList()
		{
			return ConfigMoraleAreaAll.GetConfigList(true) ?? Array.Empty<MoraleArea>();
		}

		// Token: 0x0602B9F4 RID: 178676 RVA: 0x00C3F404 File Offset: 0x00C3D604
		public IReadOnlyList<int> GetAllAttrAddIdList()
		{
			return ConfigCommonParamById.GetIntArrayConfig("MoraleRoleAttrAddIdList") ?? Array.Empty<int>();
		}

		// Token: 0x0602B9F5 RID: 178677 RVA: 0x00C3F419 File Offset: 0x00C3D619
		public MoraleRoleGrowth? GetRoleAttrAddConfigByLv(int lv)
		{
			return ConfigMoraleRoleGrowthByLevel.GetConfig(lv, true);
		}

		// Token: 0x0602B9F6 RID: 178678 RVA: 0x00C3F424 File Offset: 0x00C3D624
		public int GetScoreProgressRichValue()
		{
			return ConfigCommonParamById.GetIntConfig("MoraleScoreProgressRichValue").GetValueOrDefault();
		}

		// Token: 0x0602B9F7 RID: 178679 RVA: 0x00C3F444 File Offset: 0x00C3D644
		public int GetMoraleGameOverQuestId()
		{
			return ConfigCommonParamById.GetIntConfig("MoraleGameOver").GetValueOrDefault();
		}

		// Token: 0x0602B9F8 RID: 178680 RVA: 0x00C3F464 File Offset: 0x00C3D664
		public bool GetMoraleMarkIsAutoTrack()
		{
			return ConfigCommonParamById.GetBoolConfig("MoraleMarkIsAutoTrack").GetValueOrDefault();
		}

		// Token: 0x0602B9F9 RID: 178681 RVA: 0x00C3F484 File Offset: 0x00C3D684
		public int GetMoraleBuffShowTime()
		{
			return ConfigCommonParamById.GetIntConfig("MoraleBuffShowTime").GetValueOrDefault(1);
		}

		// Token: 0x0602B9FA RID: 178682 RVA: 0x00C3F4A4 File Offset: 0x00C3D6A4
		public bool GetMoraleSelectHighLevelFlag()
		{
			return ConfigCommonParamById.GetBoolConfig("MoraleSelectHighLevelFlag").GetValueOrDefault();
		}

		// Token: 0x0602B9FB RID: 178683 RVA: 0x00C3F4C4 File Offset: 0x00C3D6C4
		public bool GetMoraleIsShowSmallFlagProgress()
		{
			return ConfigCommonParamById.GetBoolConfig("MoraleIsShowSmallFlagProgress").GetValueOrDefault();
		}

		// Token: 0x0602B9FC RID: 178684 RVA: 0x00C3F4E4 File Offset: 0x00C3D6E4
		public bool GetMoraleHighFlagUnFinishIsShowExploreBoxProgress()
		{
			return ConfigCommonParamById.GetBoolConfig("MoraleHighFlagUnFinishIsShowExploreBoxProgress").GetValueOrDefault();
		}

		// Token: 0x17005777 RID: 22391
		// (get) Token: 0x0602B9FD RID: 178685 RVA: 0x00C3F503 File Offset: 0x00C3D703
		public static MoraleConfig Instance
		{
			get
			{
				return MoraleConfig._Instance;
			}
		}

		// Token: 0x0602B9FE RID: 178686 RVA: 0x00C3F50A File Offset: 0x00C3D70A
		public static MoraleConfig GetOrCreateInstance()
		{
			if (MoraleConfig._Instance == null)
			{
				MoraleConfig.CreateInstance();
			}
			return MoraleConfig._Instance;
		}

		// Token: 0x0602B9FF RID: 178687 RVA: 0x00C3F51E File Offset: 0x00C3D71E
		public static bool CreateInstance()
		{
			if (MoraleConfig._Instance != null)
			{
				return true;
			}
			MoraleConfig._Instance = new MoraleConfig();
			return true;
		}

		// Token: 0x0602BA00 RID: 178688 RVA: 0x00C3F534 File Offset: 0x00C3D734
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602BA01 RID: 178689 RVA: 0x00C3F536 File Offset: 0x00C3D736
		public static void ResetStaticDefaultValue()
		{
			MoraleConfig._Instance = null;
		}

		// Token: 0x0602BA02 RID: 178690 RVA: 0x00C3F53E File Offset: 0x00C3D73E
		static MoraleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoraleConfig.CreateStaticDefaultValue), new Action(MoraleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040178A9 RID: 96425
		[Nullable(2)]
		private static MoraleConfig _Instance;
	}
}
