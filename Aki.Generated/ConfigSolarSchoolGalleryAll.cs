using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E4 RID: 2532
	public class ConfigSolarSchoolGalleryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B6C RID: 15212 RVA: 0x001ACB30 File Offset: 0x001AAD30
		static ConfigSolarSchoolGalleryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolGalleryAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolGalleryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x001ACB50 File Offset: 0x001AAD50
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolGalleryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolGalleryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolGallery"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolGallery`")
			});
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x001ACBCF File Offset: 0x001AADCF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolGalleryAll.LogPair = null;
			ConfigSolarSchoolGalleryAll.HandleId = 0;
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x001ACBDD File Offset: 0x001AADDD
		public static void Init()
		{
			ConfigSolarSchoolGalleryAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolGalleryAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolGallery`");
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x001ACBF8 File Offset: 0x001AADF8
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolGallery> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolGalleryAll.HandleId, ConfigSolarSchoolGalleryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolGallery> readOnlyList = (IReadOnlyList<SolarSchoolGallery>)ConfigCommon.GetConfig("SolarSchoolGalleryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolGallery> list = new List<SolarSchoolGallery>();
			while (ConfigCommon.Step(ConfigSolarSchoolGalleryAll.HandleId, false, ConfigSolarSchoolGalleryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolGalleryAll.HandleId, 0, ConfigSolarSchoolGalleryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolGalleryAll.HandleId, ConfigSolarSchoolGalleryAll.LogPair);
					return null;
				}
				SolarSchoolGallery rootAsSolarSchoolGallery = SolarSchoolGallery.GetRootAsSolarSchoolGallery(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolGallery);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolGalleryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolGalleryAll.HandleId, ConfigSolarSchoolGalleryAll.LogPair);
			return list;
		}

		// Token: 0x04004522 RID: 17698
		private const string DB = "db_solarschool.db";

		// Token: 0x04004523 RID: 17699
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x04004524 RID: 17700
		private const string TABLE = "SolarSchoolGallery";

		// Token: 0x04004525 RID: 17701
		private const string COMMAND = "select BinData from `SolarSchoolGallery`";

		// Token: 0x04004526 RID: 17702
		private const string KEY_PREFIX = "SolarSchoolGalleryAll";

		// Token: 0x04004527 RID: 17703
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004528 RID: 17704
		private static int HandleId;
	}
}
