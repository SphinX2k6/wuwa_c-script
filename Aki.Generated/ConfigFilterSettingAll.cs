using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DF RID: 735
	public class ConfigFilterSettingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600113F RID: 4415 RVA: 0x000BE754 File Offset: 0x000BC954
		static ConfigFilterSettingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSettingAll.CreateStaticDefaultValue), new Action(ConfigFilterSettingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x000BE774 File Offset: 0x000BC974
		public static void CreateStaticDefaultValue()
		{
			ConfigFilterSettingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFilterSettingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "FilterSetting"),
				new ValueTuple<string, object>("语句", "select BinData from `FilterSetting`")
			});
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000BE7F3 File Offset: 0x000BC9F3
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSettingAll.LogPair = null;
			ConfigFilterSettingAll.HandleId = 0;
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x000BE801 File Offset: 0x000BCA01
		public static void Init()
		{
			ConfigFilterSettingAll.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSettingAll.HandleId, "db_menu.db", "select BinData from `FilterSetting`");
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x000BE81C File Offset: 0x000BCA1C
		[NullableContext(2)]
		public static IReadOnlyList<FilterSetting> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFilterSettingAll.HandleId, ConfigFilterSettingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FilterSetting> readOnlyList = (IReadOnlyList<FilterSetting>)ConfigCommon.GetConfig("FilterSettingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FilterSetting> list = new List<FilterSetting>();
			while (ConfigCommon.Step(ConfigFilterSettingAll.HandleId, false, ConfigFilterSettingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFilterSettingAll.HandleId, 0, ConfigFilterSettingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFilterSettingAll.HandleId, ConfigFilterSettingAll.LogPair);
					return null;
				}
				FilterSetting rootAsFilterSetting = FilterSetting.GetRootAsFilterSetting(new ByteBuffer(item2));
				list.Add(rootAsFilterSetting);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FilterSettingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFilterSettingAll.HandleId, ConfigFilterSettingAll.LogPair);
			return list;
		}

		// Token: 0x040013FD RID: 5117
		private const string DB = "db_menu.db";

		// Token: 0x040013FE RID: 5118
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x040013FF RID: 5119
		private const string TABLE = "FilterSetting";

		// Token: 0x04001400 RID: 5120
		private const string COMMAND = "select BinData from `FilterSetting`";

		// Token: 0x04001401 RID: 5121
		private const string KEY_PREFIX = "FilterSettingAll";

		// Token: 0x04001402 RID: 5122
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001403 RID: 5123
		private static int HandleId;
	}
}
