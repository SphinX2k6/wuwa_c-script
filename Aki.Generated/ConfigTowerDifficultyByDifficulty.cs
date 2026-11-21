using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD6 RID: 2774
	public class ConfigTowerDifficultyByDifficulty : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004118 RID: 16664 RVA: 0x001CCCE0 File Offset: 0x001CAEE0
		static ConfigTowerDifficultyByDifficulty()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDifficultyByDifficulty.CreateStaticDefaultValue), new Action(ConfigTowerDifficultyByDifficulty.ResetStaticDefaultValue));
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x001CCD00 File Offset: 0x001CAF00
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

		// Token: 0x0600411A RID: 16666 RVA: 0x001CCD7F File Offset: 0x001CAF7F
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDifficultyByDifficulty.LogPair = null;
			ConfigTowerDifficultyByDifficulty.HandleId = 0;
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x001CCD8D File Offset: 0x001CAF8D
		public static void Init()
		{
			ConfigTowerDifficultyByDifficulty.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDifficultyByDifficulty.HandleId, "db_tower.db", "select BinData from `TowerDifficulty` where Difficulty = ?");
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x001CCDA8 File Offset: 0x001CAFA8
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

		// Token: 0x04004BC0 RID: 19392
		private const string DB = "db_tower.db";

		// Token: 0x04004BC1 RID: 19393
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004BC2 RID: 19394
		private const string TABLE = "TowerDifficulty";

		// Token: 0x04004BC3 RID: 19395
		private const string COMMAND = "select BinData from `TowerDifficulty` where Difficulty = ?";

		// Token: 0x04004BC4 RID: 19396
		private const string KEY_PREFIX = "TowerDifficultyByDifficulty";

		// Token: 0x04004BC5 RID: 19397
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BC6 RID: 19398
		private static int HandleId;
	}
}
