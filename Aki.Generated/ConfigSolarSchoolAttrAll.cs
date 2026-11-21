using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B2 RID: 2482
	public class ConfigSolarSchoolAttrAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A40 RID: 14912 RVA: 0x001A6128 File Offset: 0x001A4328
		static ConfigSolarSchoolAttrAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolAttrAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolAttrAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x001A6148 File Offset: 0x001A4348
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolAttrAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolAttrAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolAttr`")
			});
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x001A61C7 File Offset: 0x001A43C7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolAttrAll.LogPair = null;
			ConfigSolarSchoolAttrAll.HandleId = 0;
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x001A61D5 File Offset: 0x001A43D5
		public static void Init()
		{
			ConfigSolarSchoolAttrAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolAttrAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolAttr`");
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x001A61F0 File Offset: 0x001A43F0
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolAttr> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolAttrAll.HandleId, ConfigSolarSchoolAttrAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolAttr> readOnlyList = (IReadOnlyList<SolarSchoolAttr>)ConfigCommon.GetConfig("SolarSchoolAttrAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolAttr> list = new List<SolarSchoolAttr>();
			while (ConfigCommon.Step(ConfigSolarSchoolAttrAll.HandleId, false, ConfigSolarSchoolAttrAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolAttrAll.HandleId, 0, ConfigSolarSchoolAttrAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolAttrAll.HandleId, ConfigSolarSchoolAttrAll.LogPair);
					return null;
				}
				SolarSchoolAttr rootAsSolarSchoolAttr = SolarSchoolAttr.GetRootAsSolarSchoolAttr(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolAttr);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolAttrAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolAttrAll.HandleId, ConfigSolarSchoolAttrAll.LogPair);
			return list;
		}

		// Token: 0x040043C4 RID: 17348
		private const string DB = "db_solarschool.db";

		// Token: 0x040043C5 RID: 17349
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x040043C6 RID: 17350
		private const string TABLE = "SolarSchoolAttr";

		// Token: 0x040043C7 RID: 17351
		private const string COMMAND = "select BinData from `SolarSchoolAttr`";

		// Token: 0x040043C8 RID: 17352
		private const string KEY_PREFIX = "SolarSchoolAttrAll";

		// Token: 0x040043C9 RID: 17353
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043CA RID: 17354
		private static int HandleId;
	}
}
