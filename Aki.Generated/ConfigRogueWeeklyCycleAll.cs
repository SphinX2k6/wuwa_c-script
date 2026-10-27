using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000873 RID: 2163
	public class ConfigRogueWeeklyCycleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032C4 RID: 12996 RVA: 0x0017876F File Offset: 0x0017696F
		static ConfigRogueWeeklyCycleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyCycleAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyCycleAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x00178790 File Offset: 0x00176990
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

		// Token: 0x060032C6 RID: 12998 RVA: 0x0017880F File Offset: 0x00176A0F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyCycleAll.LogPair = null;
			ConfigRogueWeeklyCycleAll.HandleId = 0;
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x0017881D File Offset: 0x00176A1D
		public static void Init()
		{
			ConfigRogueWeeklyCycleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyCycleAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyCycle`");
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x00178838 File Offset: 0x00176A38
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

		// Token: 0x04003B0B RID: 15115
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B0C RID: 15116
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B0D RID: 15117
		private const string TABLE = "RogueWeeklyCycle";

		// Token: 0x04003B0E RID: 15118
		private const string COMMAND = "select BinData from `RogueWeeklyCycle`";

		// Token: 0x04003B0F RID: 15119
		private const string KEY_PREFIX = "RogueWeeklyCycleAll";

		// Token: 0x04003B10 RID: 15120
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B11 RID: 15121
		private static int HandleId;
	}
}
