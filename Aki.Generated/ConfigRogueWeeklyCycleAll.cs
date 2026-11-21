using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088F RID: 2191
	public class ConfigRogueWeeklyCycleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600336C RID: 13164 RVA: 0x0017FA57 File Offset: 0x0017DC57
		static ConfigRogueWeeklyCycleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyCycleAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyCycleAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x0017FA78 File Offset: 0x0017DC78
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyCycleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyCycleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyCycle"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyCycle`")
			});
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x0017FAF7 File Offset: 0x0017DCF7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyCycleAll.LogPair = null;
			ConfigRogueWeeklyCycleAll.HandleId = 0;
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x0017FB05 File Offset: 0x0017DD05
		public static void Init()
		{
			ConfigRogueWeeklyCycleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyCycleAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyCycle`");
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x0017FB20 File Offset: 0x0017DD20
		[NullableContext(2)]
		public static IReadOnlyList<RogueWeeklyCycle> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyCycleAll.HandleId, ConfigRogueWeeklyCycleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueWeeklyCycle> readOnlyList = (IReadOnlyList<RogueWeeklyCycle>)ConfigCommon.GetConfig("RogueWeeklyCycleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueWeeklyCycle> list = new List<RogueWeeklyCycle>();
			while (ConfigCommon.Step(ConfigRogueWeeklyCycleAll.HandleId, false, ConfigRogueWeeklyCycleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyCycleAll.HandleId, 0, ConfigRogueWeeklyCycleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueWeeklyCycleAll.HandleId, ConfigRogueWeeklyCycleAll.LogPair);
					return null;
				}
				RogueWeeklyCycle rootAsRogueWeeklyCycle = RogueWeeklyCycle.GetRootAsRogueWeeklyCycle(new ByteBuffer(item2));
				list.Add(rootAsRogueWeeklyCycle);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueWeeklyCycleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyCycleAll.HandleId, ConfigRogueWeeklyCycleAll.LogPair);
			return list;
		}

		// Token: 0x04003BCF RID: 15311
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BD0 RID: 15312
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003BD1 RID: 15313
		private const string TABLE = "RogueWeeklyCycle";

		// Token: 0x04003BD2 RID: 15314
		private const string COMMAND = "select BinData from `RogueWeeklyCycle`";

		// Token: 0x04003BD3 RID: 15315
		private const string KEY_PREFIX = "RogueWeeklyCycleAll";

		// Token: 0x04003BD4 RID: 15316
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BD5 RID: 15317
		private static int HandleId;
	}
}
