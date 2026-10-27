using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A98 RID: 2712
	public class ConfigWeeklyFrameHelpAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FA5 RID: 16293 RVA: 0x001C24A0 File Offset: 0x001C06A0
		static ConfigWeeklyFrameHelpAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeeklyFrameHelpAll.CreateStaticDefaultValue), new Action(ConfigWeeklyFrameHelpAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x001C24C0 File Offset: 0x001C06C0
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

		// Token: 0x06003FA7 RID: 16295 RVA: 0x001C253F File Offset: 0x001C073F
		public static void ResetStaticDefaultValue()
		{
			ConfigWeeklyFrameHelpAll.LogPair = null;
			ConfigWeeklyFrameHelpAll.HandleId = 0;
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x001C254D File Offset: 0x001C074D
		public static void Init()
		{
			ConfigWeeklyFrameHelpAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeeklyFrameHelpAll.HandleId, "db_weeklychallenge.db", "select BinData from `WeeklyFrameHelp`");
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x001C2568 File Offset: 0x001C0768
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

		// Token: 0x04004A0E RID: 18958
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04004A0F RID: 18959
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04004A10 RID: 18960
		private const string TABLE = "WeeklyFrameHelp";

		// Token: 0x04004A11 RID: 18961
		private const string COMMAND = "select BinData from `WeeklyFrameHelp`";

		// Token: 0x04004A12 RID: 18962
		private const string KEY_PREFIX = "WeeklyFrameHelpAll";

		// Token: 0x04004A13 RID: 18963
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A14 RID: 18964
		private static int HandleId;
	}
}
