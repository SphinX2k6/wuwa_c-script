using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000954 RID: 2388
	public class ConfigSlashBuffToItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600380B RID: 14347 RVA: 0x00196648 File Offset: 0x00194848
		static ConfigSlashBuffToItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemAll.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x00196668 File Offset: 0x00194868
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashBuffToItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashBuffToItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashBuffToItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashBuffToItem`")
			});
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x001966E7 File Offset: 0x001948E7
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemAll.LogPair = null;
			ConfigSlashBuffToItemAll.HandleId = 0;
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x001966F5 File Offset: 0x001948F5
		public static void Init()
		{
			ConfigSlashBuffToItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemAll.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem`");
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00196710 File Offset: 0x00194910
		[NullableContext(2)]
		public static IReadOnlyList<SlashBuffToItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashBuffToItemAll.HandleId, ConfigSlashBuffToItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SlashBuffToItem> readOnlyList = (IReadOnlyList<SlashBuffToItem>)ConfigCommon.GetConfig("SlashBuffToItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SlashBuffToItem> list = new List<SlashBuffToItem>();
			while (ConfigCommon.Step(ConfigSlashBuffToItemAll.HandleId, false, ConfigSlashBuffToItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashBuffToItemAll.HandleId, 0, ConfigSlashBuffToItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSlashBuffToItemAll.HandleId, ConfigSlashBuffToItemAll.LogPair);
					return null;
				}
				SlashBuffToItem rootAsSlashBuffToItem = SlashBuffToItem.GetRootAsSlashBuffToItem(new ByteBuffer(item2));
				list.Add(rootAsSlashBuffToItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SlashBuffToItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSlashBuffToItemAll.HandleId, ConfigSlashBuffToItemAll.LogPair);
			return list;
		}

		// Token: 0x04004132 RID: 16690
		private const string DB = "db_shiptower.db";

		// Token: 0x04004133 RID: 16691
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004134 RID: 16692
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x04004135 RID: 16693
		private const string COMMAND = "select BinData from `SlashBuffToItem`";

		// Token: 0x04004136 RID: 16694
		private const string KEY_PREFIX = "SlashBuffToItemAll";

		// Token: 0x04004137 RID: 16695
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004138 RID: 16696
		private static int HandleId;
	}
}
