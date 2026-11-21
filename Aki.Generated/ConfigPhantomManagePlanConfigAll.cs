using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BF RID: 1727
	public class ConfigPhantomManagePlanConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600288A RID: 10378 RVA: 0x001425D0 File Offset: 0x001407D0
		static ConfigPhantomManagePlanConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomManagePlanConfigAll.CreateStaticDefaultValue), new Action(ConfigPhantomManagePlanConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x001425F0 File Offset: 0x001407F0
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

		// Token: 0x0600288C RID: 10380 RVA: 0x0014266F File Offset: 0x0014086F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomManagePlanConfigAll.LogPair = null;
			ConfigPhantomManagePlanConfigAll.HandleId = 0;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0014267D File Offset: 0x0014087D
		public static void Init()
		{
			ConfigPhantomManagePlanConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomManagePlanConfigAll.HandleId, "db_phantommanageplan.db", "select BinData from `PhantomManagePlanConfig`");
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x00142698 File Offset: 0x00140898
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

		// Token: 0x04002F1F RID: 12063
		private const string DB = "db_phantommanageplan.db";

		// Token: 0x04002F20 RID: 12064
		private const string FILE = "s.声骸管理方案.xlsx";

		// Token: 0x04002F21 RID: 12065
		private const string TABLE = "PhantomManagePlanConfig";

		// Token: 0x04002F22 RID: 12066
		private const string COMMAND = "select BinData from `PhantomManagePlanConfig`";

		// Token: 0x04002F23 RID: 12067
		private const string KEY_PREFIX = "PhantomManagePlanConfigAll";

		// Token: 0x04002F24 RID: 12068
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F25 RID: 12069
		private static int HandleId;
	}
}
