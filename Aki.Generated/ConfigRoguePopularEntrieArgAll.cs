using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082C RID: 2092
	public class ConfigRoguePopularEntrieArgAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600311A RID: 12570 RVA: 0x0016F030 File Offset: 0x0016D230
		static ConfigRoguePopularEntrieArgAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoguePopularEntrieArgAll.CreateStaticDefaultValue), new Action(ConfigRoguePopularEntrieArgAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x0016F050 File Offset: 0x0016D250
		public static void CreateStaticDefaultValue()
		{
			ConfigRoguePopularEntrieArgAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoguePopularEntrieArgAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RoguePopularEntrieArg"),
				new ValueTuple<string, object>("语句", "select BinData from `RoguePopularEntrieArg`")
			});
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x0016F0CF File Offset: 0x0016D2CF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoguePopularEntrieArgAll.LogPair = null;
			ConfigRoguePopularEntrieArgAll.HandleId = 0;
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x0016F0DD File Offset: 0x0016D2DD
		public static void Init()
		{
			ConfigRoguePopularEntrieArgAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoguePopularEntrieArgAll.HandleId, "db_rogue.db", "select BinData from `RoguePopularEntrieArg`");
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x0016F0F8 File Offset: 0x0016D2F8
		[NullableContext(2)]
		public static IReadOnlyList<RoguePopularEntrieArg> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoguePopularEntrieArgAll.HandleId, ConfigRoguePopularEntrieArgAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoguePopularEntrieArg> readOnlyList = (IReadOnlyList<RoguePopularEntrieArg>)ConfigCommon.GetConfig("RoguePopularEntrieArgAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoguePopularEntrieArg> list = new List<RoguePopularEntrieArg>();
			while (ConfigCommon.Step(ConfigRoguePopularEntrieArgAll.HandleId, false, ConfigRoguePopularEntrieArgAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoguePopularEntrieArgAll.HandleId, 0, ConfigRoguePopularEntrieArgAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoguePopularEntrieArgAll.HandleId, ConfigRoguePopularEntrieArgAll.LogPair);
					return null;
				}
				RoguePopularEntrieArg rootAsRoguePopularEntrieArg = RoguePopularEntrieArg.GetRootAsRoguePopularEntrieArg(new ByteBuffer(item2));
				list.Add(rootAsRoguePopularEntrieArg);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoguePopularEntrieArgAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoguePopularEntrieArgAll.HandleId, ConfigRoguePopularEntrieArgAll.LogPair);
			return list;
		}

		// Token: 0x0400391A RID: 14618
		private const string DB = "db_rogue.db";

		// Token: 0x0400391B RID: 14619
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x0400391C RID: 14620
		private const string TABLE = "RoguePopularEntrieArg";

		// Token: 0x0400391D RID: 14621
		private const string COMMAND = "select BinData from `RoguePopularEntrieArg`";

		// Token: 0x0400391E RID: 14622
		private const string KEY_PREFIX = "RoguePopularEntrieArgAll";

		// Token: 0x0400391F RID: 14623
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003920 RID: 14624
		private static int HandleId;
	}
}
