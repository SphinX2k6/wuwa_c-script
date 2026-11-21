using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088C RID: 2188
	public class ConfigRogueWeeklyBuffPoolAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600335A RID: 13146 RVA: 0x0017F444 File Offset: 0x0017D644
		static ConfigRogueWeeklyBuffPoolAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyBuffPoolAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyBuffPoolAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x0017F464 File Offset: 0x0017D664
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

		// Token: 0x0600335C RID: 13148 RVA: 0x0017F4E3 File Offset: 0x0017D6E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolAll.LogPair = null;
			ConfigRogueWeeklyBuffPoolAll.HandleId = 0;
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x0017F4F1 File Offset: 0x0017D6F1
		public static void Init()
		{
			ConfigRogueWeeklyBuffPoolAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyBuffPoolAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyBuffPool`");
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x0017F50C File Offset: 0x0017D70C
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

		// Token: 0x04003BBA RID: 15290
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BBB RID: 15291
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003BBC RID: 15292
		private const string TABLE = "RogueWeeklyBuffPool";

		// Token: 0x04003BBD RID: 15293
		private const string COMMAND = "select BinData from `RogueWeeklyBuffPool`";

		// Token: 0x04003BBE RID: 15294
		private const string KEY_PREFIX = "RogueWeeklyBuffPoolAll";

		// Token: 0x04003BBF RID: 15295
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BC0 RID: 15296
		private static int HandleId;
	}
}
