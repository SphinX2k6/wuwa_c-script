using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002EB RID: 747
	public class ConfigFishingShipSkinAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001187 RID: 4487 RVA: 0x000BC940 File Offset: 0x000BAB40
		static ConfigFishingShipSkinAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingShipSkinAll.CreateStaticDefaultValue), new Action(ConfigFishingShipSkinAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000BC960 File Offset: 0x000BAB60
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingShipSkinAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingShipSkinAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingShipSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingShipSkin`")
			});
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000BC9DF File Offset: 0x000BABDF
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingShipSkinAll.LogPair = null;
			ConfigFishingShipSkinAll.HandleId = 0;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x000BC9ED File Offset: 0x000BABED
		public static void Init()
		{
			ConfigFishingShipSkinAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingShipSkinAll.HandleId, "db_fishing.db", "select BinData from `FishingShipSkin`");
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x000BCA08 File Offset: 0x000BAC08
		[NullableContext(2)]
		public static IReadOnlyList<FishingShipSkin> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingShipSkinAll.HandleId, ConfigFishingShipSkinAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FishingShipSkin> readOnlyList = (IReadOnlyList<FishingShipSkin>)ConfigCommon.GetConfig("FishingShipSkinAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FishingShipSkin> list = new List<FishingShipSkin>();
			while (ConfigCommon.Step(ConfigFishingShipSkinAll.HandleId, false, ConfigFishingShipSkinAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingShipSkinAll.HandleId, 0, ConfigFishingShipSkinAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingShipSkinAll.HandleId, ConfigFishingShipSkinAll.LogPair);
					return null;
				}
				FishingShipSkin rootAsFishingShipSkin = FishingShipSkin.GetRootAsFishingShipSkin(new ByteBuffer(item2));
				list.Add(rootAsFishingShipSkin);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FishingShipSkinAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingShipSkinAll.HandleId, ConfigFishingShipSkinAll.LogPair);
			return list;
		}

		// Token: 0x04001451 RID: 5201
		private const string DB = "db_fishing.db";

		// Token: 0x04001452 RID: 5202
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001453 RID: 5203
		private const string TABLE = "FishingShipSkin";

		// Token: 0x04001454 RID: 5204
		private const string COMMAND = "select BinData from `FishingShipSkin`";

		// Token: 0x04001455 RID: 5205
		private const string KEY_PREFIX = "FishingShipSkinAll";

		// Token: 0x04001456 RID: 5206
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001457 RID: 5207
		private static int HandleId;
	}
}
