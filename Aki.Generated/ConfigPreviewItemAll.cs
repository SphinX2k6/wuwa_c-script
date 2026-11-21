using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000779 RID: 1913
	public class ConfigPreviewItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CE7 RID: 11495 RVA: 0x0015A92C File Offset: 0x00158B2C
		static ConfigPreviewItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreviewItemAll.CreateStaticDefaultValue), new Action(ConfigPreviewItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x0015A94C File Offset: 0x00158B4C
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

		// Token: 0x06002CE9 RID: 11497 RVA: 0x0015A9CB File Offset: 0x00158BCB
		public static void ResetStaticDefaultValue()
		{
			ConfigPreviewItemAll.LogPair = null;
			ConfigPreviewItemAll.HandleId = 0;
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x0015A9D9 File Offset: 0x00158BD9
		public static void Init()
		{
			ConfigPreviewItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreviewItemAll.HandleId, "db_item.db", "select BinData from `PreviewItem`");
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x0015A9F4 File Offset: 0x00158BF4
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

		// Token: 0x04003435 RID: 13365
		private const string DB = "db_item.db";

		// Token: 0x04003436 RID: 13366
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04003437 RID: 13367
		private const string TABLE = "PreviewItem";

		// Token: 0x04003438 RID: 13368
		private const string COMMAND = "select BinData from `PreviewItem`";

		// Token: 0x04003439 RID: 13369
		private const string KEY_PREFIX = "PreviewItemAll";

		// Token: 0x0400343A RID: 13370
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400343B RID: 13371
		private static int HandleId;
	}
}
