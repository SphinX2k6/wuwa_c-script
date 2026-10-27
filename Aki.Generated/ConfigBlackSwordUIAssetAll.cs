using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FF RID: 255
	public class ConfigBlackSwordUIAssetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x0007B838 File Offset: 0x00079A38
		static ConfigBlackSwordUIAssetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordUIAssetAll.CreateStaticDefaultValue), new Action(ConfigBlackSwordUIAssetAll.ResetStaticDefaultValue));
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0007B858 File Offset: 0x00079A58
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackSwordUIAssetAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackSwordUIAssetAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackswordchallenge.db"),
				new ValueTuple<string, object>("文件", "h.黑剑挑战.xlsx"),
				new ValueTuple<string, object>("表名", "BlackSwordUIAsset"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackSwordUIAsset`")
			});
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0007B8D7 File Offset: 0x00079AD7
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordUIAssetAll.LogPair = null;
			ConfigBlackSwordUIAssetAll.HandleId = 0;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0007B8E5 File Offset: 0x00079AE5
		public static void Init()
		{
			ConfigBlackSwordUIAssetAll.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordUIAssetAll.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordUIAsset`");
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0007B900 File Offset: 0x00079B00
		[NullableContext(2)]
		public static IReadOnlyList<BlackSwordUIAsset> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackSwordUIAssetAll.HandleId, ConfigBlackSwordUIAssetAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BlackSwordUIAsset> readOnlyList = (IReadOnlyList<BlackSwordUIAsset>)ConfigCommon.GetConfig("BlackSwordUIAssetAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BlackSwordUIAsset> list = new List<BlackSwordUIAsset>();
			while (ConfigCommon.Step(ConfigBlackSwordUIAssetAll.HandleId, false, ConfigBlackSwordUIAssetAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackSwordUIAssetAll.HandleId, 0, ConfigBlackSwordUIAssetAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBlackSwordUIAssetAll.HandleId, ConfigBlackSwordUIAssetAll.LogPair);
					return null;
				}
				BlackSwordUIAsset rootAsBlackSwordUIAsset = BlackSwordUIAsset.GetRootAsBlackSwordUIAsset(new ByteBuffer(item2));
				list.Add(rootAsBlackSwordUIAsset);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BlackSwordUIAssetAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBlackSwordUIAssetAll.HandleId, ConfigBlackSwordUIAssetAll.LogPair);
			return list;
		}

		// Token: 0x040006DD RID: 1757
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x040006DE RID: 1758
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x040006DF RID: 1759
		private const string TABLE = "BlackSwordUIAsset";

		// Token: 0x040006E0 RID: 1760
		private const string COMMAND = "select BinData from `BlackSwordUIAsset`";

		// Token: 0x040006E1 RID: 1761
		private const string KEY_PREFIX = "BlackSwordUIAssetAll";

		// Token: 0x040006E2 RID: 1762
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006E3 RID: 1763
		private static int HandleId;
	}
}
