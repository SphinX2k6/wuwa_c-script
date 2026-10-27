using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000624 RID: 1572
	public class ConfigOccupyScoreAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024E8 RID: 9448 RVA: 0x0012A641 File Offset: 0x00128841
		static ConfigOccupyScoreAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOccupyScoreAll.CreateStaticDefaultValue), new Action(ConfigOccupyScoreAll.ResetStaticDefaultValue));
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x0012A660 File Offset: 0x00128860
		public static void CreateStaticDefaultValue()
		{
			ConfigOccupyScoreAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOccupyScoreAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "OccupyScore"),
				new ValueTuple<string, object>("语句", "select BinData from `OccupyScore`")
			});
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0012A6DF File Offset: 0x001288DF
		public static void ResetStaticDefaultValue()
		{
			ConfigOccupyScoreAll.LogPair = null;
			ConfigOccupyScoreAll.HandleId = 0;
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x0012A6ED File Offset: 0x001288ED
		public static void Init()
		{
			ConfigOccupyScoreAll.HandleId = ConfigCommon.InitDataStatement(ConfigOccupyScoreAll.HandleId, "db_moraleplay.db", "select BinData from `OccupyScore`");
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x0012A708 File Offset: 0x00128908
		[NullableContext(2)]
		public static IReadOnlyList<OccupyScore> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOccupyScoreAll.HandleId, ConfigOccupyScoreAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<OccupyScore> readOnlyList = (IReadOnlyList<OccupyScore>)ConfigCommon.GetConfig("OccupyScoreAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<OccupyScore> list = new List<OccupyScore>();
			while (ConfigCommon.Step(ConfigOccupyScoreAll.HandleId, false, ConfigOccupyScoreAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOccupyScoreAll.HandleId, 0, ConfigOccupyScoreAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigOccupyScoreAll.HandleId, ConfigOccupyScoreAll.LogPair);
					return null;
				}
				OccupyScore rootAsOccupyScore = OccupyScore.GetRootAsOccupyScore(new ByteBuffer(item2));
				list.Add(rootAsOccupyScore);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("OccupyScoreAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigOccupyScoreAll.HandleId, ConfigOccupyScoreAll.LogPair);
			return list;
		}

		// Token: 0x04002AE2 RID: 10978
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002AE3 RID: 10979
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002AE4 RID: 10980
		private const string TABLE = "OccupyScore";

		// Token: 0x04002AE5 RID: 10981
		private const string COMMAND = "select BinData from `OccupyScore`";

		// Token: 0x04002AE6 RID: 10982
		private const string KEY_PREFIX = "OccupyScoreAll";

		// Token: 0x04002AE7 RID: 10983
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AE8 RID: 10984
		private static int HandleId;
	}
}
