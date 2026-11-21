using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021E RID: 542
	public class ConfigDirectTrainHighlightAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CB7 RID: 3255 RVA: 0x000A5190 File Offset: 0x000A3390
		static ConfigDirectTrainHighlightAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainHighlightAll.CreateStaticDefaultValue), new Action(ConfigDirectTrainHighlightAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000A51B0 File Offset: 0x000A33B0
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

		// Token: 0x06000CB9 RID: 3257 RVA: 0x000A522F File Offset: 0x000A342F
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainHighlightAll.LogPair = null;
			ConfigDirectTrainHighlightAll.HandleId = 0;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x000A523D File Offset: 0x000A343D
		public static void Init()
		{
			ConfigDirectTrainHighlightAll.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainHighlightAll.HandleId, "db_directtrain.db", "select BinData from `DirectTrainHighlight`");
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000A5258 File Offset: 0x000A3458
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

		// Token: 0x04000EB6 RID: 3766
		private const string DB = "db_directtrain.db";

		// Token: 0x04000EB7 RID: 3767
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000EB8 RID: 3768
		private const string TABLE = "DirectTrainHighlight";

		// Token: 0x04000EB9 RID: 3769
		private const string COMMAND = "select BinData from `DirectTrainHighlight`";

		// Token: 0x04000EBA RID: 3770
		private const string KEY_PREFIX = "DirectTrainHighlightAll";

		// Token: 0x04000EBB RID: 3771
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EBC RID: 3772
		private static int HandleId;
	}
}
