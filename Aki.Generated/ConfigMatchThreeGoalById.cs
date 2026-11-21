using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000548 RID: 1352
	public class ConfigMatchThreeGoalById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FBB RID: 8123 RVA: 0x00110320 File Offset: 0x0010E520
		static ConfigMatchThreeGoalById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeGoalById.CreateStaticDefaultValue), new Action(ConfigMatchThreeGoalById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00110340 File Offset: 0x0010E540
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

		// Token: 0x06001FBD RID: 8125 RVA: 0x001103BF File Offset: 0x0010E5BF
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeGoalById.LogPair = null;
			ConfigMatchThreeGoalById.HandleId = 0;
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x001103CD File Offset: 0x0010E5CD
		public static void Init()
		{
			ConfigMatchThreeGoalById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeGoalById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeGoal` where Id=?");
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x001103E8 File Offset: 0x0010E5E8
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

		// Token: 0x040024DC RID: 9436
		private const string DB = "db_matchthree.db";

		// Token: 0x040024DD RID: 9437
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x040024DE RID: 9438
		private const string TABLE = "MatchThreeGoal";

		// Token: 0x040024DF RID: 9439
		private const string COMMAND = "select BinData from `MatchThreeGoal` where Id=?";

		// Token: 0x040024E0 RID: 9440
		private const string KEY_PREFIX = "MatchThreeGoalById";

		// Token: 0x040024E1 RID: 9441
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024E2 RID: 9442
		private static int HandleId;
	}
}
