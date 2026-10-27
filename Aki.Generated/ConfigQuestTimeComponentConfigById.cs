using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000787 RID: 1927
	public class ConfigQuestTimeComponentConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D3B RID: 11579 RVA: 0x00158CF4 File Offset: 0x00156EF4
		static ConfigQuestTimeComponentConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTimeComponentConfigById.CreateStaticDefaultValue), new Action(ConfigQuestTimeComponentConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00158D14 File Offset: 0x00156F14
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

		// Token: 0x06002D3D RID: 11581 RVA: 0x00158D93 File Offset: 0x00156F93
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTimeComponentConfigById.LogPair = null;
			ConfigQuestTimeComponentConfigById.HandleId = 0;
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x00158DA1 File Offset: 0x00156FA1
		public static void Init()
		{
			ConfigQuestTimeComponentConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTimeComponentConfigById.HandleId, "db_questmultiline.db", "select BinData from `QuestTimeComponentConfig` where Id=?");
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00158DBC File Offset: 0x00156FBC
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

		// Token: 0x04003497 RID: 13463
		private const string DB = "db_questmultiline.db";

		// Token: 0x04003498 RID: 13464
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x04003499 RID: 13465
		private const string TABLE = "QuestTimeComponentConfig";

		// Token: 0x0400349A RID: 13466
		private const string COMMAND = "select BinData from `QuestTimeComponentConfig` where Id=?";

		// Token: 0x0400349B RID: 13467
		private const string KEY_PREFIX = "QuestTimeComponentConfigById";

		// Token: 0x0400349C RID: 13468
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400349D RID: 13469
		private static int HandleId;
	}
}
