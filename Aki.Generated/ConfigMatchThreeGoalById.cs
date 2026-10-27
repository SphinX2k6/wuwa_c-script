using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000532 RID: 1330
	public class ConfigMatchThreeGoalById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F37 RID: 7991 RVA: 0x00109BCC File Offset: 0x00107DCC
		static ConfigMatchThreeGoalById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeGoalById.CreateStaticDefaultValue), new Action(ConfigMatchThreeGoalById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00109BEC File Offset: 0x00107DEC
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeGoalById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeGoalById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeGoal"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeGoal` where Id=?")
			});
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00109C6B File Offset: 0x00107E6B
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeGoalById.LogPair = null;
			ConfigMatchThreeGoalById.HandleId = 0;
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00109C79 File Offset: 0x00107E79
		public static void Init()
		{
			ConfigMatchThreeGoalById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeGoalById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeGoal` where Id=?");
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00109C94 File Offset: 0x00107E94
		public static MatchThreeGoal? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeGoalById.HandleId, ConfigMatchThreeGoalById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeGoalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeGoal?(MatchThreeGoal.GetRootAsMatchThreeGoal(configBuffer));
				}
			}
			ConfigMatchThreeGoalById.LogPair.Clear();
			ConfigMatchThreeGoalById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeGoalById.HandleId, 1, p0Id, ConfigMatchThreeGoalById.LogPair) || ConfigCommon.Step(ConfigMatchThreeGoalById.HandleId, true, ConfigMatchThreeGoalById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeGoalById.HandleId, ConfigMatchThreeGoalById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeGoalById.HandleId, 0, ConfigMatchThreeGoalById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeGoalById.HandleId, ConfigMatchThreeGoalById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeGoal rootAsMatchThreeGoal = MatchThreeGoal.GetRootAsMatchThreeGoal(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeGoalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeGoalById.HandleId, ConfigMatchThreeGoalById.LogPair);
			return new MatchThreeGoal?(rootAsMatchThreeGoal);
		}

		// Token: 0x04002442 RID: 9282
		private const string DB = "db_matchthree.db";

		// Token: 0x04002443 RID: 9283
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x04002444 RID: 9284
		private const string TABLE = "MatchThreeGoal";

		// Token: 0x04002445 RID: 9285
		private const string COMMAND = "select BinData from `MatchThreeGoal` where Id=?";

		// Token: 0x04002446 RID: 9286
		private const string KEY_PREFIX = "MatchThreeGoalById";

		// Token: 0x04002447 RID: 9287
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002448 RID: 9288
		private static int HandleId;
	}
}
