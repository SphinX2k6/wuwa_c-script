using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000870 RID: 2160
	public class ConfigRogueWeeklyBuffPoolAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032B2 RID: 12978 RVA: 0x0017815C File Offset: 0x0017635C
		static ConfigRogueWeeklyBuffPoolAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyBuffPoolAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyBuffPoolAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x0017817C File Offset: 0x0017637C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyBuffPoolAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyBuffPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyBuffPool`")
			});
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x001781FB File Offset: 0x001763FB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolAll.LogPair = null;
			ConfigRogueWeeklyBuffPoolAll.HandleId = 0;
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x00178209 File Offset: 0x00176409
		public static void Init()
		{
			ConfigRogueWeeklyBuffPoolAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyBuffPoolAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyBuffPool`");
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x00178224 File Offset: 0x00176424
		[NullableContext(2)]
		public static IReadOnlyList<RogueWeeklyBuffPool> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyBuffPoolAll.HandleId, ConfigRogueWeeklyBuffPoolAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueWeeklyBuffPool> readOnlyList = (IReadOnlyList<RogueWeeklyBuffPool>)ConfigCommon.GetConfig("RogueWeeklyBuffPoolAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueWeeklyBuffPool> list = new List<RogueWeeklyBuffPool>();
			while (ConfigCommon.Step(ConfigRogueWeeklyBuffPoolAll.HandleId, false, ConfigRogueWeeklyBuffPoolAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyBuffPoolAll.HandleId, 0, ConfigRogueWeeklyBuffPoolAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolAll.HandleId, ConfigRogueWeeklyBuffPoolAll.LogPair);
					return null;
				}
				RogueWeeklyBuffPool rootAsRogueWeeklyBuffPool = RogueWeeklyBuffPool.GetRootAsRogueWeeklyBuffPool(new ByteBuffer(item2));
				list.Add(rootAsRogueWeeklyBuffPool);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueWeeklyBuffPoolAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolAll.HandleId, ConfigRogueWeeklyBuffPoolAll.LogPair);
			return list;
		}

		// Token: 0x04003AF6 RID: 15094
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003AF7 RID: 15095
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003AF8 RID: 15096
		private const string TABLE = "RogueWeeklyBuffPool";

		// Token: 0x04003AF9 RID: 15097
		private const string COMMAND = "select BinData from `RogueWeeklyBuffPool`";

		// Token: 0x04003AFA RID: 15098
		private const string KEY_PREFIX = "RogueWeeklyBuffPoolAll";

		// Token: 0x04003AFB RID: 15099
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AFC RID: 15100
		private static int HandleId;
	}
}
