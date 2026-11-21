using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C4 RID: 1988
	public class ConfigRacingBetsRuleTextPoolBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EAA RID: 11946 RVA: 0x001648C8 File Offset: 0x00162AC8
		static ConfigRacingBetsRuleTextPoolBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsRuleTextPoolBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetsRuleTextPoolBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x001648E8 File Offset: 0x00162AE8
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

		// Token: 0x06002EAC RID: 11948 RVA: 0x00164967 File Offset: 0x00162B67
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsRuleTextPoolBySeasonId.LogPair = null;
			ConfigRacingBetsRuleTextPoolBySeasonId.HandleId = 0;
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00164975 File Offset: 0x00162B75
		public static void Init()
		{
			ConfigRacingBetsRuleTextPoolBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsRuleTextPoolBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsRuleTextPool` where SeasonId=?");
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00164990 File Offset: 0x00162B90
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

		// Token: 0x04003642 RID: 13890
		private const string DB = "db_racingbets.db";

		// Token: 0x04003643 RID: 13891
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003644 RID: 13892
		private const string TABLE = "RacingBetsRuleTextPool";

		// Token: 0x04003645 RID: 13893
		private const string COMMAND = "select BinData from `RacingBetsRuleTextPool` where SeasonId=?";

		// Token: 0x04003646 RID: 13894
		private const string KEY_PREFIX = "RacingBetsRuleTextPoolBySeasonId";

		// Token: 0x04003647 RID: 13895
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003648 RID: 13896
		private static int HandleId;
	}
}
