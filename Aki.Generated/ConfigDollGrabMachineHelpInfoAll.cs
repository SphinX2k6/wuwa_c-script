using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000225 RID: 549
	public class ConfigDollGrabMachineHelpInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CE1 RID: 3297 RVA: 0x000A5F6C File Offset: 0x000A416C
		static ConfigDollGrabMachineHelpInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDollGrabMachineHelpInfoAll.CreateStaticDefaultValue), new Action(ConfigDollGrabMachineHelpInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x000A5F8C File Offset: 0x000A418C
		public static void CreateStaticDefaultValue()
		{
			ConfigDollGrabMachineHelpInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDollGrabMachineHelpInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dollgrabmachinehelpinfo.db"),
				new ValueTuple<string, object>("文件", "w.娃娃机帮助文档.xlsx"),
				new ValueTuple<string, object>("表名", "DollGrabMachineHelpInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `DollGrabMachineHelpInfo`")
			});
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000A600B File Offset: 0x000A420B
		public static void ResetStaticDefaultValue()
		{
			ConfigDollGrabMachineHelpInfoAll.LogPair = null;
			ConfigDollGrabMachineHelpInfoAll.HandleId = 0;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000A6019 File Offset: 0x000A4219
		public static void Init()
		{
			ConfigDollGrabMachineHelpInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigDollGrabMachineHelpInfoAll.HandleId, "db_dollgrabmachinehelpinfo.db", "select BinData from `DollGrabMachineHelpInfo`");
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000A6034 File Offset: 0x000A4234
		[NullableContext(2)]
		public static IReadOnlyList<DollGrabMachineHelpInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDollGrabMachineHelpInfoAll.HandleId, ConfigDollGrabMachineHelpInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DollGrabMachineHelpInfo> readOnlyList = (IReadOnlyList<DollGrabMachineHelpInfo>)ConfigCommon.GetConfig("DollGrabMachineHelpInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DollGrabMachineHelpInfo> list = new List<DollGrabMachineHelpInfo>();
			while (ConfigCommon.Step(ConfigDollGrabMachineHelpInfoAll.HandleId, false, ConfigDollGrabMachineHelpInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDollGrabMachineHelpInfoAll.HandleId, 0, ConfigDollGrabMachineHelpInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDollGrabMachineHelpInfoAll.HandleId, ConfigDollGrabMachineHelpInfoAll.LogPair);
					return null;
				}
				DollGrabMachineHelpInfo rootAsDollGrabMachineHelpInfo = DollGrabMachineHelpInfo.GetRootAsDollGrabMachineHelpInfo(new ByteBuffer(item2));
				list.Add(rootAsDollGrabMachineHelpInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DollGrabMachineHelpInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDollGrabMachineHelpInfoAll.HandleId, ConfigDollGrabMachineHelpInfoAll.LogPair);
			return list;
		}

		// Token: 0x04000EE7 RID: 3815
		private const string DB = "db_dollgrabmachinehelpinfo.db";

		// Token: 0x04000EE8 RID: 3816
		private const string FILE = "w.娃娃机帮助文档.xlsx";

		// Token: 0x04000EE9 RID: 3817
		private const string TABLE = "DollGrabMachineHelpInfo";

		// Token: 0x04000EEA RID: 3818
		private const string COMMAND = "select BinData from `DollGrabMachineHelpInfo`";

		// Token: 0x04000EEB RID: 3819
		private const string KEY_PREFIX = "DollGrabMachineHelpInfoAll";

		// Token: 0x04000EEC RID: 3820
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EED RID: 3821
		private static int HandleId;
	}
}
