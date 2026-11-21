using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000267 RID: 615
	public class ConfigEdgeRunnerTrialById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E6E RID: 3694 RVA: 0x000AE98B File Offset: 0x000ACB8B
		static ConfigEdgeRunnerTrialById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerTrialById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerTrialById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x000AE9AC File Offset: 0x000ACBAC
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerTrialById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerTrialById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerTrial"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerTrial` where Id=?")
			});
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x000AEA2B File Offset: 0x000ACC2B
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerTrialById.LogPair = null;
			ConfigEdgeRunnerTrialById.HandleId = 0;
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x000AEA39 File Offset: 0x000ACC39
		public static void Init()
		{
			ConfigEdgeRunnerTrialById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerTrialById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerTrial` where Id=?");
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000AEA54 File Offset: 0x000ACC54
		public static EdgeRunnerTrial? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerTrialById.HandleId, ConfigEdgeRunnerTrialById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerTrialById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EdgeRunnerTrial?(EdgeRunnerTrial.GetRootAsEdgeRunnerTrial(configBuffer));
				}
			}
			ConfigEdgeRunnerTrialById.LogPair.Clear();
			ConfigEdgeRunnerTrialById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerTrialById.HandleId, 1, p0Id, ConfigEdgeRunnerTrialById.LogPair) || ConfigCommon.Step(ConfigEdgeRunnerTrialById.HandleId, true, ConfigEdgeRunnerTrialById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerTrialById.HandleId, ConfigEdgeRunnerTrialById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerTrialById.HandleId, 0, ConfigEdgeRunnerTrialById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerTrialById.HandleId, ConfigEdgeRunnerTrialById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EdgeRunnerTrial rootAsEdgeRunnerTrial = EdgeRunnerTrial.GetRootAsEdgeRunnerTrial(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerTrialById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerTrialById.HandleId, ConfigEdgeRunnerTrialById.LogPair);
			return new EdgeRunnerTrial?(rootAsEdgeRunnerTrial);
		}

		// Token: 0x040010B5 RID: 4277
		private const string DB = "db_edgerunner.db";

		// Token: 0x040010B6 RID: 4278
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x040010B7 RID: 4279
		private const string TABLE = "EdgeRunnerTrial";

		// Token: 0x040010B8 RID: 4280
		private const string COMMAND = "select BinData from `EdgeRunnerTrial` where Id=?";

		// Token: 0x040010B9 RID: 4281
		private const string KEY_PREFIX = "EdgeRunnerTrialById";

		// Token: 0x040010BA RID: 4282
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010BB RID: 4283
		private static int HandleId;
	}
}
