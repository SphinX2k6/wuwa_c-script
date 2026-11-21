using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D3 RID: 2515
	public class ConfigSolarSchoolEventCheckOptById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B06 RID: 15110 RVA: 0x001AA60F File Offset: 0x001A880F
		static ConfigSolarSchoolEventCheckOptById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEventCheckOptById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEventCheckOptById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x001AA630 File Offset: 0x001A8830
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEventCheckOptById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEventCheckOptById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEventCheckOpt"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEventCheckOpt` where Id=?")
			});
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x001AA6AF File Offset: 0x001A88AF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEventCheckOptById.LogPair = null;
			ConfigSolarSchoolEventCheckOptById.HandleId = 0;
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x001AA6BD File Offset: 0x001A88BD
		public static void Init()
		{
			ConfigSolarSchoolEventCheckOptById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEventCheckOptById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEventCheckOpt` where Id=?");
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x001AA6D8 File Offset: 0x001A88D8
		public static SolarSchoolEventCheckOpt? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEventCheckOptById.HandleId, ConfigSolarSchoolEventCheckOptById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEventCheckOptById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolEventCheckOpt?(SolarSchoolEventCheckOpt.GetRootAsSolarSchoolEventCheckOpt(configBuffer));
				}
			}
			ConfigSolarSchoolEventCheckOptById.LogPair.Clear();
			ConfigSolarSchoolEventCheckOptById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolEventCheckOptById.HandleId, 1, p0Id, ConfigSolarSchoolEventCheckOptById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolEventCheckOptById.HandleId, true, ConfigSolarSchoolEventCheckOptById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEventCheckOptById.HandleId, ConfigSolarSchoolEventCheckOptById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEventCheckOptById.HandleId, 0, ConfigSolarSchoolEventCheckOptById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEventCheckOptById.HandleId, ConfigSolarSchoolEventCheckOptById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolEventCheckOpt rootAsSolarSchoolEventCheckOpt = SolarSchoolEventCheckOpt.GetRootAsSolarSchoolEventCheckOpt(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEventCheckOptById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEventCheckOptById.HandleId, ConfigSolarSchoolEventCheckOptById.LogPair);
			return new SolarSchoolEventCheckOpt?(rootAsSolarSchoolEventCheckOpt);
		}

		// Token: 0x040044AB RID: 17579
		private const string DB = "db_solarschool.db";

		// Token: 0x040044AC RID: 17580
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044AD RID: 17581
		private const string TABLE = "SolarSchoolEventCheckOpt";

		// Token: 0x040044AE RID: 17582
		private const string COMMAND = "select BinData from `SolarSchoolEventCheckOpt` where Id=?";

		// Token: 0x040044AF RID: 17583
		private const string KEY_PREFIX = "SolarSchoolEventCheckOptById";

		// Token: 0x040044B0 RID: 17584
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044B1 RID: 17585
		private static int HandleId;
	}
}
