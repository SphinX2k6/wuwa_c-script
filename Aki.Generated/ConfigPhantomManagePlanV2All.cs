using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AA RID: 1706
	public class ConfigPhantomManagePlanV2All : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600280C RID: 10252 RVA: 0x0013C167 File Offset: 0x0013A367
		static ConfigPhantomManagePlanV2All()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomManagePlanV2All.CreateStaticDefaultValue), new Action(ConfigPhantomManagePlanV2All.ResetStaticDefaultValue));
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x0013C188 File Offset: 0x0013A388
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

		// Token: 0x0600280E RID: 10254 RVA: 0x0013C207 File Offset: 0x0013A407
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomManagePlanV2All.LogPair = null;
			ConfigPhantomManagePlanV2All.HandleId = 0;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0013C215 File Offset: 0x0013A415
		public static void Init()
		{
			ConfigPhantomManagePlanV2All.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomManagePlanV2All.HandleId, "db_phantommanageplan.db", "select BinData from `PhantomManagePlanV2`");
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x0013C230 File Offset: 0x0013A430
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

		// Token: 0x04002E8C RID: 11916
		private const string DB = "db_phantommanageplan.db";

		// Token: 0x04002E8D RID: 11917
		private const string FILE = "s.声骸管理方案.xlsx";

		// Token: 0x04002E8E RID: 11918
		private const string TABLE = "PhantomManagePlanV2";

		// Token: 0x04002E8F RID: 11919
		private const string COMMAND = "select BinData from `PhantomManagePlanV2`";

		// Token: 0x04002E90 RID: 11920
		private const string KEY_PREFIX = "PhantomManagePlanV2All";

		// Token: 0x04002E91 RID: 11921
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E92 RID: 11922
		private static int HandleId;
	}
}
