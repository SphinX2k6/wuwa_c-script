using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C2C RID: 19500
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MoraleBattleConfig : ConfigBase
	{
		// Token: 0x06030AA4 RID: 199332 RVA: 0x00D92B34 File Offset: 0x00D90D34
		public MoralePlay? GetMoraleConfig(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigMoralePlayById.GetConfig(id, true);
		}

		// Token: 0x06030AA5 RID: 199333 RVA: 0x00D92B55 File Offset: 0x00D90D55
		public MoraleKeepLevel? GetExpConfig(int id)
		{
			return ConfigMoraleKeepLevelById.GetConfig(id, true);
		}

		// Token: 0x06030AA6 RID: 199334 RVA: 0x00D92B5E File Offset: 0x00D90D5E
		[NullableContext(2)]
		public IReadOnlyList<MoraleKeepLevel> GetAllExpConfig()
		{
			return ConfigMoraleKeepLevelAll.GetConfigList(true);
		}

		// Token: 0x06030AA7 RID: 199335 RVA: 0x00D92B66 File Offset: 0x00D90D66
		public MoraleLevelDiff? GetLevelDiffConfig(int id)
		{
			return ConfigMoraleLevelDiffById.GetConfig(id, true);
		}

		// Token: 0x06030AA8 RID: 199336 RVA: 0x00D92B6F File Offset: 0x00D90D6F
		public MoraleLevelDiffShow? GetLevelDiffShowConfig(int id)
		{
			return ConfigMoraleLevelDiffShowById.GetConfig(id, true);
		}

		// Token: 0x06030AA9 RID: 199337 RVA: 0x00D92B78 File Offset: 0x00D90D78
		[NullableContext(2)]
		public IReadOnlyList<MoraleLevelDiffShow> GetAllLevelDiffShowConfig()
		{
			return ConfigMoraleLevelDiffShowAll.GetConfigList(true);
		}

		// Token: 0x1700618B RID: 24971
		// (get) Token: 0x06030AAA RID: 199338 RVA: 0x00D92B80 File Offset: 0x00D90D80
		public static MoraleBattleConfig Instance
		{
			get
			{
				return MoraleBattleConfig._Instance;
			}
		}

		// Token: 0x06030AAB RID: 199339 RVA: 0x00D92B87 File Offset: 0x00D90D87
		public static MoraleBattleConfig GetOrCreateInstance()
		{
			if (MoraleBattleConfig._Instance == null)
			{
				MoraleBattleConfig.CreateInstance();
			}
			return MoraleBattleConfig._Instance;
		}

		// Token: 0x06030AAC RID: 199340 RVA: 0x00D92B9B File Offset: 0x00D90D9B
		public static bool CreateInstance()
		{
			if (MoraleBattleConfig._Instance != null)
			{
				return true;
			}
			MoraleBattleConfig._Instance = new MoraleBattleConfig();
			return true;
		}

		// Token: 0x06030AAD RID: 199341 RVA: 0x00D92BB1 File Offset: 0x00D90DB1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030AAE RID: 199342 RVA: 0x00D92BB3 File Offset: 0x00D90DB3
		public static void ResetStaticDefaultValue()
		{
			MoraleBattleConfig._Instance = null;
		}

		// Token: 0x06030AAF RID: 199343 RVA: 0x00D92BBB File Offset: 0x00D90DBB
		static MoraleBattleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoraleBattleConfig.CreateStaticDefaultValue), new Action(MoraleBattleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04019C19 RID: 105497
		[Nullable(2)]
		private static MoraleBattleConfig _Instance;
	}
}
