using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C1 RID: 1729
	public class ConfigPhantomManagePlanConfigByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002896 RID: 10390 RVA: 0x001429AC File Offset: 0x00140BAC
		static ConfigPhantomManagePlanConfigByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomManagePlanConfigByType.CreateStaticDefaultValue), new Action(ConfigPhantomManagePlanConfigByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x001429CC File Offset: 0x00140BCC
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

		// Token: 0x06002898 RID: 10392 RVA: 0x00142A4B File Offset: 0x00140C4B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomManagePlanConfigByType.LogPair = null;
			ConfigPhantomManagePlanConfigByType.HandleId = 0;
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00142A59 File Offset: 0x00140C59
		public static void Init()
		{
			ConfigPhantomManagePlanConfigByType.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomManagePlanConfigByType.HandleId, "db_phantommanageplan.db", "select BinData from `PhantomManagePlanConfig` where Type=?");
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x00142A74 File Offset: 0x00140C74
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

		// Token: 0x04002F2D RID: 12077
		private const string DB = "db_phantommanageplan.db";

		// Token: 0x04002F2E RID: 12078
		private const string FILE = "s.声骸管理方案.xlsx";

		// Token: 0x04002F2F RID: 12079
		private const string TABLE = "PhantomManagePlanConfig";

		// Token: 0x04002F30 RID: 12080
		private const string COMMAND = "select BinData from `PhantomManagePlanConfig` where Type=?";

		// Token: 0x04002F31 RID: 12081
		private const string KEY_PREFIX = "PhantomManagePlanConfigByType";

		// Token: 0x04002F32 RID: 12082
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F33 RID: 12083
		private static int HandleId;
	}
}
