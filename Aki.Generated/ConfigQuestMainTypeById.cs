using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000791 RID: 1937
	public class ConfigQuestMainTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D77 RID: 11639 RVA: 0x0015DB64 File Offset: 0x0015BD64
		static ConfigQuestMainTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestMainTypeById.CreateStaticDefaultValue), new Action(ConfigQuestMainTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x0015DB84 File Offset: 0x0015BD84
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestMainTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestMainTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtype.db"),
				new ValueTuple<string, object>("文件", "r.任务类型.xlsx"),
				new ValueTuple<string, object>("表名", "QuestMainType"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestMainType` where Id=?")
			});
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x0015DC03 File Offset: 0x0015BE03
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestMainTypeById.LogPair = null;
			ConfigQuestMainTypeById.HandleId = 0;
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x0015DC11 File Offset: 0x0015BE11
		public static void Init()
		{
			ConfigQuestMainTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestMainTypeById.HandleId, "db_questtype.db", "select BinData from `QuestMainType` where Id=?");
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x0015DC2C File Offset: 0x0015BE2C
		public static QuestMainType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestMainTypeById.HandleId, ConfigQuestMainTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestMainTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestMainType?(QuestMainType.GetRootAsQuestMainType(configBuffer));
				}
			}
			ConfigQuestMainTypeById.LogPair.Clear();
			ConfigQuestMainTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestMainTypeById.HandleId, 1, p0Id, ConfigQuestMainTypeById.LogPair) || ConfigCommon.Step(ConfigQuestMainTypeById.HandleId, true, ConfigQuestMainTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestMainTypeById.HandleId, ConfigQuestMainTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestMainTypeById.HandleId, 0, ConfigQuestMainTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestMainTypeById.HandleId, ConfigQuestMainTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestMainType rootAsQuestMainType = QuestMainType.GetRootAsQuestMainType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestMainTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestMainTypeById.HandleId, ConfigQuestMainTypeById.LogPair);
			return new QuestMainType?(rootAsQuestMainType);
		}

		// Token: 0x040034DD RID: 13533
		private const string DB = "db_questtype.db";

		// Token: 0x040034DE RID: 13534
		private const string FILE = "r.任务类型.xlsx";

		// Token: 0x040034DF RID: 13535
		private const string TABLE = "QuestMainType";

		// Token: 0x040034E0 RID: 13536
		private const string COMMAND = "select BinData from `QuestMainType` where Id=?";

		// Token: 0x040034E1 RID: 13537
		private const string KEY_PREFIX = "QuestMainTypeById";

		// Token: 0x040034E2 RID: 13538
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034E3 RID: 13539
		private static int HandleId;
	}
}
