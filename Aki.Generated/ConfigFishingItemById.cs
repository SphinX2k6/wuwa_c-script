using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F2 RID: 754
	public class ConfigFishingItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011B1 RID: 4529 RVA: 0x000C0F27 File Offset: 0x000BF127
		static ConfigFishingItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingItemById.CreateStaticDefaultValue), new Action(ConfigFishingItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x000C0F48 File Offset: 0x000BF148
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

		// Token: 0x060011B3 RID: 4531 RVA: 0x000C0FC7 File Offset: 0x000BF1C7
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingItemById.LogPair = null;
			ConfigFishingItemById.HandleId = 0;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x000C0FD5 File Offset: 0x000BF1D5
		public static void Init()
		{
			ConfigFishingItemById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingItemById.HandleId, "db_fishing.db", "select BinData from `FishingItem` where Id=?");
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x000C0FF0 File Offset: 0x000BF1F0
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

		// Token: 0x04001482 RID: 5250
		private const string DB = "db_fishing.db";

		// Token: 0x04001483 RID: 5251
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x04001484 RID: 5252
		private const string TABLE = "FishingItem";

		// Token: 0x04001485 RID: 5253
		private const string COMMAND = "select BinData from `FishingItem` where Id=?";

		// Token: 0x04001486 RID: 5254
		private const string KEY_PREFIX = "FishingItemById";

		// Token: 0x04001487 RID: 5255
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001488 RID: 5256
		private static int HandleId;
	}
}
