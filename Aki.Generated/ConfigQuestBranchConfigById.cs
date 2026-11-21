using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078B RID: 1931
	public class ConfigQuestBranchConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D53 RID: 11603 RVA: 0x0015CDB4 File Offset: 0x0015AFB4
		static ConfigQuestBranchConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestBranchConfigById.CreateStaticDefaultValue), new Action(ConfigQuestBranchConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x0015CDD4 File Offset: 0x0015AFD4
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestBranchConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestBranchConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questmultiline.db"),
				new ValueTuple<string, object>("文件", "r.任务分线.xlsx"),
				new ValueTuple<string, object>("表名", "QuestBranchConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestBranchConfig` where Id=?")
			});
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x0015CE53 File Offset: 0x0015B053
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestBranchConfigById.LogPair = null;
			ConfigQuestBranchConfigById.HandleId = 0;
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x0015CE61 File Offset: 0x0015B061
		public static void Init()
		{
			ConfigQuestBranchConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestBranchConfigById.HandleId, "db_questmultiline.db", "select BinData from `QuestBranchConfig` where Id=?");
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x0015CE7C File Offset: 0x0015B07C
		public static QuestBranchConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestBranchConfigById.HandleId, ConfigQuestBranchConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestBranchConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestBranchConfig?(QuestBranchConfig.GetRootAsQuestBranchConfig(configBuffer));
				}
			}
			ConfigQuestBranchConfigById.LogPair.Clear();
			ConfigQuestBranchConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestBranchConfigById.HandleId, 1, p0Id, ConfigQuestBranchConfigById.LogPair) || ConfigCommon.Step(ConfigQuestBranchConfigById.HandleId, true, ConfigQuestBranchConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestBranchConfigById.HandleId, ConfigQuestBranchConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestBranchConfigById.HandleId, 0, ConfigQuestBranchConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestBranchConfigById.HandleId, ConfigQuestBranchConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestBranchConfig rootAsQuestBranchConfig = QuestBranchConfig.GetRootAsQuestBranchConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestBranchConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestBranchConfigById.HandleId, ConfigQuestBranchConfigById.LogPair);
			return new QuestBranchConfig?(rootAsQuestBranchConfig);
		}

		// Token: 0x040034B3 RID: 13491
		private const string DB = "db_questmultiline.db";

		// Token: 0x040034B4 RID: 13492
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x040034B5 RID: 13493
		private const string TABLE = "QuestBranchConfig";

		// Token: 0x040034B6 RID: 13494
		private const string COMMAND = "select BinData from `QuestBranchConfig` where Id=?";

		// Token: 0x040034B7 RID: 13495
		private const string KEY_PREFIX = "QuestBranchConfigById";

		// Token: 0x040034B8 RID: 13496
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034B9 RID: 13497
		private static int HandleId;
	}
}
