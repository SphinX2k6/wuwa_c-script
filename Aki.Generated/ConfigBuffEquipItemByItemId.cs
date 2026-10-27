using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000123 RID: 291
	public class ConfigBuffEquipItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x000803E1 File Offset: 0x0007E5E1
		static ConfigBuffEquipItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffEquipItemByItemId.CreateStaticDefaultValue), new Action(ConfigBuffEquipItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00080400 File Offset: 0x0007E600
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

		// Token: 0x060006D5 RID: 1749 RVA: 0x0008047F File Offset: 0x0007E67F
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffEquipItemByItemId.LogPair = null;
			ConfigBuffEquipItemByItemId.HandleId = 0;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0008048D File Offset: 0x0007E68D
		public static void Init()
		{
			ConfigBuffEquipItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigBuffEquipItemByItemId.HandleId, "db_itemattributereward.db", "select BinData from `BuffEquipItem` where ItemId = ?");
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000804A8 File Offset: 0x0007E6A8
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

		// Token: 0x040007D9 RID: 2009
		private const string DB = "db_itemattributereward.db";

		// Token: 0x040007DA RID: 2010
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x040007DB RID: 2011
		private const string TABLE = "BuffEquipItem";

		// Token: 0x040007DC RID: 2012
		private const string COMMAND = "select BinData from `BuffEquipItem` where ItemId = ?";

		// Token: 0x040007DD RID: 2013
		private const string KEY_PREFIX = "BuffEquipItemByItemId";

		// Token: 0x040007DE RID: 2014
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007DF RID: 2015
		private static int HandleId;
	}
}
