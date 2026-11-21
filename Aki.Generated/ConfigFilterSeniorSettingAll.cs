using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DD RID: 733
	public class ConfigFilterSeniorSettingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001133 RID: 4403 RVA: 0x000BE378 File Offset: 0x000BC578
		static ConfigFilterSeniorSettingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSeniorSettingAll.CreateStaticDefaultValue), new Action(ConfigFilterSeniorSettingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x000BE398 File Offset: 0x000BC598
		public static void CreateStaticDefaultValue()
		{
			ConfigFilterSeniorSettingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFilterSeniorSettingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "FilterSeniorSetting"),
				new ValueTuple<string, object>("语句", "select BinData from `FilterSeniorSetting`")
			});
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x000BE417 File Offset: 0x000BC617
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSeniorSettingAll.LogPair = null;
			ConfigFilterSeniorSettingAll.HandleId = 0;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x000BE425 File Offset: 0x000BC625
		public static void Init()
		{
			ConfigFilterSeniorSettingAll.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSeniorSettingAll.HandleId, "db_menu.db", "select BinData from `FilterSeniorSetting`");
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x000BE440 File Offset: 0x000BC640
		[NullableContext(2)]
		public static IReadOnlyList<FilterSeniorSetting> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFilterSeniorSettingAll.HandleId, ConfigFilterSeniorSettingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FilterSeniorSetting> readOnlyList = (IReadOnlyList<FilterSeniorSetting>)ConfigCommon.GetConfig("FilterSeniorSettingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FilterSeniorSetting> list = new List<FilterSeniorSetting>();
			while (ConfigCommon.Step(ConfigFilterSeniorSettingAll.HandleId, false, ConfigFilterSeniorSettingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFilterSeniorSettingAll.HandleId, 0, ConfigFilterSeniorSettingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFilterSeniorSettingAll.HandleId, ConfigFilterSeniorSettingAll.LogPair);
					return null;
				}
				FilterSeniorSetting rootAsFilterSeniorSetting = FilterSeniorSetting.GetRootAsFilterSeniorSetting(new ByteBuffer(item2));
				list.Add(rootAsFilterSeniorSetting);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FilterSeniorSettingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFilterSeniorSettingAll.HandleId, ConfigFilterSeniorSettingAll.LogPair);
			return list;
		}

		// Token: 0x040013EF RID: 5103
		private const string DB = "db_menu.db";

		// Token: 0x040013F0 RID: 5104
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x040013F1 RID: 5105
		private const string TABLE = "FilterSeniorSetting";

		// Token: 0x040013F2 RID: 5106
		private const string COMMAND = "select BinData from `FilterSeniorSetting`";

		// Token: 0x040013F3 RID: 5107
		private const string KEY_PREFIX = "FilterSeniorSettingAll";

		// Token: 0x040013F4 RID: 5108
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013F5 RID: 5109
		private static int HandleId;
	}
}
