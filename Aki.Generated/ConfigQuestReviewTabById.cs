using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000784 RID: 1924
	public class ConfigQuestReviewTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D29 RID: 11561 RVA: 0x0015861B File Offset: 0x0015681B
		static ConfigQuestReviewTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewTabById.CreateStaticDefaultValue), new Action(ConfigQuestReviewTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x0015863C File Offset: 0x0015683C
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

		// Token: 0x06002D2B RID: 11563 RVA: 0x001586BB File Offset: 0x001568BB
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewTabById.LogPair = null;
			ConfigQuestReviewTabById.HandleId = 0;
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x001586C9 File Offset: 0x001568C9
		public static void Init()
		{
			ConfigQuestReviewTabById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewTabById.HandleId, "db_questreview.db", "select BinData from `QuestReviewTab` where Id=?");
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x001586E4 File Offset: 0x001568E4
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

		// Token: 0x04003482 RID: 13442
		private const string DB = "db_questreview.db";

		// Token: 0x04003483 RID: 13443
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x04003484 RID: 13444
		private const string TABLE = "QuestReviewTab";

		// Token: 0x04003485 RID: 13445
		private const string COMMAND = "select BinData from `QuestReviewTab` where Id=?";

		// Token: 0x04003486 RID: 13446
		private const string KEY_PREFIX = "QuestReviewTabById";

		// Token: 0x04003487 RID: 13447
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003488 RID: 13448
		private static int HandleId;
	}
}
