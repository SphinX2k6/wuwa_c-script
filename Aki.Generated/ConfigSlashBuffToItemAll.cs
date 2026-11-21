using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099F RID: 2463
	public class ConfigSlashBuffToItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039CD RID: 14797 RVA: 0x001A3868 File Offset: 0x001A1A68
		static ConfigSlashBuffToItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemAll.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x001A3888 File Offset: 0x001A1A88
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

		// Token: 0x060039CF RID: 14799 RVA: 0x001A3907 File Offset: 0x001A1B07
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemAll.LogPair = null;
			ConfigSlashBuffToItemAll.HandleId = 0;
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x001A3915 File Offset: 0x001A1B15
		public static void Init()
		{
			ConfigSlashBuffToItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemAll.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem`");
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x001A3930 File Offset: 0x001A1B30
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

		// Token: 0x0400433F RID: 17215
		private const string DB = "db_shiptower.db";

		// Token: 0x04004340 RID: 17216
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004341 RID: 17217
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x04004342 RID: 17218
		private const string COMMAND = "select BinData from `SlashBuffToItem`";

		// Token: 0x04004343 RID: 17219
		private const string KEY_PREFIX = "SlashBuffToItemAll";

		// Token: 0x04004344 RID: 17220
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004345 RID: 17221
		private static int HandleId;
	}
}
