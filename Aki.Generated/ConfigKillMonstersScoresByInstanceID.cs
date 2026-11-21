using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000487 RID: 1159
	public class ConfigKillMonstersScoresByInstanceID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B34 RID: 6964 RVA: 0x000F6B98 File Offset: 0x000F4D98
		static ConfigKillMonstersScoresByInstanceID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKillMonstersScoresByInstanceID.CreateStaticDefaultValue), new Action(ConfigKillMonstersScoresByInstanceID.ResetStaticDefaultValue));
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000F6BB8 File Offset: 0x000F4DB8
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

		// Token: 0x06001B36 RID: 6966 RVA: 0x000F6C37 File Offset: 0x000F4E37
		public static void ResetStaticDefaultValue()
		{
			ConfigKillMonstersScoresByInstanceID.LogPair = null;
			ConfigKillMonstersScoresByInstanceID.HandleId = 0;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000F6C45 File Offset: 0x000F4E45
		public static void Init()
		{
			ConfigKillMonstersScoresByInstanceID.HandleId = ConfigCommon.InitDataStatement(ConfigKillMonstersScoresByInstanceID.HandleId, "db_takeweeds.db", "select BinData from `KillMonstersScores` where InstanceID=?");
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000F6C60 File Offset: 0x000F4E60
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

		// Token: 0x04001F95 RID: 8085
		private const string DB = "db_takeweeds.db";

		// Token: 0x04001F96 RID: 8086
		private const string FILE = "g.割草活动.xlsx";

		// Token: 0x04001F97 RID: 8087
		private const string TABLE = "KillMonstersScores";

		// Token: 0x04001F98 RID: 8088
		private const string COMMAND = "select BinData from `KillMonstersScores` where InstanceID=?";

		// Token: 0x04001F99 RID: 8089
		private const string KEY_PREFIX = "KillMonstersScoresByInstanceID";

		// Token: 0x04001F9A RID: 8090
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F9B RID: 8091
		private static int HandleId;
	}
}
