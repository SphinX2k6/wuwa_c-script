using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000196 RID: 406
	public class ConfigConsumptiveActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000987 RID: 2439 RVA: 0x0008F5F7 File Offset: 0x0008D7F7
		static ConfigConsumptiveActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConsumptiveActivityAll.CreateStaticDefaultValue), new Action(ConfigConsumptiveActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0008F618 File Offset: 0x0008D818
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

		// Token: 0x06000989 RID: 2441 RVA: 0x0008F697 File Offset: 0x0008D897
		public static void ResetStaticDefaultValue()
		{
			ConfigConsumptiveActivityAll.LogPair = null;
			ConfigConsumptiveActivityAll.HandleId = 0;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0008F6A5 File Offset: 0x0008D8A5
		public static void Init()
		{
			ConfigConsumptiveActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigConsumptiveActivityAll.HandleId, "db_consumptiveactivity.db", "select BinData from `ConsumptiveActivity`");
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0008F6C0 File Offset: 0x0008D8C0
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

		// Token: 0x04000AFE RID: 2814
		private const string DB = "db_consumptiveactivity.db";

		// Token: 0x04000AFF RID: 2815
		private const string FILE = "l.累消活动.xlsx";

		// Token: 0x04000B00 RID: 2816
		private const string TABLE = "ConsumptiveActivity";

		// Token: 0x04000B01 RID: 2817
		private const string COMMAND = "select BinData from `ConsumptiveActivity`";

		// Token: 0x04000B02 RID: 2818
		private const string KEY_PREFIX = "ConsumptiveActivityAll";

		// Token: 0x04000B03 RID: 2819
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B04 RID: 2820
		private static int HandleId;
	}
}
