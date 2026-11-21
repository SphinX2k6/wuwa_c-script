using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C2 RID: 1474
	public class ConfigMotorLinkageQuestAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002299 RID: 8857 RVA: 0x00120BAC File Offset: 0x0011EDAC
		static ConfigMotorLinkageQuestAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLinkageQuestAll.CreateStaticDefaultValue), new Action(ConfigMotorLinkageQuestAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00120BCC File Offset: 0x0011EDCC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLinkageQuestAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLinkageQuestAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorlinkage.db"),
				new ValueTuple<string, object>("文件", "m.摩托车IP联动活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLinkageQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLinkageQuest`")
			});
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00120C4B File Offset: 0x0011EE4B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLinkageQuestAll.LogPair = null;
			ConfigMotorLinkageQuestAll.HandleId = 0;
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00120C59 File Offset: 0x0011EE59
		public static void Init()
		{
			ConfigMotorLinkageQuestAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLinkageQuestAll.HandleId, "db_motorlinkage.db", "select BinData from `MotorLinkageQuest`");
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00120C74 File Offset: 0x0011EE74
		[NullableContext(2)]
		public static IReadOnlyList<MotorLinkageQuest> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLinkageQuestAll.HandleId, ConfigMotorLinkageQuestAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorLinkageQuest> readOnlyList = (IReadOnlyList<MotorLinkageQuest>)ConfigCommon.GetConfig("MotorLinkageQuestAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorLinkageQuest> list = new List<MotorLinkageQuest>();
			while (ConfigCommon.Step(ConfigMotorLinkageQuestAll.HandleId, false, ConfigMotorLinkageQuestAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLinkageQuestAll.HandleId, 0, ConfigMotorLinkageQuestAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorLinkageQuestAll.HandleId, ConfigMotorLinkageQuestAll.LogPair);
					return null;
				}
				MotorLinkageQuest rootAsMotorLinkageQuest = MotorLinkageQuest.GetRootAsMotorLinkageQuest(new ByteBuffer(item2));
				list.Add(rootAsMotorLinkageQuest);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorLinkageQuestAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorLinkageQuestAll.HandleId, ConfigMotorLinkageQuestAll.LogPair);
			return list;
		}

		// Token: 0x04002832 RID: 10290
		private const string DB = "db_motorlinkage.db";

		// Token: 0x04002833 RID: 10291
		private const string FILE = "m.摩托车IP联动活动.xlsx";

		// Token: 0x04002834 RID: 10292
		private const string TABLE = "MotorLinkageQuest";

		// Token: 0x04002835 RID: 10293
		private const string COMMAND = "select BinData from `MotorLinkageQuest`";

		// Token: 0x04002836 RID: 10294
		private const string KEY_PREFIX = "MotorLinkageQuestAll";

		// Token: 0x04002837 RID: 10295
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002838 RID: 10296
		private static int HandleId;
	}
}
