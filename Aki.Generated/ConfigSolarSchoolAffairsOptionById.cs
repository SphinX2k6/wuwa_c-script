using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B1 RID: 2481
	public class ConfigSolarSchoolAffairsOptionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A3A RID: 14906 RVA: 0x001A5EDF File Offset: 0x001A40DF
		static ConfigSolarSchoolAffairsOptionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolAffairsOptionById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolAffairsOptionById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x001A5F00 File Offset: 0x001A4100
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolAffairsOptionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolAffairsOptionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolAffairsOption"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolAffairsOption` where Id=?")
			});
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x001A5F7F File Offset: 0x001A417F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolAffairsOptionById.LogPair = null;
			ConfigSolarSchoolAffairsOptionById.HandleId = 0;
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x001A5F8D File Offset: 0x001A418D
		public static void Init()
		{
			ConfigSolarSchoolAffairsOptionById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolAffairsOptionById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolAffairsOption` where Id=?");
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x001A5FA8 File Offset: 0x001A41A8
		public static SolarSchoolAffairsOption? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolAffairsOptionById.HandleId, ConfigSolarSchoolAffairsOptionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAffairsOptionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolAffairsOption?(SolarSchoolAffairsOption.GetRootAsSolarSchoolAffairsOption(configBuffer));
				}
			}
			ConfigSolarSchoolAffairsOptionById.LogPair.Clear();
			ConfigSolarSchoolAffairsOptionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolAffairsOptionById.HandleId, 1, p0Id, ConfigSolarSchoolAffairsOptionById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolAffairsOptionById.HandleId, true, ConfigSolarSchoolAffairsOptionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolAffairsOptionById.HandleId, ConfigSolarSchoolAffairsOptionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolAffairsOptionById.HandleId, 0, ConfigSolarSchoolAffairsOptionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolAffairsOptionById.HandleId, ConfigSolarSchoolAffairsOptionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolAffairsOption rootAsSolarSchoolAffairsOption = SolarSchoolAffairsOption.GetRootAsSolarSchoolAffairsOption(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAffairsOptionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolAffairsOptionById.HandleId, ConfigSolarSchoolAffairsOptionById.LogPair);
			return new SolarSchoolAffairsOption?(rootAsSolarSchoolAffairsOption);
		}

		// Token: 0x040043BD RID: 17341
		private const string DB = "db_solarschool.db";

		// Token: 0x040043BE RID: 17342
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040043BF RID: 17343
		private const string TABLE = "SolarSchoolAffairsOption";

		// Token: 0x040043C0 RID: 17344
		private const string COMMAND = "select BinData from `SolarSchoolAffairsOption` where Id=?";

		// Token: 0x040043C1 RID: 17345
		private const string KEY_PREFIX = "SolarSchoolAffairsOptionById";

		// Token: 0x040043C2 RID: 17346
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043C3 RID: 17347
		private static int HandleId;
	}
}
