using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020A RID: 522
	public class ConfigDirectTrainActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C3F RID: 3135 RVA: 0x0009EE7C File Offset: 0x0009D07C
		static ConfigDirectTrainActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainActivityAll.CreateStaticDefaultValue), new Action(ConfigDirectTrainActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0009EE9C File Offset: 0x0009D09C
		public static void CreateStaticDefaultValue()
		{
			ConfigDirectTrainActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDirectTrainActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_directtrain.db"),
				new ValueTuple<string, object>("文件", "j.剧情直通车活动.xlsx"),
				new ValueTuple<string, object>("表名", "DirectTrainActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `DirectTrainActivity`")
			});
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0009EF1B File Offset: 0x0009D11B
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainActivityAll.LogPair = null;
			ConfigDirectTrainActivityAll.HandleId = 0;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0009EF29 File Offset: 0x0009D129
		public static void Init()
		{
			ConfigDirectTrainActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainActivityAll.HandleId, "db_directtrain.db", "select BinData from `DirectTrainActivity`");
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0009EF44 File Offset: 0x0009D144
		[NullableContext(2)]
		public static IReadOnlyList<DirectTrainActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDirectTrainActivityAll.HandleId, ConfigDirectTrainActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DirectTrainActivity> readOnlyList = (IReadOnlyList<DirectTrainActivity>)ConfigCommon.GetConfig("DirectTrainActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DirectTrainActivity> list = new List<DirectTrainActivity>();
			while (ConfigCommon.Step(ConfigDirectTrainActivityAll.HandleId, false, ConfigDirectTrainActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDirectTrainActivityAll.HandleId, 0, ConfigDirectTrainActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDirectTrainActivityAll.HandleId, ConfigDirectTrainActivityAll.LogPair);
					return null;
				}
				DirectTrainActivity rootAsDirectTrainActivity = DirectTrainActivity.GetRootAsDirectTrainActivity(new ByteBuffer(item2));
				list.Add(rootAsDirectTrainActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DirectTrainActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDirectTrainActivityAll.HandleId, ConfigDirectTrainActivityAll.LogPair);
			return list;
		}

		// Token: 0x04000E2A RID: 3626
		private const string DB = "db_directtrain.db";

		// Token: 0x04000E2B RID: 3627
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000E2C RID: 3628
		private const string TABLE = "DirectTrainActivity";

		// Token: 0x04000E2D RID: 3629
		private const string COMMAND = "select BinData from `DirectTrainActivity`";

		// Token: 0x04000E2E RID: 3630
		private const string KEY_PREFIX = "DirectTrainActivityAll";

		// Token: 0x04000E2F RID: 3631
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E30 RID: 3632
		private static int HandleId;
	}
}
