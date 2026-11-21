using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AF RID: 2479
	public class ConfigSolarSchoolAffairsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A2E RID: 14894 RVA: 0x001A5A60 File Offset: 0x001A3C60
		static ConfigSolarSchoolAffairsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolAffairsById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolAffairsById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x001A5A80 File Offset: 0x001A3C80
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolAffairsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolAffairsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolAffairs"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolAffairs` where Id=?")
			});
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x001A5AFF File Offset: 0x001A3CFF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolAffairsById.LogPair = null;
			ConfigSolarSchoolAffairsById.HandleId = 0;
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x001A5B0D File Offset: 0x001A3D0D
		public static void Init()
		{
			ConfigSolarSchoolAffairsById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolAffairsById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolAffairs` where Id=?");
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x001A5B28 File Offset: 0x001A3D28
		public static SolarSchoolAffairs? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolAffairsById.HandleId, ConfigSolarSchoolAffairsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAffairsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolAffairs?(SolarSchoolAffairs.GetRootAsSolarSchoolAffairs(configBuffer));
				}
			}
			ConfigSolarSchoolAffairsById.LogPair.Clear();
			ConfigSolarSchoolAffairsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolAffairsById.HandleId, 1, p0Id, ConfigSolarSchoolAffairsById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolAffairsById.HandleId, true, ConfigSolarSchoolAffairsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolAffairsById.HandleId, ConfigSolarSchoolAffairsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolAffairsById.HandleId, 0, ConfigSolarSchoolAffairsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolAffairsById.HandleId, ConfigSolarSchoolAffairsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolAffairs rootAsSolarSchoolAffairs = SolarSchoolAffairs.GetRootAsSolarSchoolAffairs(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAffairsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolAffairsById.HandleId, ConfigSolarSchoolAffairsById.LogPair);
			return new SolarSchoolAffairs?(rootAsSolarSchoolAffairs);
		}

		// Token: 0x040043AF RID: 17327
		private const string DB = "db_solarschool.db";

		// Token: 0x040043B0 RID: 17328
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040043B1 RID: 17329
		private const string TABLE = "SolarSchoolAffairs";

		// Token: 0x040043B2 RID: 17330
		private const string COMMAND = "select BinData from `SolarSchoolAffairs` where Id=?";

		// Token: 0x040043B3 RID: 17331
		private const string KEY_PREFIX = "SolarSchoolAffairsById";

		// Token: 0x040043B4 RID: 17332
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043B5 RID: 17333
		private static int HandleId;
	}
}
