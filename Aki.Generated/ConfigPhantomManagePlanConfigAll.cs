using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A7 RID: 1703
	public class ConfigPhantomManagePlanConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027FA RID: 10234 RVA: 0x0013BB54 File Offset: 0x00139D54
		static ConfigPhantomManagePlanConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomManagePlanConfigAll.CreateStaticDefaultValue), new Action(ConfigPhantomManagePlanConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x0013BB74 File Offset: 0x00139D74
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomManagePlanConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomManagePlanConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantommanageplan.db"),
				new ValueTuple<string, object>("文件", "s.声骸管理方案.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomManagePlanConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomManagePlanConfig`")
			});
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x0013BBF3 File Offset: 0x00139DF3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomManagePlanConfigAll.LogPair = null;
			ConfigPhantomManagePlanConfigAll.HandleId = 0;
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x0013BC01 File Offset: 0x00139E01
		public static void Init()
		{
			ConfigPhantomManagePlanConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomManagePlanConfigAll.HandleId, "db_phantommanageplan.db", "select BinData from `PhantomManagePlanConfig`");
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x0013BC1C File Offset: 0x00139E1C
		[NullableContext(2)]
		public static IReadOnlyList<PhantomManagePlanConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomManagePlanConfigAll.HandleId, ConfigPhantomManagePlanConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomManagePlanConfig> readOnlyList = (IReadOnlyList<PhantomManagePlanConfig>)ConfigCommon.GetConfig("PhantomManagePlanConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomManagePlanConfig> list = new List<PhantomManagePlanConfig>();
			while (ConfigCommon.Step(ConfigPhantomManagePlanConfigAll.HandleId, false, ConfigPhantomManagePlanConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomManagePlanConfigAll.HandleId, 0, ConfigPhantomManagePlanConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomManagePlanConfigAll.HandleId, ConfigPhantomManagePlanConfigAll.LogPair);
					return null;
				}
				PhantomManagePlanConfig rootAsPhantomManagePlanConfig = PhantomManagePlanConfig.GetRootAsPhantomManagePlanConfig(new ByteBuffer(item2));
				list.Add(rootAsPhantomManagePlanConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomManagePlanConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomManagePlanConfigAll.HandleId, ConfigPhantomManagePlanConfigAll.LogPair);
			return list;
		}

		// Token: 0x04002E77 RID: 11895
		private const string DB = "db_phantommanageplan.db";

		// Token: 0x04002E78 RID: 11896
		private const string FILE = "s.声骸管理方案.xlsx";

		// Token: 0x04002E79 RID: 11897
		private const string TABLE = "PhantomManagePlanConfig";

		// Token: 0x04002E7A RID: 11898
		private const string COMMAND = "select BinData from `PhantomManagePlanConfig`";

		// Token: 0x04002E7B RID: 11899
		private const string KEY_PREFIX = "PhantomManagePlanConfigAll";

		// Token: 0x04002E7C RID: 11900
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E7D RID: 11901
		private static int HandleId;
	}
}
