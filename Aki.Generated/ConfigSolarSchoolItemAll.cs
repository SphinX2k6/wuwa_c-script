using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009EB RID: 2539
	public class ConfigSolarSchoolItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B96 RID: 15254 RVA: 0x001ADA04 File Offset: 0x001ABC04
		static ConfigSolarSchoolItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolItemAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x001ADA24 File Offset: 0x001ABC24
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolItem`")
			});
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x001ADAA3 File Offset: 0x001ABCA3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolItemAll.LogPair = null;
			ConfigSolarSchoolItemAll.HandleId = 0;
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x001ADAB1 File Offset: 0x001ABCB1
		public static void Init()
		{
			ConfigSolarSchoolItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolItemAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolItem`");
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x001ADACC File Offset: 0x001ABCCC
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolItemAll.HandleId, ConfigSolarSchoolItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolItem> readOnlyList = (IReadOnlyList<SolarSchoolItem>)ConfigCommon.GetConfig("SolarSchoolItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolItem> list = new List<SolarSchoolItem>();
			while (ConfigCommon.Step(ConfigSolarSchoolItemAll.HandleId, false, ConfigSolarSchoolItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolItemAll.HandleId, 0, ConfigSolarSchoolItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolItemAll.HandleId, ConfigSolarSchoolItemAll.LogPair);
					return null;
				}
				SolarSchoolItem rootAsSolarSchoolItem = SolarSchoolItem.GetRootAsSolarSchoolItem(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolItemAll.HandleId, ConfigSolarSchoolItemAll.LogPair);
			return list;
		}

		// Token: 0x04004553 RID: 17747
		private const string DB = "db_solarschool.db";

		// Token: 0x04004554 RID: 17748
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x04004555 RID: 17749
		private const string TABLE = "SolarSchoolItem";

		// Token: 0x04004556 RID: 17750
		private const string COMMAND = "select BinData from `SolarSchoolItem`";

		// Token: 0x04004557 RID: 17751
		private const string KEY_PREFIX = "SolarSchoolItemAll";

		// Token: 0x04004558 RID: 17752
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004559 RID: 17753
		private static int HandleId;
	}
}
