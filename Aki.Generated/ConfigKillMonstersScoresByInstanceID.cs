using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000471 RID: 1137
	public class ConfigKillMonstersScoresByInstanceID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AB0 RID: 6832 RVA: 0x000F0444 File Offset: 0x000EE644
		static ConfigKillMonstersScoresByInstanceID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKillMonstersScoresByInstanceID.CreateStaticDefaultValue), new Action(ConfigKillMonstersScoresByInstanceID.ResetStaticDefaultValue));
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000F0464 File Offset: 0x000EE664
		public static void CreateStaticDefaultValue()
		{
			ConfigKillMonstersScoresByInstanceID.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKillMonstersScoresByInstanceID.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_takeweeds.db"),
				new ValueTuple<string, object>("文件", "g.割草活动.xlsx"),
				new ValueTuple<string, object>("表名", "KillMonstersScores"),
				new ValueTuple<string, object>("语句", "select BinData from `KillMonstersScores` where InstanceID=?")
			});
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x000F04E3 File Offset: 0x000EE6E3
		public static void ResetStaticDefaultValue()
		{
			ConfigKillMonstersScoresByInstanceID.LogPair = null;
			ConfigKillMonstersScoresByInstanceID.HandleId = 0;
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000F04F1 File Offset: 0x000EE6F1
		public static void Init()
		{
			ConfigKillMonstersScoresByInstanceID.HandleId = ConfigCommon.InitDataStatement(ConfigKillMonstersScoresByInstanceID.HandleId, "db_takeweeds.db", "select BinData from `KillMonstersScores` where InstanceID=?");
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000F050C File Offset: 0x000EE70C
		public static KillMonstersScores? GetConfig(int p0InstanceID, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKillMonstersScoresByInstanceID.HandleId, ConfigKillMonstersScoresByInstanceID.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KillMonstersScoresByInstanceID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceID);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KillMonstersScores?(KillMonstersScores.GetRootAsKillMonstersScores(configBuffer));
				}
			}
			ConfigKillMonstersScoresByInstanceID.LogPair.Clear();
			ConfigKillMonstersScoresByInstanceID.LogPair.Add(new ValueTuple<string, object>("InstanceID", p0InstanceID));
			if (!ConfigCommon.BindInt(ConfigKillMonstersScoresByInstanceID.HandleId, 1, p0InstanceID, ConfigKillMonstersScoresByInstanceID.LogPair) || ConfigCommon.Step(ConfigKillMonstersScoresByInstanceID.HandleId, true, ConfigKillMonstersScoresByInstanceID.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKillMonstersScoresByInstanceID.HandleId, ConfigKillMonstersScoresByInstanceID.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKillMonstersScoresByInstanceID.HandleId, 0, ConfigKillMonstersScoresByInstanceID.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKillMonstersScoresByInstanceID.HandleId, ConfigKillMonstersScoresByInstanceID.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KillMonstersScores rootAsKillMonstersScores = KillMonstersScores.GetRootAsKillMonstersScores(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KillMonstersScoresByInstanceID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceID);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKillMonstersScoresByInstanceID.HandleId, ConfigKillMonstersScoresByInstanceID.LogPair);
			return new KillMonstersScores?(rootAsKillMonstersScores);
		}

		// Token: 0x04001EFB RID: 7931
		private const string DB = "db_takeweeds.db";

		// Token: 0x04001EFC RID: 7932
		private const string FILE = "g.割草活动.xlsx";

		// Token: 0x04001EFD RID: 7933
		private const string TABLE = "KillMonstersScores";

		// Token: 0x04001EFE RID: 7934
		private const string COMMAND = "select BinData from `KillMonstersScores` where InstanceID=?";

		// Token: 0x04001EFF RID: 7935
		private const string KEY_PREFIX = "KillMonstersScoresByInstanceID";

		// Token: 0x04001F00 RID: 7936
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F01 RID: 7937
		private static int HandleId;
	}
}
