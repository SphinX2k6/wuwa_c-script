using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099C RID: 2460
	public class ConfigSlashAndTowerCfgBySeason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039BB RID: 14779 RVA: 0x001A31B0 File Offset: 0x001A13B0
		static ConfigSlashAndTowerCfgBySeason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashAndTowerCfgBySeason.CreateStaticDefaultValue), new Action(ConfigSlashAndTowerCfgBySeason.ResetStaticDefaultValue));
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x001A31D0 File Offset: 0x001A13D0
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

		// Token: 0x060039BD RID: 14781 RVA: 0x001A324F File Offset: 0x001A144F
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashAndTowerCfgBySeason.LogPair = null;
			ConfigSlashAndTowerCfgBySeason.HandleId = 0;
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x001A325D File Offset: 0x001A145D
		public static void Init()
		{
			ConfigSlashAndTowerCfgBySeason.HandleId = ConfigCommon.InitDataStatement(ConfigSlashAndTowerCfgBySeason.HandleId, "db_shiptower.db", "select BinData from `SlashAndTowerCfg` where Season=?");
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x001A3278 File Offset: 0x001A1478
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

		// Token: 0x0400432A RID: 17194
		private const string DB = "db_shiptower.db";

		// Token: 0x0400432B RID: 17195
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x0400432C RID: 17196
		private const string TABLE = "SlashAndTowerCfg";

		// Token: 0x0400432D RID: 17197
		private const string COMMAND = "select BinData from `SlashAndTowerCfg` where Season=?";

		// Token: 0x0400432E RID: 17198
		private const string KEY_PREFIX = "SlashAndTowerCfgBySeason";

		// Token: 0x0400432F RID: 17199
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004330 RID: 17200
		private static int HandleId;
	}
}
