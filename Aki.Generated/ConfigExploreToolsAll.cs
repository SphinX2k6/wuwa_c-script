using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A5 RID: 677
	public class ConfigExploreToolsAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FE3 RID: 4067 RVA: 0x000B3424 File Offset: 0x000B1624
		static ConfigExploreToolsAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreToolsAll.CreateStaticDefaultValue), new Action(ConfigExploreToolsAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x000B3444 File Offset: 0x000B1644
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

		// Token: 0x06000FE5 RID: 4069 RVA: 0x000B34C3 File Offset: 0x000B16C3
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreToolsAll.LogPair = null;
			ConfigExploreToolsAll.HandleId = 0;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x000B34D1 File Offset: 0x000B16D1
		public static void Init()
		{
			ConfigExploreToolsAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreToolsAll.HandleId, "db_explore_skill.db", "select BinData from `ExploreTools`");
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x000B34EC File Offset: 0x000B16EC
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

		// Token: 0x04001267 RID: 4711
		private const string DB = "db_explore_skill.db";

		// Token: 0x04001268 RID: 4712
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x04001269 RID: 4713
		private const string TABLE = "ExploreTools";

		// Token: 0x0400126A RID: 4714
		private const string COMMAND = "select BinData from `ExploreTools`";

		// Token: 0x0400126B RID: 4715
		private const string KEY_PREFIX = "ExploreToolsAll";

		// Token: 0x0400126C RID: 4716
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400126D RID: 4717
		private static int HandleId;
	}
}
