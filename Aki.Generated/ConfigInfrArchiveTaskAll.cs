using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043B RID: 1083
	public class ConfigInfrArchiveTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600196B RID: 6507 RVA: 0x000ECEFC File Offset: 0x000EB0FC
		static ConfigInfrArchiveTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrArchiveTaskAll.CreateStaticDefaultValue), new Action(ConfigInfrArchiveTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x000ECF1C File Offset: 0x000EB11C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrArchiveTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrArchiveTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建_档案馆.xlsx"),
				new ValueTuple<string, object>("表名", "InfrArchiveTask"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrArchiveTask`")
			});
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000ECF9B File Offset: 0x000EB19B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrArchiveTaskAll.LogPair = null;
			ConfigInfrArchiveTaskAll.HandleId = 0;
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x000ECFA9 File Offset: 0x000EB1A9
		public static void Init()
		{
			ConfigInfrArchiveTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrArchiveTaskAll.HandleId, "db_infrastructure.db", "select BinData from `InfrArchiveTask`");
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x000ECFC4 File Offset: 0x000EB1C4
		[NullableContext(2)]
		public static IReadOnlyList<InfrArchiveTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrArchiveTaskAll.HandleId, ConfigInfrArchiveTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrArchiveTask> readOnlyList = (IReadOnlyList<InfrArchiveTask>)ConfigCommon.GetConfig("InfrArchiveTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrArchiveTask> list = new List<InfrArchiveTask>();
			while (ConfigCommon.Step(ConfigInfrArchiveTaskAll.HandleId, false, ConfigInfrArchiveTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrArchiveTaskAll.HandleId, 0, ConfigInfrArchiveTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrArchiveTaskAll.HandleId, ConfigInfrArchiveTaskAll.LogPair);
					return null;
				}
				InfrArchiveTask rootAsInfrArchiveTask = InfrArchiveTask.GetRootAsInfrArchiveTask(new ByteBuffer(item2));
				list.Add(rootAsInfrArchiveTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrArchiveTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrArchiveTaskAll.HandleId, ConfigInfrArchiveTaskAll.LogPair);
			return list;
		}

		// Token: 0x04001D81 RID: 7553
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D82 RID: 7554
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001D83 RID: 7555
		private const string TABLE = "InfrArchiveTask";

		// Token: 0x04001D84 RID: 7556
		private const string COMMAND = "select BinData from `InfrArchiveTask`";

		// Token: 0x04001D85 RID: 7557
		private const string KEY_PREFIX = "InfrArchiveTaskAll";

		// Token: 0x04001D86 RID: 7558
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D87 RID: 7559
		private static int HandleId;
	}
}
