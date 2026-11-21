using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AF RID: 1967
	public class ConfigQuestTypeByMainId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E2C RID: 11820 RVA: 0x00161A14 File Offset: 0x0015FC14
		static ConfigQuestTypeByMainId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTypeByMainId.CreateStaticDefaultValue), new Action(ConfigQuestTypeByMainId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00161A34 File Offset: 0x0015FC34
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTypeByMainId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTypeByMainId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtype.db"),
				new ValueTuple<string, object>("文件", "r.任务类型.xlsx"),
				new ValueTuple<string, object>("表名", "QuestType"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestType` where MainId=?")
			});
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00161AB3 File Offset: 0x0015FCB3
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTypeByMainId.LogPair = null;
			ConfigQuestTypeByMainId.HandleId = 0;
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x00161AC1 File Offset: 0x0015FCC1
		public static void Init()
		{
			ConfigQuestTypeByMainId.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTypeByMainId.HandleId, "db_questtype.db", "select BinData from `QuestType` where MainId=?");
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00161ADC File Offset: 0x0015FCDC
		[NullableContext(2)]
		public static IReadOnlyList<QuestType> GetConfigList(int p0MainId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTypeByMainId.HandleId, ConfigQuestTypeByMainId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTypeByMainId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MainId);
				IReadOnlyList<QuestType> readOnlyList = (IReadOnlyList<QuestType>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigQuestTypeByMainId.LogPair.Clear();
			ConfigQuestTypeByMainId.LogPair.Add(new ValueTuple<string, object>("MainId", p0MainId));
			if (!ConfigCommon.BindInt(ConfigQuestTypeByMainId.HandleId, 1, p0MainId, ConfigQuestTypeByMainId.LogPair))
			{
				ConfigCommon.Reset(ConfigQuestTypeByMainId.HandleId, ConfigQuestTypeByMainId.LogPair);
				return null;
			}
			List<QuestType> list = new List<QuestType>();
			while (ConfigCommon.Step(ConfigQuestTypeByMainId.HandleId, false, ConfigQuestTypeByMainId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTypeByMainId.HandleId, 0, ConfigQuestTypeByMainId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestTypeByMainId.HandleId, ConfigQuestTypeByMainId.LogPair);
					return null;
				}
				QuestType rootAsQuestType = QuestType.GetRootAsQuestType(new ByteBuffer(item2));
				list.Add(rootAsQuestType);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTypeByMainId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MainId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestTypeByMainId.HandleId, ConfigQuestTypeByMainId.LogPair);
			return list;
		}

		// Token: 0x040035AF RID: 13743
		private const string DB = "db_questtype.db";

		// Token: 0x040035B0 RID: 13744
		private const string FILE = "r.任务类型.xlsx";

		// Token: 0x040035B1 RID: 13745
		private const string TABLE = "QuestType";

		// Token: 0x040035B2 RID: 13746
		private const string COMMAND = "select BinData from `QuestType` where MainId=?";

		// Token: 0x040035B3 RID: 13747
		private const string KEY_PREFIX = "QuestTypeByMainId";

		// Token: 0x040035B4 RID: 13748
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035B5 RID: 13749
		private static int HandleId;
	}
}
