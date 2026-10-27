using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000311 RID: 785
	public class ConfigFloroRanchCardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600126B RID: 4715 RVA: 0x000C1A88 File Offset: 0x000BFC88
		static ConfigFloroRanchCardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCardAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchCardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000C1AA8 File Offset: 0x000BFCA8
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchCardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchCardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchCard"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchCard`")
			});
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000C1B27 File Offset: 0x000BFD27
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCardAll.LogPair = null;
			ConfigFloroRanchCardAll.HandleId = 0;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000C1B35 File Offset: 0x000BFD35
		public static void Init()
		{
			ConfigFloroRanchCardAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCardAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCard`");
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x000C1B50 File Offset: 0x000BFD50
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchCard> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchCardAll.HandleId, ConfigFloroRanchCardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchCard> readOnlyList = (IReadOnlyList<FloroRanchCard>)ConfigCommon.GetConfig("FloroRanchCardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchCard> list = new List<FloroRanchCard>();
			while (ConfigCommon.Step(ConfigFloroRanchCardAll.HandleId, false, ConfigFloroRanchCardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchCardAll.HandleId, 0, ConfigFloroRanchCardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchCardAll.HandleId, ConfigFloroRanchCardAll.LogPair);
					return null;
				}
				FloroRanchCard rootAsFloroRanchCard = FloroRanchCard.GetRootAsFloroRanchCard(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchCard);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchCardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchCardAll.HandleId, ConfigFloroRanchCardAll.LogPair);
			return list;
		}

		// Token: 0x0400155B RID: 5467
		private const string DB = "db_flororanch.db";

		// Token: 0x0400155C RID: 5468
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400155D RID: 5469
		private const string TABLE = "FloroRanchCard";

		// Token: 0x0400155E RID: 5470
		private const string COMMAND = "select BinData from `FloroRanchCard`";

		// Token: 0x0400155F RID: 5471
		private const string KEY_PREFIX = "FloroRanchCardAll";

		// Token: 0x04001560 RID: 5472
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001561 RID: 5473
		private static int HandleId;
	}
}
