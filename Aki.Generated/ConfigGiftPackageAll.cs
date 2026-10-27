using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039A RID: 922
	public class ConfigGiftPackageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015A3 RID: 5539 RVA: 0x000D3FAC File Offset: 0x000D21AC
		static ConfigGiftPackageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiftPackageAll.CreateStaticDefaultValue), new Action(ConfigGiftPackageAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x000D3FCC File Offset: 0x000D21CC
		public static void CreateStaticDefaultValue()
		{
			ConfigGiftPackageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiftPackageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giftpackage.db"),
				new ValueTuple<string, object>("文件", "l.礼包.xlsx"),
				new ValueTuple<string, object>("表名", "GiftPackage"),
				new ValueTuple<string, object>("语句", "select BinData from `GiftPackage`")
			});
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x000D404B File Offset: 0x000D224B
		public static void ResetStaticDefaultValue()
		{
			ConfigGiftPackageAll.LogPair = null;
			ConfigGiftPackageAll.HandleId = 0;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x000D4059 File Offset: 0x000D2259
		public static void Init()
		{
			ConfigGiftPackageAll.HandleId = ConfigCommon.InitDataStatement(ConfigGiftPackageAll.HandleId, "db_giftpackage.db", "select BinData from `GiftPackage`");
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x000D4074 File Offset: 0x000D2274
		[NullableContext(2)]
		public static IReadOnlyList<GiftPackage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiftPackageAll.HandleId, ConfigGiftPackageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GiftPackage> readOnlyList = (IReadOnlyList<GiftPackage>)ConfigCommon.GetConfig("GiftPackageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GiftPackage> list = new List<GiftPackage>();
			while (ConfigCommon.Step(ConfigGiftPackageAll.HandleId, false, ConfigGiftPackageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiftPackageAll.HandleId, 0, ConfigGiftPackageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGiftPackageAll.HandleId, ConfigGiftPackageAll.LogPair);
					return null;
				}
				GiftPackage rootAsGiftPackage = GiftPackage.GetRootAsGiftPackage(new ByteBuffer(item2));
				list.Add(rootAsGiftPackage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GiftPackageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGiftPackageAll.HandleId, ConfigGiftPackageAll.LogPair);
			return list;
		}

		// Token: 0x0400191A RID: 6426
		private const string DB = "db_giftpackage.db";

		// Token: 0x0400191B RID: 6427
		private const string FILE = "l.礼包.xlsx";

		// Token: 0x0400191C RID: 6428
		private const string TABLE = "GiftPackage";

		// Token: 0x0400191D RID: 6429
		private const string COMMAND = "select BinData from `GiftPackage`";

		// Token: 0x0400191E RID: 6430
		private const string KEY_PREFIX = "GiftPackageAll";

		// Token: 0x0400191F RID: 6431
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001920 RID: 6432
		private static int HandleId;
	}
}
