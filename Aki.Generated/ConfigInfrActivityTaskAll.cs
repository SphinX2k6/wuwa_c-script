using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000420 RID: 1056
	public class ConfigInfrActivityTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018C9 RID: 6345 RVA: 0x000E5DA8 File Offset: 0x000E3FA8
		static ConfigInfrActivityTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrActivityTaskAll.CreateStaticDefaultValue), new Action(ConfigInfrActivityTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x000E5DC8 File Offset: 0x000E3FC8
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrActivityTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrActivityTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrActivityTask"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrActivityTask`")
			});
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x000E5E47 File Offset: 0x000E4047
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrActivityTaskAll.LogPair = null;
			ConfigInfrActivityTaskAll.HandleId = 0;
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x000E5E55 File Offset: 0x000E4055
		public static void Init()
		{
			ConfigInfrActivityTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrActivityTaskAll.HandleId, "db_infrastructure.db", "select BinData from `InfrActivityTask`");
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x000E5E70 File Offset: 0x000E4070
		[NullableContext(2)]
		public static IReadOnlyList<InfrActivityTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrActivityTaskAll.HandleId, ConfigInfrActivityTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrActivityTask> readOnlyList = (IReadOnlyList<InfrActivityTask>)ConfigCommon.GetConfig("InfrActivityTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrActivityTask> list = new List<InfrActivityTask>();
			while (ConfigCommon.Step(ConfigInfrActivityTaskAll.HandleId, false, ConfigInfrActivityTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrActivityTaskAll.HandleId, 0, ConfigInfrActivityTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrActivityTaskAll.HandleId, ConfigInfrActivityTaskAll.LogPair);
					return null;
				}
				InfrActivityTask rootAsInfrActivityTask = InfrActivityTask.GetRootAsInfrActivityTask(new ByteBuffer(item2));
				list.Add(rootAsInfrActivityTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrActivityTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrActivityTaskAll.HandleId, ConfigInfrActivityTaskAll.LogPair);
			return list;
		}

		// Token: 0x04001CC4 RID: 7364
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001CC5 RID: 7365
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001CC6 RID: 7366
		private const string TABLE = "InfrActivityTask";

		// Token: 0x04001CC7 RID: 7367
		private const string COMMAND = "select BinData from `InfrActivityTask`";

		// Token: 0x04001CC8 RID: 7368
		private const string KEY_PREFIX = "InfrActivityTaskAll";

		// Token: 0x04001CC9 RID: 7369
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CCA RID: 7370
		private static int HandleId;
	}
}
