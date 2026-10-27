using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000773 RID: 1907
	public class ConfigQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CC3 RID: 11459 RVA: 0x00156338 File Offset: 0x00154538
		static ConfigQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestById.CreateStaticDefaultValue), new Action(ConfigQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00156358 File Offset: 0x00154558
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_quest.db"),
				new ValueTuple<string, object>("文件", "r.任务.xlsx"),
				new ValueTuple<string, object>("表名", "Quest"),
				new ValueTuple<string, object>("语句", "select BinData from `Quest` where Id=?")
			});
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x001563D7 File Offset: 0x001545D7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestById.LogPair = null;
			ConfigQuestById.HandleId = 0;
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x001563E5 File Offset: 0x001545E5
		public static void Init()
		{
			ConfigQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestById.HandleId, "db_quest.db", "select BinData from `Quest` where Id=?");
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x00156400 File Offset: 0x00154600
		public static Quest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestById.HandleId, ConfigQuestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Quest?(Quest.GetRootAsQuest(configBuffer));
				}
			}
			ConfigQuestById.LogPair.Clear();
			ConfigQuestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestById.HandleId, 1, p0Id, ConfigQuestById.LogPair) || ConfigCommon.Step(ConfigQuestById.HandleId, true, ConfigQuestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestById.HandleId, ConfigQuestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestById.HandleId, 0, ConfigQuestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestById.HandleId, ConfigQuestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Quest rootAsQuest = Quest.GetRootAsQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestById.HandleId, ConfigQuestById.LogPair);
			return new Quest?(rootAsQuest);
		}

		// Token: 0x0400340B RID: 13323
		private const string DB = "db_quest.db";

		// Token: 0x0400340C RID: 13324
		private const string FILE = "r.任务.xlsx";

		// Token: 0x0400340D RID: 13325
		private const string TABLE = "Quest";

		// Token: 0x0400340E RID: 13326
		private const string COMMAND = "select BinData from `Quest` where Id=?";

		// Token: 0x0400340F RID: 13327
		private const string KEY_PREFIX = "QuestById";

		// Token: 0x04003410 RID: 13328
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003411 RID: 13329
		private static int HandleId;
	}
}
