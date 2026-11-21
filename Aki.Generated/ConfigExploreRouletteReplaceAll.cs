using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B2 RID: 690
	public class ConfigExploreRouletteReplaceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001031 RID: 4145 RVA: 0x000B890B File Offset: 0x000B6B0B
		static ConfigExploreRouletteReplaceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRouletteReplaceAll.CreateStaticDefaultValue), new Action(ConfigExploreRouletteReplaceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x000B892C File Offset: 0x000B6B2C
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreRouletteReplaceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreRouletteReplaceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_skill.db"),
				new ValueTuple<string, object>("文件", "t.探索工具.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreRouletteReplace"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreRouletteReplace`")
			});
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x000B89AB File Offset: 0x000B6BAB
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRouletteReplaceAll.LogPair = null;
			ConfigExploreRouletteReplaceAll.HandleId = 0;
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000B89B9 File Offset: 0x000B6BB9
		public static void Init()
		{
			ConfigExploreRouletteReplaceAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRouletteReplaceAll.HandleId, "db_explore_skill.db", "select BinData from `ExploreRouletteReplace`");
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000B89D4 File Offset: 0x000B6BD4
		[NullableContext(2)]
		public static IReadOnlyList<ExploreRouletteReplace> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreRouletteReplaceAll.HandleId, ConfigExploreRouletteReplaceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ExploreRouletteReplace> readOnlyList = (IReadOnlyList<ExploreRouletteReplace>)ConfigCommon.GetConfig("ExploreRouletteReplaceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ExploreRouletteReplace> list = new List<ExploreRouletteReplace>();
			while (ConfigCommon.Step(ConfigExploreRouletteReplaceAll.HandleId, false, ConfigExploreRouletteReplaceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreRouletteReplaceAll.HandleId, 0, ConfigExploreRouletteReplaceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreRouletteReplaceAll.HandleId, ConfigExploreRouletteReplaceAll.LogPair);
					return null;
				}
				ExploreRouletteReplace rootAsExploreRouletteReplace = ExploreRouletteReplace.GetRootAsExploreRouletteReplace(new ByteBuffer(item2));
				list.Add(rootAsExploreRouletteReplace);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ExploreRouletteReplaceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreRouletteReplaceAll.HandleId, ConfigExploreRouletteReplaceAll.LogPair);
			return list;
		}

		// Token: 0x040012C2 RID: 4802
		private const string DB = "db_explore_skill.db";

		// Token: 0x040012C3 RID: 4803
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x040012C4 RID: 4804
		private const string TABLE = "ExploreRouletteReplace";

		// Token: 0x040012C5 RID: 4805
		private const string COMMAND = "select BinData from `ExploreRouletteReplace`";

		// Token: 0x040012C6 RID: 4806
		private const string KEY_PREFIX = "ExploreRouletteReplaceAll";

		// Token: 0x040012C7 RID: 4807
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012C8 RID: 4808
		private static int HandleId;
	}
}
