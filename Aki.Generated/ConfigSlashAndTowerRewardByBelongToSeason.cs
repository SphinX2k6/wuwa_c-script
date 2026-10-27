using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000952 RID: 2386
	public class ConfigSlashAndTowerRewardByBelongToSeason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037FF RID: 14335 RVA: 0x001961C7 File Offset: 0x001943C7
		static ConfigSlashAndTowerRewardByBelongToSeason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashAndTowerRewardByBelongToSeason.CreateStaticDefaultValue), new Action(ConfigSlashAndTowerRewardByBelongToSeason.ResetStaticDefaultValue));
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x001961E8 File Offset: 0x001943E8
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

		// Token: 0x06003801 RID: 14337 RVA: 0x00196267 File Offset: 0x00194467
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashAndTowerRewardByBelongToSeason.LogPair = null;
			ConfigSlashAndTowerRewardByBelongToSeason.HandleId = 0;
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00196275 File Offset: 0x00194475
		public static void Init()
		{
			ConfigSlashAndTowerRewardByBelongToSeason.HandleId = ConfigCommon.InitDataStatement(ConfigSlashAndTowerRewardByBelongToSeason.HandleId, "db_shiptower.db", "select BinData from `SlashAndTowerReward` where BelongToSeason=?");
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00196290 File Offset: 0x00194490
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

		// Token: 0x04004124 RID: 16676
		private const string DB = "db_shiptower.db";

		// Token: 0x04004125 RID: 16677
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004126 RID: 16678
		private const string TABLE = "SlashAndTowerReward";

		// Token: 0x04004127 RID: 16679
		private const string COMMAND = "select BinData from `SlashAndTowerReward` where BelongToSeason=?";

		// Token: 0x04004128 RID: 16680
		private const string KEY_PREFIX = "SlashAndTowerRewardByBelongToSeason";

		// Token: 0x04004129 RID: 16681
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400412A RID: 16682
		private static int HandleId;
	}
}
