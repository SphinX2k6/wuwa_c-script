using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000771 RID: 1905
	public class ConfigQuestBranchConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CB7 RID: 11447 RVA: 0x00155EA8 File Offset: 0x001540A8
		static ConfigQuestBranchConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestBranchConfigById.CreateStaticDefaultValue), new Action(ConfigQuestBranchConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x00155EC8 File Offset: 0x001540C8
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

		// Token: 0x06002CB9 RID: 11449 RVA: 0x00155F47 File Offset: 0x00154147
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestBranchConfigById.LogPair = null;
			ConfigQuestBranchConfigById.HandleId = 0;
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x00155F55 File Offset: 0x00154155
		public static void Init()
		{
			ConfigQuestBranchConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestBranchConfigById.HandleId, "db_questmultiline.db", "select BinData from `QuestBranchConfig` where Id=?");
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x00155F70 File Offset: 0x00154170
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

		// Token: 0x040033FD RID: 13309
		private const string DB = "db_questmultiline.db";

		// Token: 0x040033FE RID: 13310
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x040033FF RID: 13311
		private const string TABLE = "QuestBranchConfig";

		// Token: 0x04003400 RID: 13312
		private const string COMMAND = "select BinData from `QuestBranchConfig` where Id=?";

		// Token: 0x04003401 RID: 13313
		private const string KEY_PREFIX = "QuestBranchConfigById";

		// Token: 0x04003402 RID: 13314
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003403 RID: 13315
		private static int HandleId;
	}
}
