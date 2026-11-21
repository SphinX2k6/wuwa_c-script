using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F0 RID: 752
	public class ConfigFishingIllustratedRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011A5 RID: 4517 RVA: 0x000C0B4C File Offset: 0x000BED4C
		static ConfigFishingIllustratedRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingIllustratedRewardById.CreateStaticDefaultValue), new Action(ConfigFishingIllustratedRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x000C0B6C File Offset: 0x000BED6C
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingIllustratedRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingIllustratedRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼相关.xlsx"),
				new ValueTuple<string, object>("表名", "FishingIllustratedReward"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingIllustratedReward` where Id=?")
			});
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x000C0BEB File Offset: 0x000BEDEB
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingIllustratedRewardById.LogPair = null;
			ConfigFishingIllustratedRewardById.HandleId = 0;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x000C0BF9 File Offset: 0x000BEDF9
		public static void Init()
		{
			ConfigFishingIllustratedRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingIllustratedRewardById.HandleId, "db_fishing.db", "select BinData from `FishingIllustratedReward` where Id=?");
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000C0C14 File Offset: 0x000BEE14
		public static FishingIllustratedReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingIllustratedRewardById.HandleId, ConfigFishingIllustratedRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingIllustratedRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingIllustratedReward?(FishingIllustratedReward.GetRootAsFishingIllustratedReward(configBuffer));
				}
			}
			ConfigFishingIllustratedRewardById.LogPair.Clear();
			ConfigFishingIllustratedRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingIllustratedRewardById.HandleId, 1, p0Id, ConfigFishingIllustratedRewardById.LogPair) || ConfigCommon.Step(ConfigFishingIllustratedRewardById.HandleId, true, ConfigFishingIllustratedRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingIllustratedRewardById.HandleId, ConfigFishingIllustratedRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingIllustratedRewardById.HandleId, 0, ConfigFishingIllustratedRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingIllustratedRewardById.HandleId, ConfigFishingIllustratedRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingIllustratedReward rootAsFishingIllustratedReward = FishingIllustratedReward.GetRootAsFishingIllustratedReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingIllustratedRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingIllustratedRewardById.HandleId, ConfigFishingIllustratedRewardById.LogPair);
			return new FishingIllustratedReward?(rootAsFishingIllustratedReward);
		}

		// Token: 0x04001474 RID: 5236
		private const string DB = "db_fishing.db";

		// Token: 0x04001475 RID: 5237
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x04001476 RID: 5238
		private const string TABLE = "FishingIllustratedReward";

		// Token: 0x04001477 RID: 5239
		private const string COMMAND = "select BinData from `FishingIllustratedReward` where Id=?";

		// Token: 0x04001478 RID: 5240
		private const string KEY_PREFIX = "FishingIllustratedRewardById";

		// Token: 0x04001479 RID: 5241
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400147A RID: 5242
		private static int HandleId;
	}
}
