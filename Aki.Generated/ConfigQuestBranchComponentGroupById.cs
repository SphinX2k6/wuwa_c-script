using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078A RID: 1930
	public class ConfigQuestBranchComponentGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D4D RID: 11597 RVA: 0x0015CB6C File Offset: 0x0015AD6C
		static ConfigQuestBranchComponentGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestBranchComponentGroupById.CreateStaticDefaultValue), new Action(ConfigQuestBranchComponentGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x0015CB8C File Offset: 0x0015AD8C
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestBranchComponentGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestBranchComponentGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questmultiline.db"),
				new ValueTuple<string, object>("文件", "r.任务分线.xlsx"),
				new ValueTuple<string, object>("表名", "QuestBranchComponentGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestBranchComponentGroup` where Id=?")
			});
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x0015CC0B File Offset: 0x0015AE0B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestBranchComponentGroupById.LogPair = null;
			ConfigQuestBranchComponentGroupById.HandleId = 0;
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x0015CC19 File Offset: 0x0015AE19
		public static void Init()
		{
			ConfigQuestBranchComponentGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestBranchComponentGroupById.HandleId, "db_questmultiline.db", "select BinData from `QuestBranchComponentGroup` where Id=?");
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x0015CC34 File Offset: 0x0015AE34
		public static QuestBranchComponentGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestBranchComponentGroupById.HandleId, ConfigQuestBranchComponentGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestBranchComponentGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestBranchComponentGroup?(QuestBranchComponentGroup.GetRootAsQuestBranchComponentGroup(configBuffer));
				}
			}
			ConfigQuestBranchComponentGroupById.LogPair.Clear();
			ConfigQuestBranchComponentGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestBranchComponentGroupById.HandleId, 1, p0Id, ConfigQuestBranchComponentGroupById.LogPair) || ConfigCommon.Step(ConfigQuestBranchComponentGroupById.HandleId, true, ConfigQuestBranchComponentGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestBranchComponentGroupById.HandleId, ConfigQuestBranchComponentGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestBranchComponentGroupById.HandleId, 0, ConfigQuestBranchComponentGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestBranchComponentGroupById.HandleId, ConfigQuestBranchComponentGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestBranchComponentGroup rootAsQuestBranchComponentGroup = QuestBranchComponentGroup.GetRootAsQuestBranchComponentGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestBranchComponentGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestBranchComponentGroupById.HandleId, ConfigQuestBranchComponentGroupById.LogPair);
			return new QuestBranchComponentGroup?(rootAsQuestBranchComponentGroup);
		}

		// Token: 0x040034AC RID: 13484
		private const string DB = "db_questmultiline.db";

		// Token: 0x040034AD RID: 13485
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x040034AE RID: 13486
		private const string TABLE = "QuestBranchComponentGroup";

		// Token: 0x040034AF RID: 13487
		private const string COMMAND = "select BinData from `QuestBranchComponentGroup` where Id=?";

		// Token: 0x040034B0 RID: 13488
		private const string KEY_PREFIX = "QuestBranchComponentGroupById";

		// Token: 0x040034B1 RID: 13489
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034B2 RID: 13490
		private static int HandleId;
	}
}
