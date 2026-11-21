using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B7 RID: 695
	public class ConfigExploreScoreByArea : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600104F RID: 4175 RVA: 0x000B9257 File Offset: 0x000B7457
		static ConfigExploreScoreByArea()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreScoreByArea.CreateStaticDefaultValue), new Action(ConfigExploreScoreByArea.ResetStaticDefaultValue));
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x000B9278 File Offset: 0x000B7478
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

		// Token: 0x06001051 RID: 4177 RVA: 0x000B92F7 File Offset: 0x000B74F7
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreScoreByArea.LogPair = null;
			ConfigExploreScoreByArea.HandleId = 0;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x000B9305 File Offset: 0x000B7505
		public static void Init()
		{
			ConfigExploreScoreByArea.HandleId = ConfigCommon.InitDataStatement(ConfigExploreScoreByArea.HandleId, "db_explore_progress.db", "select BinData from `ExploreScore` where Area=?");
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000B9320 File Offset: 0x000B7520
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

		// Token: 0x040012E5 RID: 4837
		private const string DB = "db_explore_progress.db";

		// Token: 0x040012E6 RID: 4838
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x040012E7 RID: 4839
		private const string TABLE = "ExploreScore";

		// Token: 0x040012E8 RID: 4840
		private const string COMMAND = "select BinData from `ExploreScore` where Area=?";

		// Token: 0x040012E9 RID: 4841
		private const string KEY_PREFIX = "ExploreScoreByArea";

		// Token: 0x040012EA RID: 4842
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012EB RID: 4843
		private static int HandleId;
	}
}
