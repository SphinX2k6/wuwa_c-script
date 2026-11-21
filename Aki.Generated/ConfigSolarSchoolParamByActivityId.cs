using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FA RID: 2554
	public class ConfigSolarSchoolParamByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BF0 RID: 15344 RVA: 0x001AF8CF File Offset: 0x001ADACF
		static ConfigSolarSchoolParamByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolParamByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolParamByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x001AF8F0 File Offset: 0x001ADAF0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolParamByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolParamByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolParam"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolParam` where ActivityId=?")
			});
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x001AF96F File Offset: 0x001ADB6F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolParamByActivityId.LogPair = null;
			ConfigSolarSchoolParamByActivityId.HandleId = 0;
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x001AF97D File Offset: 0x001ADB7D
		public static void Init()
		{
			ConfigSolarSchoolParamByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolParamByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolParam` where ActivityId=?");
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x001AF998 File Offset: 0x001ADB98
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolParam> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolParamByActivityId.HandleId, ConfigSolarSchoolParamByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolParamByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolParam> readOnlyList = (IReadOnlyList<SolarSchoolParam>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolParamByActivityId.LogPair.Clear();
			ConfigSolarSchoolParamByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolParamByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolParamByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolParamByActivityId.HandleId, ConfigSolarSchoolParamByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolParam> list = new List<SolarSchoolParam>();
			while (ConfigCommon.Step(ConfigSolarSchoolParamByActivityId.HandleId, false, ConfigSolarSchoolParamByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolParamByActivityId.HandleId, 0, ConfigSolarSchoolParamByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolParamByActivityId.HandleId, ConfigSolarSchoolParamByActivityId.LogPair);
					return null;
				}
				SolarSchoolParam rootAsSolarSchoolParam = SolarSchoolParam.GetRootAsSolarSchoolParam(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolParam);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolParamByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolParamByActivityId.HandleId, ConfigSolarSchoolParamByActivityId.LogPair);
			return list;
		}

		// Token: 0x040045BC RID: 17852
		private const string DB = "db_solarschool.db";

		// Token: 0x040045BD RID: 17853
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x040045BE RID: 17854
		private const string TABLE = "SolarSchoolParam";

		// Token: 0x040045BF RID: 17855
		private const string COMMAND = "select BinData from `SolarSchoolParam` where ActivityId=?";

		// Token: 0x040045C0 RID: 17856
		private const string KEY_PREFIX = "SolarSchoolParamByActivityId";

		// Token: 0x040045C1 RID: 17857
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045C2 RID: 17858
		private static int HandleId;
	}
}
