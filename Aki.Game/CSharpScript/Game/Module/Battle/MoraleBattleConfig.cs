using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C4C RID: 23628
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MoraleBattleConfig : ConfigBase
	{
		// Token: 0x0603BB59 RID: 244569 RVA: 0x00E42768 File Offset: 0x00E40968
		public MoralePlay? GetMoraleConfig(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigMoralePlayById.GetConfig(id, true);
		}

		// Token: 0x0603BB5A RID: 244570 RVA: 0x00E42789 File Offset: 0x00E40989
		public MoraleKeepLevel? GetExpConfig(int id)
		{
			return ConfigMoraleKeepLevelById.GetConfig(id, true);
		}

		// Token: 0x0603BB5B RID: 244571 RVA: 0x00E42792 File Offset: 0x00E40992
		[NullableContext(2)]
		public IReadOnlyList<MoraleKeepLevel> GetAllExpConfig()
		{
			return ConfigMoraleKeepLevelAll.GetConfigList(true);
		}

		// Token: 0x0603BB5C RID: 244572 RVA: 0x00E4279A File Offset: 0x00E4099A
		public MoraleLevelDiff? GetLevelDiffConfig(int id)
		{
			return ConfigMoraleLevelDiffById.GetConfig(id, true);
		}

		// Token: 0x0603BB5D RID: 244573 RVA: 0x00E427A3 File Offset: 0x00E409A3
		public MoraleLevelDiffShow? GetLevelDiffShowConfig(int id)
		{
			return ConfigMoraleLevelDiffShowById.GetConfig(id, true);
		}

		// Token: 0x0603BB5E RID: 244574 RVA: 0x00E427AC File Offset: 0x00E409AC
		[NullableContext(2)]
		public IReadOnlyList<MoraleLevelDiffShow> GetAllLevelDiffShowConfig()
		{
			return ConfigMoraleLevelDiffShowAll.GetConfigList(true);
		}

		// Token: 0x17008DB9 RID: 36281
		// (get) Token: 0x0603BB5F RID: 244575 RVA: 0x00E427B4 File Offset: 0x00E409B4
		public static MoraleBattleConfig Instance
		{
			get
			{
				return MoraleBattleConfig._Instance;
			}
		}

		// Token: 0x0603BB60 RID: 244576 RVA: 0x00E427BB File Offset: 0x00E409BB
		public static MoraleBattleConfig GetOrCreateInstance()
		{
			if (MoraleBattleConfig._Instance == null)
			{
				MoraleBattleConfig.CreateInstance();
			}
			return MoraleBattleConfig._Instance;
		}

		// Token: 0x0603BB61 RID: 244577 RVA: 0x00E427CF File Offset: 0x00E409CF
		public static bool CreateInstance()
		{
			if (MoraleBattleConfig._Instance != null)
			{
				return true;
			}
			MoraleBattleConfig._Instance = new MoraleBattleConfig();
			return true;
		}

		// Token: 0x0603BB62 RID: 244578 RVA: 0x00E427E5 File Offset: 0x00E409E5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BB63 RID: 244579 RVA: 0x00E427E7 File Offset: 0x00E409E7
		public static void ResetStaticDefaultValue()
		{
			MoraleBattleConfig._Instance = null;
		}

		// Token: 0x0603BB64 RID: 244580 RVA: 0x00E427EF File Offset: 0x00E409EF
		static MoraleBattleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoraleBattleConfig.CreateStaticDefaultValue), new Action(MoraleBattleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401F168 RID: 127336
		[Nullable(2)]
		private static MoraleBattleConfig _Instance;
	}
}
