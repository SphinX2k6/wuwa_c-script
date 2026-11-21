using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200003E RID: 62
	public class ConfigActivityActionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000174 RID: 372 RVA: 0x0006578B File Offset: 0x0006398B
		static ConfigActivityActionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityActionAll.CreateStaticDefaultValue), new Action(ConfigActivityActionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000657AC File Offset: 0x000639AC
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityActionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityActionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityaction.db"),
				new ValueTuple<string, object>("文件", "h.活动Action.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityAction"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityAction`")
			});
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0006582B File Offset: 0x00063A2B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityActionAll.LogPair = null;
			ConfigActivityActionAll.HandleId = 0;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00065839 File Offset: 0x00063A39
		public static void Init()
		{
			ConfigActivityActionAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityActionAll.HandleId, "db_activityaction.db", "select BinData from `ActivityAction`");
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00065854 File Offset: 0x00063A54
		[NullableContext(2)]
		public static IReadOnlyList<ActivityAction> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityActionAll.HandleId, ConfigActivityActionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivityAction> readOnlyList = (IReadOnlyList<ActivityAction>)ConfigCommon.GetConfig("ActivityActionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivityAction> list = new List<ActivityAction>();
			while (ConfigCommon.Step(ConfigActivityActionAll.HandleId, false, ConfigActivityActionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityActionAll.HandleId, 0, ConfigActivityActionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityActionAll.HandleId, ConfigActivityActionAll.LogPair);
					return null;
				}
				ActivityAction rootAsActivityAction = ActivityAction.GetRootAsActivityAction(new ByteBuffer(item2));
				list.Add(rootAsActivityAction);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivityActionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityActionAll.HandleId, ConfigActivityActionAll.LogPair);
			return list;
		}

		// Token: 0x04000196 RID: 406
		private const string DB = "db_activityaction.db";

		// Token: 0x04000197 RID: 407
		private const string FILE = "h.活动Action.xlsx";

		// Token: 0x04000198 RID: 408
		private const string TABLE = "ActivityAction";

		// Token: 0x04000199 RID: 409
		private const string COMMAND = "select BinData from `ActivityAction`";

		// Token: 0x0400019A RID: 410
		private const string KEY_PREFIX = "ActivityActionAll";

		// Token: 0x0400019B RID: 411
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400019C RID: 412
		private static int HandleId;
	}
}
