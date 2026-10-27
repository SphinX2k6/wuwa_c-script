using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C8 RID: 712
	public class ConfigFilterSeniorSettingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010B5 RID: 4277 RVA: 0x000B7E6C File Offset: 0x000B606C
		static ConfigFilterSeniorSettingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSeniorSettingAll.CreateStaticDefaultValue), new Action(ConfigFilterSeniorSettingAll.ResetStaticDefaultValue));
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x000B7E8C File Offset: 0x000B608C
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

		// Token: 0x060010B7 RID: 4279 RVA: 0x000B7F0B File Offset: 0x000B610B
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSeniorSettingAll.LogPair = null;
			ConfigFilterSeniorSettingAll.HandleId = 0;
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x000B7F19 File Offset: 0x000B6119
		public static void Init()
		{
			ConfigFilterSeniorSettingAll.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSeniorSettingAll.HandleId, "db_menu.db", "select BinData from `FilterSeniorSetting`");
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x000B7F34 File Offset: 0x000B6134
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

		// Token: 0x0400135C RID: 4956
		private const string DB = "db_menu.db";

		// Token: 0x0400135D RID: 4957
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x0400135E RID: 4958
		private const string TABLE = "FilterSeniorSetting";

		// Token: 0x0400135F RID: 4959
		private const string COMMAND = "select BinData from `FilterSeniorSetting`";

		// Token: 0x04001360 RID: 4960
		private const string KEY_PREFIX = "FilterSeniorSettingAll";

		// Token: 0x04001361 RID: 4961
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001362 RID: 4962
		private static int HandleId;
	}
}
