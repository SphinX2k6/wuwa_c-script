using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A9 RID: 1705
	public class ConfigPhantomManagePlanConfigByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002806 RID: 10246 RVA: 0x0013BF30 File Offset: 0x0013A130
		static ConfigPhantomManagePlanConfigByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomManagePlanConfigByType.CreateStaticDefaultValue), new Action(ConfigPhantomManagePlanConfigByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x0013BF50 File Offset: 0x0013A150
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomManagePlanConfigByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomManagePlanConfigByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantommanageplan.db"),
				new ValueTuple<string, object>("文件", "s.声骸管理方案.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomManagePlanConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomManagePlanConfig` where Type=?")
			});
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x0013BFCF File Offset: 0x0013A1CF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomManagePlanConfigByType.LogPair = null;
			ConfigPhantomManagePlanConfigByType.HandleId = 0;
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x0013BFDD File Offset: 0x0013A1DD
		public static void Init()
		{
			ConfigPhantomManagePlanConfigByType.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomManagePlanConfigByType.HandleId, "db_phantommanageplan.db", "select BinData from `PhantomManagePlanConfig` where Type=?");
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x0013BFF8 File Offset: 0x0013A1F8
		[NullableContext(2)]
		public static IReadOnlyList<PhantomManagePlanConfig> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomManagePlanConfigByType.HandleId, ConfigPhantomManagePlanConfigByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomManagePlanConfigByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<PhantomManagePlanConfig> readOnlyList = (IReadOnlyList<PhantomManagePlanConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomManagePlanConfigByType.LogPair.Clear();
			ConfigPhantomManagePlanConfigByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigPhantomManagePlanConfigByType.HandleId, 1, p0Type, ConfigPhantomManagePlanConfigByType.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomManagePlanConfigByType.HandleId, ConfigPhantomManagePlanConfigByType.LogPair);
				return null;
			}
			List<PhantomManagePlanConfig> list = new List<PhantomManagePlanConfig>();
			while (ConfigCommon.Step(ConfigPhantomManagePlanConfigByType.HandleId, false, ConfigPhantomManagePlanConfigByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomManagePlanConfigByType.HandleId, 0, ConfigPhantomManagePlanConfigByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomManagePlanConfigByType.HandleId, ConfigPhantomManagePlanConfigByType.LogPair);
					return null;
				}
				PhantomManagePlanConfig rootAsPhantomManagePlanConfig = PhantomManagePlanConfig.GetRootAsPhantomManagePlanConfig(new ByteBuffer(item2));
				list.Add(rootAsPhantomManagePlanConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomManagePlanConfigByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomManagePlanConfigByType.HandleId, ConfigPhantomManagePlanConfigByType.LogPair);
			return list;
		}

		// Token: 0x04002E85 RID: 11909
		private const string DB = "db_phantommanageplan.db";

		// Token: 0x04002E86 RID: 11910
		private const string FILE = "s.声骸管理方案.xlsx";

		// Token: 0x04002E87 RID: 11911
		private const string TABLE = "PhantomManagePlanConfig";

		// Token: 0x04002E88 RID: 11912
		private const string COMMAND = "select BinData from `PhantomManagePlanConfig` where Type=?";

		// Token: 0x04002E89 RID: 11913
		private const string KEY_PREFIX = "PhantomManagePlanConfigByType";

		// Token: 0x04002E8A RID: 11914
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E8B RID: 11915
		private static int HandleId;
	}
}
