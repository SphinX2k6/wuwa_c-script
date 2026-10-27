using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024D RID: 589
	public class ConfigEdgeRunnerRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DD2 RID: 3538 RVA: 0x000A79EB File Offset: 0x000A5BEB
		static ConfigEdgeRunnerRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerRewardById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000A7A0C File Offset: 0x000A5C0C
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

		// Token: 0x06000DD4 RID: 3540 RVA: 0x000A7A8B File Offset: 0x000A5C8B
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerRewardById.LogPair = null;
			ConfigEdgeRunnerRewardById.HandleId = 0;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000A7A99 File Offset: 0x000A5C99
		public static void Init()
		{
			ConfigEdgeRunnerRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerRewardById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerReward` where Id=?");
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000A7AB4 File Offset: 0x000A5CB4
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

		// Token: 0x04000FFF RID: 4095
		private const string DB = "db_edgerunner.db";

		// Token: 0x04001000 RID: 4096
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04001001 RID: 4097
		private const string TABLE = "EdgeRunnerReward";

		// Token: 0x04001002 RID: 4098
		private const string COMMAND = "select BinData from `EdgeRunnerReward` where Id=?";

		// Token: 0x04001003 RID: 4099
		private const string KEY_PREFIX = "EdgeRunnerRewardById";

		// Token: 0x04001004 RID: 4100
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001005 RID: 4101
		private static int HandleId;
	}
}
