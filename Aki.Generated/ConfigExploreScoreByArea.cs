using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A3 RID: 675
	public class ConfigExploreScoreByArea : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FD7 RID: 4055 RVA: 0x000B2F93 File Offset: 0x000B1193
		static ConfigExploreScoreByArea()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreScoreByArea.CreateStaticDefaultValue), new Action(ConfigExploreScoreByArea.ResetStaticDefaultValue));
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x000B2FB4 File Offset: 0x000B11B4
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreScoreByArea.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreScoreByArea.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreScore"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreScore` where Area=?")
			});
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x000B3033 File Offset: 0x000B1233
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreScoreByArea.LogPair = null;
			ConfigExploreScoreByArea.HandleId = 0;
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x000B3041 File Offset: 0x000B1241
		public static void Init()
		{
			ConfigExploreScoreByArea.HandleId = ConfigCommon.InitDataStatement(ConfigExploreScoreByArea.HandleId, "db_explore_progress.db", "select BinData from `ExploreScore` where Area=?");
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000B305C File Offset: 0x000B125C
		public static ExploreScore? GetConfig(int p0Area, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreScoreByArea.HandleId, ConfigExploreScoreByArea.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreScoreByArea");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Area);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreScore?(ExploreScore.GetRootAsExploreScore(configBuffer));
				}
			}
			ConfigExploreScoreByArea.LogPair.Clear();
			ConfigExploreScoreByArea.LogPair.Add(new ValueTuple<string, object>("Area", p0Area));
			if (!ConfigCommon.BindInt(ConfigExploreScoreByArea.HandleId, 1, p0Area, ConfigExploreScoreByArea.LogPair) || ConfigCommon.Step(ConfigExploreScoreByArea.HandleId, true, ConfigExploreScoreByArea.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreScoreByArea.HandleId, ConfigExploreScoreByArea.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreScoreByArea.HandleId, 0, ConfigExploreScoreByArea.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreScoreByArea.HandleId, ConfigExploreScoreByArea.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreScore rootAsExploreScore = ExploreScore.GetRootAsExploreScore(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreScoreByArea");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Area);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreScoreByArea.HandleId, ConfigExploreScoreByArea.LogPair);
			return new ExploreScore?(rootAsExploreScore);
		}

		// Token: 0x04001259 RID: 4697
		private const string DB = "db_explore_progress.db";

		// Token: 0x0400125A RID: 4698
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x0400125B RID: 4699
		private const string TABLE = "ExploreScore";

		// Token: 0x0400125C RID: 4700
		private const string COMMAND = "select BinData from `ExploreScore` where Area=?";

		// Token: 0x0400125D RID: 4701
		private const string KEY_PREFIX = "ExploreScoreByArea";

		// Token: 0x0400125E RID: 4702
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400125F RID: 4703
		private static int HandleId;
	}
}
