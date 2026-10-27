using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000958 RID: 2392
	public class ConfigSlashBuffToItemByItemIdList : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003823 RID: 14371 RVA: 0x00196F09 File Offset: 0x00195109
		static ConfigSlashBuffToItemByItemIdList()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemByItemIdList.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemByItemIdList.ResetStaticDefaultValue));
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x00196F28 File Offset: 0x00195128
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashBuffToItemByItemIdList.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashBuffToItemByItemIdList.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashBuffToItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashBuffToItem` where ItemId=?")
			});
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x00196FA7 File Offset: 0x001951A7
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemByItemIdList.LogPair = null;
			ConfigSlashBuffToItemByItemIdList.HandleId = 0;
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00196FB5 File Offset: 0x001951B5
		public static void Init()
		{
			ConfigSlashBuffToItemByItemIdList.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemByItemIdList.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem` where ItemId=?");
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00196FD0 File Offset: 0x001951D0
		[NullableContext(2)]
		public static IReadOnlyList<SlashBuffToItem> GetConfigList(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashBuffToItemByItemIdList.HandleId, ConfigSlashBuffToItemByItemIdList.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashBuffToItemByItemIdList");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				IReadOnlyList<SlashBuffToItem> readOnlyList = (IReadOnlyList<SlashBuffToItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSlashBuffToItemByItemIdList.LogPair.Clear();
			ConfigSlashBuffToItemByItemIdList.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigSlashBuffToItemByItemIdList.HandleId, 1, p0ItemId, ConfigSlashBuffToItemByItemIdList.LogPair))
			{
				ConfigCommon.Reset(ConfigSlashBuffToItemByItemIdList.HandleId, ConfigSlashBuffToItemByItemIdList.LogPair);
				return null;
			}
			List<SlashBuffToItem> list = new List<SlashBuffToItem>();
			while (ConfigCommon.Step(ConfigSlashBuffToItemByItemIdList.HandleId, false, ConfigSlashBuffToItemByItemIdList.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashBuffToItemByItemIdList.HandleId, 0, ConfigSlashBuffToItemByItemIdList.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSlashBuffToItemByItemIdList.HandleId, ConfigSlashBuffToItemByItemIdList.LogPair);
					return null;
				}
				SlashBuffToItem rootAsSlashBuffToItem = SlashBuffToItem.GetRootAsSlashBuffToItem(new ByteBuffer(item2));
				list.Add(rootAsSlashBuffToItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashBuffToItemByItemIdList");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSlashBuffToItemByItemIdList.HandleId, ConfigSlashBuffToItemByItemIdList.LogPair);
			return list;
		}

		// Token: 0x0400414E RID: 16718
		private const string DB = "db_shiptower.db";

		// Token: 0x0400414F RID: 16719
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004150 RID: 16720
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x04004151 RID: 16721
		private const string COMMAND = "select BinData from `SlashBuffToItem` where ItemId=?";

		// Token: 0x04004152 RID: 16722
		private const string KEY_PREFIX = "SlashBuffToItemByItemIdList";

		// Token: 0x04004153 RID: 16723
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004154 RID: 16724
		private static int HandleId;
	}
}
