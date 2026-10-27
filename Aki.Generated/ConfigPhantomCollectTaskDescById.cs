using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068C RID: 1676
	public class ConfigPhantomCollectTaskDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002758 RID: 10072 RVA: 0x00138304 File Offset: 0x00136504
		static ConfigPhantomCollectTaskDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomCollectTaskDescById.CreateStaticDefaultValue), new Action(ConfigPhantomCollectTaskDescById.ResetStaticDefaultValue));
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00138324 File Offset: 0x00136524
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomCollectTaskDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomCollectTaskDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantomcollectactivity.db"),
				new ValueTuple<string, object>("文件", "s.声骸收集活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomCollectTaskDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomCollectTaskDesc` where Id=?")
			});
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x001383A3 File Offset: 0x001365A3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomCollectTaskDescById.LogPair = null;
			ConfigPhantomCollectTaskDescById.HandleId = 0;
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x001383B1 File Offset: 0x001365B1
		public static void Init()
		{
			ConfigPhantomCollectTaskDescById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomCollectTaskDescById.HandleId, "db_phantomcollectactivity.db", "select BinData from `PhantomCollectTaskDesc` where Id=?");
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x001383CC File Offset: 0x001365CC
		public static PhantomCollectTaskDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomCollectTaskDescById.HandleId, ConfigPhantomCollectTaskDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomCollectTaskDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomCollectTaskDesc?(PhantomCollectTaskDesc.GetRootAsPhantomCollectTaskDesc(configBuffer));
				}
			}
			ConfigPhantomCollectTaskDescById.LogPair.Clear();
			ConfigPhantomCollectTaskDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomCollectTaskDescById.HandleId, 1, p0Id, ConfigPhantomCollectTaskDescById.LogPair) || ConfigCommon.Step(ConfigPhantomCollectTaskDescById.HandleId, true, ConfigPhantomCollectTaskDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomCollectTaskDescById.HandleId, ConfigPhantomCollectTaskDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomCollectTaskDescById.HandleId, 0, ConfigPhantomCollectTaskDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomCollectTaskDescById.HandleId, ConfigPhantomCollectTaskDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomCollectTaskDesc rootAsPhantomCollectTaskDesc = PhantomCollectTaskDesc.GetRootAsPhantomCollectTaskDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomCollectTaskDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomCollectTaskDescById.HandleId, ConfigPhantomCollectTaskDescById.LogPair);
			return new PhantomCollectTaskDesc?(rootAsPhantomCollectTaskDesc);
		}

		// Token: 0x04002DBA RID: 11706
		private const string DB = "db_phantomcollectactivity.db";

		// Token: 0x04002DBB RID: 11707
		private const string FILE = "s.声骸收集活动.xlsx";

		// Token: 0x04002DBC RID: 11708
		private const string TABLE = "PhantomCollectTaskDesc";

		// Token: 0x04002DBD RID: 11709
		private const string COMMAND = "select BinData from `PhantomCollectTaskDesc` where Id=?";

		// Token: 0x04002DBE RID: 11710
		private const string KEY_PREFIX = "PhantomCollectTaskDescById";

		// Token: 0x04002DBF RID: 11711
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DC0 RID: 11712
		private static int HandleId;
	}
}
