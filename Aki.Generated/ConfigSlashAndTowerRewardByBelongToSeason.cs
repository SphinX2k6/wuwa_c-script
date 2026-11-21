using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099D RID: 2461
	public class ConfigSlashAndTowerRewardByBelongToSeason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039C1 RID: 14785 RVA: 0x001A33E7 File Offset: 0x001A15E7
		static ConfigSlashAndTowerRewardByBelongToSeason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashAndTowerRewardByBelongToSeason.CreateStaticDefaultValue), new Action(ConfigSlashAndTowerRewardByBelongToSeason.ResetStaticDefaultValue));
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x001A3408 File Offset: 0x001A1608
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashAndTowerRewardByBelongToSeason.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashAndTowerRewardByBelongToSeason.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashAndTowerReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashAndTowerReward` where BelongToSeason=?")
			});
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x001A3487 File Offset: 0x001A1687
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashAndTowerRewardByBelongToSeason.LogPair = null;
			ConfigSlashAndTowerRewardByBelongToSeason.HandleId = 0;
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x001A3495 File Offset: 0x001A1695
		public static void Init()
		{
			ConfigSlashAndTowerRewardByBelongToSeason.HandleId = ConfigCommon.InitDataStatement(ConfigSlashAndTowerRewardByBelongToSeason.HandleId, "db_shiptower.db", "select BinData from `SlashAndTowerReward` where BelongToSeason=?");
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x001A34B0 File Offset: 0x001A16B0
		[NullableContext(2)]
		public static IReadOnlyList<SlashAndTowerReward> GetConfigList(int p0BelongToSeason, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashAndTowerRewardByBelongToSeason.HandleId, ConfigSlashAndTowerRewardByBelongToSeason.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashAndTowerRewardByBelongToSeason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BelongToSeason);
				IReadOnlyList<SlashAndTowerReward> readOnlyList = (IReadOnlyList<SlashAndTowerReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSlashAndTowerRewardByBelongToSeason.LogPair.Clear();
			ConfigSlashAndTowerRewardByBelongToSeason.LogPair.Add(new ValueTuple<string, object>("BelongToSeason", p0BelongToSeason));
			if (!ConfigCommon.BindInt(ConfigSlashAndTowerRewardByBelongToSeason.HandleId, 1, p0BelongToSeason, ConfigSlashAndTowerRewardByBelongToSeason.LogPair))
			{
				ConfigCommon.Reset(ConfigSlashAndTowerRewardByBelongToSeason.HandleId, ConfigSlashAndTowerRewardByBelongToSeason.LogPair);
				return null;
			}
			List<SlashAndTowerReward> list = new List<SlashAndTowerReward>();
			while (ConfigCommon.Step(ConfigSlashAndTowerRewardByBelongToSeason.HandleId, false, ConfigSlashAndTowerRewardByBelongToSeason.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashAndTowerRewardByBelongToSeason.HandleId, 0, ConfigSlashAndTowerRewardByBelongToSeason.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSlashAndTowerRewardByBelongToSeason.HandleId, ConfigSlashAndTowerRewardByBelongToSeason.LogPair);
					return null;
				}
				SlashAndTowerReward rootAsSlashAndTowerReward = SlashAndTowerReward.GetRootAsSlashAndTowerReward(new ByteBuffer(item2));
				list.Add(rootAsSlashAndTowerReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashAndTowerRewardByBelongToSeason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BelongToSeason);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSlashAndTowerRewardByBelongToSeason.HandleId, ConfigSlashAndTowerRewardByBelongToSeason.LogPair);
			return list;
		}

		// Token: 0x04004331 RID: 17201
		private const string DB = "db_shiptower.db";

		// Token: 0x04004332 RID: 17202
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004333 RID: 17203
		private const string TABLE = "SlashAndTowerReward";

		// Token: 0x04004334 RID: 17204
		private const string COMMAND = "select BinData from `SlashAndTowerReward` where BelongToSeason=?";

		// Token: 0x04004335 RID: 17205
		private const string KEY_PREFIX = "SlashAndTowerRewardByBelongToSeason";

		// Token: 0x04004336 RID: 17206
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004337 RID: 17207
		private static int HandleId;
	}
}
