using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000253 RID: 595
	public class ConfigEdgeRunnerTrialById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DF6 RID: 3574 RVA: 0x000A86C7 File Offset: 0x000A68C7
		static ConfigEdgeRunnerTrialById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerTrialById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerTrialById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x000A86E8 File Offset: 0x000A68E8
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

		// Token: 0x06000DF8 RID: 3576 RVA: 0x000A8767 File Offset: 0x000A6967
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerTrialById.LogPair = null;
			ConfigEdgeRunnerTrialById.HandleId = 0;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x000A8775 File Offset: 0x000A6975
		public static void Init()
		{
			ConfigEdgeRunnerTrialById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerTrialById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerTrial` where Id=?");
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000A8790 File Offset: 0x000A6990
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

		// Token: 0x04001029 RID: 4137
		private const string DB = "db_edgerunner.db";

		// Token: 0x0400102A RID: 4138
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x0400102B RID: 4139
		private const string TABLE = "EdgeRunnerTrial";

		// Token: 0x0400102C RID: 4140
		private const string COMMAND = "select BinData from `EdgeRunnerTrial` where Id=?";

		// Token: 0x0400102D RID: 4141
		private const string KEY_PREFIX = "EdgeRunnerTrialById";

		// Token: 0x0400102E RID: 4142
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400102F RID: 4143
		private static int HandleId;
	}
}
