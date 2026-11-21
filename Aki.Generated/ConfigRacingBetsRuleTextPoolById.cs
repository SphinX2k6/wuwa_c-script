using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C3 RID: 1987
	public class ConfigRacingBetsRuleTextPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EA4 RID: 11940 RVA: 0x0016467F File Offset: 0x0016287F
		static ConfigRacingBetsRuleTextPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsRuleTextPoolById.CreateStaticDefaultValue), new Action(ConfigRacingBetsRuleTextPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x001646A0 File Offset: 0x001628A0
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

		// Token: 0x06002EA6 RID: 11942 RVA: 0x0016471F File Offset: 0x0016291F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsRuleTextPoolById.LogPair = null;
			ConfigRacingBetsRuleTextPoolById.HandleId = 0;
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x0016472D File Offset: 0x0016292D
		public static void Init()
		{
			ConfigRacingBetsRuleTextPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsRuleTextPoolById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsRuleTextPool` where Id=?");
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x00164748 File Offset: 0x00162948
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

		// Token: 0x0400363B RID: 13883
		private const string DB = "db_racingbets.db";

		// Token: 0x0400363C RID: 13884
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400363D RID: 13885
		private const string TABLE = "RacingBetsRuleTextPool";

		// Token: 0x0400363E RID: 13886
		private const string COMMAND = "select BinData from `RacingBetsRuleTextPool` where Id=?";

		// Token: 0x0400363F RID: 13887
		private const string KEY_PREFIX = "RacingBetsRuleTextPoolById";

		// Token: 0x04003640 RID: 13888
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003641 RID: 13889
		private static int HandleId;
	}
}
