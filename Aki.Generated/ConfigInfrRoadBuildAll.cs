using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000433 RID: 1075
	public class ConfigInfrRoadBuildAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600193B RID: 6459 RVA: 0x000E8350 File Offset: 0x000E6550
		static ConfigInfrRoadBuildAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrRoadBuildAll.CreateStaticDefaultValue), new Action(ConfigInfrRoadBuildAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x000E8370 File Offset: 0x000E6570
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrRoadBuildAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrRoadBuildAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrRoadBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrRoadBuild`")
			});
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000E83EF File Offset: 0x000E65EF
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrRoadBuildAll.LogPair = null;
			ConfigInfrRoadBuildAll.HandleId = 0;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000E83FD File Offset: 0x000E65FD
		public static void Init()
		{
			ConfigInfrRoadBuildAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrRoadBuildAll.HandleId, "db_infrastructure.db", "select BinData from `InfrRoadBuild`");
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000E8418 File Offset: 0x000E6618
		[NullableContext(2)]
		public static IReadOnlyList<InfrRoadBuild> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrRoadBuildAll.HandleId, ConfigInfrRoadBuildAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrRoadBuild> readOnlyList = (IReadOnlyList<InfrRoadBuild>)ConfigCommon.GetConfig("InfrRoadBuildAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrRoadBuild> list = new List<InfrRoadBuild>();
			while (ConfigCommon.Step(ConfigInfrRoadBuildAll.HandleId, false, ConfigInfrRoadBuildAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrRoadBuildAll.HandleId, 0, ConfigInfrRoadBuildAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrRoadBuildAll.HandleId, ConfigInfrRoadBuildAll.LogPair);
					return null;
				}
				InfrRoadBuild rootAsInfrRoadBuild = InfrRoadBuild.GetRootAsInfrRoadBuild(new ByteBuffer(item2));
				list.Add(rootAsInfrRoadBuild);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrRoadBuildAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrRoadBuildAll.HandleId, ConfigInfrRoadBuildAll.LogPair);
			return list;
		}

		// Token: 0x04001D49 RID: 7497
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D4A RID: 7498
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D4B RID: 7499
		private const string TABLE = "InfrRoadBuild";

		// Token: 0x04001D4C RID: 7500
		private const string COMMAND = "select BinData from `InfrRoadBuild`";

		// Token: 0x04001D4D RID: 7501
		private const string KEY_PREFIX = "InfrRoadBuildAll";

		// Token: 0x04001D4E RID: 7502
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D4F RID: 7503
		private static int HandleId;
	}
}
