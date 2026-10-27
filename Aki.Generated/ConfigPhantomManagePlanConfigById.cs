using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A8 RID: 1704
	public class ConfigPhantomManagePlanConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002800 RID: 10240 RVA: 0x0013BCE7 File Offset: 0x00139EE7
		static ConfigPhantomManagePlanConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomManagePlanConfigById.CreateStaticDefaultValue), new Action(ConfigPhantomManagePlanConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x0013BD08 File Offset: 0x00139F08
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

		// Token: 0x06002802 RID: 10242 RVA: 0x0013BD87 File Offset: 0x00139F87
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomManagePlanConfigById.LogPair = null;
			ConfigPhantomManagePlanConfigById.HandleId = 0;
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x0013BD95 File Offset: 0x00139F95
		public static void Init()
		{
			ConfigPhantomManagePlanConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomManagePlanConfigById.HandleId, "db_phantommanageplan.db", "select BinData from `PhantomManagePlanConfig` where Id=?");
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x0013BDB0 File Offset: 0x00139FB0
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

		// Token: 0x04002E7E RID: 11902
		private const string DB = "db_phantommanageplan.db";

		// Token: 0x04002E7F RID: 11903
		private const string FILE = "s.声骸管理方案.xlsx";

		// Token: 0x04002E80 RID: 11904
		private const string TABLE = "PhantomManagePlanConfig";

		// Token: 0x04002E81 RID: 11905
		private const string COMMAND = "select BinData from `PhantomManagePlanConfig` where Id=?";

		// Token: 0x04002E82 RID: 11906
		private const string KEY_PREFIX = "PhantomManagePlanConfigById";

		// Token: 0x04002E83 RID: 11907
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E84 RID: 11908
		private static int HandleId;
	}
}
