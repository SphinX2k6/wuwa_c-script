using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AC RID: 1964
	public class ConfigQuestTreeNodeUnlockById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E1A RID: 11802 RVA: 0x001613F0 File Offset: 0x0015F5F0
		static ConfigQuestTreeNodeUnlockById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeNodeUnlockById.CreateStaticDefaultValue), new Action(ConfigQuestTreeNodeUnlockById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00161410 File Offset: 0x0015F610
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTreeNodeUnlockById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTreeNodeUnlockById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtree.db"),
				new ValueTuple<string, object>("文件", "r.任务树.xlsx"),
				new ValueTuple<string, object>("表名", "QuestTreeNodeUnlock"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTreeNodeUnlock` where Id=?")
			});
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x0016148F File Offset: 0x0015F68F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeNodeUnlockById.LogPair = null;
			ConfigQuestTreeNodeUnlockById.HandleId = 0;
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x0016149D File Offset: 0x0015F69D
		public static void Init()
		{
			ConfigQuestTreeNodeUnlockById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeNodeUnlockById.HandleId, "db_questtree.db", "select BinData from `QuestTreeNodeUnlock` where Id=?");
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x001614B8 File Offset: 0x0015F6B8
		public static QuestTreeNodeUnlock? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTreeNodeUnlockById.HandleId, ConfigQuestTreeNodeUnlockById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTreeNodeUnlockById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestTreeNodeUnlock?(QuestTreeNodeUnlock.GetRootAsQuestTreeNodeUnlock(configBuffer));
				}
			}
			ConfigQuestTreeNodeUnlockById.LogPair.Clear();
			ConfigQuestTreeNodeUnlockById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestTreeNodeUnlockById.HandleId, 1, p0Id, ConfigQuestTreeNodeUnlockById.LogPair) || ConfigCommon.Step(ConfigQuestTreeNodeUnlockById.HandleId, true, ConfigQuestTreeNodeUnlockById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestTreeNodeUnlockById.HandleId, ConfigQuestTreeNodeUnlockById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTreeNodeUnlockById.HandleId, 0, ConfigQuestTreeNodeUnlockById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestTreeNodeUnlockById.HandleId, ConfigQuestTreeNodeUnlockById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestTreeNodeUnlock rootAsQuestTreeNodeUnlock = QuestTreeNodeUnlock.GetRootAsQuestTreeNodeUnlock(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTreeNodeUnlockById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestTreeNodeUnlockById.HandleId, ConfigQuestTreeNodeUnlockById.LogPair);
			return new QuestTreeNodeUnlock?(rootAsQuestTreeNodeUnlock);
		}

		// Token: 0x0400359A RID: 13722
		private const string DB = "db_questtree.db";

		// Token: 0x0400359B RID: 13723
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x0400359C RID: 13724
		private const string TABLE = "QuestTreeNodeUnlock";

		// Token: 0x0400359D RID: 13725
		private const string COMMAND = "select BinData from `QuestTreeNodeUnlock` where Id=?";

		// Token: 0x0400359E RID: 13726
		private const string KEY_PREFIX = "QuestTreeNodeUnlockById";

		// Token: 0x0400359F RID: 13727
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035A0 RID: 13728
		private static int HandleId;
	}
}
