using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B7 RID: 2487
	public class ConfigSolarSchoolAvgParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A5E RID: 14942 RVA: 0x001A6B07 File Offset: 0x001A4D07
		static ConfigSolarSchoolAvgParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolAvgParamById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolAvgParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x001A6B28 File Offset: 0x001A4D28
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolAvgParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolAvgParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_剧情.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolAvgParam"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolAvgParam` where Id=?")
			});
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x001A6BA7 File Offset: 0x001A4DA7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolAvgParamById.LogPair = null;
			ConfigSolarSchoolAvgParamById.HandleId = 0;
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x001A6BB5 File Offset: 0x001A4DB5
		public static void Init()
		{
			ConfigSolarSchoolAvgParamById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolAvgParamById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolAvgParam` where Id=?");
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x001A6BD0 File Offset: 0x001A4DD0
		public static SolarSchoolAvgParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolAvgParamById.HandleId, ConfigSolarSchoolAvgParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAvgParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolAvgParam?(SolarSchoolAvgParam.GetRootAsSolarSchoolAvgParam(configBuffer));
				}
			}
			ConfigSolarSchoolAvgParamById.LogPair.Clear();
			ConfigSolarSchoolAvgParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolAvgParamById.HandleId, 1, p0Id, ConfigSolarSchoolAvgParamById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolAvgParamById.HandleId, true, ConfigSolarSchoolAvgParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolAvgParamById.HandleId, ConfigSolarSchoolAvgParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolAvgParamById.HandleId, 0, ConfigSolarSchoolAvgParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolAvgParamById.HandleId, ConfigSolarSchoolAvgParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolAvgParam rootAsSolarSchoolAvgParam = SolarSchoolAvgParam.GetRootAsSolarSchoolAvgParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAvgParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolAvgParamById.HandleId, ConfigSolarSchoolAvgParamById.LogPair);
			return new SolarSchoolAvgParam?(rootAsSolarSchoolAvgParam);
		}

		// Token: 0x040043E7 RID: 17383
		private const string DB = "db_solarschool.db";

		// Token: 0x040043E8 RID: 17384
		private const string FILE = "d.第二索拉_剧情.xlsx";

		// Token: 0x040043E9 RID: 17385
		private const string TABLE = "SolarSchoolAvgParam";

		// Token: 0x040043EA RID: 17386
		private const string COMMAND = "select BinData from `SolarSchoolAvgParam` where Id=?";

		// Token: 0x040043EB RID: 17387
		private const string KEY_PREFIX = "SolarSchoolAvgParamById";

		// Token: 0x040043EC RID: 17388
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043ED RID: 17389
		private static int HandleId;
	}
}
