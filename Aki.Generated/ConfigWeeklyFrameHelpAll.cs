using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6D RID: 2925
	public class ConfigWeeklyFrameHelpAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044A3 RID: 17571 RVA: 0x001E1834 File Offset: 0x001DFA34
		static ConfigWeeklyFrameHelpAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeeklyFrameHelpAll.CreateStaticDefaultValue), new Action(ConfigWeeklyFrameHelpAll.ResetStaticDefaultValue));
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x001E1854 File Offset: 0x001DFA54
		public static void CreateStaticDefaultValue()
		{
			ConfigWeeklyFrameHelpAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeeklyFrameHelpAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklychallenge.db"),
				new ValueTuple<string, object>("文件", "z.周常框架.xlsx"),
				new ValueTuple<string, object>("表名", "WeeklyFrameHelp"),
				new ValueTuple<string, object>("语句", "select BinData from `WeeklyFrameHelp`")
			});
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x001E18D3 File Offset: 0x001DFAD3
		public static void ResetStaticDefaultValue()
		{
			ConfigWeeklyFrameHelpAll.LogPair = null;
			ConfigWeeklyFrameHelpAll.HandleId = 0;
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x001E18E1 File Offset: 0x001DFAE1
		public static void Init()
		{
			ConfigWeeklyFrameHelpAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeeklyFrameHelpAll.HandleId, "db_weeklychallenge.db", "select BinData from `WeeklyFrameHelp`");
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x001E18FC File Offset: 0x001DFAFC
		[NullableContext(2)]
		public static IReadOnlyList<WeeklyFrameHelp> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeeklyFrameHelpAll.HandleId, ConfigWeeklyFrameHelpAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<WeeklyFrameHelp> readOnlyList = (IReadOnlyList<WeeklyFrameHelp>)ConfigCommon.GetConfig("WeeklyFrameHelpAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<WeeklyFrameHelp> list = new List<WeeklyFrameHelp>();
			while (ConfigCommon.Step(ConfigWeeklyFrameHelpAll.HandleId, false, ConfigWeeklyFrameHelpAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeeklyFrameHelpAll.HandleId, 0, ConfigWeeklyFrameHelpAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeeklyFrameHelpAll.HandleId, ConfigWeeklyFrameHelpAll.LogPair);
					return null;
				}
				WeeklyFrameHelp rootAsWeeklyFrameHelp = WeeklyFrameHelp.GetRootAsWeeklyFrameHelp(new ByteBuffer(item2));
				list.Add(rootAsWeeklyFrameHelp);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("WeeklyFrameHelpAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeeklyFrameHelpAll.HandleId, ConfigWeeklyFrameHelpAll.LogPair);
			return list;
		}

		// Token: 0x04004FE1 RID: 20449
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04004FE2 RID: 20450
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04004FE3 RID: 20451
		private const string TABLE = "WeeklyFrameHelp";

		// Token: 0x04004FE4 RID: 20452
		private const string COMMAND = "select BinData from `WeeklyFrameHelp`";

		// Token: 0x04004FE5 RID: 20453
		private const string KEY_PREFIX = "WeeklyFrameHelpAll";

		// Token: 0x04004FE6 RID: 20454
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FE7 RID: 20455
		private static int HandleId;
	}
}
