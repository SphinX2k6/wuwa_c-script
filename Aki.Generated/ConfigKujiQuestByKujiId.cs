using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000482 RID: 1154
	public class ConfigKujiQuestByKujiId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B16 RID: 6934 RVA: 0x000F2758 File Offset: 0x000F0958
		static ConfigKujiQuestByKujiId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiQuestByKujiId.CreateStaticDefaultValue), new Action(ConfigKujiQuestByKujiId.ResetStaticDefaultValue));
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x000F2778 File Offset: 0x000F0978
		public static void CreateStaticDefaultValue()
		{
			ConfigKujiQuestByKujiId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKujiQuestByKujiId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwukuji.db"),
				new ValueTuple<string, object>("文件", "w.呜呜一番赏.xlsx"),
				new ValueTuple<string, object>("表名", "KujiQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `KujiQuest` where KujiId=?")
			});
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x000F27F7 File Offset: 0x000F09F7
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiQuestByKujiId.LogPair = null;
			ConfigKujiQuestByKujiId.HandleId = 0;
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x000F2805 File Offset: 0x000F0A05
		public static void Init()
		{
			ConfigKujiQuestByKujiId.HandleId = ConfigCommon.InitDataStatement(ConfigKujiQuestByKujiId.HandleId, "db_wuwukuji.db", "select BinData from `KujiQuest` where KujiId=?");
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000F2820 File Offset: 0x000F0A20
		[NullableContext(2)]
		public static IReadOnlyList<KujiQuest> GetConfigList(int p0KujiId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKujiQuestByKujiId.HandleId, ConfigKujiQuestByKujiId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KujiQuestByKujiId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0KujiId);
				IReadOnlyList<KujiQuest> readOnlyList = (IReadOnlyList<KujiQuest>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKujiQuestByKujiId.LogPair.Clear();
			ConfigKujiQuestByKujiId.LogPair.Add(new ValueTuple<string, object>("KujiId", p0KujiId));
			if (!ConfigCommon.BindInt(ConfigKujiQuestByKujiId.HandleId, 1, p0KujiId, ConfigKujiQuestByKujiId.LogPair))
			{
				ConfigCommon.Reset(ConfigKujiQuestByKujiId.HandleId, ConfigKujiQuestByKujiId.LogPair);
				return null;
			}
			List<KujiQuest> list = new List<KujiQuest>();
			while (ConfigCommon.Step(ConfigKujiQuestByKujiId.HandleId, false, ConfigKujiQuestByKujiId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKujiQuestByKujiId.HandleId, 0, ConfigKujiQuestByKujiId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKujiQuestByKujiId.HandleId, ConfigKujiQuestByKujiId.LogPair);
					return null;
				}
				KujiQuest rootAsKujiQuest = KujiQuest.GetRootAsKujiQuest(new ByteBuffer(item2));
				list.Add(rootAsKujiQuest);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KujiQuestByKujiId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0KujiId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKujiQuestByKujiId.HandleId, ConfigKujiQuestByKujiId.LogPair);
			return list;
		}

		// Token: 0x04001F72 RID: 8050
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001F73 RID: 8051
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001F74 RID: 8052
		private const string TABLE = "KujiQuest";

		// Token: 0x04001F75 RID: 8053
		private const string COMMAND = "select BinData from `KujiQuest` where KujiId=?";

		// Token: 0x04001F76 RID: 8054
		private const string KEY_PREFIX = "KujiQuestByKujiId";

		// Token: 0x04001F77 RID: 8055
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F78 RID: 8056
		private static int HandleId;
	}
}
