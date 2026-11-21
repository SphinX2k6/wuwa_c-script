using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000480 RID: 1152
	public class ConfigKeySettingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B0A RID: 6922 RVA: 0x000F5C35 File Offset: 0x000F3E35
		static ConfigKeySettingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeySettingAll.CreateStaticDefaultValue), new Action(ConfigKeySettingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000F5C54 File Offset: 0x000F3E54
		public static void CreateStaticDefaultValue()
		{
			ConfigKeySettingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKeySettingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "KeySetting"),
				new ValueTuple<string, object>("语句", "select BinData from `KeySetting`")
			});
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x000F5CD3 File Offset: 0x000F3ED3
		public static void ResetStaticDefaultValue()
		{
			ConfigKeySettingAll.LogPair = null;
			ConfigKeySettingAll.HandleId = 0;
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000F5CE1 File Offset: 0x000F3EE1
		public static void Init()
		{
			ConfigKeySettingAll.HandleId = ConfigCommon.InitDataStatement(ConfigKeySettingAll.HandleId, "db_menu.db", "select BinData from `KeySetting`");
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000F5CFC File Offset: 0x000F3EFC
		[NullableContext(2)]
		public static IReadOnlyList<KeySetting> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKeySettingAll.HandleId, ConfigKeySettingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KeySetting> readOnlyList = (IReadOnlyList<KeySetting>)ConfigCommon.GetConfig("KeySettingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KeySetting> list = new List<KeySetting>();
			while (ConfigCommon.Step(ConfigKeySettingAll.HandleId, false, ConfigKeySettingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKeySettingAll.HandleId, 0, ConfigKeySettingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKeySettingAll.HandleId, ConfigKeySettingAll.LogPair);
					return null;
				}
				KeySetting rootAsKeySetting = KeySetting.GetRootAsKeySetting(new ByteBuffer(item2));
				list.Add(rootAsKeySetting);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KeySettingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKeySettingAll.HandleId, ConfigKeySettingAll.LogPair);
			return list;
		}

		// Token: 0x04001F64 RID: 8036
		private const string DB = "db_menu.db";

		// Token: 0x04001F65 RID: 8037
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001F66 RID: 8038
		private const string TABLE = "KeySetting";

		// Token: 0x04001F67 RID: 8039
		private const string COMMAND = "select BinData from `KeySetting`";

		// Token: 0x04001F68 RID: 8040
		private const string KEY_PREFIX = "KeySettingAll";

		// Token: 0x04001F69 RID: 8041
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F6A RID: 8042
		private static int HandleId;
	}
}
