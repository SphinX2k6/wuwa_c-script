using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AE RID: 2478
	public class ConfigSolarSchoolActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A28 RID: 14888 RVA: 0x001A5817 File Offset: 0x001A3A17
		static ConfigSolarSchoolActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolActivityById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x001A5838 File Offset: 0x001A3A38
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolActivity` where Id=?")
			});
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x001A58B7 File Offset: 0x001A3AB7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolActivityById.LogPair = null;
			ConfigSolarSchoolActivityById.HandleId = 0;
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x001A58C5 File Offset: 0x001A3AC5
		public static void Init()
		{
			ConfigSolarSchoolActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolActivityById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolActivity` where Id=?");
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x001A58E0 File Offset: 0x001A3AE0
		public static SolarSchoolActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolActivityById.HandleId, ConfigSolarSchoolActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolActivity?(SolarSchoolActivity.GetRootAsSolarSchoolActivity(configBuffer));
				}
			}
			ConfigSolarSchoolActivityById.LogPair.Clear();
			ConfigSolarSchoolActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolActivityById.HandleId, 1, p0Id, ConfigSolarSchoolActivityById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolActivityById.HandleId, true, ConfigSolarSchoolActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolActivityById.HandleId, ConfigSolarSchoolActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolActivityById.HandleId, 0, ConfigSolarSchoolActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolActivityById.HandleId, ConfigSolarSchoolActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolActivity rootAsSolarSchoolActivity = SolarSchoolActivity.GetRootAsSolarSchoolActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolActivityById.HandleId, ConfigSolarSchoolActivityById.LogPair);
			return new SolarSchoolActivity?(rootAsSolarSchoolActivity);
		}

		// Token: 0x040043A8 RID: 17320
		private const string DB = "db_solarschool.db";

		// Token: 0x040043A9 RID: 17321
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x040043AA RID: 17322
		private const string TABLE = "SolarSchoolActivity";

		// Token: 0x040043AB RID: 17323
		private const string COMMAND = "select BinData from `SolarSchoolActivity` where Id=?";

		// Token: 0x040043AC RID: 17324
		private const string KEY_PREFIX = "SolarSchoolActivityById";

		// Token: 0x040043AD RID: 17325
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043AE RID: 17326
		private static int HandleId;
	}
}
