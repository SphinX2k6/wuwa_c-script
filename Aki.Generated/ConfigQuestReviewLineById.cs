using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000781 RID: 1921
	public class ConfigQuestReviewLineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D17 RID: 11543 RVA: 0x00157F54 File Offset: 0x00156154
		static ConfigQuestReviewLineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewLineById.CreateStaticDefaultValue), new Action(ConfigQuestReviewLineById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00157F74 File Offset: 0x00156174
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestReviewLineById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestReviewLineById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questreview.db"),
				new ValueTuple<string, object>("文件", "j.剧情历程.xlsx"),
				new ValueTuple<string, object>("表名", "QuestReviewLine"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestReviewLine` where Id=?")
			});
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00157FF3 File Offset: 0x001561F3
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewLineById.LogPair = null;
			ConfigQuestReviewLineById.HandleId = 0;
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x00158001 File Offset: 0x00156201
		public static void Init()
		{
			ConfigQuestReviewLineById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewLineById.HandleId, "db_questreview.db", "select BinData from `QuestReviewLine` where Id=?");
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x0015801C File Offset: 0x0015621C
		public static QuestReviewLine? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestReviewLineById.HandleId, ConfigQuestReviewLineById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewLineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestReviewLine?(QuestReviewLine.GetRootAsQuestReviewLine(configBuffer));
				}
			}
			ConfigQuestReviewLineById.LogPair.Clear();
			ConfigQuestReviewLineById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestReviewLineById.HandleId, 1, p0Id, ConfigQuestReviewLineById.LogPair) || ConfigCommon.Step(ConfigQuestReviewLineById.HandleId, true, ConfigQuestReviewLineById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestReviewLineById.HandleId, ConfigQuestReviewLineById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestReviewLineById.HandleId, 0, ConfigQuestReviewLineById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestReviewLineById.HandleId, ConfigQuestReviewLineById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestReviewLine rootAsQuestReviewLine = QuestReviewLine.GetRootAsQuestReviewLine(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewLineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestReviewLineById.HandleId, ConfigQuestReviewLineById.LogPair);
			return new QuestReviewLine?(rootAsQuestReviewLine);
		}

		// Token: 0x0400346D RID: 13421
		private const string DB = "db_questreview.db";

		// Token: 0x0400346E RID: 13422
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x0400346F RID: 13423
		private const string TABLE = "QuestReviewLine";

		// Token: 0x04003470 RID: 13424
		private const string COMMAND = "select BinData from `QuestReviewLine` where Id=?";

		// Token: 0x04003471 RID: 13425
		private const string KEY_PREFIX = "QuestReviewLineById";

		// Token: 0x04003472 RID: 13426
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003473 RID: 13427
		private static int HandleId;
	}
}
