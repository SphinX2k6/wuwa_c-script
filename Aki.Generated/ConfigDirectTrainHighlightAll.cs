using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020C RID: 524
	public class ConfigDirectTrainHighlightAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C4B RID: 3147 RVA: 0x0009F258 File Offset: 0x0009D458
		static ConfigDirectTrainHighlightAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainHighlightAll.CreateStaticDefaultValue), new Action(ConfigDirectTrainHighlightAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0009F278 File Offset: 0x0009D478
		public static void CreateStaticDefaultValue()
		{
			ConfigDirectTrainHighlightAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDirectTrainHighlightAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_directtrain.db"),
				new ValueTuple<string, object>("文件", "j.剧情直通车活动.xlsx"),
				new ValueTuple<string, object>("表名", "DirectTrainHighlight"),
				new ValueTuple<string, object>("语句", "select BinData from `DirectTrainHighlight`")
			});
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0009F2F7 File Offset: 0x0009D4F7
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainHighlightAll.LogPair = null;
			ConfigDirectTrainHighlightAll.HandleId = 0;
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0009F305 File Offset: 0x0009D505
		public static void Init()
		{
			ConfigDirectTrainHighlightAll.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainHighlightAll.HandleId, "db_directtrain.db", "select BinData from `DirectTrainHighlight`");
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0009F320 File Offset: 0x0009D520
		[NullableContext(2)]
		public static IReadOnlyList<DirectTrainHighlight> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDirectTrainHighlightAll.HandleId, ConfigDirectTrainHighlightAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DirectTrainHighlight> readOnlyList = (IReadOnlyList<DirectTrainHighlight>)ConfigCommon.GetConfig("DirectTrainHighlightAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DirectTrainHighlight> list = new List<DirectTrainHighlight>();
			while (ConfigCommon.Step(ConfigDirectTrainHighlightAll.HandleId, false, ConfigDirectTrainHighlightAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDirectTrainHighlightAll.HandleId, 0, ConfigDirectTrainHighlightAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDirectTrainHighlightAll.HandleId, ConfigDirectTrainHighlightAll.LogPair);
					return null;
				}
				DirectTrainHighlight rootAsDirectTrainHighlight = DirectTrainHighlight.GetRootAsDirectTrainHighlight(new ByteBuffer(item2));
				list.Add(rootAsDirectTrainHighlight);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DirectTrainHighlightAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDirectTrainHighlightAll.HandleId, ConfigDirectTrainHighlightAll.LogPair);
			return list;
		}

		// Token: 0x04000E38 RID: 3640
		private const string DB = "db_directtrain.db";

		// Token: 0x04000E39 RID: 3641
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000E3A RID: 3642
		private const string TABLE = "DirectTrainHighlight";

		// Token: 0x04000E3B RID: 3643
		private const string COMMAND = "select BinData from `DirectTrainHighlight`";

		// Token: 0x04000E3C RID: 3644
		private const string KEY_PREFIX = "DirectTrainHighlightAll";

		// Token: 0x04000E3D RID: 3645
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E3E RID: 3646
		private static int HandleId;
	}
}
