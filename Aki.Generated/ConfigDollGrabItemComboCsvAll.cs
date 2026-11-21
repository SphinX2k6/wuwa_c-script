using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000222 RID: 546
	public class ConfigDollGrabItemComboCsvAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CCF RID: 3279 RVA: 0x000A5948 File Offset: 0x000A3B48
		static ConfigDollGrabItemComboCsvAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDollGrabItemComboCsvAll.CreateStaticDefaultValue), new Action(ConfigDollGrabItemComboCsvAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000A5968 File Offset: 0x000A3B68
		public static void CreateStaticDefaultValue()
		{
			ConfigDollGrabItemComboCsvAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDollGrabItemComboCsvAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dollgrabitemcombocsv.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/j.夹娃娃机物品组合/*.csv*"),
				new ValueTuple<string, object>("表名", "DollGrabItemComboCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `DollGrabItemComboCsv`")
			});
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x000A59E7 File Offset: 0x000A3BE7
		public static void ResetStaticDefaultValue()
		{
			ConfigDollGrabItemComboCsvAll.LogPair = null;
			ConfigDollGrabItemComboCsvAll.HandleId = 0;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000A59F5 File Offset: 0x000A3BF5
		public static void Init()
		{
			ConfigDollGrabItemComboCsvAll.HandleId = ConfigCommon.InitDataStatement(ConfigDollGrabItemComboCsvAll.HandleId, "db_dollgrabitemcombocsv.db", "select BinData from `DollGrabItemComboCsv`");
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000A5A10 File Offset: 0x000A3C10
		[NullableContext(2)]
		public static IReadOnlyList<DollGrabItemComboCsv> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDollGrabItemComboCsvAll.HandleId, ConfigDollGrabItemComboCsvAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DollGrabItemComboCsv> readOnlyList = (IReadOnlyList<DollGrabItemComboCsv>)ConfigCommon.GetConfig("DollGrabItemComboCsvAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DollGrabItemComboCsv> list = new List<DollGrabItemComboCsv>();
			while (ConfigCommon.Step(ConfigDollGrabItemComboCsvAll.HandleId, false, ConfigDollGrabItemComboCsvAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDollGrabItemComboCsvAll.HandleId, 0, ConfigDollGrabItemComboCsvAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDollGrabItemComboCsvAll.HandleId, ConfigDollGrabItemComboCsvAll.LogPair);
					return null;
				}
				DollGrabItemComboCsv rootAsDollGrabItemComboCsv = DollGrabItemComboCsv.GetRootAsDollGrabItemComboCsv(new ByteBuffer(item2));
				list.Add(rootAsDollGrabItemComboCsv);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DollGrabItemComboCsvAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDollGrabItemComboCsvAll.HandleId, ConfigDollGrabItemComboCsvAll.LogPair);
			return list;
		}

		// Token: 0x04000ED2 RID: 3794
		private const string DB = "db_dollgrabitemcombocsv.db";

		// Token: 0x04000ED3 RID: 3795
		private const string FILE = "k.可视化编辑/c.Csv/j.夹娃娃机物品组合/*.csv*";

		// Token: 0x04000ED4 RID: 3796
		private const string TABLE = "DollGrabItemComboCsv";

		// Token: 0x04000ED5 RID: 3797
		private const string COMMAND = "select BinData from `DollGrabItemComboCsv`";

		// Token: 0x04000ED6 RID: 3798
		private const string KEY_PREFIX = "DollGrabItemComboCsvAll";

		// Token: 0x04000ED7 RID: 3799
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ED8 RID: 3800
		private static int HandleId;
	}
}
