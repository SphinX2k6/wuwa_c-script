using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F4 RID: 756
	public class ConfigFishingManualRefreshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011BD RID: 4541 RVA: 0x000C13FF File Offset: 0x000BF5FF
		static ConfigFishingManualRefreshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingManualRefreshById.CreateStaticDefaultValue), new Action(ConfigFishingManualRefreshById.ResetStaticDefaultValue));
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x000C1420 File Offset: 0x000BF620
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

		// Token: 0x060011BF RID: 4543 RVA: 0x000C149F File Offset: 0x000BF69F
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingManualRefreshById.LogPair = null;
			ConfigFishingManualRefreshById.HandleId = 0;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000C14AD File Offset: 0x000BF6AD
		public static void Init()
		{
			ConfigFishingManualRefreshById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingManualRefreshById.HandleId, "db_fishing.db", "select BinData from `FishingManualRefresh` where Id=?");
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000C14C8 File Offset: 0x000BF6C8
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

		// Token: 0x04001490 RID: 5264
		private const string DB = "db_fishing.db";

		// Token: 0x04001491 RID: 5265
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x04001492 RID: 5266
		private const string TABLE = "FishingManualRefresh";

		// Token: 0x04001493 RID: 5267
		private const string COMMAND = "select BinData from `FishingManualRefresh` where Id=?";

		// Token: 0x04001494 RID: 5268
		private const string KEY_PREFIX = "FishingManualRefreshById";

		// Token: 0x04001495 RID: 5269
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001496 RID: 5270
		private static int HandleId;
	}
}
