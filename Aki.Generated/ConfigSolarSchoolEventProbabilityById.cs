using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D5 RID: 2517
	public class ConfigSolarSchoolEventProbabilityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B12 RID: 15122 RVA: 0x001AA9EB File Offset: 0x001A8BEB
		static ConfigSolarSchoolEventProbabilityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEventProbabilityById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEventProbabilityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x001AAA0C File Offset: 0x001A8C0C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEventProbabilityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEventProbabilityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEventProbability"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEventProbability` where Id=?")
			});
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x001AAA8B File Offset: 0x001A8C8B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEventProbabilityById.LogPair = null;
			ConfigSolarSchoolEventProbabilityById.HandleId = 0;
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x001AAA99 File Offset: 0x001A8C99
		public static void Init()
		{
			ConfigSolarSchoolEventProbabilityById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEventProbabilityById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEventProbability` where Id=?");
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x001AAAB4 File Offset: 0x001A8CB4
		public static SolarSchoolEventProbability? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEventProbabilityById.HandleId, ConfigSolarSchoolEventProbabilityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEventProbabilityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolEventProbability?(SolarSchoolEventProbability.GetRootAsSolarSchoolEventProbability(configBuffer));
				}
			}
			ConfigSolarSchoolEventProbabilityById.LogPair.Clear();
			ConfigSolarSchoolEventProbabilityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolEventProbabilityById.HandleId, 1, p0Id, ConfigSolarSchoolEventProbabilityById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolEventProbabilityById.HandleId, true, ConfigSolarSchoolEventProbabilityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEventProbabilityById.HandleId, ConfigSolarSchoolEventProbabilityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEventProbabilityById.HandleId, 0, ConfigSolarSchoolEventProbabilityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEventProbabilityById.HandleId, ConfigSolarSchoolEventProbabilityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolEventProbability rootAsSolarSchoolEventProbability = SolarSchoolEventProbability.GetRootAsSolarSchoolEventProbability(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEventProbabilityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEventProbabilityById.HandleId, ConfigSolarSchoolEventProbabilityById.LogPair);
			return new SolarSchoolEventProbability?(rootAsSolarSchoolEventProbability);
		}

		// Token: 0x040044B9 RID: 17593
		private const string DB = "db_solarschool.db";

		// Token: 0x040044BA RID: 17594
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044BB RID: 17595
		private const string TABLE = "SolarSchoolEventProbability";

		// Token: 0x040044BC RID: 17596
		private const string COMMAND = "select BinData from `SolarSchoolEventProbability` where Id=?";

		// Token: 0x040044BD RID: 17597
		private const string KEY_PREFIX = "SolarSchoolEventProbabilityById";

		// Token: 0x040044BE RID: 17598
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044BF RID: 17599
		private static int HandleId;
	}
}
