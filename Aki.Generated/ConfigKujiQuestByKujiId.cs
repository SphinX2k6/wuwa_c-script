using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000498 RID: 1176
	public class ConfigKujiQuestByKujiId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B9A RID: 7066 RVA: 0x000F8EAC File Offset: 0x000F70AC
		static ConfigKujiQuestByKujiId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiQuestByKujiId.CreateStaticDefaultValue), new Action(ConfigKujiQuestByKujiId.ResetStaticDefaultValue));
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x000F8ECC File Offset: 0x000F70CC
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

		// Token: 0x06001B9C RID: 7068 RVA: 0x000F8F4B File Offset: 0x000F714B
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiQuestByKujiId.LogPair = null;
			ConfigKujiQuestByKujiId.HandleId = 0;
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x000F8F59 File Offset: 0x000F7159
		public static void Init()
		{
			ConfigKujiQuestByKujiId.HandleId = ConfigCommon.InitDataStatement(ConfigKujiQuestByKujiId.HandleId, "db_wuwukuji.db", "select BinData from `KujiQuest` where KujiId=?");
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000F8F74 File Offset: 0x000F7174
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

		// Token: 0x0400200C RID: 8204
		private const string DB = "db_wuwukuji.db";

		// Token: 0x0400200D RID: 8205
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x0400200E RID: 8206
		private const string TABLE = "KujiQuest";

		// Token: 0x0400200F RID: 8207
		private const string COMMAND = "select BinData from `KujiQuest` where KujiId=?";

		// Token: 0x04002010 RID: 8208
		private const string KEY_PREFIX = "KujiQuestByKujiId";

		// Token: 0x04002011 RID: 8209
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002012 RID: 8210
		private static int HandleId;
	}
}
