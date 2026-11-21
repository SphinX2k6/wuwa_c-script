using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021C RID: 540
	public class ConfigDirectTrainActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CAB RID: 3243 RVA: 0x000A4DB4 File Offset: 0x000A2FB4
		static ConfigDirectTrainActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainActivityAll.CreateStaticDefaultValue), new Action(ConfigDirectTrainActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000A4DD4 File Offset: 0x000A2FD4
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

		// Token: 0x06000CAD RID: 3245 RVA: 0x000A4E53 File Offset: 0x000A3053
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainActivityAll.LogPair = null;
			ConfigDirectTrainActivityAll.HandleId = 0;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x000A4E61 File Offset: 0x000A3061
		public static void Init()
		{
			ConfigDirectTrainActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainActivityAll.HandleId, "db_directtrain.db", "select BinData from `DirectTrainActivity`");
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000A4E7C File Offset: 0x000A307C
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

		// Token: 0x04000EA8 RID: 3752
		private const string DB = "db_directtrain.db";

		// Token: 0x04000EA9 RID: 3753
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000EAA RID: 3754
		private const string TABLE = "DirectTrainActivity";

		// Token: 0x04000EAB RID: 3755
		private const string COMMAND = "select BinData from `DirectTrainActivity`";

		// Token: 0x04000EAC RID: 3756
		private const string KEY_PREFIX = "DirectTrainActivityAll";

		// Token: 0x04000EAD RID: 3757
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EAE RID: 3758
		private static int HandleId;
	}
}
