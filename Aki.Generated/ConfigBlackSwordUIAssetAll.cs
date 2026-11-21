using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010E RID: 270
	public class ConfigBlackSwordUIAssetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000655 RID: 1621 RVA: 0x0008119C File Offset: 0x0007F39C
		static ConfigBlackSwordUIAssetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordUIAssetAll.CreateStaticDefaultValue), new Action(ConfigBlackSwordUIAssetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000811BC File Offset: 0x0007F3BC
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

		// Token: 0x06000657 RID: 1623 RVA: 0x0008123B File Offset: 0x0007F43B
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordUIAssetAll.LogPair = null;
			ConfigBlackSwordUIAssetAll.HandleId = 0;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00081249 File Offset: 0x0007F449
		public static void Init()
		{
			ConfigBlackSwordUIAssetAll.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordUIAssetAll.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordUIAsset`");
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00081264 File Offset: 0x0007F464
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

		// Token: 0x04000746 RID: 1862
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x04000747 RID: 1863
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x04000748 RID: 1864
		private const string TABLE = "BlackSwordUIAsset";

		// Token: 0x04000749 RID: 1865
		private const string COMMAND = "select BinData from `BlackSwordUIAsset`";

		// Token: 0x0400074A RID: 1866
		private const string KEY_PREFIX = "BlackSwordUIAssetAll";

		// Token: 0x0400074B RID: 1867
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400074C RID: 1868
		private static int HandleId;
	}
}
