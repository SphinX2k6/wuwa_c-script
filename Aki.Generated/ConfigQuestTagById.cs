using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000786 RID: 1926
	public class ConfigQuestTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D35 RID: 11573 RVA: 0x00158AAC File Offset: 0x00156CAC
		static ConfigQuestTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTagById.CreateStaticDefaultValue), new Action(ConfigQuestTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00158ACC File Offset: 0x00156CCC
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

		// Token: 0x06002D37 RID: 11575 RVA: 0x00158B4B File Offset: 0x00156D4B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTagById.LogPair = null;
			ConfigQuestTagById.HandleId = 0;
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00158B59 File Offset: 0x00156D59
		public static void Init()
		{
			ConfigQuestTagById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTagById.HandleId, "db_questtag.db", "select BinData from `QuestTag` where Id=?");
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00158B74 File Offset: 0x00156D74
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

		// Token: 0x04003490 RID: 13456
		private const string DB = "db_questtag.db";

		// Token: 0x04003491 RID: 13457
		private const string FILE = "r.任务标签.xlsx";

		// Token: 0x04003492 RID: 13458
		private const string TABLE = "QuestTag";

		// Token: 0x04003493 RID: 13459
		private const string COMMAND = "select BinData from `QuestTag` where Id=?";

		// Token: 0x04003494 RID: 13460
		private const string KEY_PREFIX = "QuestTagById";

		// Token: 0x04003495 RID: 13461
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003496 RID: 13462
		private static int HandleId;
	}
}
