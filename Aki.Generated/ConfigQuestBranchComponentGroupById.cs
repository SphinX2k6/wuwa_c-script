using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000770 RID: 1904
	public class ConfigQuestBranchComponentGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CB1 RID: 11441 RVA: 0x00155C60 File Offset: 0x00153E60
		static ConfigQuestBranchComponentGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestBranchComponentGroupById.CreateStaticDefaultValue), new Action(ConfigQuestBranchComponentGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x00155C80 File Offset: 0x00153E80
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

		// Token: 0x06002CB3 RID: 11443 RVA: 0x00155CFF File Offset: 0x00153EFF
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestBranchComponentGroupById.LogPair = null;
			ConfigQuestBranchComponentGroupById.HandleId = 0;
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00155D0D File Offset: 0x00153F0D
		public static void Init()
		{
			ConfigQuestBranchComponentGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestBranchComponentGroupById.HandleId, "db_questmultiline.db", "select BinData from `QuestBranchComponentGroup` where Id=?");
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x00155D28 File Offset: 0x00153F28
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

		// Token: 0x040033F6 RID: 13302
		private const string DB = "db_questmultiline.db";

		// Token: 0x040033F7 RID: 13303
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x040033F8 RID: 13304
		private const string TABLE = "QuestBranchComponentGroup";

		// Token: 0x040033F9 RID: 13305
		private const string COMMAND = "select BinData from `QuestBranchComponentGroup` where Id=?";

		// Token: 0x040033FA RID: 13306
		private const string KEY_PREFIX = "QuestBranchComponentGroupById";

		// Token: 0x040033FB RID: 13307
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033FC RID: 13308
		private static int HandleId;
	}
}
