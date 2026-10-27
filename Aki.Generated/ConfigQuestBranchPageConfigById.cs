using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000772 RID: 1906
	public class ConfigQuestBranchPageConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CBD RID: 11453 RVA: 0x001560F0 File Offset: 0x001542F0
		static ConfigQuestBranchPageConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestBranchPageConfigById.CreateStaticDefaultValue), new Action(ConfigQuestBranchPageConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00156110 File Offset: 0x00154310
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

		// Token: 0x06002CBF RID: 11455 RVA: 0x0015618F File Offset: 0x0015438F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestBranchPageConfigById.LogPair = null;
			ConfigQuestBranchPageConfigById.HandleId = 0;
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x0015619D File Offset: 0x0015439D
		public static void Init()
		{
			ConfigQuestBranchPageConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestBranchPageConfigById.HandleId, "db_questmultiline.db", "select BinData from `QuestBranchPageConfig` where Id=?");
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x001561B8 File Offset: 0x001543B8
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

		// Token: 0x04003404 RID: 13316
		private const string DB = "db_questmultiline.db";

		// Token: 0x04003405 RID: 13317
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x04003406 RID: 13318
		private const string TABLE = "QuestBranchPageConfig";

		// Token: 0x04003407 RID: 13319
		private const string COMMAND = "select BinData from `QuestBranchPageConfig` where Id=?";

		// Token: 0x04003408 RID: 13320
		private const string KEY_PREFIX = "QuestBranchPageConfigById";

		// Token: 0x04003409 RID: 13321
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400340A RID: 13322
		private static int HandleId;
	}
}
