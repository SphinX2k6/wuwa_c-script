using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADB RID: 2779
	public class ConfigTowerSeasonRewardByDifficulty : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004136 RID: 16694 RVA: 0x001CD848 File Offset: 0x001CBA48
		static ConfigTowerSeasonRewardByDifficulty()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerSeasonRewardByDifficulty.CreateStaticDefaultValue), new Action(ConfigTowerSeasonRewardByDifficulty.ResetStaticDefaultValue));
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x001CD868 File Offset: 0x001CBA68
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerSeasonRewardByDifficulty.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerSeasonRewardByDifficulty.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerSeasonReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerSeasonReward` where Difficulty = ?")
			});
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x001CD8E7 File Offset: 0x001CBAE7
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerSeasonRewardByDifficulty.LogPair = null;
			ConfigTowerSeasonRewardByDifficulty.HandleId = 0;
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x001CD8F5 File Offset: 0x001CBAF5
		public static void Init()
		{
			ConfigTowerSeasonRewardByDifficulty.HandleId = ConfigCommon.InitDataStatement(ConfigTowerSeasonRewardByDifficulty.HandleId, "db_tower.db", "select BinData from `TowerSeasonReward` where Difficulty = ?");
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x001CD910 File Offset: 0x001CBB10
		[NullableContext(2)]
		public static IReadOnlyList<TowerSeasonReward> GetConfigList(int p0Difficulty, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerSeasonRewardByDifficulty.HandleId, ConfigTowerSeasonRewardByDifficulty.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerSeasonRewardByDifficulty");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Difficulty);
				IReadOnlyList<TowerSeasonReward> readOnlyList = (IReadOnlyList<TowerSeasonReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTowerSeasonRewardByDifficulty.LogPair.Clear();
			ConfigTowerSeasonRewardByDifficulty.LogPair.Add(new ValueTuple<string, object>("Difficulty", p0Difficulty));
			if (!ConfigCommon.BindInt(ConfigTowerSeasonRewardByDifficulty.HandleId, 1, p0Difficulty, ConfigTowerSeasonRewardByDifficulty.LogPair))
			{
				ConfigCommon.Reset(ConfigTowerSeasonRewardByDifficulty.HandleId, ConfigTowerSeasonRewardByDifficulty.LogPair);
				return null;
			}
			List<TowerSeasonReward> list = new List<TowerSeasonReward>();
			while (ConfigCommon.Step(ConfigTowerSeasonRewardByDifficulty.HandleId, false, ConfigTowerSeasonRewardByDifficulty.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerSeasonRewardByDifficulty.HandleId, 0, ConfigTowerSeasonRewardByDifficulty.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerSeasonRewardByDifficulty.HandleId, ConfigTowerSeasonRewardByDifficulty.LogPair);
					return null;
				}
				TowerSeasonReward rootAsTowerSeasonReward = TowerSeasonReward.GetRootAsTowerSeasonReward(new ByteBuffer(item2));
				list.Add(rootAsTowerSeasonReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerSeasonRewardByDifficulty");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Difficulty);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerSeasonRewardByDifficulty.HandleId, ConfigTowerSeasonRewardByDifficulty.LogPair);
			return list;
		}

		// Token: 0x04004BE3 RID: 19427
		private const string DB = "db_tower.db";

		// Token: 0x04004BE4 RID: 19428
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004BE5 RID: 19429
		private const string TABLE = "TowerSeasonReward";

		// Token: 0x04004BE6 RID: 19430
		private const string COMMAND = "select BinData from `TowerSeasonReward` where Difficulty = ?";

		// Token: 0x04004BE7 RID: 19431
		private const string KEY_PREFIX = "TowerSeasonRewardByDifficulty";

		// Token: 0x04004BE8 RID: 19432
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BE9 RID: 19433
		private static int HandleId;
	}
}
