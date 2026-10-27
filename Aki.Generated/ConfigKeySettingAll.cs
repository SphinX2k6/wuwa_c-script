using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046A RID: 1130
	public class ConfigKeySettingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A86 RID: 6790 RVA: 0x000EF4E1 File Offset: 0x000ED6E1
		static ConfigKeySettingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeySettingAll.CreateStaticDefaultValue), new Action(ConfigKeySettingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x000EF500 File Offset: 0x000ED700
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

		// Token: 0x06001A88 RID: 6792 RVA: 0x000EF57F File Offset: 0x000ED77F
		public static void ResetStaticDefaultValue()
		{
			ConfigKeySettingAll.LogPair = null;
			ConfigKeySettingAll.HandleId = 0;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000EF58D File Offset: 0x000ED78D
		public static void Init()
		{
			ConfigKeySettingAll.HandleId = ConfigCommon.InitDataStatement(ConfigKeySettingAll.HandleId, "db_menu.db", "select BinData from `KeySetting`");
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000EF5A8 File Offset: 0x000ED7A8
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

		// Token: 0x04001ECA RID: 7882
		private const string DB = "db_menu.db";

		// Token: 0x04001ECB RID: 7883
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001ECC RID: 7884
		private const string TABLE = "KeySetting";

		// Token: 0x04001ECD RID: 7885
		private const string COMMAND = "select BinData from `KeySetting`";

		// Token: 0x04001ECE RID: 7886
		private const string KEY_PREFIX = "KeySettingAll";

		// Token: 0x04001ECF RID: 7887
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001ED0 RID: 7888
		private static int HandleId;
	}
}
