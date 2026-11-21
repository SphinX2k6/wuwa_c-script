using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000493 RID: 1171
	public class ConfigKujiAwardsGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B7C RID: 7036 RVA: 0x000F84BC File Offset: 0x000F66BC
		static ConfigKujiAwardsGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiAwardsGroupAll.CreateStaticDefaultValue), new Action(ConfigKujiAwardsGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x000F84DC File Offset: 0x000F66DC
		public static void CreateStaticDefaultValue()
		{
			ConfigKujiAwardsGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKujiAwardsGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwukuji.db"),
				new ValueTuple<string, object>("文件", "w.呜呜一番赏.xlsx"),
				new ValueTuple<string, object>("表名", "KujiAwardsGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KujiAwardsGroup`")
			});
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x000F855B File Offset: 0x000F675B
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiAwardsGroupAll.LogPair = null;
			ConfigKujiAwardsGroupAll.HandleId = 0;
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x000F8569 File Offset: 0x000F6769
		public static void Init()
		{
			ConfigKujiAwardsGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigKujiAwardsGroupAll.HandleId, "db_wuwukuji.db", "select BinData from `KujiAwardsGroup`");
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x000F8584 File Offset: 0x000F6784
		[NullableContext(2)]
		public static IReadOnlyList<KujiAwardsGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKujiAwardsGroupAll.HandleId, ConfigKujiAwardsGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KujiAwardsGroup> readOnlyList = (IReadOnlyList<KujiAwardsGroup>)ConfigCommon.GetConfig("KujiAwardsGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KujiAwardsGroup> list = new List<KujiAwardsGroup>();
			while (ConfigCommon.Step(ConfigKujiAwardsGroupAll.HandleId, false, ConfigKujiAwardsGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKujiAwardsGroupAll.HandleId, 0, ConfigKujiAwardsGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKujiAwardsGroupAll.HandleId, ConfigKujiAwardsGroupAll.LogPair);
					return null;
				}
				KujiAwardsGroup rootAsKujiAwardsGroup = KujiAwardsGroup.GetRootAsKujiAwardsGroup(new ByteBuffer(item2));
				list.Add(rootAsKujiAwardsGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KujiAwardsGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKujiAwardsGroupAll.HandleId, ConfigKujiAwardsGroupAll.LogPair);
			return list;
		}

		// Token: 0x04001FE9 RID: 8169
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001FEA RID: 8170
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001FEB RID: 8171
		private const string TABLE = "KujiAwardsGroup";

		// Token: 0x04001FEC RID: 8172
		private const string COMMAND = "select BinData from `KujiAwardsGroup`";

		// Token: 0x04001FED RID: 8173
		private const string KEY_PREFIX = "KujiAwardsGroupAll";

		// Token: 0x04001FEE RID: 8174
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FEF RID: 8175
		private static int HandleId;
	}
}
