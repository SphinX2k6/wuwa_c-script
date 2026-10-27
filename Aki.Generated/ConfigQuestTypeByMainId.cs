using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000795 RID: 1941
	public class ConfigQuestTypeByMainId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D90 RID: 11664 RVA: 0x0015AB08 File Offset: 0x00158D08
		static ConfigQuestTypeByMainId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTypeByMainId.CreateStaticDefaultValue), new Action(ConfigQuestTypeByMainId.ResetStaticDefaultValue));
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x0015AB28 File Offset: 0x00158D28
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

		// Token: 0x06002D92 RID: 11666 RVA: 0x0015ABA7 File Offset: 0x00158DA7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTypeByMainId.LogPair = null;
			ConfigQuestTypeByMainId.HandleId = 0;
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x0015ABB5 File Offset: 0x00158DB5
		public static void Init()
		{
			ConfigQuestTypeByMainId.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTypeByMainId.HandleId, "db_questtype.db", "select BinData from `QuestType` where MainId=?");
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x0015ABD0 File Offset: 0x00158DD0
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

		// Token: 0x040034F9 RID: 13561
		private const string DB = "db_questtype.db";

		// Token: 0x040034FA RID: 13562
		private const string FILE = "r.任务类型.xlsx";

		// Token: 0x040034FB RID: 13563
		private const string TABLE = "QuestType";

		// Token: 0x040034FC RID: 13564
		private const string COMMAND = "select BinData from `QuestType` where MainId=?";

		// Token: 0x040034FD RID: 13565
		private const string KEY_PREFIX = "QuestTypeByMainId";

		// Token: 0x040034FE RID: 13566
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034FF RID: 13567
		private static int HandleId;
	}
}
