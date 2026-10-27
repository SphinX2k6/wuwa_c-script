using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000295 RID: 661
	public class ConfigExploreProgressAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x000B140C File Offset: 0x000AF60C
		static ConfigExploreProgressAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreProgressAll.CreateStaticDefaultValue), new Action(ConfigExploreProgressAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x000B142C File Offset: 0x000AF62C
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreProgressAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreProgressAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreProgress"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreProgress`")
			});
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000B14AB File Offset: 0x000AF6AB
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreProgressAll.LogPair = null;
			ConfigExploreProgressAll.HandleId = 0;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000B14B9 File Offset: 0x000AF6B9
		public static void Init()
		{
			ConfigExploreProgressAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreProgressAll.HandleId, "db_explore_progress.db", "select BinData from `ExploreProgress`");
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000B14D4 File Offset: 0x000AF6D4
		[NullableContext(2)]
		public static IReadOnlyList<ExploreProgress> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreProgressAll.HandleId, ConfigExploreProgressAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ExploreProgress> readOnlyList = (IReadOnlyList<ExploreProgress>)ConfigCommon.GetConfig("ExploreProgressAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ExploreProgress> list = new List<ExploreProgress>();
			while (ConfigCommon.Step(ConfigExploreProgressAll.HandleId, false, ConfigExploreProgressAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreProgressAll.HandleId, 0, ConfigExploreProgressAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreProgressAll.HandleId, ConfigExploreProgressAll.LogPair);
					return null;
				}
				ExploreProgress rootAsExploreProgress = ExploreProgress.GetRootAsExploreProgress(new ByteBuffer(item2));
				list.Add(rootAsExploreProgress);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ExploreProgressAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreProgressAll.HandleId, ConfigExploreProgressAll.LogPair);
			return list;
		}

		// Token: 0x040011F7 RID: 4599
		private const string DB = "db_explore_progress.db";

		// Token: 0x040011F8 RID: 4600
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x040011F9 RID: 4601
		private const string TABLE = "ExploreProgress";

		// Token: 0x040011FA RID: 4602
		private const string COMMAND = "select BinData from `ExploreProgress`";

		// Token: 0x040011FB RID: 4603
		private const string KEY_PREFIX = "ExploreProgressAll";

		// Token: 0x040011FC RID: 4604
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011FD RID: 4605
		private static int HandleId;
	}
}
