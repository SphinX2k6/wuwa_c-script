using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000794 RID: 1940
	public class ConfigQuestTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D8A RID: 11658 RVA: 0x0015A8BF File Offset: 0x00158ABF
		static ConfigQuestTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTypeById.CreateStaticDefaultValue), new Action(ConfigQuestTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x0015A8E0 File Offset: 0x00158AE0
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

		// Token: 0x06002D8C RID: 11660 RVA: 0x0015A95F File Offset: 0x00158B5F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTypeById.LogPair = null;
			ConfigQuestTypeById.HandleId = 0;
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x0015A96D File Offset: 0x00158B6D
		public static void Init()
		{
			ConfigQuestTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTypeById.HandleId, "db_questtype.db", "select BinData from `QuestType` where Id=?");
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x0015A988 File Offset: 0x00158B88
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

		// Token: 0x040034F2 RID: 13554
		private const string DB = "db_questtype.db";

		// Token: 0x040034F3 RID: 13555
		private const string FILE = "r.任务类型.xlsx";

		// Token: 0x040034F4 RID: 13556
		private const string TABLE = "QuestType";

		// Token: 0x040034F5 RID: 13557
		private const string COMMAND = "select BinData from `QuestType` where Id=?";

		// Token: 0x040034F6 RID: 13558
		private const string KEY_PREFIX = "QuestTypeById";

		// Token: 0x040034F7 RID: 13559
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034F8 RID: 13560
		private static int HandleId;
	}
}
