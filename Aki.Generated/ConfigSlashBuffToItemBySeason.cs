using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A4 RID: 2468
	public class ConfigSlashBuffToItemBySeason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039EB RID: 14827 RVA: 0x001A435F File Offset: 0x001A255F
		static ConfigSlashBuffToItemBySeason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemBySeason.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemBySeason.ResetStaticDefaultValue));
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x001A4380 File Offset: 0x001A2580
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

		// Token: 0x060039ED RID: 14829 RVA: 0x001A43FF File Offset: 0x001A25FF
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemBySeason.LogPair = null;
			ConfigSlashBuffToItemBySeason.HandleId = 0;
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x001A440D File Offset: 0x001A260D
		public static void Init()
		{
			ConfigSlashBuffToItemBySeason.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemBySeason.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem` where Season=?");
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x001A4428 File Offset: 0x001A2628
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

		// Token: 0x04004362 RID: 17250
		private const string DB = "db_shiptower.db";

		// Token: 0x04004363 RID: 17251
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004364 RID: 17252
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x04004365 RID: 17253
		private const string COMMAND = "select BinData from `SlashBuffToItem` where Season=?";

		// Token: 0x04004366 RID: 17254
		private const string KEY_PREFIX = "SlashBuffToItemBySeason";

		// Token: 0x04004367 RID: 17255
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004368 RID: 17256
		private static int HandleId;
	}
}
