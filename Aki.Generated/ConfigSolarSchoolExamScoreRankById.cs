using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DC RID: 2524
	public class ConfigSolarSchoolExamScoreRankById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B3C RID: 15164 RVA: 0x001AB9C3 File Offset: 0x001A9BC3
		static ConfigSolarSchoolExamScoreRankById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolExamScoreRankById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolExamScoreRankById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x001AB9E4 File Offset: 0x001A9BE4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolExamScoreRankById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolExamScoreRankById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolExamScoreRank"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolExamScoreRank` where Id=?")
			});
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x001ABA63 File Offset: 0x001A9C63
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolExamScoreRankById.LogPair = null;
			ConfigSolarSchoolExamScoreRankById.HandleId = 0;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x001ABA71 File Offset: 0x001A9C71
		public static void Init()
		{
			ConfigSolarSchoolExamScoreRankById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolExamScoreRankById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolExamScoreRank` where Id=?");
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x001ABA8C File Offset: 0x001A9C8C
		public static SolarSchoolExamScoreRank? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolExamScoreRankById.HandleId, ConfigSolarSchoolExamScoreRankById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamScoreRankById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolExamScoreRank?(SolarSchoolExamScoreRank.GetRootAsSolarSchoolExamScoreRank(configBuffer));
				}
			}
			ConfigSolarSchoolExamScoreRankById.LogPair.Clear();
			ConfigSolarSchoolExamScoreRankById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolExamScoreRankById.HandleId, 1, p0Id, ConfigSolarSchoolExamScoreRankById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolExamScoreRankById.HandleId, true, ConfigSolarSchoolExamScoreRankById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamScoreRankById.HandleId, ConfigSolarSchoolExamScoreRankById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolExamScoreRankById.HandleId, 0, ConfigSolarSchoolExamScoreRankById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamScoreRankById.HandleId, ConfigSolarSchoolExamScoreRankById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolExamScoreRank rootAsSolarSchoolExamScoreRank = SolarSchoolExamScoreRank.GetRootAsSolarSchoolExamScoreRank(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamScoreRankById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolExamScoreRankById.HandleId, ConfigSolarSchoolExamScoreRankById.LogPair);
			return new SolarSchoolExamScoreRank?(rootAsSolarSchoolExamScoreRank);
		}

		// Token: 0x040044EA RID: 17642
		private const string DB = "db_solarschool.db";

		// Token: 0x040044EB RID: 17643
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044EC RID: 17644
		private const string TABLE = "SolarSchoolExamScoreRank";

		// Token: 0x040044ED RID: 17645
		private const string COMMAND = "select BinData from `SolarSchoolExamScoreRank` where Id=?";

		// Token: 0x040044EE RID: 17646
		private const string KEY_PREFIX = "SolarSchoolExamScoreRankById";

		// Token: 0x040044EF RID: 17647
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044F0 RID: 17648
		private static int HandleId;
	}
}
