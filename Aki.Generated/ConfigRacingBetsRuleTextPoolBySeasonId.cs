using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AA RID: 1962
	public class ConfigRacingBetsRuleTextPoolBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E0E RID: 11790 RVA: 0x0015D9BC File Offset: 0x0015BBBC
		static ConfigRacingBetsRuleTextPoolBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsRuleTextPoolBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetsRuleTextPoolBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x0015D9DC File Offset: 0x0015BBDC
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsRuleTextPoolBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsRuleTextPoolBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsRuleTextPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsRuleTextPool` where SeasonId=?")
			});
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x0015DA5B File Offset: 0x0015BC5B
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsRuleTextPoolBySeasonId.LogPair = null;
			ConfigRacingBetsRuleTextPoolBySeasonId.HandleId = 0;
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x0015DA69 File Offset: 0x0015BC69
		public static void Init()
		{
			ConfigRacingBetsRuleTextPoolBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsRuleTextPoolBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsRuleTextPool` where SeasonId=?");
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x0015DA84 File Offset: 0x0015BC84
		[NullableContext(2)]
		public static IReadOnlyList<RacingBetsRuleTextPool> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsRuleTextPoolBySeasonId.HandleId, ConfigRacingBetsRuleTextPoolBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsRuleTextPoolBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RacingBetsRuleTextPool> readOnlyList = (IReadOnlyList<RacingBetsRuleTextPool>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRacingBetsRuleTextPoolBySeasonId.LogPair.Clear();
			ConfigRacingBetsRuleTextPoolBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRacingBetsRuleTextPoolBySeasonId.HandleId, 1, p0SeasonId, ConfigRacingBetsRuleTextPoolBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRacingBetsRuleTextPoolBySeasonId.HandleId, ConfigRacingBetsRuleTextPoolBySeasonId.LogPair);
				return null;
			}
			List<RacingBetsRuleTextPool> list = new List<RacingBetsRuleTextPool>();
			while (ConfigCommon.Step(ConfigRacingBetsRuleTextPoolBySeasonId.HandleId, false, ConfigRacingBetsRuleTextPoolBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsRuleTextPoolBySeasonId.HandleId, 0, ConfigRacingBetsRuleTextPoolBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRacingBetsRuleTextPoolBySeasonId.HandleId, ConfigRacingBetsRuleTextPoolBySeasonId.LogPair);
					return null;
				}
				RacingBetsRuleTextPool rootAsRacingBetsRuleTextPool = RacingBetsRuleTextPool.GetRootAsRacingBetsRuleTextPool(new ByteBuffer(item2));
				list.Add(rootAsRacingBetsRuleTextPool);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsRuleTextPoolBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRacingBetsRuleTextPoolBySeasonId.HandleId, ConfigRacingBetsRuleTextPoolBySeasonId.LogPair);
			return list;
		}

		// Token: 0x0400358C RID: 13708
		private const string DB = "db_racingbets.db";

		// Token: 0x0400358D RID: 13709
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400358E RID: 13710
		private const string TABLE = "RacingBetsRuleTextPool";

		// Token: 0x0400358F RID: 13711
		private const string COMMAND = "select BinData from `RacingBetsRuleTextPool` where SeasonId=?";

		// Token: 0x04003590 RID: 13712
		private const string KEY_PREFIX = "RacingBetsRuleTextPoolBySeasonId";

		// Token: 0x04003591 RID: 13713
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003592 RID: 13714
		private static int HandleId;
	}
}
