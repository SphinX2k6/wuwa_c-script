using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A01 RID: 2561
	public class ConfigTowerDifficultyByDifficulty : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C1A RID: 15386 RVA: 0x001AD94C File Offset: 0x001ABB4C
		static ConfigTowerDifficultyByDifficulty()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDifficultyByDifficulty.CreateStaticDefaultValue), new Action(ConfigTowerDifficultyByDifficulty.ResetStaticDefaultValue));
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x001AD96C File Offset: 0x001ABB6C
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDifficultyByDifficulty.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDifficultyByDifficulty.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDifficulty"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDifficulty` where Difficulty = ?")
			});
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x001AD9EB File Offset: 0x001ABBEB
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDifficultyByDifficulty.LogPair = null;
			ConfigTowerDifficultyByDifficulty.HandleId = 0;
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x001AD9F9 File Offset: 0x001ABBF9
		public static void Init()
		{
			ConfigTowerDifficultyByDifficulty.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDifficultyByDifficulty.HandleId, "db_tower.db", "select BinData from `TowerDifficulty` where Difficulty = ?");
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x001ADA14 File Offset: 0x001ABC14
		public static TowerDifficulty? GetConfig(int p0Difficulty, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDifficultyByDifficulty.HandleId, ConfigTowerDifficultyByDifficulty.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDifficultyByDifficulty");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Difficulty);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerDifficulty?(TowerDifficulty.GetRootAsTowerDifficulty(configBuffer));
				}
			}
			ConfigTowerDifficultyByDifficulty.LogPair.Clear();
			ConfigTowerDifficultyByDifficulty.LogPair.Add(new ValueTuple<string, object>("Difficulty", p0Difficulty));
			if (!ConfigCommon.BindInt(ConfigTowerDifficultyByDifficulty.HandleId, 1, p0Difficulty, ConfigTowerDifficultyByDifficulty.LogPair) || ConfigCommon.Step(ConfigTowerDifficultyByDifficulty.HandleId, true, ConfigTowerDifficultyByDifficulty.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerDifficultyByDifficulty.HandleId, ConfigTowerDifficultyByDifficulty.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDifficultyByDifficulty.HandleId, 0, ConfigTowerDifficultyByDifficulty.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerDifficultyByDifficulty.HandleId, ConfigTowerDifficultyByDifficulty.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerDifficulty rootAsTowerDifficulty = TowerDifficulty.GetRootAsTowerDifficulty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDifficultyByDifficulty");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Difficulty);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerDifficultyByDifficulty.HandleId, ConfigTowerDifficultyByDifficulty.LogPair);
			return new TowerDifficulty?(rootAsTowerDifficulty);
		}

		// Token: 0x040045ED RID: 17901
		private const string DB = "db_tower.db";

		// Token: 0x040045EE RID: 17902
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x040045EF RID: 17903
		private const string TABLE = "TowerDifficulty";

		// Token: 0x040045F0 RID: 17904
		private const string COMMAND = "select BinData from `TowerDifficulty` where Difficulty = ?";

		// Token: 0x040045F1 RID: 17905
		private const string KEY_PREFIX = "TowerDifficultyByDifficulty";

		// Token: 0x040045F2 RID: 17906
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045F3 RID: 17907
		private static int HandleId;
	}
}
