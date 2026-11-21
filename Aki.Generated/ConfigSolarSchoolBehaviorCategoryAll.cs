using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BC RID: 2492
	public class ConfigSolarSchoolBehaviorCategoryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A7C RID: 14972 RVA: 0x001A759C File Offset: 0x001A579C
		static ConfigSolarSchoolBehaviorCategoryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolBehaviorCategoryAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolBehaviorCategoryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x001A75BC File Offset: 0x001A57BC
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorCategoryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolBehaviorCategoryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolBehaviorCategory"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolBehaviorCategory`")
			});
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x001A763B File Offset: 0x001A583B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorCategoryAll.LogPair = null;
			ConfigSolarSchoolBehaviorCategoryAll.HandleId = 0;
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x001A7649 File Offset: 0x001A5849
		public static void Init()
		{
			ConfigSolarSchoolBehaviorCategoryAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolBehaviorCategoryAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolBehaviorCategory`");
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x001A7664 File Offset: 0x001A5864
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolBehaviorCategory> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolBehaviorCategoryAll.HandleId, ConfigSolarSchoolBehaviorCategoryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolBehaviorCategory> readOnlyList = (IReadOnlyList<SolarSchoolBehaviorCategory>)ConfigCommon.GetConfig("SolarSchoolBehaviorCategoryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolBehaviorCategory> list = new List<SolarSchoolBehaviorCategory>();
			while (ConfigCommon.Step(ConfigSolarSchoolBehaviorCategoryAll.HandleId, false, ConfigSolarSchoolBehaviorCategoryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolBehaviorCategoryAll.HandleId, 0, ConfigSolarSchoolBehaviorCategoryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolBehaviorCategoryAll.HandleId, ConfigSolarSchoolBehaviorCategoryAll.LogPair);
					return null;
				}
				SolarSchoolBehaviorCategory rootAsSolarSchoolBehaviorCategory = SolarSchoolBehaviorCategory.GetRootAsSolarSchoolBehaviorCategory(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolBehaviorCategory);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolBehaviorCategoryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolBehaviorCategoryAll.HandleId, ConfigSolarSchoolBehaviorCategoryAll.LogPair);
			return list;
		}

		// Token: 0x0400440A RID: 17418
		private const string DB = "db_solarschool.db";

		// Token: 0x0400440B RID: 17419
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x0400440C RID: 17420
		private const string TABLE = "SolarSchoolBehaviorCategory";

		// Token: 0x0400440D RID: 17421
		private const string COMMAND = "select BinData from `SolarSchoolBehaviorCategory`";

		// Token: 0x0400440E RID: 17422
		private const string KEY_PREFIX = "SolarSchoolBehaviorCategoryAll";

		// Token: 0x0400440F RID: 17423
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004410 RID: 17424
		private static int HandleId;
	}
}
