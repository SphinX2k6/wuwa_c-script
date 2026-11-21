using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079E RID: 1950
	public class ConfigQuestReviewTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DC5 RID: 11717 RVA: 0x0015F527 File Offset: 0x0015D727
		static ConfigQuestReviewTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewTabById.CreateStaticDefaultValue), new Action(ConfigQuestReviewTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x0015F548 File Offset: 0x0015D748
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestReviewTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestReviewTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questreview.db"),
				new ValueTuple<string, object>("文件", "j.剧情历程.xlsx"),
				new ValueTuple<string, object>("表名", "QuestReviewTab"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestReviewTab` where Id=?")
			});
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x0015F5C7 File Offset: 0x0015D7C7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewTabById.LogPair = null;
			ConfigQuestReviewTabById.HandleId = 0;
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x0015F5D5 File Offset: 0x0015D7D5
		public static void Init()
		{
			ConfigQuestReviewTabById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewTabById.HandleId, "db_questreview.db", "select BinData from `QuestReviewTab` where Id=?");
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x0015F5F0 File Offset: 0x0015D7F0
		public static QuestReviewTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestReviewTabById.HandleId, ConfigQuestReviewTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestReviewTab?(QuestReviewTab.GetRootAsQuestReviewTab(configBuffer));
				}
			}
			ConfigQuestReviewTabById.LogPair.Clear();
			ConfigQuestReviewTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestReviewTabById.HandleId, 1, p0Id, ConfigQuestReviewTabById.LogPair) || ConfigCommon.Step(ConfigQuestReviewTabById.HandleId, true, ConfigQuestReviewTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestReviewTabById.HandleId, ConfigQuestReviewTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestReviewTabById.HandleId, 0, ConfigQuestReviewTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestReviewTabById.HandleId, ConfigQuestReviewTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestReviewTab rootAsQuestReviewTab = QuestReviewTab.GetRootAsQuestReviewTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestReviewTabById.HandleId, ConfigQuestReviewTabById.LogPair);
			return new QuestReviewTab?(rootAsQuestReviewTab);
		}

		// Token: 0x04003538 RID: 13624
		private const string DB = "db_questreview.db";

		// Token: 0x04003539 RID: 13625
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x0400353A RID: 13626
		private const string TABLE = "QuestReviewTab";

		// Token: 0x0400353B RID: 13627
		private const string COMMAND = "select BinData from `QuestReviewTab` where Id=?";

		// Token: 0x0400353C RID: 13628
		private const string KEY_PREFIX = "QuestReviewTabById";

		// Token: 0x0400353D RID: 13629
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400353E RID: 13630
		private static int HandleId;
	}
}
