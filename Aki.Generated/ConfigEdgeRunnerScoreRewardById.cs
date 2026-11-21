using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000262 RID: 610
	public class ConfigEdgeRunnerScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E50 RID: 3664 RVA: 0x000ADEF8 File Offset: 0x000AC0F8
		static ConfigEdgeRunnerScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerScoreRewardById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x000ADF18 File Offset: 0x000AC118
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

		// Token: 0x06000E52 RID: 3666 RVA: 0x000ADF97 File Offset: 0x000AC197
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerScoreRewardById.LogPair = null;
			ConfigEdgeRunnerScoreRewardById.HandleId = 0;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000ADFA5 File Offset: 0x000AC1A5
		public static void Init()
		{
			ConfigEdgeRunnerScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerScoreRewardById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerScoreReward` where Id=?");
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000ADFC0 File Offset: 0x000AC1C0
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

		// Token: 0x04001092 RID: 4242
		private const string DB = "db_edgerunner.db";

		// Token: 0x04001093 RID: 4243
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04001094 RID: 4244
		private const string TABLE = "EdgeRunnerScoreReward";

		// Token: 0x04001095 RID: 4245
		private const string COMMAND = "select BinData from `EdgeRunnerScoreReward` where Id=?";

		// Token: 0x04001096 RID: 4246
		private const string KEY_PREFIX = "EdgeRunnerScoreRewardById";

		// Token: 0x04001097 RID: 4247
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001098 RID: 4248
		private static int HandleId;
	}
}
