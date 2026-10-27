using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029D RID: 669
	public class ConfigExploreRouletteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FB3 RID: 4019 RVA: 0x000B24B4 File Offset: 0x000B06B4
		static ConfigExploreRouletteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRouletteAll.CreateStaticDefaultValue), new Action(ConfigExploreRouletteAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000B24D4 File Offset: 0x000B06D4
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreRouletteAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreRouletteAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_skill.db"),
				new ValueTuple<string, object>("文件", "t.探索工具.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreRoulette"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreRoulette`")
			});
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x000B2553 File Offset: 0x000B0753
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRouletteAll.LogPair = null;
			ConfigExploreRouletteAll.HandleId = 0;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000B2561 File Offset: 0x000B0761
		public static void Init()
		{
			ConfigExploreRouletteAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRouletteAll.HandleId, "db_explore_skill.db", "select BinData from `ExploreRoulette`");
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x000B257C File Offset: 0x000B077C
		[NullableContext(2)]
		public static IReadOnlyList<ExploreRoulette> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreRouletteAll.HandleId, ConfigExploreRouletteAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ExploreRoulette> readOnlyList = (IReadOnlyList<ExploreRoulette>)ConfigCommon.GetConfig("ExploreRouletteAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ExploreRoulette> list = new List<ExploreRoulette>();
			while (ConfigCommon.Step(ConfigExploreRouletteAll.HandleId, false, ConfigExploreRouletteAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreRouletteAll.HandleId, 0, ConfigExploreRouletteAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreRouletteAll.HandleId, ConfigExploreRouletteAll.LogPair);
					return null;
				}
				ExploreRoulette rootAsExploreRoulette = ExploreRoulette.GetRootAsExploreRoulette(new ByteBuffer(item2));
				list.Add(rootAsExploreRoulette);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ExploreRouletteAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreRouletteAll.HandleId, ConfigExploreRouletteAll.LogPair);
			return list;
		}

		// Token: 0x0400122F RID: 4655
		private const string DB = "db_explore_skill.db";

		// Token: 0x04001230 RID: 4656
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x04001231 RID: 4657
		private const string TABLE = "ExploreRoulette";

		// Token: 0x04001232 RID: 4658
		private const string COMMAND = "select BinData from `ExploreRoulette`";

		// Token: 0x04001233 RID: 4659
		private const string KEY_PREFIX = "ExploreRouletteAll";

		// Token: 0x04001234 RID: 4660
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001235 RID: 4661
		private static int HandleId;
	}
}
