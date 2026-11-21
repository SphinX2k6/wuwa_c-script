using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FC RID: 2556
	public class ConfigSolarSchoolParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BFC RID: 15356 RVA: 0x001AFDA0 File Offset: 0x001ADFA0
		static ConfigSolarSchoolParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolParamById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x001AFDC0 File Offset: 0x001ADFC0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolParam"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolParam` where Id=?")
			});
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x001AFE3F File Offset: 0x001AE03F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolParamById.LogPair = null;
			ConfigSolarSchoolParamById.HandleId = 0;
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x001AFE4D File Offset: 0x001AE04D
		public static void Init()
		{
			ConfigSolarSchoolParamById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolParamById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolParam` where Id=?");
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x001AFE68 File Offset: 0x001AE068
		public static SolarSchoolParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolParamById.HandleId, ConfigSolarSchoolParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolParam?(SolarSchoolParam.GetRootAsSolarSchoolParam(configBuffer));
				}
			}
			ConfigSolarSchoolParamById.LogPair.Clear();
			ConfigSolarSchoolParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolParamById.HandleId, 1, p0Id, ConfigSolarSchoolParamById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolParamById.HandleId, true, ConfigSolarSchoolParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolParamById.HandleId, ConfigSolarSchoolParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolParamById.HandleId, 0, ConfigSolarSchoolParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolParamById.HandleId, ConfigSolarSchoolParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolParam rootAsSolarSchoolParam = SolarSchoolParam.GetRootAsSolarSchoolParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolParamById.HandleId, ConfigSolarSchoolParamById.LogPair);
			return new SolarSchoolParam?(rootAsSolarSchoolParam);
		}

		// Token: 0x040045CA RID: 17866
		private const string DB = "db_solarschool.db";

		// Token: 0x040045CB RID: 17867
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x040045CC RID: 17868
		private const string TABLE = "SolarSchoolParam";

		// Token: 0x040045CD RID: 17869
		private const string COMMAND = "select BinData from `SolarSchoolParam` where Id=?";

		// Token: 0x040045CE RID: 17870
		private const string KEY_PREFIX = "SolarSchoolParamById";

		// Token: 0x040045CF RID: 17871
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045D0 RID: 17872
		private static int HandleId;
	}
}
