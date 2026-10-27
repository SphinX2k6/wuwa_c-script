using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DF RID: 735
	public class ConfigFishingManualRefreshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600113F RID: 4415 RVA: 0x000BAEF3 File Offset: 0x000B90F3
		static ConfigFishingManualRefreshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingManualRefreshById.CreateStaticDefaultValue), new Action(ConfigFishingManualRefreshById.ResetStaticDefaultValue));
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x000BAF14 File Offset: 0x000B9114
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingManualRefreshById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingManualRefreshById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼委托.xlsx"),
				new ValueTuple<string, object>("表名", "FishingManualRefresh"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingManualRefresh` where Id=?")
			});
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000BAF93 File Offset: 0x000B9193
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingManualRefreshById.LogPair = null;
			ConfigFishingManualRefreshById.HandleId = 0;
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x000BAFA1 File Offset: 0x000B91A1
		public static void Init()
		{
			ConfigFishingManualRefreshById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingManualRefreshById.HandleId, "db_fishing.db", "select BinData from `FishingManualRefresh` where Id=?");
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x000BAFBC File Offset: 0x000B91BC
		public static FishingManualRefresh? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingManualRefreshById.HandleId, ConfigFishingManualRefreshById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingManualRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingManualRefresh?(FishingManualRefresh.GetRootAsFishingManualRefresh(configBuffer));
				}
			}
			ConfigFishingManualRefreshById.LogPair.Clear();
			ConfigFishingManualRefreshById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingManualRefreshById.HandleId, 1, p0Id, ConfigFishingManualRefreshById.LogPair) || ConfigCommon.Step(ConfigFishingManualRefreshById.HandleId, true, ConfigFishingManualRefreshById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingManualRefreshById.HandleId, ConfigFishingManualRefreshById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingManualRefreshById.HandleId, 0, ConfigFishingManualRefreshById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingManualRefreshById.HandleId, ConfigFishingManualRefreshById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingManualRefresh rootAsFishingManualRefresh = FishingManualRefresh.GetRootAsFishingManualRefresh(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingManualRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingManualRefreshById.HandleId, ConfigFishingManualRefreshById.LogPair);
			return new FishingManualRefresh?(rootAsFishingManualRefresh);
		}

		// Token: 0x040013FD RID: 5117
		private const string DB = "db_fishing.db";

		// Token: 0x040013FE RID: 5118
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x040013FF RID: 5119
		private const string TABLE = "FishingManualRefresh";

		// Token: 0x04001400 RID: 5120
		private const string COMMAND = "select BinData from `FishingManualRefresh` where Id=?";

		// Token: 0x04001401 RID: 5121
		private const string KEY_PREFIX = "FishingManualRefreshById";

		// Token: 0x04001402 RID: 5122
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001403 RID: 5123
		private static int HandleId;
	}
}
