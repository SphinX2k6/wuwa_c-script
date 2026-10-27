using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A9 RID: 1961
	public class ConfigRacingBetsRuleTextPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E08 RID: 11784 RVA: 0x0015D773 File Offset: 0x0015B973
		static ConfigRacingBetsRuleTextPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsRuleTextPoolById.CreateStaticDefaultValue), new Action(ConfigRacingBetsRuleTextPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x0015D794 File Offset: 0x0015B994
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsRuleTextPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsRuleTextPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsRuleTextPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsRuleTextPool` where Id=?")
			});
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x0015D813 File Offset: 0x0015BA13
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsRuleTextPoolById.LogPair = null;
			ConfigRacingBetsRuleTextPoolById.HandleId = 0;
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x0015D821 File Offset: 0x0015BA21
		public static void Init()
		{
			ConfigRacingBetsRuleTextPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsRuleTextPoolById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsRuleTextPool` where Id=?");
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x0015D83C File Offset: 0x0015BA3C
		public static RacingBetsRuleTextPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsRuleTextPoolById.HandleId, ConfigRacingBetsRuleTextPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsRuleTextPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetsRuleTextPool?(RacingBetsRuleTextPool.GetRootAsRacingBetsRuleTextPool(configBuffer));
				}
			}
			ConfigRacingBetsRuleTextPoolById.LogPair.Clear();
			ConfigRacingBetsRuleTextPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetsRuleTextPoolById.HandleId, 1, p0Id, ConfigRacingBetsRuleTextPoolById.LogPair) || ConfigCommon.Step(ConfigRacingBetsRuleTextPoolById.HandleId, true, ConfigRacingBetsRuleTextPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetsRuleTextPoolById.HandleId, ConfigRacingBetsRuleTextPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsRuleTextPoolById.HandleId, 0, ConfigRacingBetsRuleTextPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetsRuleTextPoolById.HandleId, ConfigRacingBetsRuleTextPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetsRuleTextPool rootAsRacingBetsRuleTextPool = RacingBetsRuleTextPool.GetRootAsRacingBetsRuleTextPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsRuleTextPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetsRuleTextPoolById.HandleId, ConfigRacingBetsRuleTextPoolById.LogPair);
			return new RacingBetsRuleTextPool?(rootAsRacingBetsRuleTextPool);
		}

		// Token: 0x04003585 RID: 13701
		private const string DB = "db_racingbets.db";

		// Token: 0x04003586 RID: 13702
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003587 RID: 13703
		private const string TABLE = "RacingBetsRuleTextPool";

		// Token: 0x04003588 RID: 13704
		private const string COMMAND = "select BinData from `RacingBetsRuleTextPool` where Id=?";

		// Token: 0x04003589 RID: 13705
		private const string KEY_PREFIX = "RacingBetsRuleTextPoolById";

		// Token: 0x0400358A RID: 13706
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400358B RID: 13707
		private static int HandleId;
	}
}
