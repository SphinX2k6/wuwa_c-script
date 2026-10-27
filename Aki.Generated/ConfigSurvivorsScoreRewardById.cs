using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A8 RID: 2472
	public class ConfigSurvivorsScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A04 RID: 14852 RVA: 0x001A1CA7 File Offset: 0x0019FEA7
		static ConfigSurvivorsScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsScoreRewardById.CreateStaticDefaultValue), new Action(ConfigSurvivorsScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x001A1CC8 File Offset: 0x0019FEC8
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_活动.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsScoreReward` where Id=?")
			});
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x001A1D47 File Offset: 0x0019FF47
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsScoreRewardById.LogPair = null;
			ConfigSurvivorsScoreRewardById.HandleId = 0;
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x001A1D55 File Offset: 0x0019FF55
		public static void Init()
		{
			ConfigSurvivorsScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsScoreRewardById.HandleId, "db_survivors.db", "select BinData from `SurvivorsScoreReward` where Id=?");
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x001A1D70 File Offset: 0x0019FF70
		public static SurvivorsScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsScoreRewardById.HandleId, ConfigSurvivorsScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsScoreReward?(SurvivorsScoreReward.GetRootAsSurvivorsScoreReward(configBuffer));
				}
			}
			ConfigSurvivorsScoreRewardById.LogPair.Clear();
			ConfigSurvivorsScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsScoreRewardById.HandleId, 1, p0Id, ConfigSurvivorsScoreRewardById.LogPair) || ConfigCommon.Step(ConfigSurvivorsScoreRewardById.HandleId, true, ConfigSurvivorsScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsScoreRewardById.HandleId, ConfigSurvivorsScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsScoreRewardById.HandleId, 0, ConfigSurvivorsScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsScoreRewardById.HandleId, ConfigSurvivorsScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsScoreReward rootAsSurvivorsScoreReward = SurvivorsScoreReward.GetRootAsSurvivorsScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsScoreRewardById.HandleId, ConfigSurvivorsScoreRewardById.LogPair);
			return new SurvivorsScoreReward?(rootAsSurvivorsScoreReward);
		}

		// Token: 0x0400437E RID: 17278
		private const string DB = "db_survivors.db";

		// Token: 0x0400437F RID: 17279
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x04004380 RID: 17280
		private const string TABLE = "SurvivorsScoreReward";

		// Token: 0x04004381 RID: 17281
		private const string COMMAND = "select BinData from `SurvivorsScoreReward` where Id=?";

		// Token: 0x04004382 RID: 17282
		private const string KEY_PREFIX = "SurvivorsScoreRewardById";

		// Token: 0x04004383 RID: 17283
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004384 RID: 17284
		private static int HandleId;
	}
}
