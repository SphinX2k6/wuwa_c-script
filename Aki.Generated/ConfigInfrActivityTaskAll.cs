using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000436 RID: 1078
	public class ConfigInfrActivityTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600194D RID: 6477 RVA: 0x000EC4FC File Offset: 0x000EA6FC
		static ConfigInfrActivityTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrActivityTaskAll.CreateStaticDefaultValue), new Action(ConfigInfrActivityTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x000EC51C File Offset: 0x000EA71C
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

		// Token: 0x0600194F RID: 6479 RVA: 0x000EC59B File Offset: 0x000EA79B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrActivityTaskAll.LogPair = null;
			ConfigInfrActivityTaskAll.HandleId = 0;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x000EC5A9 File Offset: 0x000EA7A9
		public static void Init()
		{
			ConfigInfrActivityTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrActivityTaskAll.HandleId, "db_infrastructure.db", "select BinData from `InfrActivityTask`");
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000EC5C4 File Offset: 0x000EA7C4
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

		// Token: 0x04001D5E RID: 7518
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D5F RID: 7519
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D60 RID: 7520
		private const string TABLE = "InfrActivityTask";

		// Token: 0x04001D61 RID: 7521
		private const string COMMAND = "select BinData from `InfrActivityTask`";

		// Token: 0x04001D62 RID: 7522
		private const string KEY_PREFIX = "InfrActivityTaskAll";

		// Token: 0x04001D63 RID: 7523
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D64 RID: 7524
		private static int HandleId;
	}
}
