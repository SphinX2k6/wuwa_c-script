using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024E RID: 590
	public class ConfigEdgeRunnerScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DD8 RID: 3544 RVA: 0x000A7C34 File Offset: 0x000A5E34
		static ConfigEdgeRunnerScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerScoreRewardById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000A7C54 File Offset: 0x000A5E54
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerScoreReward` where Id=?")
			});
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000A7CD3 File Offset: 0x000A5ED3
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerScoreRewardById.LogPair = null;
			ConfigEdgeRunnerScoreRewardById.HandleId = 0;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000A7CE1 File Offset: 0x000A5EE1
		public static void Init()
		{
			ConfigEdgeRunnerScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerScoreRewardById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerScoreReward` where Id=?");
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000A7CFC File Offset: 0x000A5EFC
		public static EdgeRunnerScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerScoreRewardById.HandleId, ConfigEdgeRunnerScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EdgeRunnerScoreReward?(EdgeRunnerScoreReward.GetRootAsEdgeRunnerScoreReward(configBuffer));
				}
			}
			ConfigEdgeRunnerScoreRewardById.LogPair.Clear();
			ConfigEdgeRunnerScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerScoreRewardById.HandleId, 1, p0Id, ConfigEdgeRunnerScoreRewardById.LogPair) || ConfigCommon.Step(ConfigEdgeRunnerScoreRewardById.HandleId, true, ConfigEdgeRunnerScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerScoreRewardById.HandleId, ConfigEdgeRunnerScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerScoreRewardById.HandleId, 0, ConfigEdgeRunnerScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerScoreRewardById.HandleId, ConfigEdgeRunnerScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EdgeRunnerScoreReward rootAsEdgeRunnerScoreReward = EdgeRunnerScoreReward.GetRootAsEdgeRunnerScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerScoreRewardById.HandleId, ConfigEdgeRunnerScoreRewardById.LogPair);
			return new EdgeRunnerScoreReward?(rootAsEdgeRunnerScoreReward);
		}

		// Token: 0x04001006 RID: 4102
		private const string DB = "db_edgerunner.db";

		// Token: 0x04001007 RID: 4103
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04001008 RID: 4104
		private const string TABLE = "EdgeRunnerScoreReward";

		// Token: 0x04001009 RID: 4105
		private const string COMMAND = "select BinData from `EdgeRunnerScoreReward` where Id=?";

		// Token: 0x0400100A RID: 4106
		private const string KEY_PREFIX = "EdgeRunnerScoreRewardById";

		// Token: 0x0400100B RID: 4107
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400100C RID: 4108
		private static int HandleId;
	}
}
