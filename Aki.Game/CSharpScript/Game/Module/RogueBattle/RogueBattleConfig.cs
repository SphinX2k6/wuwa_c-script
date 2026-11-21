using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E86 RID: 16006
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class RogueBattleConfig : ConfigBase
	{
		// Token: 0x06028A88 RID: 166536 RVA: 0x00B69C44 File Offset: 0x00B67E44
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

		// Token: 0x06028A89 RID: 166537 RVA: 0x00B69C92 File Offset: 0x00B67E92
		public RogueResRoomPool? GetRoomPoolConfig(int id)
		{
			return ConfigRogueResRoomPoolById.GetConfig(id, true);
		}

		// Token: 0x06028A8A RID: 166538 RVA: 0x00B69C9B File Offset: 0x00B67E9B
		public RogueResRoomType? GetRogueRoomType(int id)
		{
			return ConfigRogueResRoomTypeById.GetConfig(id, true);
		}

		// Token: 0x06028A8B RID: 166539 RVA: 0x00B69CA4 File Offset: 0x00B67EA4
		public ResElementLevelGain? GetElementLevelGain(int targetType)
		{
			return ConfigResElementLevelGainByTargetType.GetConfig(targetType, true);
		}

		// Token: 0x06028A8C RID: 166540 RVA: 0x00B69CAD File Offset: 0x00B67EAD
		public RogueResPokemon? GetRogueResPokemon(int id)
		{
			return ConfigRogueResPokemonById.GetConfig(id, true);
		}

		// Token: 0x06028A8D RID: 166541 RVA: 0x00B69CB6 File Offset: 0x00B67EB6
		public RogueResAffix? GetRogueResAffix(int id)
		{
			return ConfigRogueResAffixById.GetConfig(id, true);
		}

		// Token: 0x06028A8E RID: 166542 RVA: 0x00B69CBF File Offset: 0x00B67EBF
		public RogueResQualityConfig? GetRogueResQualityConfig(int id)
		{
			return ConfigRogueResQualityConfigById.GetConfig(id, true);
		}

		// Token: 0x06028A8F RID: 166543 RVA: 0x00B69CC8 File Offset: 0x00B67EC8
		public RogueResBond? GetRogueResBond(int id)
		{
			return ConfigRogueResBondById.GetConfig(id, true);
		}

		// Token: 0x06028A90 RID: 166544 RVA: 0x00B69CD1 File Offset: 0x00B67ED1
		public IReadOnlyList<RogueResBond> GetAllRogueResBond()
		{
			return ConfigRogueResBondAll.GetConfigList(true);
		}

		// Token: 0x06028A91 RID: 166545 RVA: 0x00B69CD9 File Offset: 0x00B67ED9
		public RogueResBondRole? GetRogueResBondRole(int id)
		{
			return ConfigRogueResBondRoleByRoleId.GetConfig(id, true);
		}

		// Token: 0x06028A92 RID: 166546 RVA: 0x00B69CE2 File Offset: 0x00B67EE2
		public IReadOnlyList<RogueResBondRole> GetAllRogueResBondRole()
		{
			return ConfigRogueResBondRoleAll.GetConfigList(true);
		}

		// Token: 0x06028A93 RID: 166547 RVA: 0x00B69CEA File Offset: 0x00B67EEA
		public RogueResCharacterBuff? GetRogueResCharacterBuff(int id)
		{
			return ConfigRogueResCharacterBuffById.GetConfig(id, true);
		}

		// Token: 0x06028A94 RID: 166548 RVA: 0x00B69CF3 File Offset: 0x00B67EF3
		public IReadOnlyList<RogueResSynergyType> GetAllRogueResBondType()
		{
			return ConfigRogueResSynergyTypeAll.GetConfigList(true);
		}

		// Token: 0x06028A95 RID: 166549 RVA: 0x00B69CFB File Offset: 0x00B67EFB
		public RogueResSynergyType? GetRogueResBondTypeById(int id)
		{
			return ConfigRogueResSynergyTypeById.GetConfig(id, true);
		}

		// Token: 0x06028A96 RID: 166550 RVA: 0x00B69D04 File Offset: 0x00B67F04
		public RogueResEffect? GetRogueResEffectById(int id)
		{
			return ConfigRogueResEffectById.GetConfig(id, true);
		}

		// Token: 0x06028A97 RID: 166551 RVA: 0x00B69D0D File Offset: 0x00B67F0D
		public RogueResEffectTag? GetRogueResEffectTagById(int id)
		{
			return ConfigRogueResEffectTagById.GetConfig(id, true);
		}

		// Token: 0x06028A98 RID: 166552 RVA: 0x00B69D16 File Offset: 0x00B67F16
		public IReadOnlyList<RogueResTeamLvRule> GetAllRogueResTeamLvRule()
		{
			return ConfigRogueResTeamLvRuleAll.GetConfigList(true);
		}

		// Token: 0x06028A99 RID: 166553 RVA: 0x00B69D1E File Offset: 0x00B67F1E
		public IReadOnlyList<RogueResSkillLvRule> GetAllRogueResSkillLvRule()
		{
			return ConfigRogueResSkillLvRuleAll.GetConfigList(true);
		}

		// Token: 0x06028A9A RID: 166554 RVA: 0x00B69D26 File Offset: 0x00B67F26
		public RogueResBondLv? GetBondLvConfigByLv(int lv)
		{
			return ConfigRogueResBondLvByLv.GetConfig(lv, true);
		}

		// Token: 0x1700528F RID: 21135
		// (get) Token: 0x06028A9B RID: 166555 RVA: 0x00B69D2F File Offset: 0x00B67F2F
		[Nullable(1)]
		public static RogueBattleConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return RogueBattleConfig._Instance;
			}
		}

		// Token: 0x06028A9C RID: 166556 RVA: 0x00B69D36 File Offset: 0x00B67F36
		[NullableContext(1)]
		public static RogueBattleConfig GetOrCreateInstance()
		{
			if (RogueBattleConfig._Instance == null)
			{
				RogueBattleConfig.CreateInstance();
			}
			return RogueBattleConfig._Instance;
		}

		// Token: 0x06028A9D RID: 166557 RVA: 0x00B69D4A File Offset: 0x00B67F4A
		public static bool CreateInstance()
		{
			if (RogueBattleConfig._Instance != null)
			{
				return true;
			}
			RogueBattleConfig._Instance = new RogueBattleConfig();
			return true;
		}

		// Token: 0x06028A9E RID: 166558 RVA: 0x00B69D60 File Offset: 0x00B67F60
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028A9F RID: 166559 RVA: 0x00B69D62 File Offset: 0x00B67F62
		public static void ResetStaticDefaultValue()
		{
			RogueBattleConfig._Instance = null;
		}

		// Token: 0x06028AA0 RID: 166560 RVA: 0x00B69D6A File Offset: 0x00B67F6A
		static RogueBattleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RogueBattleConfig.CreateStaticDefaultValue), new Action(RogueBattleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040161E7 RID: 90599
		private static RogueBattleConfig _Instance;
	}
}
