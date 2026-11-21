using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000775 RID: 1909
	public class ConfigPreheatVoteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CCF RID: 11471 RVA: 0x0015A174 File Offset: 0x00158374
		static ConfigPreheatVoteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatVoteAll.CreateStaticDefaultValue), new Action(ConfigPreheatVoteAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x0015A194 File Offset: 0x00158394
		public static void CreateStaticDefaultValue()
		{
			ConfigPreheatVoteAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreheatVoteAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_preheat.db"),
				new ValueTuple<string, object>("文件", "y.预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "PreheatVote"),
				new ValueTuple<string, object>("语句", "select BinData from `PreheatVote`")
			});
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x0015A213 File Offset: 0x00158413
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatVoteAll.LogPair = null;
			ConfigPreheatVoteAll.HandleId = 0;
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x0015A221 File Offset: 0x00158421
		public static void Init()
		{
			ConfigPreheatVoteAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatVoteAll.HandleId, "db_preheat.db", "select BinData from `PreheatVote`");
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x0015A23C File Offset: 0x0015843C
		[NullableContext(2)]
		public static IReadOnlyList<PreheatVote> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreheatVoteAll.HandleId, ConfigPreheatVoteAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PreheatVote> readOnlyList = (IReadOnlyList<PreheatVote>)ConfigCommon.GetConfig("PreheatVoteAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PreheatVote> list = new List<PreheatVote>();
			while (ConfigCommon.Step(ConfigPreheatVoteAll.HandleId, false, ConfigPreheatVoteAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreheatVoteAll.HandleId, 0, ConfigPreheatVoteAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPreheatVoteAll.HandleId, ConfigPreheatVoteAll.LogPair);
					return null;
				}
				PreheatVote rootAsPreheatVote = PreheatVote.GetRootAsPreheatVote(new ByteBuffer(item2));
				list.Add(rootAsPreheatVote);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PreheatVoteAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPreheatVoteAll.HandleId, ConfigPreheatVoteAll.LogPair);
			return list;
		}

		// Token: 0x04003419 RID: 13337
		private const string DB = "db_preheat.db";

		// Token: 0x0400341A RID: 13338
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x0400341B RID: 13339
		private const string TABLE = "PreheatVote";

		// Token: 0x0400341C RID: 13340
		private const string COMMAND = "select BinData from `PreheatVote`";

		// Token: 0x0400341D RID: 13341
		private const string KEY_PREFIX = "PreheatVoteAll";

		// Token: 0x0400341E RID: 13342
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400341F RID: 13343
		private static int HandleId;
	}
}
