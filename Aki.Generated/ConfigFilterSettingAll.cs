using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CA RID: 714
	public class ConfigFilterSettingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010C1 RID: 4289 RVA: 0x000B8248 File Offset: 0x000B6448
		static ConfigFilterSettingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSettingAll.CreateStaticDefaultValue), new Action(ConfigFilterSettingAll.ResetStaticDefaultValue));
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x000B8268 File Offset: 0x000B6468
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

		// Token: 0x060010C3 RID: 4291 RVA: 0x000B82E7 File Offset: 0x000B64E7
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSettingAll.LogPair = null;
			ConfigFilterSettingAll.HandleId = 0;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x000B82F5 File Offset: 0x000B64F5
		public static void Init()
		{
			ConfigFilterSettingAll.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSettingAll.HandleId, "db_menu.db", "select BinData from `FilterSetting`");
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x000B8310 File Offset: 0x000B6510
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

		// Token: 0x0400136A RID: 4970
		private const string DB = "db_menu.db";

		// Token: 0x0400136B RID: 4971
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x0400136C RID: 4972
		private const string TABLE = "FilterSetting";

		// Token: 0x0400136D RID: 4973
		private const string COMMAND = "select BinData from `FilterSetting`";

		// Token: 0x0400136E RID: 4974
		private const string KEY_PREFIX = "FilterSettingAll";

		// Token: 0x0400136F RID: 4975
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001370 RID: 4976
		private static int HandleId;
	}
}
