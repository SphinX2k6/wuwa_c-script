using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DB RID: 2523
	public class ConfigSolarSchoolExamScoreRankByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B36 RID: 15158 RVA: 0x001AB78C File Offset: 0x001A998C
		static ConfigSolarSchoolExamScoreRankByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolExamScoreRankByGroupId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolExamScoreRankByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x001AB7AC File Offset: 0x001A99AC
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolExamScoreRankByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolExamScoreRankByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolExamScoreRank"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolExamScoreRank` where GroupId=?")
			});
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x001AB82B File Offset: 0x001A9A2B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolExamScoreRankByGroupId.LogPair = null;
			ConfigSolarSchoolExamScoreRankByGroupId.HandleId = 0;
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x001AB839 File Offset: 0x001A9A39
		public static void Init()
		{
			ConfigSolarSchoolExamScoreRankByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolExamScoreRankByGroupId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolExamScoreRank` where GroupId=?");
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x001AB854 File Offset: 0x001A9A54
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolExamScoreRank> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolExamScoreRankByGroupId.HandleId, ConfigSolarSchoolExamScoreRankByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamScoreRankByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<SolarSchoolExamScoreRank> readOnlyList = (IReadOnlyList<SolarSchoolExamScoreRank>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolExamScoreRankByGroupId.LogPair.Clear();
			ConfigSolarSchoolExamScoreRankByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolExamScoreRankByGroupId.HandleId, 1, p0GroupId, ConfigSolarSchoolExamScoreRankByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamScoreRankByGroupId.HandleId, ConfigSolarSchoolExamScoreRankByGroupId.LogPair);
				return null;
			}
			List<SolarSchoolExamScoreRank> list = new List<SolarSchoolExamScoreRank>();
			while (ConfigCommon.Step(ConfigSolarSchoolExamScoreRankByGroupId.HandleId, false, ConfigSolarSchoolExamScoreRankByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolExamScoreRankByGroupId.HandleId, 0, ConfigSolarSchoolExamScoreRankByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolExamScoreRankByGroupId.HandleId, ConfigSolarSchoolExamScoreRankByGroupId.LogPair);
					return null;
				}
				SolarSchoolExamScoreRank rootAsSolarSchoolExamScoreRank = SolarSchoolExamScoreRank.GetRootAsSolarSchoolExamScoreRank(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolExamScoreRank);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamScoreRankByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolExamScoreRankByGroupId.HandleId, ConfigSolarSchoolExamScoreRankByGroupId.LogPair);
			return list;
		}

		// Token: 0x040044E3 RID: 17635
		private const string DB = "db_solarschool.db";

		// Token: 0x040044E4 RID: 17636
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044E5 RID: 17637
		private const string TABLE = "SolarSchoolExamScoreRank";

		// Token: 0x040044E6 RID: 17638
		private const string COMMAND = "select BinData from `SolarSchoolExamScoreRank` where GroupId=?";

		// Token: 0x040044E7 RID: 17639
		private const string KEY_PREFIX = "SolarSchoolExamScoreRankByGroupId";

		// Token: 0x040044E8 RID: 17640
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044E9 RID: 17641
		private static int HandleId;
	}
}
