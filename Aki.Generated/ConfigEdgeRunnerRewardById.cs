using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000261 RID: 609
	public class ConfigEdgeRunnerRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E4A RID: 3658 RVA: 0x000ADCAF File Offset: 0x000ABEAF
		static ConfigEdgeRunnerRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerRewardById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000ADCD0 File Offset: 0x000ABED0
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerReward"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerReward` where Id=?")
			});
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000ADD4F File Offset: 0x000ABF4F
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerRewardById.LogPair = null;
			ConfigEdgeRunnerRewardById.HandleId = 0;
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000ADD5D File Offset: 0x000ABF5D
		public static void Init()
		{
			ConfigEdgeRunnerRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerRewardById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerReward` where Id=?");
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000ADD78 File Offset: 0x000ABF78
		public static EdgeRunnerReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerRewardById.HandleId, ConfigEdgeRunnerRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EdgeRunnerReward?(EdgeRunnerReward.GetRootAsEdgeRunnerReward(configBuffer));
				}
			}
			ConfigEdgeRunnerRewardById.LogPair.Clear();
			ConfigEdgeRunnerRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerRewardById.HandleId, 1, p0Id, ConfigEdgeRunnerRewardById.LogPair) || ConfigCommon.Step(ConfigEdgeRunnerRewardById.HandleId, true, ConfigEdgeRunnerRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerRewardById.HandleId, ConfigEdgeRunnerRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerRewardById.HandleId, 0, ConfigEdgeRunnerRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerRewardById.HandleId, ConfigEdgeRunnerRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EdgeRunnerReward rootAsEdgeRunnerReward = EdgeRunnerReward.GetRootAsEdgeRunnerReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerRewardById.HandleId, ConfigEdgeRunnerRewardById.LogPair);
			return new EdgeRunnerReward?(rootAsEdgeRunnerReward);
		}

		// Token: 0x0400108B RID: 4235
		private const string DB = "db_edgerunner.db";

		// Token: 0x0400108C RID: 4236
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x0400108D RID: 4237
		private const string TABLE = "EdgeRunnerReward";

		// Token: 0x0400108E RID: 4238
		private const string COMMAND = "select BinData from `EdgeRunnerReward` where Id=?";

		// Token: 0x0400108F RID: 4239
		private const string KEY_PREFIX = "EdgeRunnerRewardById";

		// Token: 0x04001090 RID: 4240
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001091 RID: 4241
		private static int HandleId;
	}
}
