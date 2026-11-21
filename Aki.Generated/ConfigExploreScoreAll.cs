using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B6 RID: 694
	public class ConfigExploreScoreAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001049 RID: 4169 RVA: 0x000B90C4 File Offset: 0x000B72C4
		static ConfigExploreScoreAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreScoreAll.CreateStaticDefaultValue), new Action(ConfigExploreScoreAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x000B90E4 File Offset: 0x000B72E4
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreScoreAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreScoreAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreScore"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreScore`")
			});
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x000B9163 File Offset: 0x000B7363
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreScoreAll.LogPair = null;
			ConfigExploreScoreAll.HandleId = 0;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x000B9171 File Offset: 0x000B7371
		public static void Init()
		{
			ConfigExploreScoreAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreScoreAll.HandleId, "db_explore_progress.db", "select BinData from `ExploreScore`");
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x000B918C File Offset: 0x000B738C
		[NullableContext(2)]
		public static IReadOnlyList<ExploreScore> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreScoreAll.HandleId, ConfigExploreScoreAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ExploreScore> readOnlyList = (IReadOnlyList<ExploreScore>)ConfigCommon.GetConfig("ExploreScoreAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ExploreScore> list = new List<ExploreScore>();
			while (ConfigCommon.Step(ConfigExploreScoreAll.HandleId, false, ConfigExploreScoreAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreScoreAll.HandleId, 0, ConfigExploreScoreAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreScoreAll.HandleId, ConfigExploreScoreAll.LogPair);
					return null;
				}
				ExploreScore rootAsExploreScore = ExploreScore.GetRootAsExploreScore(new ByteBuffer(item2));
				list.Add(rootAsExploreScore);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ExploreScoreAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreScoreAll.HandleId, ConfigExploreScoreAll.LogPair);
			return list;
		}

		// Token: 0x040012DE RID: 4830
		private const string DB = "db_explore_progress.db";

		// Token: 0x040012DF RID: 4831
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x040012E0 RID: 4832
		private const string TABLE = "ExploreScore";

		// Token: 0x040012E1 RID: 4833
		private const string COMMAND = "select BinData from `ExploreScore`";

		// Token: 0x040012E2 RID: 4834
		private const string KEY_PREFIX = "ExploreScoreAll";

		// Token: 0x040012E3 RID: 4835
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012E4 RID: 4836
		private static int HandleId;
	}
}
