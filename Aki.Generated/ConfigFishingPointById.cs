using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F8 RID: 760
	public class ConfigFishingPointById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011D5 RID: 4565 RVA: 0x000C1CD0 File Offset: 0x000BFED0
		static ConfigFishingPointById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingPointById.CreateStaticDefaultValue), new Action(ConfigFishingPointById.ResetStaticDefaultValue));
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x000C1CF0 File Offset: 0x000BFEF0
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingPointById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingPointById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼相关.xlsx"),
				new ValueTuple<string, object>("表名", "FishingPoint"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingPoint` where Id=?")
			});
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x000C1D6F File Offset: 0x000BFF6F
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingPointById.LogPair = null;
			ConfigFishingPointById.HandleId = 0;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x000C1D7D File Offset: 0x000BFF7D
		public static void Init()
		{
			ConfigFishingPointById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingPointById.HandleId, "db_fishing.db", "select BinData from `FishingPoint` where Id=?");
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x000C1D98 File Offset: 0x000BFF98
		public static FishingPoint? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingPointById.HandleId, ConfigFishingPointById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPointById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingPoint?(FishingPoint.GetRootAsFishingPoint(configBuffer));
				}
			}
			ConfigFishingPointById.LogPair.Clear();
			ConfigFishingPointById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingPointById.HandleId, 1, p0Id, ConfigFishingPointById.LogPair) || ConfigCommon.Step(ConfigFishingPointById.HandleId, true, ConfigFishingPointById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingPointById.HandleId, ConfigFishingPointById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingPointById.HandleId, 0, ConfigFishingPointById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingPointById.HandleId, ConfigFishingPointById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingPoint rootAsFishingPoint = FishingPoint.GetRootAsFishingPoint(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPointById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingPointById.HandleId, ConfigFishingPointById.LogPair);
			return new FishingPoint?(rootAsFishingPoint);
		}

		// Token: 0x040014AC RID: 5292
		private const string DB = "db_fishing.db";

		// Token: 0x040014AD RID: 5293
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x040014AE RID: 5294
		private const string TABLE = "FishingPoint";

		// Token: 0x040014AF RID: 5295
		private const string COMMAND = "select BinData from `FishingPoint` where Id=?";

		// Token: 0x040014B0 RID: 5296
		private const string KEY_PREFIX = "FishingPointById";

		// Token: 0x040014B1 RID: 5297
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014B2 RID: 5298
		private static int HandleId;
	}
}
