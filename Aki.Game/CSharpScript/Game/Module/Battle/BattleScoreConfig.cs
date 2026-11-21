using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C38 RID: 19512
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleScoreConfig : ConfigBase
	{
		// Token: 0x06030B65 RID: 199525 RVA: 0x00D963B9 File Offset: 0x00D945B9
		public BattleScoreConf? GetBattleScoreConfig(int id)
		{
			return ConfigBattleScoreConfById.GetConfig(id, true);
		}

		// Token: 0x06030B66 RID: 199526 RVA: 0x00D963C2 File Offset: 0x00D945C2
		public BattleScoreLevelConf? GetBattleScoreLevelConfig(int id)
		{
			return ConfigBattleScoreLevelConfById.GetConfig(id, true);
		}

		// Token: 0x06030B67 RID: 199527 RVA: 0x00D963CB File Offset: 0x00D945CB
		[NullableContext(2)]
		public IReadOnlyList<BattleScoreLevelConf> GetBattleScoreActionConfigByGroupId(int groupId)
		{
			return ConfigBattleScoreLevelConfByGroupId.GetConfigList(groupId, true);
		}

		// Token: 0x1700618E RID: 24974
		// (get) Token: 0x06030B68 RID: 199528 RVA: 0x00D963D4 File Offset: 0x00D945D4
		public static BattleScoreConfig Instance
		{
			get
			{
				return BattleScoreConfig._Instance;
			}
		}

		// Token: 0x06030B69 RID: 199529 RVA: 0x00D963DB File Offset: 0x00D945DB
		public static BattleScoreConfig GetOrCreateInstance()
		{
			if (BattleScoreConfig._Instance == null)
			{
				BattleScoreConfig.CreateInstance();
			}
			return BattleScoreConfig._Instance;
		}

		// Token: 0x06030B6A RID: 199530 RVA: 0x00D963EF File Offset: 0x00D945EF
		public static bool CreateInstance()
		{
			if (BattleScoreConfig._Instance != null)
			{
				return true;
			}
			BattleScoreConfig._Instance = new BattleScoreConfig();
			return true;
		}

		// Token: 0x06030B6B RID: 199531 RVA: 0x00D96405 File Offset: 0x00D94605
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030B6C RID: 199532 RVA: 0x00D96407 File Offset: 0x00D94607
		public static void ResetStaticDefaultValue()
		{
			BattleScoreConfig._Instance = null;
		}

		// Token: 0x06030B6D RID: 199533 RVA: 0x00D9640F File Offset: 0x00D9460F
		static BattleScoreConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleScoreConfig.CreateStaticDefaultValue), new Action(BattleScoreConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04019C95 RID: 105621
		[Nullable(2)]
		private static BattleScoreConfig _Instance;
	}
}
