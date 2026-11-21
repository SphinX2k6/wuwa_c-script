using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FB RID: 2555
	public class ConfigSolarSchoolParamByActivityIdAndKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BF6 RID: 15350 RVA: 0x001AFB07 File Offset: 0x001ADD07
		static ConfigSolarSchoolParamByActivityIdAndKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolParamByActivityIdAndKey.CreateStaticDefaultValue), new Action(ConfigSolarSchoolParamByActivityIdAndKey.ResetStaticDefaultValue));
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x001AFB28 File Offset: 0x001ADD28
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolParamByActivityIdAndKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolParamByActivityIdAndKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolParam"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolParam` where ActivityId=? AND Key=?")
			});
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x001AFBA7 File Offset: 0x001ADDA7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolParamByActivityIdAndKey.LogPair = null;
			ConfigSolarSchoolParamByActivityIdAndKey.HandleId = 0;
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x001AFBB5 File Offset: 0x001ADDB5
		public static void Init()
		{
			ConfigSolarSchoolParamByActivityIdAndKey.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolParamByActivityIdAndKey.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolParam` where ActivityId=? AND Key=?");
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x001AFBD0 File Offset: 0x001ADDD0
		public static SolarSchoolParam? GetConfig(int p0ActivityId, string p1Key, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolParamByActivityIdAndKey.HandleId, ConfigSolarSchoolParamByActivityIdAndKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolParamByActivityIdAndKey");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1Key);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolParam?(SolarSchoolParam.GetRootAsSolarSchoolParam(configBuffer));
				}
			}
			ConfigSolarSchoolParamByActivityIdAndKey.LogPair.Clear();
			ConfigSolarSchoolParamByActivityIdAndKey.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigSolarSchoolParamByActivityIdAndKey.LogPair.Add(new ValueTuple<string, object>("Key", p1Key));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolParamByActivityIdAndKey.HandleId, 1, p0ActivityId, ConfigSolarSchoolParamByActivityIdAndKey.LogPair) || !ConfigCommon.BindString(ConfigSolarSchoolParamByActivityIdAndKey.HandleId, 2, p1Key, ConfigSolarSchoolParamByActivityIdAndKey.LogPair) || ConfigCommon.Step(ConfigSolarSchoolParamByActivityIdAndKey.HandleId, true, ConfigSolarSchoolParamByActivityIdAndKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolParamByActivityIdAndKey.HandleId, ConfigSolarSchoolParamByActivityIdAndKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolParamByActivityIdAndKey.HandleId, 0, ConfigSolarSchoolParamByActivityIdAndKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolParamByActivityIdAndKey.HandleId, ConfigSolarSchoolParamByActivityIdAndKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolParam rootAsSolarSchoolParam = SolarSchoolParam.GetRootAsSolarSchoolParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolParamByActivityIdAndKey");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1Key);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolParamByActivityIdAndKey.HandleId, ConfigSolarSchoolParamByActivityIdAndKey.LogPair);
			return new SolarSchoolParam?(rootAsSolarSchoolParam);
		}

		// Token: 0x040045C3 RID: 17859
		private const string DB = "db_solarschool.db";

		// Token: 0x040045C4 RID: 17860
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x040045C5 RID: 17861
		private const string TABLE = "SolarSchoolParam";

		// Token: 0x040045C6 RID: 17862
		private const string COMMAND = "select BinData from `SolarSchoolParam` where ActivityId=? AND Key=?";

		// Token: 0x040045C7 RID: 17863
		private const string KEY_PREFIX = "SolarSchoolParamByActivityIdAndKey";

		// Token: 0x040045C8 RID: 17864
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045C9 RID: 17865
		private static int HandleId;
	}
}
