using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AE RID: 1966
	public class ConfigQuestTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E26 RID: 11814 RVA: 0x001617CB File Offset: 0x0015F9CB
		static ConfigQuestTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTypeById.CreateStaticDefaultValue), new Action(ConfigQuestTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x001617EC File Offset: 0x0015F9EC
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtype.db"),
				new ValueTuple<string, object>("文件", "r.任务类型.xlsx"),
				new ValueTuple<string, object>("表名", "QuestType"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestType` where Id=?")
			});
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x0016186B File Offset: 0x0015FA6B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTypeById.LogPair = null;
			ConfigQuestTypeById.HandleId = 0;
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00161879 File Offset: 0x0015FA79
		public static void Init()
		{
			ConfigQuestTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTypeById.HandleId, "db_questtype.db", "select BinData from `QuestType` where Id=?");
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00161894 File Offset: 0x0015FA94
		public static QuestType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTypeById.HandleId, ConfigQuestTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestType?(QuestType.GetRootAsQuestType(configBuffer));
				}
			}
			ConfigQuestTypeById.LogPair.Clear();
			ConfigQuestTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestTypeById.HandleId, 1, p0Id, ConfigQuestTypeById.LogPair) || ConfigCommon.Step(ConfigQuestTypeById.HandleId, true, ConfigQuestTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestTypeById.HandleId, ConfigQuestTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTypeById.HandleId, 0, ConfigQuestTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestTypeById.HandleId, ConfigQuestTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestType rootAsQuestType = QuestType.GetRootAsQuestType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestTypeById.HandleId, ConfigQuestTypeById.LogPair);
			return new QuestType?(rootAsQuestType);
		}

		// Token: 0x040035A8 RID: 13736
		private const string DB = "db_questtype.db";

		// Token: 0x040035A9 RID: 13737
		private const string FILE = "r.任务类型.xlsx";

		// Token: 0x040035AA RID: 13738
		private const string TABLE = "QuestType";

		// Token: 0x040035AB RID: 13739
		private const string COMMAND = "select BinData from `QuestType` where Id=?";

		// Token: 0x040035AC RID: 13740
		private const string KEY_PREFIX = "QuestTypeById";

		// Token: 0x040035AD RID: 13741
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035AE RID: 13742
		private static int HandleId;
	}
}
