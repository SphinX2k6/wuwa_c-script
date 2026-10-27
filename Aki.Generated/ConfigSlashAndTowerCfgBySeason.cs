using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000951 RID: 2385
	public class ConfigSlashAndTowerCfgBySeason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037F9 RID: 14329 RVA: 0x00195F90 File Offset: 0x00194190
		static ConfigSlashAndTowerCfgBySeason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashAndTowerCfgBySeason.CreateStaticDefaultValue), new Action(ConfigSlashAndTowerCfgBySeason.ResetStaticDefaultValue));
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00195FB0 File Offset: 0x001941B0
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashAndTowerCfgBySeason.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashAndTowerCfgBySeason.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashAndTowerCfg"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashAndTowerCfg` where Season=?")
			});
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x0019602F File Offset: 0x0019422F
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashAndTowerCfgBySeason.LogPair = null;
			ConfigSlashAndTowerCfgBySeason.HandleId = 0;
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x0019603D File Offset: 0x0019423D
		public static void Init()
		{
			ConfigSlashAndTowerCfgBySeason.HandleId = ConfigCommon.InitDataStatement(ConfigSlashAndTowerCfgBySeason.HandleId, "db_shiptower.db", "select BinData from `SlashAndTowerCfg` where Season=?");
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00196058 File Offset: 0x00194258
		[NullableContext(2)]
		public static IReadOnlyList<SlashAndTowerCfg> GetConfigList(int p0Season, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashAndTowerCfgBySeason.HandleId, ConfigSlashAndTowerCfgBySeason.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashAndTowerCfgBySeason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Season);
				IReadOnlyList<SlashAndTowerCfg> readOnlyList = (IReadOnlyList<SlashAndTowerCfg>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSlashAndTowerCfgBySeason.LogPair.Clear();
			ConfigSlashAndTowerCfgBySeason.LogPair.Add(new ValueTuple<string, object>("Season", p0Season));
			if (!ConfigCommon.BindInt(ConfigSlashAndTowerCfgBySeason.HandleId, 1, p0Season, ConfigSlashAndTowerCfgBySeason.LogPair))
			{
				ConfigCommon.Reset(ConfigSlashAndTowerCfgBySeason.HandleId, ConfigSlashAndTowerCfgBySeason.LogPair);
				return null;
			}
			List<SlashAndTowerCfg> list = new List<SlashAndTowerCfg>();
			while (ConfigCommon.Step(ConfigSlashAndTowerCfgBySeason.HandleId, false, ConfigSlashAndTowerCfgBySeason.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashAndTowerCfgBySeason.HandleId, 0, ConfigSlashAndTowerCfgBySeason.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSlashAndTowerCfgBySeason.HandleId, ConfigSlashAndTowerCfgBySeason.LogPair);
					return null;
				}
				SlashAndTowerCfg rootAsSlashAndTowerCfg = SlashAndTowerCfg.GetRootAsSlashAndTowerCfg(new ByteBuffer(item2));
				list.Add(rootAsSlashAndTowerCfg);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashAndTowerCfgBySeason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Season);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSlashAndTowerCfgBySeason.HandleId, ConfigSlashAndTowerCfgBySeason.LogPair);
			return list;
		}

		// Token: 0x0400411D RID: 16669
		private const string DB = "db_shiptower.db";

		// Token: 0x0400411E RID: 16670
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x0400411F RID: 16671
		private const string TABLE = "SlashAndTowerCfg";

		// Token: 0x04004120 RID: 16672
		private const string COMMAND = "select BinData from `SlashAndTowerCfg` where Season=?";

		// Token: 0x04004121 RID: 16673
		private const string KEY_PREFIX = "SlashAndTowerCfgBySeason";

		// Token: 0x04004122 RID: 16674
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004123 RID: 16675
		private static int HandleId;
	}
}
