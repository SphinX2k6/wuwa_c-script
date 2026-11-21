using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DA RID: 2010
	public class ConfigRecallRouletteFuncAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F2E RID: 12078 RVA: 0x00167974 File Offset: 0x00165B74
		static ConfigRecallRouletteFuncAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallRouletteFuncAll.CreateStaticDefaultValue), new Action(ConfigRecallRouletteFuncAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x00167994 File Offset: 0x00165B94
		public static void CreateStaticDefaultValue()
		{
			ConfigRecallRouletteFuncAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRecallRouletteFuncAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrecall.db"),
				new ValueTuple<string, object>("文件", "r.任务回顾.xlsx"),
				new ValueTuple<string, object>("表名", "RecallRouletteFunc"),
				new ValueTuple<string, object>("语句", "select BinData from `RecallRouletteFunc`")
			});
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00167A13 File Offset: 0x00165C13
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallRouletteFuncAll.LogPair = null;
			ConfigRecallRouletteFuncAll.HandleId = 0;
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00167A21 File Offset: 0x00165C21
		public static void Init()
		{
			ConfigRecallRouletteFuncAll.HandleId = ConfigCommon.InitDataStatement(ConfigRecallRouletteFuncAll.HandleId, "db_questrecall.db", "select BinData from `RecallRouletteFunc`");
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00167A3C File Offset: 0x00165C3C
		[NullableContext(2)]
		public static IReadOnlyList<RecallRouletteFunc> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRecallRouletteFuncAll.HandleId, ConfigRecallRouletteFuncAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RecallRouletteFunc> readOnlyList = (IReadOnlyList<RecallRouletteFunc>)ConfigCommon.GetConfig("RecallRouletteFuncAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RecallRouletteFunc> list = new List<RecallRouletteFunc>();
			while (ConfigCommon.Step(ConfigRecallRouletteFuncAll.HandleId, false, ConfigRecallRouletteFuncAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRecallRouletteFuncAll.HandleId, 0, ConfigRecallRouletteFuncAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRecallRouletteFuncAll.HandleId, ConfigRecallRouletteFuncAll.LogPair);
					return null;
				}
				RecallRouletteFunc rootAsRecallRouletteFunc = RecallRouletteFunc.GetRootAsRecallRouletteFunc(new ByteBuffer(item2));
				list.Add(rootAsRecallRouletteFunc);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RecallRouletteFuncAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRecallRouletteFuncAll.HandleId, ConfigRecallRouletteFuncAll.LogPair);
			return list;
		}

		// Token: 0x040036DC RID: 14044
		private const string DB = "db_questrecall.db";

		// Token: 0x040036DD RID: 14045
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x040036DE RID: 14046
		private const string TABLE = "RecallRouletteFunc";

		// Token: 0x040036DF RID: 14047
		private const string COMMAND = "select BinData from `RecallRouletteFunc`";

		// Token: 0x040036E0 RID: 14048
		private const string KEY_PREFIX = "RecallRouletteFuncAll";

		// Token: 0x040036E1 RID: 14049
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036E2 RID: 14050
		private static int HandleId;
	}
}
