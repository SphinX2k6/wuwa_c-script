using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000335 RID: 821
	public class ConfigFloroRanchWeeklyEventAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001343 RID: 4931 RVA: 0x000C6344 File Offset: 0x000C4544
		static ConfigFloroRanchWeeklyEventAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchWeeklyEventAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchWeeklyEventAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x000C6364 File Offset: 0x000C4564
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

		// Token: 0x06001345 RID: 4933 RVA: 0x000C63E3 File Offset: 0x000C45E3
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyEventAll.LogPair = null;
			ConfigFloroRanchWeeklyEventAll.HandleId = 0;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000C63F1 File Offset: 0x000C45F1
		public static void Init()
		{
			ConfigFloroRanchWeeklyEventAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchWeeklyEventAll.HandleId, "db_flororanchevent.db", "select BinData from `FloroRanchWeeklyEvent`");
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x000C640C File Offset: 0x000C460C
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

		// Token: 0x04001657 RID: 5719
		private const string DB = "db_flororanchevent.db";

		// Token: 0x04001658 RID: 5720
		private const string FILE = "f.弗洛洛牧场_事件.xlsx";

		// Token: 0x04001659 RID: 5721
		private const string TABLE = "FloroRanchWeeklyEvent";

		// Token: 0x0400165A RID: 5722
		private const string COMMAND = "select BinData from `FloroRanchWeeklyEvent`";

		// Token: 0x0400165B RID: 5723
		private const string KEY_PREFIX = "FloroRanchWeeklyEventAll";

		// Token: 0x0400165C RID: 5724
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400165D RID: 5725
		private static int HandleId;
	}
}
