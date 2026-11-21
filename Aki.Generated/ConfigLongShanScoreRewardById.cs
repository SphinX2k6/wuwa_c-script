using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000503 RID: 1283
	public class ConfigLongShanScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E1D RID: 7709 RVA: 0x00106FEF File Offset: 0x001051EF
		static ConfigLongShanScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanScoreRewardById.CreateStaticDefaultValue), new Action(ConfigLongShanScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00107010 File Offset: 0x00105210
		public static void CreateStaticDefaultValue()
		{
			ConfigLongShanScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLongShanScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_longshanactivity.db"),
				new ValueTuple<string, object>("文件", "l.龙山主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "LongShanScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `LongShanScoreReward` where Id=?")
			});
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0010708F File Offset: 0x0010528F
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanScoreRewardById.LogPair = null;
			ConfigLongShanScoreRewardById.HandleId = 0;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0010709D File Offset: 0x0010529D
		public static void Init()
		{
			ConfigLongShanScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanScoreRewardById.HandleId, "db_longshanactivity.db", "select BinData from `LongShanScoreReward` where Id=?");
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x001070B8 File Offset: 0x001052B8
		public static LongShanScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLongShanScoreRewardById.HandleId, ConfigLongShanScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LongShanScoreReward?(LongShanScoreReward.GetRootAsLongShanScoreReward(configBuffer));
				}
			}
			ConfigLongShanScoreRewardById.LogPair.Clear();
			ConfigLongShanScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLongShanScoreRewardById.HandleId, 1, p0Id, ConfigLongShanScoreRewardById.LogPair) || ConfigCommon.Step(ConfigLongShanScoreRewardById.HandleId, true, ConfigLongShanScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLongShanScoreRewardById.HandleId, ConfigLongShanScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLongShanScoreRewardById.HandleId, 0, ConfigLongShanScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLongShanScoreRewardById.HandleId, ConfigLongShanScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LongShanScoreReward rootAsLongShanScoreReward = LongShanScoreReward.GetRootAsLongShanScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLongShanScoreRewardById.HandleId, ConfigLongShanScoreRewardById.LogPair);
			return new LongShanScoreReward?(rootAsLongShanScoreReward);
		}

		// Token: 0x040022F9 RID: 8953
		private const string DB = "db_longshanactivity.db";

		// Token: 0x040022FA RID: 8954
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x040022FB RID: 8955
		private const string TABLE = "LongShanScoreReward";

		// Token: 0x040022FC RID: 8956
		private const string COMMAND = "select BinData from `LongShanScoreReward` where Id=?";

		// Token: 0x040022FD RID: 8957
		private const string KEY_PREFIX = "LongShanScoreRewardById";

		// Token: 0x040022FE RID: 8958
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022FF RID: 8959
		private static int HandleId;
	}
}
