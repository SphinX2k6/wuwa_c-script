using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F9 RID: 2553
	public class ConfigSolarSchoolParamAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BEA RID: 15338 RVA: 0x001AF73C File Offset: 0x001AD93C
		static ConfigSolarSchoolParamAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolParamAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolParamAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x001AF75C File Offset: 0x001AD95C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolParamAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolParamAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolParam"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolParam`")
			});
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x001AF7DB File Offset: 0x001AD9DB
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolParamAll.LogPair = null;
			ConfigSolarSchoolParamAll.HandleId = 0;
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x001AF7E9 File Offset: 0x001AD9E9
		public static void Init()
		{
			ConfigSolarSchoolParamAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolParamAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolParam`");
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x001AF804 File Offset: 0x001ADA04
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolParam> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolParamAll.HandleId, ConfigSolarSchoolParamAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolParam> readOnlyList = (IReadOnlyList<SolarSchoolParam>)ConfigCommon.GetConfig("SolarSchoolParamAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolParam> list = new List<SolarSchoolParam>();
			while (ConfigCommon.Step(ConfigSolarSchoolParamAll.HandleId, false, ConfigSolarSchoolParamAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolParamAll.HandleId, 0, ConfigSolarSchoolParamAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolParamAll.HandleId, ConfigSolarSchoolParamAll.LogPair);
					return null;
				}
				SolarSchoolParam rootAsSolarSchoolParam = SolarSchoolParam.GetRootAsSolarSchoolParam(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolParam);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolParamAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolParamAll.HandleId, ConfigSolarSchoolParamAll.LogPair);
			return list;
		}

		// Token: 0x040045B5 RID: 17845
		private const string DB = "db_solarschool.db";

		// Token: 0x040045B6 RID: 17846
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x040045B7 RID: 17847
		private const string TABLE = "SolarSchoolParam";

		// Token: 0x040045B8 RID: 17848
		private const string COMMAND = "select BinData from `SolarSchoolParam`";

		// Token: 0x040045B9 RID: 17849
		private const string KEY_PREFIX = "SolarSchoolParamAll";

		// Token: 0x040045BA RID: 17850
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045BB RID: 17851
		private static int HandleId;
	}
}
