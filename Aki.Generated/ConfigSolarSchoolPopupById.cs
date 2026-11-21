using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FD RID: 2557
	public class ConfigSolarSchoolPopupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C02 RID: 15362 RVA: 0x001AFFE8 File Offset: 0x001AE1E8
		static ConfigSolarSchoolPopupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolPopupById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolPopupById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x001B0008 File Offset: 0x001AE208
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolPopupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolPopupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolPopup"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolPopup` where Id=?")
			});
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x001B0087 File Offset: 0x001AE287
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolPopupById.LogPair = null;
			ConfigSolarSchoolPopupById.HandleId = 0;
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x001B0095 File Offset: 0x001AE295
		public static void Init()
		{
			ConfigSolarSchoolPopupById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolPopupById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolPopup` where Id=?");
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x001B00B0 File Offset: 0x001AE2B0
		public static SolarSchoolPopup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolPopupById.HandleId, ConfigSolarSchoolPopupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolPopupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolPopup?(SolarSchoolPopup.GetRootAsSolarSchoolPopup(configBuffer));
				}
			}
			ConfigSolarSchoolPopupById.LogPair.Clear();
			ConfigSolarSchoolPopupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolPopupById.HandleId, 1, p0Id, ConfigSolarSchoolPopupById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolPopupById.HandleId, true, ConfigSolarSchoolPopupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolPopupById.HandleId, ConfigSolarSchoolPopupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolPopupById.HandleId, 0, ConfigSolarSchoolPopupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolPopupById.HandleId, ConfigSolarSchoolPopupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolPopup rootAsSolarSchoolPopup = SolarSchoolPopup.GetRootAsSolarSchoolPopup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolPopupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolPopupById.HandleId, ConfigSolarSchoolPopupById.LogPair);
			return new SolarSchoolPopup?(rootAsSolarSchoolPopup);
		}

		// Token: 0x040045D1 RID: 17873
		private const string DB = "db_solarschool.db";

		// Token: 0x040045D2 RID: 17874
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040045D3 RID: 17875
		private const string TABLE = "SolarSchoolPopup";

		// Token: 0x040045D4 RID: 17876
		private const string COMMAND = "select BinData from `SolarSchoolPopup` where Id=?";

		// Token: 0x040045D5 RID: 17877
		private const string KEY_PREFIX = "SolarSchoolPopupById";

		// Token: 0x040045D6 RID: 17878
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045D7 RID: 17879
		private static int HandleId;
	}
}
