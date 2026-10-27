using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075D RID: 1885
	public class ConfigPreheatVoteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C3F RID: 11327 RVA: 0x001536F8 File Offset: 0x001518F8
		static ConfigPreheatVoteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatVoteAll.CreateStaticDefaultValue), new Action(ConfigPreheatVoteAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x00153718 File Offset: 0x00151918
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

		// Token: 0x06002C41 RID: 11329 RVA: 0x00153797 File Offset: 0x00151997
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatVoteAll.LogPair = null;
			ConfigPreheatVoteAll.HandleId = 0;
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x001537A5 File Offset: 0x001519A5
		public static void Init()
		{
			ConfigPreheatVoteAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatVoteAll.HandleId, "db_preheat.db", "select BinData from `PreheatVote`");
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x001537C0 File Offset: 0x001519C0
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

		// Token: 0x04003371 RID: 13169
		private const string DB = "db_preheat.db";

		// Token: 0x04003372 RID: 13170
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x04003373 RID: 13171
		private const string TABLE = "PreheatVote";

		// Token: 0x04003374 RID: 13172
		private const string COMMAND = "select BinData from `PreheatVote`";

		// Token: 0x04003375 RID: 13173
		private const string KEY_PREFIX = "PreheatVoteAll";

		// Token: 0x04003376 RID: 13174
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003377 RID: 13175
		private static int HandleId;
	}
}
