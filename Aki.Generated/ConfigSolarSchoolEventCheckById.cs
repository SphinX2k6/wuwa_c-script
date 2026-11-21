using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D1 RID: 2513
	public class ConfigSolarSchoolEventCheckById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AFA RID: 15098 RVA: 0x001AA190 File Offset: 0x001A8390
		static ConfigSolarSchoolEventCheckById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEventCheckById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEventCheckById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x001AA1B0 File Offset: 0x001A83B0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEventCheckById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEventCheckById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEventCheck"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEventCheck` where Id=?")
			});
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x001AA22F File Offset: 0x001A842F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEventCheckById.LogPair = null;
			ConfigSolarSchoolEventCheckById.HandleId = 0;
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x001AA23D File Offset: 0x001A843D
		public static void Init()
		{
			ConfigSolarSchoolEventCheckById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEventCheckById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEventCheck` where Id=?");
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x001AA258 File Offset: 0x001A8458
		public static SolarSchoolEventCheck? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEventCheckById.HandleId, ConfigSolarSchoolEventCheckById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEventCheckById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolEventCheck?(SolarSchoolEventCheck.GetRootAsSolarSchoolEventCheck(configBuffer));
				}
			}
			ConfigSolarSchoolEventCheckById.LogPair.Clear();
			ConfigSolarSchoolEventCheckById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolEventCheckById.HandleId, 1, p0Id, ConfigSolarSchoolEventCheckById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolEventCheckById.HandleId, true, ConfigSolarSchoolEventCheckById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEventCheckById.HandleId, ConfigSolarSchoolEventCheckById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEventCheckById.HandleId, 0, ConfigSolarSchoolEventCheckById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEventCheckById.HandleId, ConfigSolarSchoolEventCheckById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolEventCheck rootAsSolarSchoolEventCheck = SolarSchoolEventCheck.GetRootAsSolarSchoolEventCheck(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEventCheckById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEventCheckById.HandleId, ConfigSolarSchoolEventCheckById.LogPair);
			return new SolarSchoolEventCheck?(rootAsSolarSchoolEventCheck);
		}

		// Token: 0x0400449D RID: 17565
		private const string DB = "db_solarschool.db";

		// Token: 0x0400449E RID: 17566
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x0400449F RID: 17567
		private const string TABLE = "SolarSchoolEventCheck";

		// Token: 0x040044A0 RID: 17568
		private const string COMMAND = "select BinData from `SolarSchoolEventCheck` where Id=?";

		// Token: 0x040044A1 RID: 17569
		private const string KEY_PREFIX = "SolarSchoolEventCheckById";

		// Token: 0x040044A2 RID: 17570
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044A3 RID: 17571
		private static int HandleId;
	}
}
