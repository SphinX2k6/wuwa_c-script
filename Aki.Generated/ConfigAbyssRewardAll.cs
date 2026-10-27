using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200001D RID: 29
	public class ConfigAbyssRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000AE RID: 174 RVA: 0x0005DC08 File Offset: 0x0005BE08
		static ConfigAbyssRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRewardAll.CreateStaticDefaultValue), new Action(ConfigAbyssRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0005DC28 File Offset: 0x0005BE28
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssReward"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssReward`")
			});
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0005DCA7 File Offset: 0x0005BEA7
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRewardAll.LogPair = null;
			ConfigAbyssRewardAll.HandleId = 0;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0005DCB5 File Offset: 0x0005BEB5
		public static void Init()
		{
			ConfigAbyssRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRewardAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssReward`");
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0005DCD0 File Offset: 0x0005BED0
		[NullableContext(2)]
		public static IReadOnlyList<AbyssReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRewardAll.HandleId, ConfigAbyssRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssReward> readOnlyList = (IReadOnlyList<AbyssReward>)ConfigCommon.GetConfig("AbyssRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssReward> list = new List<AbyssReward>();
			while (ConfigCommon.Step(ConfigAbyssRewardAll.HandleId, false, ConfigAbyssRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRewardAll.HandleId, 0, ConfigAbyssRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssRewardAll.HandleId, ConfigAbyssRewardAll.LogPair);
					return null;
				}
				AbyssReward rootAsAbyssReward = AbyssReward.GetRootAsAbyssReward(new ByteBuffer(item2));
				list.Add(rootAsAbyssReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssRewardAll.HandleId, ConfigAbyssRewardAll.LogPair);
			return list;
		}

		// Token: 0x040000AF RID: 175
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000B0 RID: 176
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000B1 RID: 177
		private const string TABLE = "AbyssReward";

		// Token: 0x040000B2 RID: 178
		private const string COMMAND = "select BinData from `AbyssReward`";

		// Token: 0x040000B3 RID: 179
		private const string KEY_PREFIX = "AbyssRewardAll";

		// Token: 0x040000B4 RID: 180
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000B5 RID: 181
		private static int HandleId;
	}
}
