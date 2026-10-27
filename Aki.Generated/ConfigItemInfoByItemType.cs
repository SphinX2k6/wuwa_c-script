using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045F RID: 1119
	public class ConfigItemInfoByItemType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A44 RID: 6724 RVA: 0x000EDE44 File Offset: 0x000EC044
		static ConfigItemInfoByItemType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemInfoByItemType.CreateStaticDefaultValue), new Action(ConfigItemInfoByItemType.ResetStaticDefaultValue));
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x000EDE64 File Offset: 0x000EC064
		public static void CreateStaticDefaultValue()
		{
			ConfigItemInfoByItemType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemInfoByItemType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "ItemInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemInfo` where ItemType=?")
			});
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x000EDEE3 File Offset: 0x000EC0E3
		public static void ResetStaticDefaultValue()
		{
			ConfigItemInfoByItemType.LogPair = null;
			ConfigItemInfoByItemType.HandleId = 0;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x000EDEF1 File Offset: 0x000EC0F1
		public static void Init()
		{
			ConfigItemInfoByItemType.HandleId = ConfigCommon.InitDataStatement(ConfigItemInfoByItemType.HandleId, "db_item.db", "select BinData from `ItemInfo` where ItemType=?");
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x000EDF0C File Offset: 0x000EC10C
		[NullableContext(2)]
		public static IReadOnlyList<ItemInfo> GetConfigList(int p0ItemType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemInfoByItemType.HandleId, ConfigItemInfoByItemType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemInfoByItemType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemType);
				IReadOnlyList<ItemInfo> readOnlyList = (IReadOnlyList<ItemInfo>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigItemInfoByItemType.LogPair.Clear();
			ConfigItemInfoByItemType.LogPair.Add(new ValueTuple<string, object>("ItemType", p0ItemType));
			if (!ConfigCommon.BindInt(ConfigItemInfoByItemType.HandleId, 1, p0ItemType, ConfigItemInfoByItemType.LogPair))
			{
				ConfigCommon.Reset(ConfigItemInfoByItemType.HandleId, ConfigItemInfoByItemType.LogPair);
				return null;
			}
			List<ItemInfo> list = new List<ItemInfo>();
			while (ConfigCommon.Step(ConfigItemInfoByItemType.HandleId, false, ConfigItemInfoByItemType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemInfoByItemType.HandleId, 0, ConfigItemInfoByItemType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigItemInfoByItemType.HandleId, ConfigItemInfoByItemType.LogPair);
					return null;
				}
				ItemInfo rootAsItemInfo = ItemInfo.GetRootAsItemInfo(new ByteBuffer(item2));
				list.Add(rootAsItemInfo);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemInfoByItemType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigItemInfoByItemType.HandleId, ConfigItemInfoByItemType.LogPair);
			return list;
		}

		// Token: 0x04001E7D RID: 7805
		private const string DB = "db_item.db";

		// Token: 0x04001E7E RID: 7806
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04001E7F RID: 7807
		private const string TABLE = "ItemInfo";

		// Token: 0x04001E80 RID: 7808
		private const string COMMAND = "select BinData from `ItemInfo` where ItemType=?";

		// Token: 0x04001E81 RID: 7809
		private const string KEY_PREFIX = "ItemInfoByItemType";

		// Token: 0x04001E82 RID: 7810
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E83 RID: 7811
		private static int HandleId;
	}
}
