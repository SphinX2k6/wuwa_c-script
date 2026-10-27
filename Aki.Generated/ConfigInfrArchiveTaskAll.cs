using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000425 RID: 1061
	public class ConfigInfrArchiveTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018E7 RID: 6375 RVA: 0x000E67A8 File Offset: 0x000E49A8
		static ConfigInfrArchiveTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrArchiveTaskAll.CreateStaticDefaultValue), new Action(ConfigInfrArchiveTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x000E67C8 File Offset: 0x000E49C8
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

		// Token: 0x060018E9 RID: 6377 RVA: 0x000E6847 File Offset: 0x000E4A47
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrArchiveTaskAll.LogPair = null;
			ConfigInfrArchiveTaskAll.HandleId = 0;
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x000E6855 File Offset: 0x000E4A55
		public static void Init()
		{
			ConfigInfrArchiveTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrArchiveTaskAll.HandleId, "db_infrastructure.db", "select BinData from `InfrArchiveTask`");
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x000E6870 File Offset: 0x000E4A70
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

		// Token: 0x04001CE7 RID: 7399
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001CE8 RID: 7400
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001CE9 RID: 7401
		private const string TABLE = "InfrArchiveTask";

		// Token: 0x04001CEA RID: 7402
		private const string COMMAND = "select BinData from `InfrArchiveTask`";

		// Token: 0x04001CEB RID: 7403
		private const string KEY_PREFIX = "InfrArchiveTaskAll";

		// Token: 0x04001CEC RID: 7404
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CED RID: 7405
		private static int HandleId;
	}
}
