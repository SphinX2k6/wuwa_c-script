using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000132 RID: 306
	public class ConfigBuffEquipItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x00085D45 File Offset: 0x00083F45
		static ConfigBuffEquipItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffEquipItemByItemId.CreateStaticDefaultValue), new Action(ConfigBuffEquipItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00085D64 File Offset: 0x00083F64
		public static void CreateStaticDefaultValue()
		{
			ConfigBuffEquipItemByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuffEquipItemByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_itemattributereward.db"),
				new ValueTuple<string, object>("文件", "s.属性奖励.xlsx"),
				new ValueTuple<string, object>("表名", "BuffEquipItem"),
				new ValueTuple<string, object>("语句", "select BinData from `BuffEquipItem` where ItemId = ?")
			});
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00085DE3 File Offset: 0x00083FE3
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffEquipItemByItemId.LogPair = null;
			ConfigBuffEquipItemByItemId.HandleId = 0;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00085DF1 File Offset: 0x00083FF1
		public static void Init()
		{
			ConfigBuffEquipItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigBuffEquipItemByItemId.HandleId, "db_itemattributereward.db", "select BinData from `BuffEquipItem` where ItemId = ?");
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00085E0C File Offset: 0x0008400C
		[NullableContext(2)]
		public static IReadOnlyList<BuffEquipItem> GetConfigList(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuffEquipItemByItemId.HandleId, ConfigBuffEquipItemByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffEquipItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				IReadOnlyList<BuffEquipItem> readOnlyList = (IReadOnlyList<BuffEquipItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBuffEquipItemByItemId.LogPair.Clear();
			ConfigBuffEquipItemByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigBuffEquipItemByItemId.HandleId, 1, p0ItemId, ConfigBuffEquipItemByItemId.LogPair))
			{
				ConfigCommon.Reset(ConfigBuffEquipItemByItemId.HandleId, ConfigBuffEquipItemByItemId.LogPair);
				return null;
			}
			List<BuffEquipItem> list = new List<BuffEquipItem>();
			while (ConfigCommon.Step(ConfigBuffEquipItemByItemId.HandleId, false, ConfigBuffEquipItemByItemId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuffEquipItemByItemId.HandleId, 0, ConfigBuffEquipItemByItemId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBuffEquipItemByItemId.HandleId, ConfigBuffEquipItemByItemId.LogPair);
					return null;
				}
				BuffEquipItem rootAsBuffEquipItem = BuffEquipItem.GetRootAsBuffEquipItem(new ByteBuffer(item2));
				list.Add(rootAsBuffEquipItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffEquipItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBuffEquipItemByItemId.HandleId, ConfigBuffEquipItemByItemId.LogPair);
			return list;
		}

		// Token: 0x04000842 RID: 2114
		private const string DB = "db_itemattributereward.db";

		// Token: 0x04000843 RID: 2115
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x04000844 RID: 2116
		private const string TABLE = "BuffEquipItem";

		// Token: 0x04000845 RID: 2117
		private const string COMMAND = "select BinData from `BuffEquipItem` where ItemId = ?";

		// Token: 0x04000846 RID: 2118
		private const string KEY_PREFIX = "BuffEquipItemByItemId";

		// Token: 0x04000847 RID: 2119
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000848 RID: 2120
		private static int HandleId;
	}
}
