using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B9 RID: 697
	public class ConfigExploreToolsAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600105B RID: 4187 RVA: 0x000B96E8 File Offset: 0x000B78E8
		static ConfigExploreToolsAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreToolsAll.CreateStaticDefaultValue), new Action(ConfigExploreToolsAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x000B9708 File Offset: 0x000B7908
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreToolsAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreToolsAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_skill.db"),
				new ValueTuple<string, object>("文件", "t.探索工具.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreTools"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreTools`")
			});
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x000B9787 File Offset: 0x000B7987
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreToolsAll.LogPair = null;
			ConfigExploreToolsAll.HandleId = 0;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000B9795 File Offset: 0x000B7995
		public static void Init()
		{
			ConfigExploreToolsAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreToolsAll.HandleId, "db_explore_skill.db", "select BinData from `ExploreTools`");
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x000B97B0 File Offset: 0x000B79B0
		[NullableContext(2)]
		public static IReadOnlyList<ExploreTools> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreToolsAll.HandleId, ConfigExploreToolsAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ExploreTools> readOnlyList = (IReadOnlyList<ExploreTools>)ConfigCommon.GetConfig("ExploreToolsAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ExploreTools> list = new List<ExploreTools>();
			while (ConfigCommon.Step(ConfigExploreToolsAll.HandleId, false, ConfigExploreToolsAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreToolsAll.HandleId, 0, ConfigExploreToolsAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreToolsAll.HandleId, ConfigExploreToolsAll.LogPair);
					return null;
				}
				ExploreTools rootAsExploreTools = ExploreTools.GetRootAsExploreTools(new ByteBuffer(item2));
				list.Add(rootAsExploreTools);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ExploreToolsAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreToolsAll.HandleId, ConfigExploreToolsAll.LogPair);
			return list;
		}

		// Token: 0x040012F3 RID: 4851
		private const string DB = "db_explore_skill.db";

		// Token: 0x040012F4 RID: 4852
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x040012F5 RID: 4853
		private const string TABLE = "ExploreTools";

		// Token: 0x040012F6 RID: 4854
		private const string COMMAND = "select BinData from `ExploreTools`";

		// Token: 0x040012F7 RID: 4855
		private const string KEY_PREFIX = "ExploreToolsAll";

		// Token: 0x040012F8 RID: 4856
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012F9 RID: 4857
		private static int HandleId;
	}
}
