using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005C RID: 92
	public class ConfigActivityTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00069630 File Offset: 0x00067830
		static ConfigActivityTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityTabAll.CreateStaticDefaultValue), new Action(ConfigActivityTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00069650 File Offset: 0x00067850
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklychallenge.db"),
				new ValueTuple<string, object>("文件", "z.周常框架.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityTab"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityTab`")
			});
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000696CF File Offset: 0x000678CF
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityTabAll.LogPair = null;
			ConfigActivityTabAll.HandleId = 0;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000696DD File Offset: 0x000678DD
		public static void Init()
		{
			ConfigActivityTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityTabAll.HandleId, "db_weeklychallenge.db", "select BinData from `ActivityTab`");
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000696F8 File Offset: 0x000678F8
		[NullableContext(2)]
		public static IReadOnlyList<ActivityTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityTabAll.HandleId, ConfigActivityTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivityTab> readOnlyList = (IReadOnlyList<ActivityTab>)ConfigCommon.GetConfig("ActivityTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivityTab> list = new List<ActivityTab>();
			while (ConfigCommon.Step(ConfigActivityTabAll.HandleId, false, ConfigActivityTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityTabAll.HandleId, 0, ConfigActivityTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityTabAll.HandleId, ConfigActivityTabAll.LogPair);
					return null;
				}
				ActivityTab rootAsActivityTab = ActivityTab.GetRootAsActivityTab(new ByteBuffer(item2));
				list.Add(rootAsActivityTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivityTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityTabAll.HandleId, ConfigActivityTabAll.LogPair);
			return list;
		}

		// Token: 0x04000268 RID: 616
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04000269 RID: 617
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x0400026A RID: 618
		private const string TABLE = "ActivityTab";

		// Token: 0x0400026B RID: 619
		private const string COMMAND = "select BinData from `ActivityTab`";

		// Token: 0x0400026C RID: 620
		private const string KEY_PREFIX = "ActivityTabAll";

		// Token: 0x0400026D RID: 621
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400026E RID: 622
		private static int HandleId;
	}
}
