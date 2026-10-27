using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000792 RID: 1938
	public class ConfigQuestTreeNodeUnlockById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D7E RID: 11646 RVA: 0x0015A4E4 File Offset: 0x001586E4
		static ConfigQuestTreeNodeUnlockById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeNodeUnlockById.CreateStaticDefaultValue), new Action(ConfigQuestTreeNodeUnlockById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x0015A504 File Offset: 0x00158704
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

		// Token: 0x06002D80 RID: 11648 RVA: 0x0015A583 File Offset: 0x00158783
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeNodeUnlockById.LogPair = null;
			ConfigQuestTreeNodeUnlockById.HandleId = 0;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x0015A591 File Offset: 0x00158791
		public static void Init()
		{
			ConfigQuestTreeNodeUnlockById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeNodeUnlockById.HandleId, "db_questtree.db", "select BinData from `QuestTreeNodeUnlock` where Id=?");
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x0015A5AC File Offset: 0x001587AC
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

		// Token: 0x040034E4 RID: 13540
		private const string DB = "db_questtree.db";

		// Token: 0x040034E5 RID: 13541
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x040034E6 RID: 13542
		private const string TABLE = "QuestTreeNodeUnlock";

		// Token: 0x040034E7 RID: 13543
		private const string COMMAND = "select BinData from `QuestTreeNodeUnlock` where Id=?";

		// Token: 0x040034E8 RID: 13544
		private const string KEY_PREFIX = "QuestTreeNodeUnlockById";

		// Token: 0x040034E9 RID: 13545
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034EA RID: 13546
		private static int HandleId;
	}
}
