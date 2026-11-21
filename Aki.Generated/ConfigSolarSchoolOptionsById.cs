using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F8 RID: 2552
	public class ConfigSolarSchoolOptionsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BE4 RID: 15332 RVA: 0x001AF4F3 File Offset: 0x001AD6F3
		static ConfigSolarSchoolOptionsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolOptionsById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolOptionsById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x001AF514 File Offset: 0x001AD714
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolOptionsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolOptionsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_地点.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolOptions"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolOptions` where Id=?")
			});
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x001AF593 File Offset: 0x001AD793
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolOptionsById.LogPair = null;
			ConfigSolarSchoolOptionsById.HandleId = 0;
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x001AF5A1 File Offset: 0x001AD7A1
		public static void Init()
		{
			ConfigSolarSchoolOptionsById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolOptionsById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolOptions` where Id=?");
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x001AF5BC File Offset: 0x001AD7BC
		public static SolarSchoolOptions? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolOptionsById.HandleId, ConfigSolarSchoolOptionsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolOptionsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolOptions?(SolarSchoolOptions.GetRootAsSolarSchoolOptions(configBuffer));
				}
			}
			ConfigSolarSchoolOptionsById.LogPair.Clear();
			ConfigSolarSchoolOptionsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolOptionsById.HandleId, 1, p0Id, ConfigSolarSchoolOptionsById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolOptionsById.HandleId, true, ConfigSolarSchoolOptionsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolOptionsById.HandleId, ConfigSolarSchoolOptionsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolOptionsById.HandleId, 0, ConfigSolarSchoolOptionsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolOptionsById.HandleId, ConfigSolarSchoolOptionsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolOptions rootAsSolarSchoolOptions = SolarSchoolOptions.GetRootAsSolarSchoolOptions(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolOptionsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolOptionsById.HandleId, ConfigSolarSchoolOptionsById.LogPair);
			return new SolarSchoolOptions?(rootAsSolarSchoolOptions);
		}

		// Token: 0x040045AE RID: 17838
		private const string DB = "db_solarschool.db";

		// Token: 0x040045AF RID: 17839
		private const string FILE = "d.第二索拉_地点.xlsx";

		// Token: 0x040045B0 RID: 17840
		private const string TABLE = "SolarSchoolOptions";

		// Token: 0x040045B1 RID: 17841
		private const string COMMAND = "select BinData from `SolarSchoolOptions` where Id=?";

		// Token: 0x040045B2 RID: 17842
		private const string KEY_PREFIX = "SolarSchoolOptionsById";

		// Token: 0x040045B3 RID: 17843
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045B4 RID: 17844
		private static int HandleId;
	}
}
