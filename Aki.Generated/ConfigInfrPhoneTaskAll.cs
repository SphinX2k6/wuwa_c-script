using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000447 RID: 1095
	public class ConfigInfrPhoneTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019B3 RID: 6579 RVA: 0x000EE6C8 File Offset: 0x000EC8C8
		static ConfigInfrPhoneTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPhoneTaskAll.CreateStaticDefaultValue), new Action(ConfigInfrPhoneTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x000EE6E8 File Offset: 0x000EC8E8
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

		// Token: 0x060019B5 RID: 6581 RVA: 0x000EE767 File Offset: 0x000EC967
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPhoneTaskAll.LogPair = null;
			ConfigInfrPhoneTaskAll.HandleId = 0;
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x000EE775 File Offset: 0x000EC975
		public static void Init()
		{
			ConfigInfrPhoneTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPhoneTaskAll.HandleId, "db_infrastructure.db", "select BinData from `InfrPhoneTask`");
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x000EE790 File Offset: 0x000EC990
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

		// Token: 0x04001DD5 RID: 7637
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DD6 RID: 7638
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001DD7 RID: 7639
		private const string TABLE = "InfrPhoneTask";

		// Token: 0x04001DD8 RID: 7640
		private const string COMMAND = "select BinData from `InfrPhoneTask`";

		// Token: 0x04001DD9 RID: 7641
		private const string KEY_PREFIX = "InfrPhoneTaskAll";

		// Token: 0x04001DDA RID: 7642
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DDB RID: 7643
		private static int HandleId;
	}
}
