using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002EA RID: 746
	public class ConfigFishingDeliveryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001181 RID: 4481 RVA: 0x000BFE50 File Offset: 0x000BE050
		static ConfigFishingDeliveryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingDeliveryById.CreateStaticDefaultValue), new Action(ConfigFishingDeliveryById.ResetStaticDefaultValue));
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x000BFE70 File Offset: 0x000BE070
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingDeliveryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingDeliveryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼委托.xlsx"),
				new ValueTuple<string, object>("表名", "FishingDelivery"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingDelivery` where Id=?")
			});
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x000BFEEF File Offset: 0x000BE0EF
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingDeliveryById.LogPair = null;
			ConfigFishingDeliveryById.HandleId = 0;
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000BFEFD File Offset: 0x000BE0FD
		public static void Init()
		{
			ConfigFishingDeliveryById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingDeliveryById.HandleId, "db_fishing.db", "select BinData from `FishingDelivery` where Id=?");
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x000BFF18 File Offset: 0x000BE118
		public static FishingDelivery? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingDeliveryById.HandleId, ConfigFishingDeliveryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingDeliveryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingDelivery?(FishingDelivery.GetRootAsFishingDelivery(configBuffer));
				}
			}
			ConfigFishingDeliveryById.LogPair.Clear();
			ConfigFishingDeliveryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingDeliveryById.HandleId, 1, p0Id, ConfigFishingDeliveryById.LogPair) || ConfigCommon.Step(ConfigFishingDeliveryById.HandleId, true, ConfigFishingDeliveryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingDeliveryById.HandleId, ConfigFishingDeliveryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingDeliveryById.HandleId, 0, ConfigFishingDeliveryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingDeliveryById.HandleId, ConfigFishingDeliveryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingDelivery rootAsFishingDelivery = FishingDelivery.GetRootAsFishingDelivery(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingDeliveryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingDeliveryById.HandleId, ConfigFishingDeliveryById.LogPair);
			return new FishingDelivery?(rootAsFishingDelivery);
		}

		// Token: 0x0400144A RID: 5194
		private const string DB = "db_fishing.db";

		// Token: 0x0400144B RID: 5195
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x0400144C RID: 5196
		private const string TABLE = "FishingDelivery";

		// Token: 0x0400144D RID: 5197
		private const string COMMAND = "select BinData from `FishingDelivery` where Id=?";

		// Token: 0x0400144E RID: 5198
		private const string KEY_PREFIX = "FishingDeliveryById";

		// Token: 0x0400144F RID: 5199
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001450 RID: 5200
		private static int HandleId;
	}
}
