using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A96 RID: 2710
	public class ConfigWeeklyFrameAwardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F99 RID: 16281 RVA: 0x001C20C4 File Offset: 0x001C02C4
		static ConfigWeeklyFrameAwardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeeklyFrameAwardAll.CreateStaticDefaultValue), new Action(ConfigWeeklyFrameAwardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x001C20E4 File Offset: 0x001C02E4
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

		// Token: 0x06003F9B RID: 16283 RVA: 0x001C2163 File Offset: 0x001C0363
		public static void ResetStaticDefaultValue()
		{
			ConfigWeeklyFrameAwardAll.LogPair = null;
			ConfigWeeklyFrameAwardAll.HandleId = 0;
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x001C2171 File Offset: 0x001C0371
		public static void Init()
		{
			ConfigWeeklyFrameAwardAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeeklyFrameAwardAll.HandleId, "db_weeklychallenge.db", "select BinData from `WeeklyFrameAward`");
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x001C218C File Offset: 0x001C038C
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

		// Token: 0x04004A00 RID: 18944
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04004A01 RID: 18945
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04004A02 RID: 18946
		private const string TABLE = "WeeklyFrameAward";

		// Token: 0x04004A03 RID: 18947
		private const string COMMAND = "select BinData from `WeeklyFrameAward`";

		// Token: 0x04004A04 RID: 18948
		private const string KEY_PREFIX = "WeeklyFrameAwardAll";

		// Token: 0x04004A05 RID: 18949
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A06 RID: 18950
		private static int HandleId;
	}
}
