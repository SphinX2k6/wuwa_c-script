using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000215 RID: 533
	public class ConfigDeviceInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C81 RID: 3201 RVA: 0x000A3ED0 File Offset: 0x000A20D0
		static ConfigDeviceInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDeviceInfoAll.CreateStaticDefaultValue), new Action(ConfigDeviceInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000A3EF0 File Offset: 0x000A20F0
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

		// Token: 0x06000C83 RID: 3203 RVA: 0x000A3F6F File Offset: 0x000A216F
		public static void ResetStaticDefaultValue()
		{
			ConfigDeviceInfoAll.LogPair = null;
			ConfigDeviceInfoAll.HandleId = 0;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000A3F7D File Offset: 0x000A217D
		public static void Init()
		{
			ConfigDeviceInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigDeviceInfoAll.HandleId, "db_menu.db", "select BinData from `DeviceInfo`");
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000A3F98 File Offset: 0x000A2198
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

		// Token: 0x04000E77 RID: 3703
		private const string DB = "db_menu.db";

		// Token: 0x04000E78 RID: 3704
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04000E79 RID: 3705
		private const string TABLE = "DeviceInfo";

		// Token: 0x04000E7A RID: 3706
		private const string COMMAND = "select BinData from `DeviceInfo`";

		// Token: 0x04000E7B RID: 3707
		private const string KEY_PREFIX = "DeviceInfoAll";

		// Token: 0x04000E7C RID: 3708
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E7D RID: 3709
		private static int HandleId;
	}
}
