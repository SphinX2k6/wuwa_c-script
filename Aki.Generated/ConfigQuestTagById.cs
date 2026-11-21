using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A0 RID: 1952
	public class ConfigQuestTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DD1 RID: 11729 RVA: 0x0015F9B8 File Offset: 0x0015DBB8
		static ConfigQuestTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTagById.CreateStaticDefaultValue), new Action(ConfigQuestTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x0015F9D8 File Offset: 0x0015DBD8
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtag.db"),
				new ValueTuple<string, object>("文件", "r.任务标签.xlsx"),
				new ValueTuple<string, object>("表名", "QuestTag"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTag` where Id=?")
			});
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x0015FA57 File Offset: 0x0015DC57
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTagById.LogPair = null;
			ConfigQuestTagById.HandleId = 0;
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x0015FA65 File Offset: 0x0015DC65
		public static void Init()
		{
			ConfigQuestTagById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTagById.HandleId, "db_questtag.db", "select BinData from `QuestTag` where Id=?");
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x0015FA80 File Offset: 0x0015DC80
		public static QuestTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTagById.HandleId, ConfigQuestTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestTag?(QuestTag.GetRootAsQuestTag(configBuffer));
				}
			}
			ConfigQuestTagById.LogPair.Clear();
			ConfigQuestTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestTagById.HandleId, 1, p0Id, ConfigQuestTagById.LogPair) || ConfigCommon.Step(ConfigQuestTagById.HandleId, true, ConfigQuestTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestTagById.HandleId, ConfigQuestTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTagById.HandleId, 0, ConfigQuestTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestTagById.HandleId, ConfigQuestTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestTag rootAsQuestTag = QuestTag.GetRootAsQuestTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestTagById.HandleId, ConfigQuestTagById.LogPair);
			return new QuestTag?(rootAsQuestTag);
		}

		// Token: 0x04003546 RID: 13638
		private const string DB = "db_questtag.db";

		// Token: 0x04003547 RID: 13639
		private const string FILE = "r.任务标签.xlsx";

		// Token: 0x04003548 RID: 13640
		private const string TABLE = "QuestTag";

		// Token: 0x04003549 RID: 13641
		private const string COMMAND = "select BinData from `QuestTag` where Id=?";

		// Token: 0x0400354A RID: 13642
		private const string KEY_PREFIX = "QuestTagById";

		// Token: 0x0400354B RID: 13643
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400354C RID: 13644
		private static int HandleId;
	}
}
