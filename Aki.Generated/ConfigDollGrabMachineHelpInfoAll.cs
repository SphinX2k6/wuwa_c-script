using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000213 RID: 531
	public class ConfigDollGrabMachineHelpInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C75 RID: 3189 RVA: 0x000A0034 File Offset: 0x0009E234
		static ConfigDollGrabMachineHelpInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDollGrabMachineHelpInfoAll.CreateStaticDefaultValue), new Action(ConfigDollGrabMachineHelpInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000A0054 File Offset: 0x0009E254
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

		// Token: 0x06000C77 RID: 3191 RVA: 0x000A00D3 File Offset: 0x0009E2D3
		public static void ResetStaticDefaultValue()
		{
			ConfigDollGrabMachineHelpInfoAll.LogPair = null;
			ConfigDollGrabMachineHelpInfoAll.HandleId = 0;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x000A00E1 File Offset: 0x0009E2E1
		public static void Init()
		{
			ConfigDollGrabMachineHelpInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigDollGrabMachineHelpInfoAll.HandleId, "db_dollgrabmachinehelpinfo.db", "select BinData from `DollGrabMachineHelpInfo`");
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x000A00FC File Offset: 0x0009E2FC
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

		// Token: 0x04000E69 RID: 3689
		private const string DB = "db_dollgrabmachinehelpinfo.db";

		// Token: 0x04000E6A RID: 3690
		private const string FILE = "w.娃娃机帮助文档.xlsx";

		// Token: 0x04000E6B RID: 3691
		private const string TABLE = "DollGrabMachineHelpInfo";

		// Token: 0x04000E6C RID: 3692
		private const string COMMAND = "select BinData from `DollGrabMachineHelpInfo`";

		// Token: 0x04000E6D RID: 3693
		private const string KEY_PREFIX = "DollGrabMachineHelpInfoAll";

		// Token: 0x04000E6E RID: 3694
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E6F RID: 3695
		private static int HandleId;
	}
}
