using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B8 RID: 2488
	public class ConfigSolarSchoolBehaviorAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A64 RID: 14948 RVA: 0x001A6D50 File Offset: 0x001A4F50
		static ConfigSolarSchoolBehaviorAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolBehaviorAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolBehaviorAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x001A6D70 File Offset: 0x001A4F70
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolBehaviorAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolBehavior"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolBehavior`")
			});
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x001A6DEF File Offset: 0x001A4FEF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorAll.LogPair = null;
			ConfigSolarSchoolBehaviorAll.HandleId = 0;
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x001A6DFD File Offset: 0x001A4FFD
		public static void Init()
		{
			ConfigSolarSchoolBehaviorAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolBehaviorAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolBehavior`");
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x001A6E18 File Offset: 0x001A5018
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolBehavior> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolBehaviorAll.HandleId, ConfigSolarSchoolBehaviorAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolBehavior> readOnlyList = (IReadOnlyList<SolarSchoolBehavior>)ConfigCommon.GetConfig("SolarSchoolBehaviorAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolBehavior> list = new List<SolarSchoolBehavior>();
			while (ConfigCommon.Step(ConfigSolarSchoolBehaviorAll.HandleId, false, ConfigSolarSchoolBehaviorAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolBehaviorAll.HandleId, 0, ConfigSolarSchoolBehaviorAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolBehaviorAll.HandleId, ConfigSolarSchoolBehaviorAll.LogPair);
					return null;
				}
				SolarSchoolBehavior rootAsSolarSchoolBehavior = SolarSchoolBehavior.GetRootAsSolarSchoolBehavior(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolBehavior);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolBehaviorAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolBehaviorAll.HandleId, ConfigSolarSchoolBehaviorAll.LogPair);
			return list;
		}

		// Token: 0x040043EE RID: 17390
		private const string DB = "db_solarschool.db";

		// Token: 0x040043EF RID: 17391
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x040043F0 RID: 17392
		private const string TABLE = "SolarSchoolBehavior";

		// Token: 0x040043F1 RID: 17393
		private const string COMMAND = "select BinData from `SolarSchoolBehavior`";

		// Token: 0x040043F2 RID: 17394
		private const string KEY_PREFIX = "SolarSchoolBehaviorAll";

		// Token: 0x040043F3 RID: 17395
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043F4 RID: 17396
		private static int HandleId;
	}
}
