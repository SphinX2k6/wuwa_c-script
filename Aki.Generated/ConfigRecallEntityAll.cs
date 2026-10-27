using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BC RID: 1980
	public class ConfigRecallEntityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E7A RID: 11898 RVA: 0x001601A8 File Offset: 0x0015E3A8
		static ConfigRecallEntityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallEntityAll.CreateStaticDefaultValue), new Action(ConfigRecallEntityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x001601C8 File Offset: 0x0015E3C8
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

		// Token: 0x06002E7C RID: 11900 RVA: 0x00160247 File Offset: 0x0015E447
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallEntityAll.LogPair = null;
			ConfigRecallEntityAll.HandleId = 0;
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x00160255 File Offset: 0x0015E455
		public static void Init()
		{
			ConfigRecallEntityAll.HandleId = ConfigCommon.InitDataStatement(ConfigRecallEntityAll.HandleId, "db_questrecall.db", "select BinData from `RecallEntity`");
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00160270 File Offset: 0x0015E470
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

		// Token: 0x0400360A RID: 13834
		private const string DB = "db_questrecall.db";

		// Token: 0x0400360B RID: 13835
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x0400360C RID: 13836
		private const string TABLE = "RecallEntity";

		// Token: 0x0400360D RID: 13837
		private const string COMMAND = "select BinData from `RecallEntity`";

		// Token: 0x0400360E RID: 13838
		private const string KEY_PREFIX = "RecallEntityAll";

		// Token: 0x0400360F RID: 13839
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003610 RID: 13840
		private static int HandleId;
	}
}
