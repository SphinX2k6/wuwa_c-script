using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000959 RID: 2393
	public class ConfigSlashBuffToItemBySeason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003829 RID: 14377 RVA: 0x0019713F File Offset: 0x0019533F
		static ConfigSlashBuffToItemBySeason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemBySeason.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemBySeason.ResetStaticDefaultValue));
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x00197160 File Offset: 0x00195360
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashBuffToItemBySeason.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashBuffToItemBySeason.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashBuffToItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashBuffToItem` where Season=?")
			});
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x001971DF File Offset: 0x001953DF
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemBySeason.LogPair = null;
			ConfigSlashBuffToItemBySeason.HandleId = 0;
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x001971ED File Offset: 0x001953ED
		public static void Init()
		{
			ConfigSlashBuffToItemBySeason.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemBySeason.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem` where Season=?");
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00197208 File Offset: 0x00195408
		[NullableContext(2)]
		public static IReadOnlyList<SlashBuffToItem> GetConfigList(int p0Season, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashBuffToItemBySeason.HandleId, ConfigSlashBuffToItemBySeason.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashBuffToItemBySeason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Season);
				IReadOnlyList<SlashBuffToItem> readOnlyList = (IReadOnlyList<SlashBuffToItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSlashBuffToItemBySeason.LogPair.Clear();
			ConfigSlashBuffToItemBySeason.LogPair.Add(new ValueTuple<string, object>("Season", p0Season));
			if (!ConfigCommon.BindInt(ConfigSlashBuffToItemBySeason.HandleId, 1, p0Season, ConfigSlashBuffToItemBySeason.LogPair))
			{
				ConfigCommon.Reset(ConfigSlashBuffToItemBySeason.HandleId, ConfigSlashBuffToItemBySeason.LogPair);
				return null;
			}
			List<SlashBuffToItem> list = new List<SlashBuffToItem>();
			while (ConfigCommon.Step(ConfigSlashBuffToItemBySeason.HandleId, false, ConfigSlashBuffToItemBySeason.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashBuffToItemBySeason.HandleId, 0, ConfigSlashBuffToItemBySeason.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSlashBuffToItemBySeason.HandleId, ConfigSlashBuffToItemBySeason.LogPair);
					return null;
				}
				SlashBuffToItem rootAsSlashBuffToItem = SlashBuffToItem.GetRootAsSlashBuffToItem(new ByteBuffer(item2));
				list.Add(rootAsSlashBuffToItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashBuffToItemBySeason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Season);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSlashBuffToItemBySeason.HandleId, ConfigSlashBuffToItemBySeason.LogPair);
			return list;
		}

		// Token: 0x04004155 RID: 16725
		private const string DB = "db_shiptower.db";

		// Token: 0x04004156 RID: 16726
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004157 RID: 16727
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x04004158 RID: 16728
		private const string COMMAND = "select BinData from `SlashBuffToItem` where Season=?";

		// Token: 0x04004159 RID: 16729
		private const string KEY_PREFIX = "SlashBuffToItemBySeason";

		// Token: 0x0400415A RID: 16730
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400415B RID: 16731
		private static int HandleId;
	}
}
