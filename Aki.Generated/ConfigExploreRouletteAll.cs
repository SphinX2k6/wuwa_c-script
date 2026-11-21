using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B1 RID: 689
	public class ConfigExploreRouletteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600102B RID: 4139 RVA: 0x000B8778 File Offset: 0x000B6978
		static ConfigExploreRouletteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRouletteAll.CreateStaticDefaultValue), new Action(ConfigExploreRouletteAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x000B8798 File Offset: 0x000B6998
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

		// Token: 0x0600102D RID: 4141 RVA: 0x000B8817 File Offset: 0x000B6A17
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRouletteAll.LogPair = null;
			ConfigExploreRouletteAll.HandleId = 0;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x000B8825 File Offset: 0x000B6A25
		public static void Init()
		{
			ConfigExploreRouletteAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRouletteAll.HandleId, "db_explore_skill.db", "select BinData from `ExploreRoulette`");
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000B8840 File Offset: 0x000B6A40
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

		// Token: 0x040012BB RID: 4795
		private const string DB = "db_explore_skill.db";

		// Token: 0x040012BC RID: 4796
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x040012BD RID: 4797
		private const string TABLE = "ExploreRoulette";

		// Token: 0x040012BE RID: 4798
		private const string COMMAND = "select BinData from `ExploreRoulette`";

		// Token: 0x040012BF RID: 4799
		private const string KEY_PREFIX = "ExploreRouletteAll";

		// Token: 0x040012C0 RID: 4800
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012C1 RID: 4801
		private static int HandleId;
	}
}
