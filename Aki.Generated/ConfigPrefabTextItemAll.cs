using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076B RID: 1899
	public class ConfigPrefabTextItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C93 RID: 11411 RVA: 0x00158D85 File Offset: 0x00156F85
		static ConfigPrefabTextItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrefabTextItemAll.CreateStaticDefaultValue), new Action(ConfigPrefabTextItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x00158DA4 File Offset: 0x00156FA4
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

		// Token: 0x06002C95 RID: 11413 RVA: 0x00158E23 File Offset: 0x00157023
		public static void ResetStaticDefaultValue()
		{
			ConfigPrefabTextItemAll.LogPair = null;
			ConfigPrefabTextItemAll.HandleId = 0;
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x00158E31 File Offset: 0x00157031
		public static void Init()
		{
			ConfigPrefabTextItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPrefabTextItemAll.HandleId, "db_ui_prefabtextitem.db", "select BinData from `PrefabTextItem`");
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00158E4C File Offset: 0x0015704C
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

		// Token: 0x040033D3 RID: 13267
		private const string DB = "db_ui_prefabtextitem.db";

		// Token: 0x040033D4 RID: 13268
		private const string FILE = "u.UiTextCollect/u.预制体文本收集.csv";

		// Token: 0x040033D5 RID: 13269
		private const string TABLE = "PrefabTextItem";

		// Token: 0x040033D6 RID: 13270
		private const string COMMAND = "select BinData from `PrefabTextItem`";

		// Token: 0x040033D7 RID: 13271
		private const string KEY_PREFIX = "PrefabTextItemAll";

		// Token: 0x040033D8 RID: 13272
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033D9 RID: 13273
		private static int HandleId;
	}
}
