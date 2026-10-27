using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E8 RID: 744
	public class ConfigFishingQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001175 RID: 4469 RVA: 0x000BC31C File Offset: 0x000BA51C
		static ConfigFishingQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingQualityById.CreateStaticDefaultValue), new Action(ConfigFishingQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000BC33C File Offset: 0x000BA53C
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

		// Token: 0x06001177 RID: 4471 RVA: 0x000BC3BB File Offset: 0x000BA5BB
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingQualityById.LogPair = null;
			ConfigFishingQualityById.HandleId = 0;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x000BC3C9 File Offset: 0x000BA5C9
		public static void Init()
		{
			ConfigFishingQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingQualityById.HandleId, "db_fishing.db", "select BinData from `FishingQuality` where Id=?");
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x000BC3E4 File Offset: 0x000BA5E4
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

		// Token: 0x0400143C RID: 5180
		private const string DB = "db_fishing.db";

		// Token: 0x0400143D RID: 5181
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x0400143E RID: 5182
		private const string TABLE = "FishingQuality";

		// Token: 0x0400143F RID: 5183
		private const string COMMAND = "select BinData from `FishingQuality` where Id=?";

		// Token: 0x04001440 RID: 5184
		private const string KEY_PREFIX = "FishingQualityById";

		// Token: 0x04001441 RID: 5185
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001442 RID: 5186
		private static int HandleId;
	}
}
