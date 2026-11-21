using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034A RID: 842
	public class ConfigFloroRanchWeeklyEventAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013C1 RID: 5057 RVA: 0x000CC850 File Offset: 0x000CAA50
		static ConfigFloroRanchWeeklyEventAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchWeeklyEventAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchWeeklyEventAll.ResetStaticDefaultValue));
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x000CC870 File Offset: 0x000CAA70
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyEventAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchWeeklyEventAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchevent.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_事件.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchWeeklyEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchWeeklyEvent`")
			});
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x000CC8EF File Offset: 0x000CAAEF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyEventAll.LogPair = null;
			ConfigFloroRanchWeeklyEventAll.HandleId = 0;
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000CC8FD File Offset: 0x000CAAFD
		public static void Init()
		{
			ConfigFloroRanchWeeklyEventAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchWeeklyEventAll.HandleId, "db_flororanchevent.db", "select BinData from `FloroRanchWeeklyEvent`");
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x000CC918 File Offset: 0x000CAB18
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchWeeklyEvent> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchWeeklyEventAll.HandleId, ConfigFloroRanchWeeklyEventAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchWeeklyEvent> readOnlyList = (IReadOnlyList<FloroRanchWeeklyEvent>)ConfigCommon.GetConfig("FloroRanchWeeklyEventAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchWeeklyEvent> list = new List<FloroRanchWeeklyEvent>();
			while (ConfigCommon.Step(ConfigFloroRanchWeeklyEventAll.HandleId, false, ConfigFloroRanchWeeklyEventAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchWeeklyEventAll.HandleId, 0, ConfigFloroRanchWeeklyEventAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchWeeklyEventAll.HandleId, ConfigFloroRanchWeeklyEventAll.LogPair);
					return null;
				}
				FloroRanchWeeklyEvent rootAsFloroRanchWeeklyEvent = FloroRanchWeeklyEvent.GetRootAsFloroRanchWeeklyEvent(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchWeeklyEvent);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchWeeklyEventAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchWeeklyEventAll.HandleId, ConfigFloroRanchWeeklyEventAll.LogPair);
			return list;
		}

		// Token: 0x040016EA RID: 5866
		private const string DB = "db_flororanchevent.db";

		// Token: 0x040016EB RID: 5867
		private const string FILE = "f.弗洛洛牧场_事件.xlsx";

		// Token: 0x040016EC RID: 5868
		private const string TABLE = "FloroRanchWeeklyEvent";

		// Token: 0x040016ED RID: 5869
		private const string COMMAND = "select BinData from `FloroRanchWeeklyEvent`";

		// Token: 0x040016EE RID: 5870
		private const string KEY_PREFIX = "FloroRanchWeeklyEventAll";

		// Token: 0x040016EF RID: 5871
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016F0 RID: 5872
		private static int HandleId;
	}
}
