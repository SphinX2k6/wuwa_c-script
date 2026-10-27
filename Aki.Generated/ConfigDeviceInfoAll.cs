using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000203 RID: 515
	public class ConfigDeviceInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C15 RID: 3093 RVA: 0x0009DF98 File Offset: 0x0009C198
		static ConfigDeviceInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDeviceInfoAll.CreateStaticDefaultValue), new Action(ConfigDeviceInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0009DFB8 File Offset: 0x0009C1B8
		public static void CreateStaticDefaultValue()
		{
			ConfigDeviceInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDeviceInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "DeviceInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `DeviceInfo`")
			});
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0009E037 File Offset: 0x0009C237
		public static void ResetStaticDefaultValue()
		{
			ConfigDeviceInfoAll.LogPair = null;
			ConfigDeviceInfoAll.HandleId = 0;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0009E045 File Offset: 0x0009C245
		public static void Init()
		{
			ConfigDeviceInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigDeviceInfoAll.HandleId, "db_menu.db", "select BinData from `DeviceInfo`");
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0009E060 File Offset: 0x0009C260
		[NullableContext(2)]
		public static IReadOnlyList<DeviceInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDeviceInfoAll.HandleId, ConfigDeviceInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DeviceInfo> readOnlyList = (IReadOnlyList<DeviceInfo>)ConfigCommon.GetConfig("DeviceInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DeviceInfo> list = new List<DeviceInfo>();
			while (ConfigCommon.Step(ConfigDeviceInfoAll.HandleId, false, ConfigDeviceInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDeviceInfoAll.HandleId, 0, ConfigDeviceInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDeviceInfoAll.HandleId, ConfigDeviceInfoAll.LogPair);
					return null;
				}
				DeviceInfo rootAsDeviceInfo = DeviceInfo.GetRootAsDeviceInfo(new ByteBuffer(item2));
				list.Add(rootAsDeviceInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DeviceInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDeviceInfoAll.HandleId, ConfigDeviceInfoAll.LogPair);
			return list;
		}

		// Token: 0x04000DF9 RID: 3577
		private const string DB = "db_menu.db";

		// Token: 0x04000DFA RID: 3578
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04000DFB RID: 3579
		private const string TABLE = "DeviceInfo";

		// Token: 0x04000DFC RID: 3580
		private const string COMMAND = "select BinData from `DeviceInfo`";

		// Token: 0x04000DFD RID: 3581
		private const string KEY_PREFIX = "DeviceInfoAll";

		// Token: 0x04000DFE RID: 3582
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DFF RID: 3583
		private static int HandleId;
	}
}
