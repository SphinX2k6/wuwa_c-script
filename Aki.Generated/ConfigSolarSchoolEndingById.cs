using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CB RID: 2507
	public class ConfigSolarSchoolEndingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AD6 RID: 15062 RVA: 0x001A94A3 File Offset: 0x001A76A3
		static ConfigSolarSchoolEndingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEndingById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEndingById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x001A94C4 File Offset: 0x001A76C4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEndingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEndingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEnding"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEnding` where Id=?")
			});
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x001A9543 File Offset: 0x001A7743
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEndingById.LogPair = null;
			ConfigSolarSchoolEndingById.HandleId = 0;
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x001A9551 File Offset: 0x001A7751
		public static void Init()
		{
			ConfigSolarSchoolEndingById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEndingById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEnding` where Id=?");
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x001A956C File Offset: 0x001A776C
		public static SolarSchoolEnding? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEndingById.HandleId, ConfigSolarSchoolEndingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolEnding?(SolarSchoolEnding.GetRootAsSolarSchoolEnding(configBuffer));
				}
			}
			ConfigSolarSchoolEndingById.LogPair.Clear();
			ConfigSolarSchoolEndingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolEndingById.HandleId, 1, p0Id, ConfigSolarSchoolEndingById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolEndingById.HandleId, true, ConfigSolarSchoolEndingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEndingById.HandleId, ConfigSolarSchoolEndingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEndingById.HandleId, 0, ConfigSolarSchoolEndingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEndingById.HandleId, ConfigSolarSchoolEndingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolEnding rootAsSolarSchoolEnding = SolarSchoolEnding.GetRootAsSolarSchoolEnding(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEndingById.HandleId, ConfigSolarSchoolEndingById.LogPair);
			return new SolarSchoolEnding?(rootAsSolarSchoolEnding);
		}

		// Token: 0x04004473 RID: 17523
		private const string DB = "db_solarschool.db";

		// Token: 0x04004474 RID: 17524
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x04004475 RID: 17525
		private const string TABLE = "SolarSchoolEnding";

		// Token: 0x04004476 RID: 17526
		private const string COMMAND = "select BinData from `SolarSchoolEnding` where Id=?";

		// Token: 0x04004477 RID: 17527
		private const string KEY_PREFIX = "SolarSchoolEndingById";

		// Token: 0x04004478 RID: 17528
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004479 RID: 17529
		private static int HandleId;
	}
}
