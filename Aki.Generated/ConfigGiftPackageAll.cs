using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B0 RID: 944
	public class ConfigGiftPackageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001627 RID: 5671 RVA: 0x000DA700 File Offset: 0x000D8900
		static ConfigGiftPackageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiftPackageAll.CreateStaticDefaultValue), new Action(ConfigGiftPackageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000DA720 File Offset: 0x000D8920
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

		// Token: 0x06001629 RID: 5673 RVA: 0x000DA79F File Offset: 0x000D899F
		public static void ResetStaticDefaultValue()
		{
			ConfigGiftPackageAll.LogPair = null;
			ConfigGiftPackageAll.HandleId = 0;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000DA7AD File Offset: 0x000D89AD
		public static void Init()
		{
			ConfigGiftPackageAll.HandleId = ConfigCommon.InitDataStatement(ConfigGiftPackageAll.HandleId, "db_giftpackage.db", "select BinData from `GiftPackage`");
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000DA7C8 File Offset: 0x000D89C8
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

		// Token: 0x040019B4 RID: 6580
		private const string DB = "db_giftpackage.db";

		// Token: 0x040019B5 RID: 6581
		private const string FILE = "l.礼包.xlsx";

		// Token: 0x040019B6 RID: 6582
		private const string TABLE = "GiftPackage";

		// Token: 0x040019B7 RID: 6583
		private const string COMMAND = "select BinData from `GiftPackage`";

		// Token: 0x040019B8 RID: 6584
		private const string KEY_PREFIX = "GiftPackageAll";

		// Token: 0x040019B9 RID: 6585
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019BA RID: 6586
		private static int HandleId;
	}
}
