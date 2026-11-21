using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000475 RID: 1141
	public class ConfigItemInfoByItemType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AC8 RID: 6856 RVA: 0x000F4598 File Offset: 0x000F2798
		static ConfigItemInfoByItemType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemInfoByItemType.CreateStaticDefaultValue), new Action(ConfigItemInfoByItemType.ResetStaticDefaultValue));
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x000F45B8 File Offset: 0x000F27B8
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

		// Token: 0x06001ACA RID: 6858 RVA: 0x000F4637 File Offset: 0x000F2837
		public static void ResetStaticDefaultValue()
		{
			ConfigItemInfoByItemType.LogPair = null;
			ConfigItemInfoByItemType.HandleId = 0;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x000F4645 File Offset: 0x000F2845
		public static void Init()
		{
			ConfigItemInfoByItemType.HandleId = ConfigCommon.InitDataStatement(ConfigItemInfoByItemType.HandleId, "db_item.db", "select BinData from `ItemInfo` where ItemType=?");
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x000F4660 File Offset: 0x000F2860
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

		// Token: 0x04001F17 RID: 7959
		private const string DB = "db_item.db";

		// Token: 0x04001F18 RID: 7960
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04001F19 RID: 7961
		private const string TABLE = "ItemInfo";

		// Token: 0x04001F1A RID: 7962
		private const string COMMAND = "select BinData from `ItemInfo` where ItemType=?";

		// Token: 0x04001F1B RID: 7963
		private const string KEY_PREFIX = "ItemInfoByItemType";

		// Token: 0x04001F1C RID: 7964
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F1D RID: 7965
		private static int HandleId;
	}
}
