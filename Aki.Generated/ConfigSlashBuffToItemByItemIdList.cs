using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A3 RID: 2467
	public class ConfigSlashBuffToItemByItemIdList : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039E5 RID: 14821 RVA: 0x001A4129 File Offset: 0x001A2329
		static ConfigSlashBuffToItemByItemIdList()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemByItemIdList.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemByItemIdList.ResetStaticDefaultValue));
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x001A4148 File Offset: 0x001A2348
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

		// Token: 0x060039E7 RID: 14823 RVA: 0x001A41C7 File Offset: 0x001A23C7
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemByItemIdList.LogPair = null;
			ConfigSlashBuffToItemByItemIdList.HandleId = 0;
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x001A41D5 File Offset: 0x001A23D5
		public static void Init()
		{
			ConfigSlashBuffToItemByItemIdList.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemByItemIdList.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem` where ItemId=?");
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x001A41F0 File Offset: 0x001A23F0
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

		// Token: 0x0400435B RID: 17243
		private const string DB = "db_shiptower.db";

		// Token: 0x0400435C RID: 17244
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x0400435D RID: 17245
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x0400435E RID: 17246
		private const string COMMAND = "select BinData from `SlashBuffToItem` where ItemId=?";

		// Token: 0x0400435F RID: 17247
		private const string KEY_PREFIX = "SlashBuffToItemByItemIdList";

		// Token: 0x04004360 RID: 17248
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004361 RID: 17249
		private static int HandleId;
	}
}
