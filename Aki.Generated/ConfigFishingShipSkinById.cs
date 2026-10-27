using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002EC RID: 748
	public class ConfigFishingShipSkinById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600118D RID: 4493 RVA: 0x000BCAD3 File Offset: 0x000BACD3
		static ConfigFishingShipSkinById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingShipSkinById.CreateStaticDefaultValue), new Action(ConfigFishingShipSkinById.ResetStaticDefaultValue));
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000BCAF4 File Offset: 0x000BACF4
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingShipSkinById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingShipSkinById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingShipSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingShipSkin` where Id=?")
			});
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x000BCB73 File Offset: 0x000BAD73
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingShipSkinById.LogPair = null;
			ConfigFishingShipSkinById.HandleId = 0;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x000BCB81 File Offset: 0x000BAD81
		public static void Init()
		{
			ConfigFishingShipSkinById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingShipSkinById.HandleId, "db_fishing.db", "select BinData from `FishingShipSkin` where Id=?");
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x000BCB9C File Offset: 0x000BAD9C
		public static FishingShipSkin? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingShipSkinById.HandleId, ConfigFishingShipSkinById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingShipSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingShipSkin?(FishingShipSkin.GetRootAsFishingShipSkin(configBuffer));
				}
			}
			ConfigFishingShipSkinById.LogPair.Clear();
			ConfigFishingShipSkinById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingShipSkinById.HandleId, 1, p0Id, ConfigFishingShipSkinById.LogPair) || ConfigCommon.Step(ConfigFishingShipSkinById.HandleId, true, ConfigFishingShipSkinById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingShipSkinById.HandleId, ConfigFishingShipSkinById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingShipSkinById.HandleId, 0, ConfigFishingShipSkinById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingShipSkinById.HandleId, ConfigFishingShipSkinById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingShipSkin rootAsFishingShipSkin = FishingShipSkin.GetRootAsFishingShipSkin(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingShipSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingShipSkinById.HandleId, ConfigFishingShipSkinById.LogPair);
			return new FishingShipSkin?(rootAsFishingShipSkin);
		}

		// Token: 0x04001458 RID: 5208
		private const string DB = "db_fishing.db";

		// Token: 0x04001459 RID: 5209
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x0400145A RID: 5210
		private const string TABLE = "FishingShipSkin";

		// Token: 0x0400145B RID: 5211
		private const string COMMAND = "select BinData from `FishingShipSkin` where Id=?";

		// Token: 0x0400145C RID: 5212
		private const string KEY_PREFIX = "FishingShipSkinById";

		// Token: 0x0400145D RID: 5213
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400145E RID: 5214
		private static int HandleId;
	}
}
