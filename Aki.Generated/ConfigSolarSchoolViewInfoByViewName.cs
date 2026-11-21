using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A36 RID: 2614
	public class ConfigSolarSchoolViewInfoByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D58 RID: 15704 RVA: 0x001B75FF File Offset: 0x001B57FF
		static ConfigSolarSchoolViewInfoByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolViewInfoByViewName.CreateStaticDefaultValue), new Action(ConfigSolarSchoolViewInfoByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x001B7620 File Offset: 0x001B5820
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolViewInfoByViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolViewInfoByViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolViewInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolViewInfo` where ViewName=?")
			});
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x001B769F File Offset: 0x001B589F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolViewInfoByViewName.LogPair = null;
			ConfigSolarSchoolViewInfoByViewName.HandleId = 0;
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x001B76AD File Offset: 0x001B58AD
		public static void Init()
		{
			ConfigSolarSchoolViewInfoByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolViewInfoByViewName.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolViewInfo` where ViewName=?");
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x001B76C8 File Offset: 0x001B58C8
		public static SolarSchoolViewInfo? GetConfig(string p0ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolViewInfoByViewName.HandleId, ConfigSolarSchoolViewInfoByViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("SolarSchoolViewInfoByViewName#" + p0ViewName);
				if (configBuffer != null)
				{
					return new SolarSchoolViewInfo?(SolarSchoolViewInfo.GetRootAsSolarSchoolViewInfo(configBuffer));
				}
			}
			ConfigSolarSchoolViewInfoByViewName.LogPair.Clear();
			ConfigSolarSchoolViewInfoByViewName.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			if (!ConfigCommon.BindString(ConfigSolarSchoolViewInfoByViewName.HandleId, 1, p0ViewName, ConfigSolarSchoolViewInfoByViewName.LogPair) || ConfigCommon.Step(ConfigSolarSchoolViewInfoByViewName.HandleId, true, ConfigSolarSchoolViewInfoByViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolViewInfoByViewName.HandleId, ConfigSolarSchoolViewInfoByViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolViewInfoByViewName.HandleId, 0, ConfigSolarSchoolViewInfoByViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolViewInfoByViewName.HandleId, ConfigSolarSchoolViewInfoByViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolViewInfo rootAsSolarSchoolViewInfo = SolarSchoolViewInfo.GetRootAsSolarSchoolViewInfo(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("SolarSchoolViewInfoByViewName#" + p0ViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolViewInfoByViewName.HandleId, ConfigSolarSchoolViewInfoByViewName.LogPair);
			return new SolarSchoolViewInfo?(rootAsSolarSchoolViewInfo);
		}

		// Token: 0x04004760 RID: 18272
		private const string DB = "db_solarschool.db";

		// Token: 0x04004761 RID: 18273
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004762 RID: 18274
		private const string TABLE = "SolarSchoolViewInfo";

		// Token: 0x04004763 RID: 18275
		private const string COMMAND = "select BinData from `SolarSchoolViewInfo` where ViewName=?";

		// Token: 0x04004764 RID: 18276
		private const string KEY_PREFIX = "SolarSchoolViewInfoByViewName";

		// Token: 0x04004765 RID: 18277
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004766 RID: 18278
		private static int HandleId;
	}
}
