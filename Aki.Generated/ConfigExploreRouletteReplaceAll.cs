using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029E RID: 670
	public class ConfigExploreRouletteReplaceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FB9 RID: 4025 RVA: 0x000B2647 File Offset: 0x000B0847
		static ConfigExploreRouletteReplaceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRouletteReplaceAll.CreateStaticDefaultValue), new Action(ConfigExploreRouletteReplaceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000B2668 File Offset: 0x000B0868
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

		// Token: 0x06000FBB RID: 4027 RVA: 0x000B26E7 File Offset: 0x000B08E7
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRouletteReplaceAll.LogPair = null;
			ConfigExploreRouletteReplaceAll.HandleId = 0;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000B26F5 File Offset: 0x000B08F5
		public static void Init()
		{
			ConfigExploreRouletteReplaceAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRouletteReplaceAll.HandleId, "db_explore_skill.db", "select BinData from `ExploreRouletteReplace`");
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x000B2710 File Offset: 0x000B0910
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

		// Token: 0x04001236 RID: 4662
		private const string DB = "db_explore_skill.db";

		// Token: 0x04001237 RID: 4663
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x04001238 RID: 4664
		private const string TABLE = "ExploreRouletteReplace";

		// Token: 0x04001239 RID: 4665
		private const string COMMAND = "select BinData from `ExploreRouletteReplace`";

		// Token: 0x0400123A RID: 4666
		private const string KEY_PREFIX = "ExploreRouletteReplaceAll";

		// Token: 0x0400123B RID: 4667
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400123C RID: 4668
		private static int HandleId;
	}
}
