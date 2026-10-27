using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A06 RID: 2566
	public class ConfigTowerSeasonRewardByDifficulty : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C38 RID: 15416 RVA: 0x001AE4B4 File Offset: 0x001AC6B4
		static ConfigTowerSeasonRewardByDifficulty()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerSeasonRewardByDifficulty.CreateStaticDefaultValue), new Action(ConfigTowerSeasonRewardByDifficulty.ResetStaticDefaultValue));
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x001AE4D4 File Offset: 0x001AC6D4
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

		// Token: 0x06003C3A RID: 15418 RVA: 0x001AE553 File Offset: 0x001AC753
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerSeasonRewardByDifficulty.LogPair = null;
			ConfigTowerSeasonRewardByDifficulty.HandleId = 0;
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x001AE561 File Offset: 0x001AC761
		public static void Init()
		{
			ConfigTowerSeasonRewardByDifficulty.HandleId = ConfigCommon.InitDataStatement(ConfigTowerSeasonRewardByDifficulty.HandleId, "db_tower.db", "select BinData from `TowerSeasonReward` where Difficulty = ?");
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x001AE57C File Offset: 0x001AC77C
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

		// Token: 0x04004610 RID: 17936
		private const string DB = "db_tower.db";

		// Token: 0x04004611 RID: 17937
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004612 RID: 17938
		private const string TABLE = "TowerSeasonReward";

		// Token: 0x04004613 RID: 17939
		private const string COMMAND = "select BinData from `TowerSeasonReward` where Difficulty = ?";

		// Token: 0x04004614 RID: 17940
		private const string KEY_PREFIX = "TowerSeasonRewardByDifficulty";

		// Token: 0x04004615 RID: 17941
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004616 RID: 17942
		private static int HandleId;
	}
}
