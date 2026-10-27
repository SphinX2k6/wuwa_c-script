using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D5 RID: 725
	public class ConfigFishingDeliveryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001103 RID: 4355 RVA: 0x000B9944 File Offset: 0x000B7B44
		static ConfigFishingDeliveryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingDeliveryById.CreateStaticDefaultValue), new Action(ConfigFishingDeliveryById.ResetStaticDefaultValue));
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000B9964 File Offset: 0x000B7B64
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

		// Token: 0x06001105 RID: 4357 RVA: 0x000B99E3 File Offset: 0x000B7BE3
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingDeliveryById.LogPair = null;
			ConfigFishingDeliveryById.HandleId = 0;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x000B99F1 File Offset: 0x000B7BF1
		public static void Init()
		{
			ConfigFishingDeliveryById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingDeliveryById.HandleId, "db_fishing.db", "select BinData from `FishingDelivery` where Id=?");
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x000B9A0C File Offset: 0x000B7C0C
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

		// Token: 0x040013B7 RID: 5047
		private const string DB = "db_fishing.db";

		// Token: 0x040013B8 RID: 5048
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x040013B9 RID: 5049
		private const string TABLE = "FishingDelivery";

		// Token: 0x040013BA RID: 5050
		private const string COMMAND = "select BinData from `FishingDelivery` where Id=?";

		// Token: 0x040013BB RID: 5051
		private const string KEY_PREFIX = "FishingDeliveryById";

		// Token: 0x040013BC RID: 5052
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013BD RID: 5053
		private static int HandleId;
	}
}
