using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C2 RID: 1730
	public class ConfigPhantomManagePlanV2All : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600289C RID: 10396 RVA: 0x00142BE3 File Offset: 0x00140DE3
		static ConfigPhantomManagePlanV2All()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomManagePlanV2All.CreateStaticDefaultValue), new Action(ConfigPhantomManagePlanV2All.ResetStaticDefaultValue));
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x00142C04 File Offset: 0x00140E04
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomManagePlanV2All.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomManagePlanV2All.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantommanageplan.db"),
				new ValueTuple<string, object>("文件", "s.声骸管理方案.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomManagePlanV2"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomManagePlanV2`")
			});
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x00142C83 File Offset: 0x00140E83
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomManagePlanV2All.LogPair = null;
			ConfigPhantomManagePlanV2All.HandleId = 0;
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x00142C91 File Offset: 0x00140E91
		public static void Init()
		{
			ConfigPhantomManagePlanV2All.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomManagePlanV2All.HandleId, "db_phantommanageplan.db", "select BinData from `PhantomManagePlanV2`");
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x00142CAC File Offset: 0x00140EAC
		[NullableContext(2)]
		public static IReadOnlyList<PhantomManagePlanV2> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomManagePlanV2All.HandleId, ConfigPhantomManagePlanV2All.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomManagePlanV2> readOnlyList = (IReadOnlyList<PhantomManagePlanV2>)ConfigCommon.GetConfig("PhantomManagePlanV2All");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomManagePlanV2> list = new List<PhantomManagePlanV2>();
			while (ConfigCommon.Step(ConfigPhantomManagePlanV2All.HandleId, false, ConfigPhantomManagePlanV2All.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomManagePlanV2All.HandleId, 0, ConfigPhantomManagePlanV2All.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomManagePlanV2All.HandleId, ConfigPhantomManagePlanV2All.LogPair);
					return null;
				}
				PhantomManagePlanV2 rootAsPhantomManagePlanV = PhantomManagePlanV2.GetRootAsPhantomManagePlanV2(new ByteBuffer(item2));
				list.Add(rootAsPhantomManagePlanV);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomManagePlanV2All", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomManagePlanV2All.HandleId, ConfigPhantomManagePlanV2All.LogPair);
			return list;
		}

		// Token: 0x04002F34 RID: 12084
		private const string DB = "db_phantommanageplan.db";

		// Token: 0x04002F35 RID: 12085
		private const string FILE = "s.声骸管理方案.xlsx";

		// Token: 0x04002F36 RID: 12086
		private const string TABLE = "PhantomManagePlanV2";

		// Token: 0x04002F37 RID: 12087
		private const string COMMAND = "select BinData from `PhantomManagePlanV2`";

		// Token: 0x04002F38 RID: 12088
		private const string KEY_PREFIX = "PhantomManagePlanV2All";

		// Token: 0x04002F39 RID: 12089
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F3A RID: 12090
		private static int HandleId;
	}
}
