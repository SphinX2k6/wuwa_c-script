using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A6C RID: 19052
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkConfig : ConfigBase
	{
		// Token: 0x0602FAD3 RID: 195283 RVA: 0x00D4D192 File Offset: 0x00D4B392
		public DreamLinkRoleDungeon? GetDreamLinkRoleDungeonConfig(int id)
		{
			return ConfigDreamLinkRoleDungeonById.GetConfig(id, true);
		}

		// Token: 0x0602FAD4 RID: 195284 RVA: 0x00D4D19B File Offset: 0x00D4B39B
		public RogueWhiteCat? GetActivityConfig(int id)
		{
			return ConfigRogueWhiteCatById.GetConfig(id, true);
		}

		// Token: 0x0602FAD5 RID: 195285 RVA: 0x00D4D1A4 File Offset: 0x00D4B3A4
		public RogueBossInstance? GetRogueBossInstanceConfig(int id)
		{
			return ConfigRogueBossInstanceById.GetConfig(id, true);
		}

		// Token: 0x0602FAD6 RID: 195286 RVA: 0x00D4D1AD File Offset: 0x00D4B3AD
		public BattleLinkCharacter? GetRoleConfig(int id)
		{
			return ConfigBattleLinkCharacterById.GetConfig(id, true);
		}

		// Token: 0x0602FAD7 RID: 195287 RVA: 0x00D4D1B6 File Offset: 0x00D4B3B6
		[NullableContext(2)]
		public IReadOnlyList<BattleLinkCharacter> GetRoleConfigList()
		{
			return ConfigBattleLinkCharacterAll.GetConfigList(true);
		}

		// Token: 0x0602FAD8 RID: 195288 RVA: 0x00D4D1BE File Offset: 0x00D4B3BE
		public RogueWhiteCatReward? GetEnergyRewardConfig(int id)
		{
			return ConfigRogueWhiteCatRewardById.GetConfig(id, true);
		}

		// Token: 0x0602FAD9 RID: 195289 RVA: 0x00D4D1C7 File Offset: 0x00D4B3C7
		public DreamLinkWorldRun? GetWorldRunConfig(int id)
		{
			return ConfigDreamLinkWorldRunById.GetConfig(id, true);
		}

		// Token: 0x0602FADA RID: 195290 RVA: 0x00D4D1D0 File Offset: 0x00D4B3D0
		public DreamLinkWorldRun? GetWorldRunConfigByMarkId(int markId)
		{
			return ConfigDreamLinkWorldRunByMarkId.GetConfig(markId, true);
		}

		// Token: 0x0602FADB RID: 195291 RVA: 0x00D4D1D9 File Offset: 0x00D4B3D9
		public RogueLimitTimeReward? GetLimitTimeRewardConfig(int id)
		{
			return ConfigRogueLimitTimeRewardById.GetConfig(id, true);
		}

		// Token: 0x0602FADC RID: 195292 RVA: 0x00D4D1E2 File Offset: 0x00D4B3E2
		public RogueWhiteCatBossReward? GetBossRewardConfig(int id)
		{
			return ConfigRogueWhiteCatBossRewardById.GetConfig(id, true);
		}

		// Token: 0x17005FCE RID: 24526
		// (get) Token: 0x0602FADD RID: 195293 RVA: 0x00D4D1EB File Offset: 0x00D4B3EB
		public static DreamLinkConfig Instance
		{
			get
			{
				return DreamLinkConfig._Instance;
			}
		}

		// Token: 0x0602FADE RID: 195294 RVA: 0x00D4D1F2 File Offset: 0x00D4B3F2
		public static DreamLinkConfig GetOrCreateInstance()
		{
			if (DreamLinkConfig._Instance == null)
			{
				DreamLinkConfig.CreateInstance();
			}
			return DreamLinkConfig._Instance;
		}

		// Token: 0x0602FADF RID: 195295 RVA: 0x00D4D206 File Offset: 0x00D4B406
		public static bool CreateInstance()
		{
			if (DreamLinkConfig._Instance != null)
			{
				return true;
			}
			DreamLinkConfig._Instance = new DreamLinkConfig();
			return true;
		}

		// Token: 0x0602FAE0 RID: 195296 RVA: 0x00D4D21C File Offset: 0x00D4B41C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FAE1 RID: 195297 RVA: 0x00D4D21E File Offset: 0x00D4B41E
		public static void ResetStaticDefaultValue()
		{
			DreamLinkConfig._Instance = null;
		}

		// Token: 0x0602FAE2 RID: 195298 RVA: 0x00D4D226 File Offset: 0x00D4B426
		static DreamLinkConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DreamLinkConfig.CreateStaticDefaultValue), new Action(DreamLinkConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401950E RID: 103694
		[Nullable(2)]
		private static DreamLinkConfig _Instance;
	}
}
