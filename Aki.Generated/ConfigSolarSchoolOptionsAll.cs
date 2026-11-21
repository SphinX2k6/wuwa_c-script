using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F6 RID: 2550
	public class ConfigSolarSchoolOptionsAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BD8 RID: 15320 RVA: 0x001AF128 File Offset: 0x001AD328
		static ConfigSolarSchoolOptionsAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolOptionsAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolOptionsAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x001AF148 File Offset: 0x001AD348
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolOptionsAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolOptionsAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_地点.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolOptions"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolOptions`")
			});
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x001AF1C7 File Offset: 0x001AD3C7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolOptionsAll.LogPair = null;
			ConfigSolarSchoolOptionsAll.HandleId = 0;
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x001AF1D5 File Offset: 0x001AD3D5
		public static void Init()
		{
			ConfigSolarSchoolOptionsAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolOptionsAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolOptions`");
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x001AF1F0 File Offset: 0x001AD3F0
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolOptions> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolOptionsAll.HandleId, ConfigSolarSchoolOptionsAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolOptions> readOnlyList = (IReadOnlyList<SolarSchoolOptions>)ConfigCommon.GetConfig("SolarSchoolOptionsAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolOptions> list = new List<SolarSchoolOptions>();
			while (ConfigCommon.Step(ConfigSolarSchoolOptionsAll.HandleId, false, ConfigSolarSchoolOptionsAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolOptionsAll.HandleId, 0, ConfigSolarSchoolOptionsAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolOptionsAll.HandleId, ConfigSolarSchoolOptionsAll.LogPair);
					return null;
				}
				SolarSchoolOptions rootAsSolarSchoolOptions = SolarSchoolOptions.GetRootAsSolarSchoolOptions(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolOptions);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolOptionsAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolOptionsAll.HandleId, ConfigSolarSchoolOptionsAll.LogPair);
			return list;
		}

		// Token: 0x040045A0 RID: 17824
		private const string DB = "db_solarschool.db";

		// Token: 0x040045A1 RID: 17825
		private const string FILE = "d.第二索拉_地点.xlsx";

		// Token: 0x040045A2 RID: 17826
		private const string TABLE = "SolarSchoolOptions";

		// Token: 0x040045A3 RID: 17827
		private const string COMMAND = "select BinData from `SolarSchoolOptions`";

		// Token: 0x040045A4 RID: 17828
		private const string KEY_PREFIX = "SolarSchoolOptionsAll";

		// Token: 0x040045A5 RID: 17829
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045A6 RID: 17830
		private static int HandleId;
	}
}
