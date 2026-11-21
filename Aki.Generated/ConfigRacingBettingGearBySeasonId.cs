using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C7 RID: 1991
	public class ConfigRacingBettingGearBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EBC RID: 11964 RVA: 0x00164F90 File Offset: 0x00163190
		static ConfigRacingBettingGearBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBettingGearBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBettingGearBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00164FB0 File Offset: 0x001631B0
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBettingGearBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBettingGearBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBettingGear"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBettingGear` where SeasonId=?")
			});
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x0016502F File Offset: 0x0016322F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBettingGearBySeasonId.LogPair = null;
			ConfigRacingBettingGearBySeasonId.HandleId = 0;
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x0016503D File Offset: 0x0016323D
		public static void Init()
		{
			ConfigRacingBettingGearBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBettingGearBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBettingGear` where SeasonId=?");
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x00165058 File Offset: 0x00163258
		[NullableContext(2)]
		public static IReadOnlyList<RacingBettingGear> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBettingGearBySeasonId.HandleId, ConfigRacingBettingGearBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBettingGearBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RacingBettingGear> readOnlyList = (IReadOnlyList<RacingBettingGear>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRacingBettingGearBySeasonId.LogPair.Clear();
			ConfigRacingBettingGearBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRacingBettingGearBySeasonId.HandleId, 1, p0SeasonId, ConfigRacingBettingGearBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRacingBettingGearBySeasonId.HandleId, ConfigRacingBettingGearBySeasonId.LogPair);
				return null;
			}
			List<RacingBettingGear> list = new List<RacingBettingGear>();
			while (ConfigCommon.Step(ConfigRacingBettingGearBySeasonId.HandleId, false, ConfigRacingBettingGearBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBettingGearBySeasonId.HandleId, 0, ConfigRacingBettingGearBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRacingBettingGearBySeasonId.HandleId, ConfigRacingBettingGearBySeasonId.LogPair);
					return null;
				}
				RacingBettingGear rootAsRacingBettingGear = RacingBettingGear.GetRootAsRacingBettingGear(new ByteBuffer(item2));
				list.Add(rootAsRacingBettingGear);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBettingGearBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRacingBettingGearBySeasonId.HandleId, ConfigRacingBettingGearBySeasonId.LogPair);
			return list;
		}

		// Token: 0x04003657 RID: 13911
		private const string DB = "db_racingbets.db";

		// Token: 0x04003658 RID: 13912
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003659 RID: 13913
		private const string TABLE = "RacingBettingGear";

		// Token: 0x0400365A RID: 13914
		private const string COMMAND = "select BinData from `RacingBettingGear` where SeasonId=?";

		// Token: 0x0400365B RID: 13915
		private const string KEY_PREFIX = "RacingBettingGearBySeasonId";

		// Token: 0x0400365C RID: 13916
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400365D RID: 13917
		private static int HandleId;
	}
}
