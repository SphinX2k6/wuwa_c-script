using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043E RID: 1086
	public class ConfigInfrV2TreeBuildAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600197E RID: 6526 RVA: 0x000E9A4C File Offset: 0x000E7C4C
		static ConfigInfrV2TreeBuildAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2TreeBuildAll.CreateStaticDefaultValue), new Action(ConfigInfrV2TreeBuildAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x000E9A6C File Offset: 0x000E7C6C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2TreeBuildAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2TreeBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2TreeBuild`")
			});
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x000E9AEB File Offset: 0x000E7CEB
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildAll.LogPair = null;
			ConfigInfrV2TreeBuildAll.HandleId = 0;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000E9AF9 File Offset: 0x000E7CF9
		public static void Init()
		{
			ConfigInfrV2TreeBuildAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2TreeBuildAll.HandleId, "db_villageinfr.db", "select BinData from `InfrV2TreeBuild`");
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x000E9B14 File Offset: 0x000E7D14
		[NullableContext(2)]
		public static IReadOnlyList<InfrV2TreeBuild> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2TreeBuildAll.HandleId, ConfigInfrV2TreeBuildAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrV2TreeBuild> readOnlyList = (IReadOnlyList<InfrV2TreeBuild>)ConfigCommon.GetConfig("InfrV2TreeBuildAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrV2TreeBuild> list = new List<InfrV2TreeBuild>();
			while (ConfigCommon.Step(ConfigInfrV2TreeBuildAll.HandleId, false, ConfigInfrV2TreeBuildAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2TreeBuildAll.HandleId, 0, ConfigInfrV2TreeBuildAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrV2TreeBuildAll.HandleId, ConfigInfrV2TreeBuildAll.LogPair);
					return null;
				}
				InfrV2TreeBuild rootAsInfrV2TreeBuild = InfrV2TreeBuild.GetRootAsInfrV2TreeBuild(new ByteBuffer(item2));
				list.Add(rootAsInfrV2TreeBuild);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrV2TreeBuildAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrV2TreeBuildAll.HandleId, ConfigInfrV2TreeBuildAll.LogPair);
			return list;
		}

		// Token: 0x04001D96 RID: 7574
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001D97 RID: 7575
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001D98 RID: 7576
		private const string TABLE = "InfrV2TreeBuild";

		// Token: 0x04001D99 RID: 7577
		private const string COMMAND = "select BinData from `InfrV2TreeBuild`";

		// Token: 0x04001D9A RID: 7578
		private const string KEY_PREFIX = "InfrV2TreeBuildAll";

		// Token: 0x04001D9B RID: 7579
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D9C RID: 7580
		private static int HandleId;
	}
}
