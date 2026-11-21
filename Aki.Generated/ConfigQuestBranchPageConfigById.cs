using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078C RID: 1932
	public class ConfigQuestBranchPageConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D59 RID: 11609 RVA: 0x0015CFFC File Offset: 0x0015B1FC
		static ConfigQuestBranchPageConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestBranchPageConfigById.CreateStaticDefaultValue), new Action(ConfigQuestBranchPageConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x0015D01C File Offset: 0x0015B21C
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestBranchPageConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestBranchPageConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questmultiline.db"),
				new ValueTuple<string, object>("文件", "r.任务分线.xlsx"),
				new ValueTuple<string, object>("表名", "QuestBranchPageConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestBranchPageConfig` where Id=?")
			});
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x0015D09B File Offset: 0x0015B29B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestBranchPageConfigById.LogPair = null;
			ConfigQuestBranchPageConfigById.HandleId = 0;
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x0015D0A9 File Offset: 0x0015B2A9
		public static void Init()
		{
			ConfigQuestBranchPageConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestBranchPageConfigById.HandleId, "db_questmultiline.db", "select BinData from `QuestBranchPageConfig` where Id=?");
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x0015D0C4 File Offset: 0x0015B2C4
		public static QuestBranchPageConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestBranchPageConfigById.HandleId, ConfigQuestBranchPageConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestBranchPageConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestBranchPageConfig?(QuestBranchPageConfig.GetRootAsQuestBranchPageConfig(configBuffer));
				}
			}
			ConfigQuestBranchPageConfigById.LogPair.Clear();
			ConfigQuestBranchPageConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestBranchPageConfigById.HandleId, 1, p0Id, ConfigQuestBranchPageConfigById.LogPair) || ConfigCommon.Step(ConfigQuestBranchPageConfigById.HandleId, true, ConfigQuestBranchPageConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestBranchPageConfigById.HandleId, ConfigQuestBranchPageConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestBranchPageConfigById.HandleId, 0, ConfigQuestBranchPageConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestBranchPageConfigById.HandleId, ConfigQuestBranchPageConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestBranchPageConfig rootAsQuestBranchPageConfig = QuestBranchPageConfig.GetRootAsQuestBranchPageConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestBranchPageConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestBranchPageConfigById.HandleId, ConfigQuestBranchPageConfigById.LogPair);
			return new QuestBranchPageConfig?(rootAsQuestBranchPageConfig);
		}

		// Token: 0x040034BA RID: 13498
		private const string DB = "db_questmultiline.db";

		// Token: 0x040034BB RID: 13499
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x040034BC RID: 13500
		private const string TABLE = "QuestBranchPageConfig";

		// Token: 0x040034BD RID: 13501
		private const string COMMAND = "select BinData from `QuestBranchPageConfig` where Id=?";

		// Token: 0x040034BE RID: 13502
		private const string KEY_PREFIX = "QuestBranchPageConfigById";

		// Token: 0x040034BF RID: 13503
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034C0 RID: 13504
		private static int HandleId;
	}
}
