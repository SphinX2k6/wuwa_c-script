using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FD RID: 765
	public class ConfigFishingQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011F3 RID: 4595 RVA: 0x000C2828 File Offset: 0x000C0A28
		static ConfigFishingQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingQualityById.CreateStaticDefaultValue), new Action(ConfigFishingQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x000C2848 File Offset: 0x000C0A48
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼相关.xlsx"),
				new ValueTuple<string, object>("表名", "FishingQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingQuality` where Id=?")
			});
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x000C28C7 File Offset: 0x000C0AC7
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingQualityById.LogPair = null;
			ConfigFishingQualityById.HandleId = 0;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x000C28D5 File Offset: 0x000C0AD5
		public static void Init()
		{
			ConfigFishingQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingQualityById.HandleId, "db_fishing.db", "select BinData from `FishingQuality` where Id=?");
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x000C28F0 File Offset: 0x000C0AF0
		public static FishingQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingQualityById.HandleId, ConfigFishingQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingQuality?(FishingQuality.GetRootAsFishingQuality(configBuffer));
				}
			}
			ConfigFishingQualityById.LogPair.Clear();
			ConfigFishingQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingQualityById.HandleId, 1, p0Id, ConfigFishingQualityById.LogPair) || ConfigCommon.Step(ConfigFishingQualityById.HandleId, true, ConfigFishingQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingQualityById.HandleId, ConfigFishingQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingQualityById.HandleId, 0, ConfigFishingQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingQualityById.HandleId, ConfigFishingQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingQuality rootAsFishingQuality = FishingQuality.GetRootAsFishingQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingQualityById.HandleId, ConfigFishingQualityById.LogPair);
			return new FishingQuality?(rootAsFishingQuality);
		}

		// Token: 0x040014CF RID: 5327
		private const string DB = "db_fishing.db";

		// Token: 0x040014D0 RID: 5328
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x040014D1 RID: 5329
		private const string TABLE = "FishingQuality";

		// Token: 0x040014D2 RID: 5330
		private const string COMMAND = "select BinData from `FishingQuality` where Id=?";

		// Token: 0x040014D3 RID: 5331
		private const string KEY_PREFIX = "FishingQualityById";

		// Token: 0x040014D4 RID: 5332
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014D5 RID: 5333
		private static int HandleId;
	}
}
