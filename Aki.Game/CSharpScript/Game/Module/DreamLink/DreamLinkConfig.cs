using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005A90 RID: 23184
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkConfig : ConfigBase
	{
		// Token: 0x0603AB8A RID: 240522 RVA: 0x00DFCBFE File Offset: 0x00DFADFE
		public DreamLinkRoleDungeon? GetDreamLinkRoleDungeonConfig(int id)
		{
			return ConfigDreamLinkRoleDungeonById.GetConfig(id, true);
		}

		// Token: 0x0603AB8B RID: 240523 RVA: 0x00DFCC07 File Offset: 0x00DFAE07
		public RogueWhiteCat? GetActivityConfig(int id)
		{
			return ConfigRogueWhiteCatById.GetConfig(id, true);
		}

		// Token: 0x0603AB8C RID: 240524 RVA: 0x00DFCC10 File Offset: 0x00DFAE10
		public RogueBossInstance? GetRogueBossInstanceConfig(int id)
		{
			return ConfigRogueBossInstanceById.GetConfig(id, true);
		}

		// Token: 0x0603AB8D RID: 240525 RVA: 0x00DFCC19 File Offset: 0x00DFAE19
		public BattleLinkCharacter? GetRoleConfig(int id)
		{
			return ConfigBattleLinkCharacterById.GetConfig(id, true);
		}

		// Token: 0x0603AB8E RID: 240526 RVA: 0x00DFCC22 File Offset: 0x00DFAE22
		[NullableContext(2)]
		public IReadOnlyList<BattleLinkCharacter> GetRoleConfigList()
		{
			return ConfigBattleLinkCharacterAll.GetConfigList(true);
		}

		// Token: 0x0603AB8F RID: 240527 RVA: 0x00DFCC2A File Offset: 0x00DFAE2A
		public RogueWhiteCatReward? GetEnergyRewardConfig(int id)
		{
			return ConfigRogueWhiteCatRewardById.GetConfig(id, true);
		}

		// Token: 0x0603AB90 RID: 240528 RVA: 0x00DFCC33 File Offset: 0x00DFAE33
		public DreamLinkWorldRun? GetWorldRunConfig(int id)
		{
			return ConfigDreamLinkWorldRunById.GetConfig(id, true);
		}

		// Token: 0x0603AB91 RID: 240529 RVA: 0x00DFCC3C File Offset: 0x00DFAE3C
		public DreamLinkWorldRun? GetWorldRunConfigByMarkId(int markId)
		{
			return ConfigDreamLinkWorldRunByMarkId.GetConfig(markId, true);
		}

		// Token: 0x0603AB92 RID: 240530 RVA: 0x00DFCC45 File Offset: 0x00DFAE45
		public RogueLimitTimeReward? GetLimitTimeRewardConfig(int id)
		{
			return ConfigRogueLimitTimeRewardById.GetConfig(id, true);
		}

		// Token: 0x0603AB93 RID: 240531 RVA: 0x00DFCC4E File Offset: 0x00DFAE4E
		public RogueWhiteCatBossReward? GetBossRewardConfig(int id)
		{
			return ConfigRogueWhiteCatBossRewardById.GetConfig(id, true);
		}

		// Token: 0x17008C00 RID: 35840
		// (get) Token: 0x0603AB94 RID: 240532 RVA: 0x00DFCC57 File Offset: 0x00DFAE57
		public static DreamLinkConfig Instance
		{
			get
			{
				return DreamLinkConfig._Instance;
			}
		}

		// Token: 0x0603AB95 RID: 240533 RVA: 0x00DFCC5E File Offset: 0x00DFAE5E
		public static DreamLinkConfig GetOrCreateInstance()
		{
			if (DreamLinkConfig._Instance == null)
			{
				DreamLinkConfig.CreateInstance();
			}
			return DreamLinkConfig._Instance;
		}

		// Token: 0x0603AB96 RID: 240534 RVA: 0x00DFCC72 File Offset: 0x00DFAE72
		public static bool CreateInstance()
		{
			if (DreamLinkConfig._Instance != null)
			{
				return true;
			}
			DreamLinkConfig._Instance = new DreamLinkConfig();
			return true;
		}

		// Token: 0x0603AB97 RID: 240535 RVA: 0x00DFCC88 File Offset: 0x00DFAE88
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AB98 RID: 240536 RVA: 0x00DFCC8A File Offset: 0x00DFAE8A
		public static void ResetStaticDefaultValue()
		{
			DreamLinkConfig._Instance = null;
		}

		// Token: 0x0603AB99 RID: 240537 RVA: 0x00DFCC92 File Offset: 0x00DFAE92
		static DreamLinkConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DreamLinkConfig.CreateStaticDefaultValue), new Action(DreamLinkConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401EA67 RID: 125543
		[Nullable(2)]
		private static DreamLinkConfig _Instance;
	}
}
