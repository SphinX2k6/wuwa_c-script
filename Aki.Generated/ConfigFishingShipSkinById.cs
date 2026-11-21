using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000301 RID: 769
	public class ConfigFishingShipSkinById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600120B RID: 4619 RVA: 0x000C2FDF File Offset: 0x000C11DF
		static ConfigFishingShipSkinById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingShipSkinById.CreateStaticDefaultValue), new Action(ConfigFishingShipSkinById.ResetStaticDefaultValue));
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000C3000 File Offset: 0x000C1200
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

		// Token: 0x0600120D RID: 4621 RVA: 0x000C307F File Offset: 0x000C127F
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingShipSkinById.LogPair = null;
			ConfigFishingShipSkinById.HandleId = 0;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x000C308D File Offset: 0x000C128D
		public static void Init()
		{
			ConfigFishingShipSkinById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingShipSkinById.HandleId, "db_fishing.db", "select BinData from `FishingShipSkin` where Id=?");
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x000C30A8 File Offset: 0x000C12A8
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

		// Token: 0x040014EB RID: 5355
		private const string DB = "db_fishing.db";

		// Token: 0x040014EC RID: 5356
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x040014ED RID: 5357
		private const string TABLE = "FishingShipSkin";

		// Token: 0x040014EE RID: 5358
		private const string COMMAND = "select BinData from `FishingShipSkin` where Id=?";

		// Token: 0x040014EF RID: 5359
		private const string KEY_PREFIX = "FishingShipSkinById";

		// Token: 0x040014F0 RID: 5360
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014F1 RID: 5361
		private static int HandleId;
	}
}
