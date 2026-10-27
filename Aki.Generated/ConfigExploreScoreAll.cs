using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A2 RID: 674
	public class ConfigExploreScoreAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FD1 RID: 4049 RVA: 0x000B2E00 File Offset: 0x000B1000
		static ConfigExploreScoreAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreScoreAll.CreateStaticDefaultValue), new Action(ConfigExploreScoreAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000B2E20 File Offset: 0x000B1020
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

		// Token: 0x06000FD3 RID: 4051 RVA: 0x000B2E9F File Offset: 0x000B109F
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreScoreAll.LogPair = null;
			ConfigExploreScoreAll.HandleId = 0;
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x000B2EAD File Offset: 0x000B10AD
		public static void Init()
		{
			ConfigExploreScoreAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreScoreAll.HandleId, "db_explore_progress.db", "select BinData from `ExploreScore`");
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000B2EC8 File Offset: 0x000B10C8
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

		// Token: 0x04001252 RID: 4690
		private const string DB = "db_explore_progress.db";

		// Token: 0x04001253 RID: 4691
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x04001254 RID: 4692
		private const string TABLE = "ExploreScore";

		// Token: 0x04001255 RID: 4693
		private const string COMMAND = "select BinData from `ExploreScore`";

		// Token: 0x04001256 RID: 4694
		private const string KEY_PREFIX = "ExploreScoreAll";

		// Token: 0x04001257 RID: 4695
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001258 RID: 4696
		private static int HandleId;
	}
}
