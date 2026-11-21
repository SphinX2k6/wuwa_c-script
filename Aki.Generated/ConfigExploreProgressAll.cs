using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A9 RID: 681
	public class ConfigExploreProgressAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FFB RID: 4091 RVA: 0x000B76D0 File Offset: 0x000B58D0
		static ConfigExploreProgressAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreProgressAll.CreateStaticDefaultValue), new Action(ConfigExploreProgressAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x000B76F0 File Offset: 0x000B58F0
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

		// Token: 0x06000FFD RID: 4093 RVA: 0x000B776F File Offset: 0x000B596F
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreProgressAll.LogPair = null;
			ConfigExploreProgressAll.HandleId = 0;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x000B777D File Offset: 0x000B597D
		public static void Init()
		{
			ConfigExploreProgressAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreProgressAll.HandleId, "db_explore_progress.db", "select BinData from `ExploreProgress`");
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000B7798 File Offset: 0x000B5998
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

		// Token: 0x04001283 RID: 4739
		private const string DB = "db_explore_progress.db";

		// Token: 0x04001284 RID: 4740
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x04001285 RID: 4741
		private const string TABLE = "ExploreProgress";

		// Token: 0x04001286 RID: 4742
		private const string COMMAND = "select BinData from `ExploreProgress`";

		// Token: 0x04001287 RID: 4743
		private const string KEY_PREFIX = "ExploreProgressAll";

		// Token: 0x04001288 RID: 4744
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001289 RID: 4745
		private static int HandleId;
	}
}
