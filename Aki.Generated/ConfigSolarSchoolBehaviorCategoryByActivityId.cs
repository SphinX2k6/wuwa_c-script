using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BD RID: 2493
	public class ConfigSolarSchoolBehaviorCategoryByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A82 RID: 14978 RVA: 0x001A772F File Offset: 0x001A592F
		static ConfigSolarSchoolBehaviorCategoryByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolBehaviorCategoryByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolBehaviorCategoryByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x001A7750 File Offset: 0x001A5950
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolBehaviorCategory"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolBehaviorCategory` where ActivityId=?")
			});
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x001A77CF File Offset: 0x001A59CF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair = null;
			ConfigSolarSchoolBehaviorCategoryByActivityId.HandleId = 0;
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x001A77DD File Offset: 0x001A59DD
		public static void Init()
		{
			ConfigSolarSchoolBehaviorCategoryByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolBehaviorCategoryByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolBehaviorCategory` where ActivityId=?");
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x001A77F8 File Offset: 0x001A59F8
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolBehaviorCategory> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolBehaviorCategoryByActivityId.HandleId, ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBehaviorCategoryByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolBehaviorCategory> readOnlyList = (IReadOnlyList<SolarSchoolBehaviorCategory>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair.Clear();
			ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolBehaviorCategoryByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolBehaviorCategoryByActivityId.HandleId, ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolBehaviorCategory> list = new List<SolarSchoolBehaviorCategory>();
			while (ConfigCommon.Step(ConfigSolarSchoolBehaviorCategoryByActivityId.HandleId, false, ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolBehaviorCategoryByActivityId.HandleId, 0, ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolBehaviorCategoryByActivityId.HandleId, ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair);
					return null;
				}
				SolarSchoolBehaviorCategory rootAsSolarSchoolBehaviorCategory = SolarSchoolBehaviorCategory.GetRootAsSolarSchoolBehaviorCategory(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolBehaviorCategory);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBehaviorCategoryByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolBehaviorCategoryByActivityId.HandleId, ConfigSolarSchoolBehaviorCategoryByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004411 RID: 17425
		private const string DB = "db_solarschool.db";

		// Token: 0x04004412 RID: 17426
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004413 RID: 17427
		private const string TABLE = "SolarSchoolBehaviorCategory";

		// Token: 0x04004414 RID: 17428
		private const string COMMAND = "select BinData from `SolarSchoolBehaviorCategory` where ActivityId=?";

		// Token: 0x04004415 RID: 17429
		private const string KEY_PREFIX = "SolarSchoolBehaviorCategoryByActivityId";

		// Token: 0x04004416 RID: 17430
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004417 RID: 17431
		private static int HandleId;
	}
}
