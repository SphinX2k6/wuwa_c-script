using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000454 RID: 1108
	public class ConfigInfrV2TreeBuildAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A02 RID: 6658 RVA: 0x000F01A0 File Offset: 0x000EE3A0
		static ConfigInfrV2TreeBuildAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2TreeBuildAll.CreateStaticDefaultValue), new Action(ConfigInfrV2TreeBuildAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x000F01C0 File Offset: 0x000EE3C0
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

		// Token: 0x06001A04 RID: 6660 RVA: 0x000F023F File Offset: 0x000EE43F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildAll.LogPair = null;
			ConfigInfrV2TreeBuildAll.HandleId = 0;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x000F024D File Offset: 0x000EE44D
		public static void Init()
		{
			ConfigInfrV2TreeBuildAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2TreeBuildAll.HandleId, "db_villageinfr.db", "select BinData from `InfrV2TreeBuild`");
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x000F0268 File Offset: 0x000EE468
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

		// Token: 0x04001E30 RID: 7728
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E31 RID: 7729
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E32 RID: 7730
		private const string TABLE = "InfrV2TreeBuild";

		// Token: 0x04001E33 RID: 7731
		private const string COMMAND = "select BinData from `InfrV2TreeBuild`";

		// Token: 0x04001E34 RID: 7732
		private const string KEY_PREFIX = "InfrV2TreeBuildAll";

		// Token: 0x04001E35 RID: 7733
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E36 RID: 7734
		private static int HandleId;
	}
}
