using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A1 RID: 1953
	public class ConfigQuestTimeComponentConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DD7 RID: 11735 RVA: 0x0015FC00 File Offset: 0x0015DE00
		static ConfigQuestTimeComponentConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTimeComponentConfigById.CreateStaticDefaultValue), new Action(ConfigQuestTimeComponentConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x0015FC20 File Offset: 0x0015DE20
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTimeComponentConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTimeComponentConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questmultiline.db"),
				new ValueTuple<string, object>("文件", "r.任务分线.xlsx"),
				new ValueTuple<string, object>("表名", "QuestTimeComponentConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTimeComponentConfig` where Id=?")
			});
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x0015FC9F File Offset: 0x0015DE9F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTimeComponentConfigById.LogPair = null;
			ConfigQuestTimeComponentConfigById.HandleId = 0;
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x0015FCAD File Offset: 0x0015DEAD
		public static void Init()
		{
			ConfigQuestTimeComponentConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTimeComponentConfigById.HandleId, "db_questmultiline.db", "select BinData from `QuestTimeComponentConfig` where Id=?");
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x0015FCC8 File Offset: 0x0015DEC8
		public static QuestTimeComponentConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTimeComponentConfigById.HandleId, ConfigQuestTimeComponentConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTimeComponentConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestTimeComponentConfig?(QuestTimeComponentConfig.GetRootAsQuestTimeComponentConfig(configBuffer));
				}
			}
			ConfigQuestTimeComponentConfigById.LogPair.Clear();
			ConfigQuestTimeComponentConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestTimeComponentConfigById.HandleId, 1, p0Id, ConfigQuestTimeComponentConfigById.LogPair) || ConfigCommon.Step(ConfigQuestTimeComponentConfigById.HandleId, true, ConfigQuestTimeComponentConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestTimeComponentConfigById.HandleId, ConfigQuestTimeComponentConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTimeComponentConfigById.HandleId, 0, ConfigQuestTimeComponentConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestTimeComponentConfigById.HandleId, ConfigQuestTimeComponentConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestTimeComponentConfig rootAsQuestTimeComponentConfig = QuestTimeComponentConfig.GetRootAsQuestTimeComponentConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTimeComponentConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestTimeComponentConfigById.HandleId, ConfigQuestTimeComponentConfigById.LogPair);
			return new QuestTimeComponentConfig?(rootAsQuestTimeComponentConfig);
		}

		// Token: 0x0400354D RID: 13645
		private const string DB = "db_questmultiline.db";

		// Token: 0x0400354E RID: 13646
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x0400354F RID: 13647
		private const string TABLE = "QuestTimeComponentConfig";

		// Token: 0x04003550 RID: 13648
		private const string COMMAND = "select BinData from `QuestTimeComponentConfig` where Id=?";

		// Token: 0x04003551 RID: 13649
		private const string KEY_PREFIX = "QuestTimeComponentConfigById";

		// Token: 0x04003552 RID: 13650
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003553 RID: 13651
		private static int HandleId;
	}
}
