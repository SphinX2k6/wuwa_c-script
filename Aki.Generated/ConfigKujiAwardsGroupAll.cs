using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047D RID: 1149
	public class ConfigKujiAwardsGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AF8 RID: 6904 RVA: 0x000F1D68 File Offset: 0x000EFF68
		static ConfigKujiAwardsGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiAwardsGroupAll.CreateStaticDefaultValue), new Action(ConfigKujiAwardsGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000F1D88 File Offset: 0x000EFF88
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

		// Token: 0x06001AFA RID: 6906 RVA: 0x000F1E07 File Offset: 0x000F0007
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiAwardsGroupAll.LogPair = null;
			ConfigKujiAwardsGroupAll.HandleId = 0;
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000F1E15 File Offset: 0x000F0015
		public static void Init()
		{
			ConfigKujiAwardsGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigKujiAwardsGroupAll.HandleId, "db_wuwukuji.db", "select BinData from `KujiAwardsGroup`");
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x000F1E30 File Offset: 0x000F0030
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

		// Token: 0x04001F4F RID: 8015
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001F50 RID: 8016
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001F51 RID: 8017
		private const string TABLE = "KujiAwardsGroup";

		// Token: 0x04001F52 RID: 8018
		private const string COMMAND = "select BinData from `KujiAwardsGroup`";

		// Token: 0x04001F53 RID: 8019
		private const string KEY_PREFIX = "KujiAwardsGroupAll";

		// Token: 0x04001F54 RID: 8020
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F55 RID: 8021
		private static int HandleId;
	}
}
