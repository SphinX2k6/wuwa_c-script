using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EBD RID: 20157
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class RogueBattleConfig : ConfigBase
	{
		// Token: 0x06033C1D RID: 211997 RVA: 0x00C2072C File Offset: 0x00C1E92C
		public RogueResBuffPool? GetRogueResBuffPoolById(int id)
		{
			RogueResBuffPool? config = ConfigRogueResBuffPoolById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RogueBattle;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "RogueBattleTokenItem.RefreshDescText tokenConfig is null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06033C1E RID: 211998 RVA: 0x00C2077A File Offset: 0x00C1E97A
		public RogueResRoomPool? GetRoomPoolConfig(int id)
		{
			return ConfigRogueResRoomPoolById.GetConfig(id, true);
		}

		// Token: 0x06033C1F RID: 211999 RVA: 0x00C20783 File Offset: 0x00C1E983
		public RogueResRoomType? GetRogueRoomType(int id)
		{
			return ConfigRogueResRoomTypeById.GetConfig(id, true);
		}

		// Token: 0x06033C20 RID: 212000 RVA: 0x00C2078C File Offset: 0x00C1E98C
		public ResElementLevelGain? GetElementLevelGain(int targetType)
		{
			return ConfigResElementLevelGainByTargetType.GetConfig(targetType, true);
		}

		// Token: 0x06033C21 RID: 212001 RVA: 0x00C20795 File Offset: 0x00C1E995
		public RogueResPokemon? GetRogueResPokemon(int id)
		{
			return ConfigRogueResPokemonById.GetConfig(id, true);
		}

		// Token: 0x06033C22 RID: 212002 RVA: 0x00C2079E File Offset: 0x00C1E99E
		public RogueResAffix? GetRogueResAffix(int id)
		{
			return ConfigRogueResAffixById.GetConfig(id, true);
		}

		// Token: 0x06033C23 RID: 212003 RVA: 0x00C207A7 File Offset: 0x00C1E9A7
		public RogueResQualityConfig? GetRogueResQualityConfig(int id)
		{
			return ConfigRogueResQualityConfigById.GetConfig(id, true);
		}

		// Token: 0x06033C24 RID: 212004 RVA: 0x00C207B0 File Offset: 0x00C1E9B0
		public RogueResBond? GetRogueResBond(int id)
		{
			return ConfigRogueResBondById.GetConfig(id, true);
		}

		// Token: 0x06033C25 RID: 212005 RVA: 0x00C207B9 File Offset: 0x00C1E9B9
		public IReadOnlyList<RogueResBond> GetAllRogueResBond()
		{
			return ConfigRogueResBondAll.GetConfigList(true);
		}

		// Token: 0x06033C26 RID: 212006 RVA: 0x00C207C1 File Offset: 0x00C1E9C1
		public RogueResBondRole? GetRogueResBondRole(int id)
		{
			return ConfigRogueResBondRoleByRoleId.GetConfig(id, true);
		}

		// Token: 0x06033C27 RID: 212007 RVA: 0x00C207CA File Offset: 0x00C1E9CA
		public IReadOnlyList<RogueResBondRole> GetAllRogueResBondRole()
		{
			return ConfigRogueResBondRoleAll.GetConfigList(true);
		}

		// Token: 0x06033C28 RID: 212008 RVA: 0x00C207D2 File Offset: 0x00C1E9D2
		public RogueResCharacterBuff? GetRogueResCharacterBuff(int id)
		{
			return ConfigRogueResCharacterBuffById.GetConfig(id, true);
		}

		// Token: 0x06033C29 RID: 212009 RVA: 0x00C207DB File Offset: 0x00C1E9DB
		public IReadOnlyList<RogueResSynergyType> GetAllRogueResBondType()
		{
			return ConfigRogueResSynergyTypeAll.GetConfigList(true);
		}

		// Token: 0x06033C2A RID: 212010 RVA: 0x00C207E3 File Offset: 0x00C1E9E3
		public RogueResSynergyType? GetRogueResBondTypeById(int id)
		{
			return ConfigRogueResSynergyTypeById.GetConfig(id, true);
		}

		// Token: 0x06033C2B RID: 212011 RVA: 0x00C207EC File Offset: 0x00C1E9EC
		public RogueResEffect? GetRogueResEffectById(int id)
		{
			return ConfigRogueResEffectById.GetConfig(id, true);
		}

		// Token: 0x06033C2C RID: 212012 RVA: 0x00C207F5 File Offset: 0x00C1E9F5
		public RogueResEffectTag? GetRogueResEffectTagById(int id)
		{
			return ConfigRogueResEffectTagById.GetConfig(id, true);
		}

		// Token: 0x06033C2D RID: 212013 RVA: 0x00C207FE File Offset: 0x00C1E9FE
		public IReadOnlyList<RogueResTeamLvRule> GetAllRogueResTeamLvRule()
		{
			return ConfigRogueResTeamLvRuleAll.GetConfigList(true);
		}

		// Token: 0x06033C2E RID: 212014 RVA: 0x00C20806 File Offset: 0x00C1EA06
		public IReadOnlyList<RogueResSkillLvRule> GetAllRogueResSkillLvRule()
		{
			return ConfigRogueResSkillLvRuleAll.GetConfigList(true);
		}

		// Token: 0x06033C2F RID: 212015 RVA: 0x00C2080E File Offset: 0x00C1EA0E
		public RogueResBondLv? GetBondLvConfigByLv(int lv)
		{
			return ConfigRogueResBondLvByLv.GetConfig(lv, true);
		}

		// Token: 0x17007EDF RID: 32479
		// (get) Token: 0x06033C30 RID: 212016 RVA: 0x00C20817 File Offset: 0x00C1EA17
		[Nullable(1)]
		public static RogueBattleConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return RogueBattleConfig._Instance;
			}
		}

		// Token: 0x06033C31 RID: 212017 RVA: 0x00C2081E File Offset: 0x00C1EA1E
		[NullableContext(1)]
		public static RogueBattleConfig GetOrCreateInstance()
		{
			if (RogueBattleConfig._Instance == null)
			{
				RogueBattleConfig.CreateInstance();
			}
			return RogueBattleConfig._Instance;
		}

		// Token: 0x06033C32 RID: 212018 RVA: 0x00C20832 File Offset: 0x00C1EA32
		public static bool CreateInstance()
		{
			if (RogueBattleConfig._Instance != null)
			{
				return true;
			}
			RogueBattleConfig._Instance = new RogueBattleConfig();
			return true;
		}

		// Token: 0x06033C33 RID: 212019 RVA: 0x00C20848 File Offset: 0x00C1EA48
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033C34 RID: 212020 RVA: 0x00C2084A File Offset: 0x00C1EA4A
		public static void ResetStaticDefaultValue()
		{
			RogueBattleConfig._Instance = null;
		}

		// Token: 0x06033C35 RID: 212021 RVA: 0x00C20852 File Offset: 0x00C1EA52
		static RogueBattleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RogueBattleConfig.CreateStaticDefaultValue), new Action(RogueBattleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B814 RID: 112660
		private static RogueBattleConfig _Instance;
	}
}
