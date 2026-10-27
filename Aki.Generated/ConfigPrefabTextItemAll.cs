using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000753 RID: 1875
	public class ConfigPrefabTextItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C03 RID: 11267 RVA: 0x00152309 File Offset: 0x00150509
		static ConfigPrefabTextItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrefabTextItemAll.CreateStaticDefaultValue), new Action(ConfigPrefabTextItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00152328 File Offset: 0x00150528
		public static void CreateStaticDefaultValue()
		{
			ConfigPrefabTextItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPrefabTextItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui_prefabtextitem.db"),
				new ValueTuple<string, object>("文件", "u.UiTextCollect/u.预制体文本收集.csv"),
				new ValueTuple<string, object>("表名", "PrefabTextItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PrefabTextItem`")
			});
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x001523A7 File Offset: 0x001505A7
		public static void ResetStaticDefaultValue()
		{
			ConfigPrefabTextItemAll.LogPair = null;
			ConfigPrefabTextItemAll.HandleId = 0;
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x001523B5 File Offset: 0x001505B5
		public static void Init()
		{
			ConfigPrefabTextItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPrefabTextItemAll.HandleId, "db_ui_prefabtextitem.db", "select BinData from `PrefabTextItem`");
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x001523D0 File Offset: 0x001505D0
		[NullableContext(2)]
		public static IReadOnlyList<PrefabTextItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPrefabTextItemAll.HandleId, ConfigPrefabTextItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PrefabTextItem> readOnlyList = (IReadOnlyList<PrefabTextItem>)ConfigCommon.GetConfig("PrefabTextItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PrefabTextItem> list = new List<PrefabTextItem>();
			while (ConfigCommon.Step(ConfigPrefabTextItemAll.HandleId, false, ConfigPrefabTextItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPrefabTextItemAll.HandleId, 0, ConfigPrefabTextItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPrefabTextItemAll.HandleId, ConfigPrefabTextItemAll.LogPair);
					return null;
				}
				PrefabTextItem rootAsPrefabTextItem = PrefabTextItem.GetRootAsPrefabTextItem(new ByteBuffer(item2));
				list.Add(rootAsPrefabTextItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PrefabTextItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPrefabTextItemAll.HandleId, ConfigPrefabTextItemAll.LogPair);
			return list;
		}

		// Token: 0x0400332B RID: 13099
		private const string DB = "db_ui_prefabtextitem.db";

		// Token: 0x0400332C RID: 13100
		private const string FILE = "u.UiTextCollect/u.预制体文本收集.csv";

		// Token: 0x0400332D RID: 13101
		private const string TABLE = "PrefabTextItem";

		// Token: 0x0400332E RID: 13102
		private const string COMMAND = "select BinData from `PrefabTextItem`";

		// Token: 0x0400332F RID: 13103
		private const string KEY_PREFIX = "PrefabTextItemAll";

		// Token: 0x04003330 RID: 13104
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003331 RID: 13105
		private static int HandleId;
	}
}
