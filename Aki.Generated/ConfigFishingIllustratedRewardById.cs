using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DB RID: 731
	public class ConfigFishingIllustratedRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001127 RID: 4391 RVA: 0x000BA640 File Offset: 0x000B8840
		static ConfigFishingIllustratedRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingIllustratedRewardById.CreateStaticDefaultValue), new Action(ConfigFishingIllustratedRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x000BA660 File Offset: 0x000B8860
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

		// Token: 0x06001129 RID: 4393 RVA: 0x000BA6DF File Offset: 0x000B88DF
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingIllustratedRewardById.LogPair = null;
			ConfigFishingIllustratedRewardById.HandleId = 0;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x000BA6ED File Offset: 0x000B88ED
		public static void Init()
		{
			ConfigFishingIllustratedRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingIllustratedRewardById.HandleId, "db_fishing.db", "select BinData from `FishingIllustratedReward` where Id=?");
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x000BA708 File Offset: 0x000B8908
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

		// Token: 0x040013E1 RID: 5089
		private const string DB = "db_fishing.db";

		// Token: 0x040013E2 RID: 5090
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x040013E3 RID: 5091
		private const string TABLE = "FishingIllustratedReward";

		// Token: 0x040013E4 RID: 5092
		private const string COMMAND = "select BinData from `FishingIllustratedReward` where Id=?";

		// Token: 0x040013E5 RID: 5093
		private const string KEY_PREFIX = "FishingIllustratedRewardById";

		// Token: 0x040013E6 RID: 5094
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013E7 RID: 5095
		private static int HandleId;
	}
}
