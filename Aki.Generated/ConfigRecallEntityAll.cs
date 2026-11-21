using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D6 RID: 2006
	public class ConfigRecallEntityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F16 RID: 12054 RVA: 0x001670B4 File Offset: 0x001652B4
		static ConfigRecallEntityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallEntityAll.CreateStaticDefaultValue), new Action(ConfigRecallEntityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x001670D4 File Offset: 0x001652D4
		public static void CreateStaticDefaultValue()
		{
			ConfigRecallEntityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRecallEntityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrecall.db"),
				new ValueTuple<string, object>("文件", "r.任务回顾.xlsx"),
				new ValueTuple<string, object>("表名", "RecallEntity"),
				new ValueTuple<string, object>("语句", "select BinData from `RecallEntity`")
			});
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00167153 File Offset: 0x00165353
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallEntityAll.LogPair = null;
			ConfigRecallEntityAll.HandleId = 0;
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x00167161 File Offset: 0x00165361
		public static void Init()
		{
			ConfigRecallEntityAll.HandleId = ConfigCommon.InitDataStatement(ConfigRecallEntityAll.HandleId, "db_questrecall.db", "select BinData from `RecallEntity`");
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x0016717C File Offset: 0x0016537C
		[NullableContext(2)]
		public static IReadOnlyList<RecallEntity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRecallEntityAll.HandleId, ConfigRecallEntityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RecallEntity> readOnlyList = (IReadOnlyList<RecallEntity>)ConfigCommon.GetConfig("RecallEntityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RecallEntity> list = new List<RecallEntity>();
			while (ConfigCommon.Step(ConfigRecallEntityAll.HandleId, false, ConfigRecallEntityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRecallEntityAll.HandleId, 0, ConfigRecallEntityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRecallEntityAll.HandleId, ConfigRecallEntityAll.LogPair);
					return null;
				}
				RecallEntity rootAsRecallEntity = RecallEntity.GetRootAsRecallEntity(new ByteBuffer(item2));
				list.Add(rootAsRecallEntity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RecallEntityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRecallEntityAll.HandleId, ConfigRecallEntityAll.LogPair);
			return list;
		}

		// Token: 0x040036C0 RID: 14016
		private const string DB = "db_questrecall.db";

		// Token: 0x040036C1 RID: 14017
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x040036C2 RID: 14018
		private const string TABLE = "RecallEntity";

		// Token: 0x040036C3 RID: 14019
		private const string COMMAND = "select BinData from `RecallEntity`";

		// Token: 0x040036C4 RID: 14020
		private const string KEY_PREFIX = "RecallEntityAll";

		// Token: 0x040036C5 RID: 14021
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036C6 RID: 14022
		private static int HandleId;
	}
}
