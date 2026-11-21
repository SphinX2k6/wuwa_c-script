using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A8 RID: 424
	public class ConfigConsumptiveActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009F3 RID: 2547 RVA: 0x0009552F File Offset: 0x0009372F
		static ConfigConsumptiveActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConsumptiveActivityAll.CreateStaticDefaultValue), new Action(ConfigConsumptiveActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00095550 File Offset: 0x00093750
		public static void CreateStaticDefaultValue()
		{
			ConfigConsumptiveActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigConsumptiveActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_consumptiveactivity.db"),
				new ValueTuple<string, object>("文件", "l.累消活动.xlsx"),
				new ValueTuple<string, object>("表名", "ConsumptiveActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `ConsumptiveActivity`")
			});
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000955CF File Offset: 0x000937CF
		public static void ResetStaticDefaultValue()
		{
			ConfigConsumptiveActivityAll.LogPair = null;
			ConfigConsumptiveActivityAll.HandleId = 0;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000955DD File Offset: 0x000937DD
		public static void Init()
		{
			ConfigConsumptiveActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigConsumptiveActivityAll.HandleId, "db_consumptiveactivity.db", "select BinData from `ConsumptiveActivity`");
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x000955F8 File Offset: 0x000937F8
		[NullableContext(2)]
		public static IReadOnlyList<ConsumptiveActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigConsumptiveActivityAll.HandleId, ConfigConsumptiveActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ConsumptiveActivity> readOnlyList = (IReadOnlyList<ConsumptiveActivity>)ConfigCommon.GetConfig("ConsumptiveActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ConsumptiveActivity> list = new List<ConsumptiveActivity>();
			while (ConfigCommon.Step(ConfigConsumptiveActivityAll.HandleId, false, ConfigConsumptiveActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigConsumptiveActivityAll.HandleId, 0, ConfigConsumptiveActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigConsumptiveActivityAll.HandleId, ConfigConsumptiveActivityAll.LogPair);
					return null;
				}
				ConsumptiveActivity rootAsConsumptiveActivity = ConsumptiveActivity.GetRootAsConsumptiveActivity(new ByteBuffer(item2));
				list.Add(rootAsConsumptiveActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ConsumptiveActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigConsumptiveActivityAll.HandleId, ConfigConsumptiveActivityAll.LogPair);
			return list;
		}

		// Token: 0x04000B7C RID: 2940
		private const string DB = "db_consumptiveactivity.db";

		// Token: 0x04000B7D RID: 2941
		private const string FILE = "l.累消活动.xlsx";

		// Token: 0x04000B7E RID: 2942
		private const string TABLE = "ConsumptiveActivity";

		// Token: 0x04000B7F RID: 2943
		private const string COMMAND = "select BinData from `ConsumptiveActivity`";

		// Token: 0x04000B80 RID: 2944
		private const string KEY_PREFIX = "ConsumptiveActivityAll";

		// Token: 0x04000B81 RID: 2945
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B82 RID: 2946
		private static int HandleId;
	}
}
