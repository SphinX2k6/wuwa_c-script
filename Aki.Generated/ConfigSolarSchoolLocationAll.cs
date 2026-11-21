using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F2 RID: 2546
	public class ConfigSolarSchoolLocationAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BC0 RID: 15296 RVA: 0x001AE884 File Offset: 0x001ACA84
		static ConfigSolarSchoolLocationAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolLocationAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolLocationAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x001AE8A4 File Offset: 0x001ACAA4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolLocationAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolLocationAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_地点.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolLocation"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolLocation`")
			});
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x001AE923 File Offset: 0x001ACB23
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolLocationAll.LogPair = null;
			ConfigSolarSchoolLocationAll.HandleId = 0;
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x001AE931 File Offset: 0x001ACB31
		public static void Init()
		{
			ConfigSolarSchoolLocationAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolLocationAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolLocation`");
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x001AE94C File Offset: 0x001ACB4C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolLocation> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolLocationAll.HandleId, ConfigSolarSchoolLocationAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolLocation> readOnlyList = (IReadOnlyList<SolarSchoolLocation>)ConfigCommon.GetConfig("SolarSchoolLocationAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolLocation> list = new List<SolarSchoolLocation>();
			while (ConfigCommon.Step(ConfigSolarSchoolLocationAll.HandleId, false, ConfigSolarSchoolLocationAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolLocationAll.HandleId, 0, ConfigSolarSchoolLocationAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolLocationAll.HandleId, ConfigSolarSchoolLocationAll.LogPair);
					return null;
				}
				SolarSchoolLocation rootAsSolarSchoolLocation = SolarSchoolLocation.GetRootAsSolarSchoolLocation(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolLocation);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolLocationAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolLocationAll.HandleId, ConfigSolarSchoolLocationAll.LogPair);
			return list;
		}

		// Token: 0x04004584 RID: 17796
		private const string DB = "db_solarschool.db";

		// Token: 0x04004585 RID: 17797
		private const string FILE = "d.第二索拉_地点.xlsx";

		// Token: 0x04004586 RID: 17798
		private const string TABLE = "SolarSchoolLocation";

		// Token: 0x04004587 RID: 17799
		private const string COMMAND = "select BinData from `SolarSchoolLocation`";

		// Token: 0x04004588 RID: 17800
		private const string KEY_PREFIX = "SolarSchoolLocationAll";

		// Token: 0x04004589 RID: 17801
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400458A RID: 17802
		private static int HandleId;
	}
}
