using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6B RID: 2923
	public class ConfigWeeklyFrameAwardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004497 RID: 17559 RVA: 0x001E1458 File Offset: 0x001DF658
		static ConfigWeeklyFrameAwardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeeklyFrameAwardAll.CreateStaticDefaultValue), new Action(ConfigWeeklyFrameAwardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x001E1478 File Offset: 0x001DF678
		public static void CreateStaticDefaultValue()
		{
			ConfigWeeklyFrameAwardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeeklyFrameAwardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklychallenge.db"),
				new ValueTuple<string, object>("文件", "z.周常框架.xlsx"),
				new ValueTuple<string, object>("表名", "WeeklyFrameAward"),
				new ValueTuple<string, object>("语句", "select BinData from `WeeklyFrameAward`")
			});
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x001E14F7 File Offset: 0x001DF6F7
		public static void ResetStaticDefaultValue()
		{
			ConfigWeeklyFrameAwardAll.LogPair = null;
			ConfigWeeklyFrameAwardAll.HandleId = 0;
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x001E1505 File Offset: 0x001DF705
		public static void Init()
		{
			ConfigWeeklyFrameAwardAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeeklyFrameAwardAll.HandleId, "db_weeklychallenge.db", "select BinData from `WeeklyFrameAward`");
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x001E1520 File Offset: 0x001DF720
		[NullableContext(2)]
		public static IReadOnlyList<WeeklyFrameAward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeeklyFrameAwardAll.HandleId, ConfigWeeklyFrameAwardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<WeeklyFrameAward> readOnlyList = (IReadOnlyList<WeeklyFrameAward>)ConfigCommon.GetConfig("WeeklyFrameAwardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<WeeklyFrameAward> list = new List<WeeklyFrameAward>();
			while (ConfigCommon.Step(ConfigWeeklyFrameAwardAll.HandleId, false, ConfigWeeklyFrameAwardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeeklyFrameAwardAll.HandleId, 0, ConfigWeeklyFrameAwardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeeklyFrameAwardAll.HandleId, ConfigWeeklyFrameAwardAll.LogPair);
					return null;
				}
				WeeklyFrameAward rootAsWeeklyFrameAward = WeeklyFrameAward.GetRootAsWeeklyFrameAward(new ByteBuffer(item2));
				list.Add(rootAsWeeklyFrameAward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("WeeklyFrameAwardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeeklyFrameAwardAll.HandleId, ConfigWeeklyFrameAwardAll.LogPair);
			return list;
		}

		// Token: 0x04004FD3 RID: 20435
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04004FD4 RID: 20436
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04004FD5 RID: 20437
		private const string TABLE = "WeeklyFrameAward";

		// Token: 0x04004FD6 RID: 20438
		private const string COMMAND = "select BinData from `WeeklyFrameAward`";

		// Token: 0x04004FD7 RID: 20439
		private const string KEY_PREFIX = "WeeklyFrameAwardAll";

		// Token: 0x04004FD8 RID: 20440
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FD9 RID: 20441
		private static int HandleId;
	}
}
