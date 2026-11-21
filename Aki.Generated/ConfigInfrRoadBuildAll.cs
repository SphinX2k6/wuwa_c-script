using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000449 RID: 1097
	public class ConfigInfrRoadBuildAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019BF RID: 6591 RVA: 0x000EEAA4 File Offset: 0x000ECCA4
		static ConfigInfrRoadBuildAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrRoadBuildAll.CreateStaticDefaultValue), new Action(ConfigInfrRoadBuildAll.ResetStaticDefaultValue));
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x000EEAC4 File Offset: 0x000ECCC4
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

		// Token: 0x060019C1 RID: 6593 RVA: 0x000EEB43 File Offset: 0x000ECD43
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrRoadBuildAll.LogPair = null;
			ConfigInfrRoadBuildAll.HandleId = 0;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x000EEB51 File Offset: 0x000ECD51
		public static void Init()
		{
			ConfigInfrRoadBuildAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrRoadBuildAll.HandleId, "db_infrastructure.db", "select BinData from `InfrRoadBuild`");
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x000EEB6C File Offset: 0x000ECD6C
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

		// Token: 0x04001DE3 RID: 7651
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DE4 RID: 7652
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001DE5 RID: 7653
		private const string TABLE = "InfrRoadBuild";

		// Token: 0x04001DE6 RID: 7654
		private const string COMMAND = "select BinData from `InfrRoadBuild`";

		// Token: 0x04001DE7 RID: 7655
		private const string KEY_PREFIX = "InfrRoadBuildAll";

		// Token: 0x04001DE8 RID: 7656
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DE9 RID: 7657
		private static int HandleId;
	}
}
