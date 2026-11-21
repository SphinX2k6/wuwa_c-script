using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C0 RID: 1728
	public class ConfigPhantomManagePlanConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002890 RID: 10384 RVA: 0x00142763 File Offset: 0x00140963
		static ConfigPhantomManagePlanConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomManagePlanConfigById.CreateStaticDefaultValue), new Action(ConfigPhantomManagePlanConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00142784 File Offset: 0x00140984
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomManagePlanConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomManagePlanConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantommanageplan.db"),
				new ValueTuple<string, object>("文件", "s.声骸管理方案.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomManagePlanConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomManagePlanConfig` where Id=?")
			});
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x00142803 File Offset: 0x00140A03
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomManagePlanConfigById.LogPair = null;
			ConfigPhantomManagePlanConfigById.HandleId = 0;
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00142811 File Offset: 0x00140A11
		public static void Init()
		{
			ConfigPhantomManagePlanConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomManagePlanConfigById.HandleId, "db_phantommanageplan.db", "select BinData from `PhantomManagePlanConfig` where Id=?");
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x0014282C File Offset: 0x00140A2C
		public static PhantomManagePlanConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomManagePlanConfigById.HandleId, ConfigPhantomManagePlanConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomManagePlanConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomManagePlanConfig?(PhantomManagePlanConfig.GetRootAsPhantomManagePlanConfig(configBuffer));
				}
			}
			ConfigPhantomManagePlanConfigById.LogPair.Clear();
			ConfigPhantomManagePlanConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomManagePlanConfigById.HandleId, 1, p0Id, ConfigPhantomManagePlanConfigById.LogPair) || ConfigCommon.Step(ConfigPhantomManagePlanConfigById.HandleId, true, ConfigPhantomManagePlanConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomManagePlanConfigById.HandleId, ConfigPhantomManagePlanConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomManagePlanConfigById.HandleId, 0, ConfigPhantomManagePlanConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomManagePlanConfigById.HandleId, ConfigPhantomManagePlanConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomManagePlanConfig rootAsPhantomManagePlanConfig = PhantomManagePlanConfig.GetRootAsPhantomManagePlanConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomManagePlanConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomManagePlanConfigById.HandleId, ConfigPhantomManagePlanConfigById.LogPair);
			return new PhantomManagePlanConfig?(rootAsPhantomManagePlanConfig);
		}

		// Token: 0x04002F26 RID: 12070
		private const string DB = "db_phantommanageplan.db";

		// Token: 0x04002F27 RID: 12071
		private const string FILE = "s.声骸管理方案.xlsx";

		// Token: 0x04002F28 RID: 12072
		private const string TABLE = "PhantomManagePlanConfig";

		// Token: 0x04002F29 RID: 12073
		private const string COMMAND = "select BinData from `PhantomManagePlanConfig` where Id=?";

		// Token: 0x04002F2A RID: 12074
		private const string KEY_PREFIX = "PhantomManagePlanConfigById";

		// Token: 0x04002F2B RID: 12075
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F2C RID: 12076
		private static int HandleId;
	}
}
