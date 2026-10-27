using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000761 RID: 1889
	public class ConfigPreviewItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C57 RID: 11351 RVA: 0x00153EB0 File Offset: 0x001520B0
		static ConfigPreviewItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreviewItemAll.CreateStaticDefaultValue), new Action(ConfigPreviewItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00153ED0 File Offset: 0x001520D0
		public static void CreateStaticDefaultValue()
		{
			ConfigPreviewItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreviewItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "PreviewItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PreviewItem`")
			});
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x00153F4F File Offset: 0x0015214F
		public static void ResetStaticDefaultValue()
		{
			ConfigPreviewItemAll.LogPair = null;
			ConfigPreviewItemAll.HandleId = 0;
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00153F5D File Offset: 0x0015215D
		public static void Init()
		{
			ConfigPreviewItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreviewItemAll.HandleId, "db_item.db", "select BinData from `PreviewItem`");
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x00153F78 File Offset: 0x00152178
		[NullableContext(2)]
		public static IReadOnlyList<PreviewItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreviewItemAll.HandleId, ConfigPreviewItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PreviewItem> readOnlyList = (IReadOnlyList<PreviewItem>)ConfigCommon.GetConfig("PreviewItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PreviewItem> list = new List<PreviewItem>();
			while (ConfigCommon.Step(ConfigPreviewItemAll.HandleId, false, ConfigPreviewItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreviewItemAll.HandleId, 0, ConfigPreviewItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPreviewItemAll.HandleId, ConfigPreviewItemAll.LogPair);
					return null;
				}
				PreviewItem rootAsPreviewItem = PreviewItem.GetRootAsPreviewItem(new ByteBuffer(item2));
				list.Add(rootAsPreviewItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PreviewItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPreviewItemAll.HandleId, ConfigPreviewItemAll.LogPair);
			return list;
		}

		// Token: 0x0400338D RID: 13197
		private const string DB = "db_item.db";

		// Token: 0x0400338E RID: 13198
		private const string FILE = "d.道具.xlsx";

		// Token: 0x0400338F RID: 13199
		private const string TABLE = "PreviewItem";

		// Token: 0x04003390 RID: 13200
		private const string COMMAND = "select BinData from `PreviewItem`";

		// Token: 0x04003391 RID: 13201
		private const string KEY_PREFIX = "PreviewItemAll";

		// Token: 0x04003392 RID: 13202
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003393 RID: 13203
		private static int HandleId;
	}
}
