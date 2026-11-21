using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F5 RID: 2549
	public class ConfigSolarSchoolLocationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BD2 RID: 15314 RVA: 0x001AEEDF File Offset: 0x001AD0DF
		static ConfigSolarSchoolLocationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolLocationById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolLocationById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x001AEF00 File Offset: 0x001AD100
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolLocationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolLocationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_地点.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolLocation"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolLocation` where Id=?")
			});
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x001AEF7F File Offset: 0x001AD17F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolLocationById.LogPair = null;
			ConfigSolarSchoolLocationById.HandleId = 0;
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x001AEF8D File Offset: 0x001AD18D
		public static void Init()
		{
			ConfigSolarSchoolLocationById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolLocationById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolLocation` where Id=?");
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x001AEFA8 File Offset: 0x001AD1A8
		public static SolarSchoolLocation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolLocationById.HandleId, ConfigSolarSchoolLocationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolLocationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolLocation?(SolarSchoolLocation.GetRootAsSolarSchoolLocation(configBuffer));
				}
			}
			ConfigSolarSchoolLocationById.LogPair.Clear();
			ConfigSolarSchoolLocationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolLocationById.HandleId, 1, p0Id, ConfigSolarSchoolLocationById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolLocationById.HandleId, true, ConfigSolarSchoolLocationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolLocationById.HandleId, ConfigSolarSchoolLocationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolLocationById.HandleId, 0, ConfigSolarSchoolLocationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolLocationById.HandleId, ConfigSolarSchoolLocationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolLocation rootAsSolarSchoolLocation = SolarSchoolLocation.GetRootAsSolarSchoolLocation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolLocationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolLocationById.HandleId, ConfigSolarSchoolLocationById.LogPair);
			return new SolarSchoolLocation?(rootAsSolarSchoolLocation);
		}

		// Token: 0x04004599 RID: 17817
		private const string DB = "db_solarschool.db";

		// Token: 0x0400459A RID: 17818
		private const string FILE = "d.第二索拉_地点.xlsx";

		// Token: 0x0400459B RID: 17819
		private const string TABLE = "SolarSchoolLocation";

		// Token: 0x0400459C RID: 17820
		private const string COMMAND = "select BinData from `SolarSchoolLocation` where Id=?";

		// Token: 0x0400459D RID: 17821
		private const string KEY_PREFIX = "SolarSchoolLocationById";

		// Token: 0x0400459E RID: 17822
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400459F RID: 17823
		private static int HandleId;
	}
}
