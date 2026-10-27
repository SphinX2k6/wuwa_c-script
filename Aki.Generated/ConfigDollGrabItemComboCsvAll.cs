using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000210 RID: 528
	public class ConfigDollGrabItemComboCsvAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C63 RID: 3171 RVA: 0x0009FA10 File Offset: 0x0009DC10
		static ConfigDollGrabItemComboCsvAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDollGrabItemComboCsvAll.CreateStaticDefaultValue), new Action(ConfigDollGrabItemComboCsvAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0009FA30 File Offset: 0x0009DC30
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

		// Token: 0x06000C65 RID: 3173 RVA: 0x0009FAAF File Offset: 0x0009DCAF
		public static void ResetStaticDefaultValue()
		{
			ConfigDollGrabItemComboCsvAll.LogPair = null;
			ConfigDollGrabItemComboCsvAll.HandleId = 0;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0009FABD File Offset: 0x0009DCBD
		public static void Init()
		{
			ConfigDollGrabItemComboCsvAll.HandleId = ConfigCommon.InitDataStatement(ConfigDollGrabItemComboCsvAll.HandleId, "db_dollgrabitemcombocsv.db", "select BinData from `DollGrabItemComboCsv`");
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0009FAD8 File Offset: 0x0009DCD8
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

		// Token: 0x04000E54 RID: 3668
		private const string DB = "db_dollgrabitemcombocsv.db";

		// Token: 0x04000E55 RID: 3669
		private const string FILE = "k.可视化编辑/c.Csv/j.夹娃娃机物品组合/*.csv*";

		// Token: 0x04000E56 RID: 3670
		private const string TABLE = "DollGrabItemComboCsv";

		// Token: 0x04000E57 RID: 3671
		private const string COMMAND = "select BinData from `DollGrabItemComboCsv`";

		// Token: 0x04000E58 RID: 3672
		private const string KEY_PREFIX = "DollGrabItemComboCsvAll";

		// Token: 0x04000E59 RID: 3673
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E5A RID: 3674
		private static int HandleId;
	}
}
