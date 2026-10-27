using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AB RID: 1451
	public class ConfigMotorLinkageQuestAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600220F RID: 8719 RVA: 0x0011A2C4 File Offset: 0x001184C4
		static ConfigMotorLinkageQuestAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLinkageQuestAll.CreateStaticDefaultValue), new Action(ConfigMotorLinkageQuestAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0011A2E4 File Offset: 0x001184E4
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

		// Token: 0x06002211 RID: 8721 RVA: 0x0011A363 File Offset: 0x00118563
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLinkageQuestAll.LogPair = null;
			ConfigMotorLinkageQuestAll.HandleId = 0;
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0011A371 File Offset: 0x00118571
		public static void Init()
		{
			ConfigMotorLinkageQuestAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLinkageQuestAll.HandleId, "db_motorlinkage.db", "select BinData from `MotorLinkageQuest`");
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0011A38C File Offset: 0x0011858C
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

		// Token: 0x04002791 RID: 10129
		private const string DB = "db_motorlinkage.db";

		// Token: 0x04002792 RID: 10130
		private const string FILE = "m.摩托车IP联动活动.xlsx";

		// Token: 0x04002793 RID: 10131
		private const string TABLE = "MotorLinkageQuest";

		// Token: 0x04002794 RID: 10132
		private const string COMMAND = "select BinData from `MotorLinkageQuest`";

		// Token: 0x04002795 RID: 10133
		private const string KEY_PREFIX = "MotorLinkageQuestAll";

		// Token: 0x04002796 RID: 10134
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002797 RID: 10135
		private static int HandleId;
	}
}
