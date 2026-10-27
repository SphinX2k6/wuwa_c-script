using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C58 RID: 23640
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleScoreConfig : ConfigBase
	{
		// Token: 0x0603BC1A RID: 244762 RVA: 0x00E45FD9 File Offset: 0x00E441D9
		public BattleScoreConf? GetBattleScoreConfig(int id)
		{
			return ConfigBattleScoreConfById.GetConfig(id, true);
		}

		// Token: 0x0603BC1B RID: 244763 RVA: 0x00E45FE2 File Offset: 0x00E441E2
		public BattleScoreLevelConf? GetBattleScoreLevelConfig(int id)
		{
			return ConfigBattleScoreLevelConfById.GetConfig(id, true);
		}

		// Token: 0x0603BC1C RID: 244764 RVA: 0x00E45FEB File Offset: 0x00E441EB
		[NullableContext(2)]
		public IReadOnlyList<BattleScoreLevelConf> GetBattleScoreActionConfigByGroupId(int groupId)
		{
			return ConfigBattleScoreLevelConfByGroupId.GetConfigList(groupId, true);
		}

		// Token: 0x17008DBC RID: 36284
		// (get) Token: 0x0603BC1D RID: 244765 RVA: 0x00E45FF4 File Offset: 0x00E441F4
		public static BattleScoreConfig Instance
		{
			get
			{
				return BattleScoreConfig._Instance;
			}
		}

		// Token: 0x0603BC1E RID: 244766 RVA: 0x00E45FFB File Offset: 0x00E441FB
		public static BattleScoreConfig GetOrCreateInstance()
		{
			if (BattleScoreConfig._Instance == null)
			{
				BattleScoreConfig.CreateInstance();
			}
			return BattleScoreConfig._Instance;
		}

		// Token: 0x0603BC1F RID: 244767 RVA: 0x00E4600F File Offset: 0x00E4420F
		public static bool CreateInstance()
		{
			if (BattleScoreConfig._Instance != null)
			{
				return true;
			}
			BattleScoreConfig._Instance = new BattleScoreConfig();
			return true;
		}

		// Token: 0x0603BC20 RID: 244768 RVA: 0x00E46025 File Offset: 0x00E44225
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BC21 RID: 244769 RVA: 0x00E46027 File Offset: 0x00E44227
		public static void ResetStaticDefaultValue()
		{
			BattleScoreConfig._Instance = null;
		}

		// Token: 0x0603BC22 RID: 244770 RVA: 0x00E4602F File Offset: 0x00E4422F
		static BattleScoreConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleScoreConfig.CreateStaticDefaultValue), new Action(BattleScoreConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401F1E4 RID: 127460
		[Nullable(2)]
		private static BattleScoreConfig _Instance;
	}
}
