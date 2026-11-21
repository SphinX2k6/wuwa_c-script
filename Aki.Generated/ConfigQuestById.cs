using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078D RID: 1933
	public class ConfigQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D5F RID: 11615 RVA: 0x0015D244 File Offset: 0x0015B444
		static ConfigQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestById.CreateStaticDefaultValue), new Action(ConfigQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x0015D264 File Offset: 0x0015B464
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_quest.db"),
				new ValueTuple<string, object>("文件", "r.任务.xlsx"),
				new ValueTuple<string, object>("表名", "Quest"),
				new ValueTuple<string, object>("语句", "select BinData from `Quest` where Id=?")
			});
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x0015D2E3 File Offset: 0x0015B4E3
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestById.LogPair = null;
			ConfigQuestById.HandleId = 0;
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x0015D2F1 File Offset: 0x0015B4F1
		public static void Init()
		{
			ConfigQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestById.HandleId, "db_quest.db", "select BinData from `Quest` where Id=?");
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x0015D30C File Offset: 0x0015B50C
		public static Quest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestById.HandleId, ConfigQuestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Quest?(Quest.GetRootAsQuest(configBuffer));
				}
			}
			ConfigQuestById.LogPair.Clear();
			ConfigQuestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestById.HandleId, 1, p0Id, ConfigQuestById.LogPair) || ConfigCommon.Step(ConfigQuestById.HandleId, true, ConfigQuestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestById.HandleId, ConfigQuestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestById.HandleId, 0, ConfigQuestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestById.HandleId, ConfigQuestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Quest rootAsQuest = Quest.GetRootAsQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestById.HandleId, ConfigQuestById.LogPair);
			return new Quest?(rootAsQuest);
		}

		// Token: 0x040034C1 RID: 13505
		private const string DB = "db_quest.db";

		// Token: 0x040034C2 RID: 13506
		private const string FILE = "r.任务.xlsx";

		// Token: 0x040034C3 RID: 13507
		private const string TABLE = "Quest";

		// Token: 0x040034C4 RID: 13508
		private const string COMMAND = "select BinData from `Quest` where Id=?";

		// Token: 0x040034C5 RID: 13509
		private const string KEY_PREFIX = "QuestById";

		// Token: 0x040034C6 RID: 13510
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034C7 RID: 13511
		private static int HandleId;
	}
}
