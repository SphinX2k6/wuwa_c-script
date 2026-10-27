using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000431 RID: 1073
	public class ConfigInfrPhoneTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600192F RID: 6447 RVA: 0x000E7F74 File Offset: 0x000E6174
		static ConfigInfrPhoneTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPhoneTaskAll.CreateStaticDefaultValue), new Action(ConfigInfrPhoneTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x000E7F94 File Offset: 0x000E6194
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrPhoneTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrPhoneTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建_档案馆.xlsx"),
				new ValueTuple<string, object>("表名", "InfrPhoneTask"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrPhoneTask`")
			});
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x000E8013 File Offset: 0x000E6213
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPhoneTaskAll.LogPair = null;
			ConfigInfrPhoneTaskAll.HandleId = 0;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x000E8021 File Offset: 0x000E6221
		public static void Init()
		{
			ConfigInfrPhoneTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPhoneTaskAll.HandleId, "db_infrastructure.db", "select BinData from `InfrPhoneTask`");
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x000E803C File Offset: 0x000E623C
		[NullableContext(2)]
		public static IReadOnlyList<InfrPhoneTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrPhoneTaskAll.HandleId, ConfigInfrPhoneTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrPhoneTask> readOnlyList = (IReadOnlyList<InfrPhoneTask>)ConfigCommon.GetConfig("InfrPhoneTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrPhoneTask> list = new List<InfrPhoneTask>();
			while (ConfigCommon.Step(ConfigInfrPhoneTaskAll.HandleId, false, ConfigInfrPhoneTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrPhoneTaskAll.HandleId, 0, ConfigInfrPhoneTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrPhoneTaskAll.HandleId, ConfigInfrPhoneTaskAll.LogPair);
					return null;
				}
				InfrPhoneTask rootAsInfrPhoneTask = InfrPhoneTask.GetRootAsInfrPhoneTask(new ByteBuffer(item2));
				list.Add(rootAsInfrPhoneTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrPhoneTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrPhoneTaskAll.HandleId, ConfigInfrPhoneTaskAll.LogPair);
			return list;
		}

		// Token: 0x04001D3B RID: 7483
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D3C RID: 7484
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001D3D RID: 7485
		private const string TABLE = "InfrPhoneTask";

		// Token: 0x04001D3E RID: 7486
		private const string COMMAND = "select BinData from `InfrPhoneTask`";

		// Token: 0x04001D3F RID: 7487
		private const string KEY_PREFIX = "InfrPhoneTaskAll";

		// Token: 0x04001D40 RID: 7488
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D41 RID: 7489
		private static int HandleId;
	}
}
