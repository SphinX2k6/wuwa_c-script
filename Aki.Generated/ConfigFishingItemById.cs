using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DD RID: 733
	public class ConfigFishingItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001133 RID: 4403 RVA: 0x000BAA1B File Offset: 0x000B8C1B
		static ConfigFishingItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingItemById.CreateStaticDefaultValue), new Action(ConfigFishingItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x000BAA3C File Offset: 0x000B8C3C
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼相关.xlsx"),
				new ValueTuple<string, object>("表名", "FishingItem"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingItem` where Id=?")
			});
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x000BAABB File Offset: 0x000B8CBB
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingItemById.LogPair = null;
			ConfigFishingItemById.HandleId = 0;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x000BAAC9 File Offset: 0x000B8CC9
		public static void Init()
		{
			ConfigFishingItemById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingItemById.HandleId, "db_fishing.db", "select BinData from `FishingItem` where Id=?");
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x000BAAE4 File Offset: 0x000B8CE4
		public static FishingItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingItemById.HandleId, ConfigFishingItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingItem?(FishingItem.GetRootAsFishingItem(configBuffer));
				}
			}
			ConfigFishingItemById.LogPair.Clear();
			ConfigFishingItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingItemById.HandleId, 1, p0Id, ConfigFishingItemById.LogPair) || ConfigCommon.Step(ConfigFishingItemById.HandleId, true, ConfigFishingItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingItemById.HandleId, ConfigFishingItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingItemById.HandleId, 0, ConfigFishingItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingItemById.HandleId, ConfigFishingItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingItem rootAsFishingItem = FishingItem.GetRootAsFishingItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingItemById.HandleId, ConfigFishingItemById.LogPair);
			return new FishingItem?(rootAsFishingItem);
		}

		// Token: 0x040013EF RID: 5103
		private const string DB = "db_fishing.db";

		// Token: 0x040013F0 RID: 5104
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x040013F1 RID: 5105
		private const string TABLE = "FishingItem";

		// Token: 0x040013F2 RID: 5106
		private const string COMMAND = "select BinData from `FishingItem` where Id=?";

		// Token: 0x040013F3 RID: 5107
		private const string KEY_PREFIX = "FishingItemById";

		// Token: 0x040013F4 RID: 5108
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013F5 RID: 5109
		private static int HandleId;
	}
}
