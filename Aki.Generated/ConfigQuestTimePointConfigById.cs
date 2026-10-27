using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000789 RID: 1929
	public class ConfigQuestTimePointConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D47 RID: 11591 RVA: 0x001590CF File Offset: 0x001572CF
		static ConfigQuestTimePointConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTimePointConfigById.CreateStaticDefaultValue), new Action(ConfigQuestTimePointConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x001590F0 File Offset: 0x001572F0
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTimePointConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTimePointConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questmultiline.db"),
				new ValueTuple<string, object>("文件", "r.任务分线.xlsx"),
				new ValueTuple<string, object>("表名", "QuestTimePointConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTimePointConfig` where Id=?")
			});
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x0015916F File Offset: 0x0015736F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTimePointConfigById.LogPair = null;
			ConfigQuestTimePointConfigById.HandleId = 0;
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x0015917D File Offset: 0x0015737D
		public static void Init()
		{
			ConfigQuestTimePointConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTimePointConfigById.HandleId, "db_questmultiline.db", "select BinData from `QuestTimePointConfig` where Id=?");
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00159198 File Offset: 0x00157398
		public static QuestTimePointConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTimePointConfigById.HandleId, ConfigQuestTimePointConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTimePointConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestTimePointConfig?(QuestTimePointConfig.GetRootAsQuestTimePointConfig(configBuffer));
				}
			}
			ConfigQuestTimePointConfigById.LogPair.Clear();
			ConfigQuestTimePointConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestTimePointConfigById.HandleId, 1, p0Id, ConfigQuestTimePointConfigById.LogPair) || ConfigCommon.Step(ConfigQuestTimePointConfigById.HandleId, true, ConfigQuestTimePointConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestTimePointConfigById.HandleId, ConfigQuestTimePointConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTimePointConfigById.HandleId, 0, ConfigQuestTimePointConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestTimePointConfigById.HandleId, ConfigQuestTimePointConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestTimePointConfig rootAsQuestTimePointConfig = QuestTimePointConfig.GetRootAsQuestTimePointConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTimePointConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestTimePointConfigById.HandleId, ConfigQuestTimePointConfigById.LogPair);
			return new QuestTimePointConfig?(rootAsQuestTimePointConfig);
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x00159310 File Offset: 0x00157510
		[NullableContext(2)]
		public static IReadOnlyList<QuestTimePointConfig> GetConfigList(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTimePointConfigById.HandleId, ConfigQuestTimePointConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTimePointConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				IReadOnlyList<QuestTimePointConfig> readOnlyList = (IReadOnlyList<QuestTimePointConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigQuestTimePointConfigById.LogPair.Clear();
			ConfigQuestTimePointConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestTimePointConfigById.HandleId, 1, p0Id, ConfigQuestTimePointConfigById.LogPair))
			{
				ConfigCommon.Reset(ConfigQuestTimePointConfigById.HandleId, ConfigQuestTimePointConfigById.LogPair);
				return null;
			}
			List<QuestTimePointConfig> list = new List<QuestTimePointConfig>();
			while (ConfigCommon.Step(ConfigQuestTimePointConfigById.HandleId, false, ConfigQuestTimePointConfigById.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTimePointConfigById.HandleId, 0, ConfigQuestTimePointConfigById.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestTimePointConfigById.HandleId, ConfigQuestTimePointConfigById.LogPair);
					return null;
				}
				QuestTimePointConfig rootAsQuestTimePointConfig = QuestTimePointConfig.GetRootAsQuestTimePointConfig(new ByteBuffer(item2));
				list.Add(rootAsQuestTimePointConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTimePointConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestTimePointConfigById.HandleId, ConfigQuestTimePointConfigById.LogPair);
			return list;
		}

		// Token: 0x040034A5 RID: 13477
		private const string DB = "db_questmultiline.db";

		// Token: 0x040034A6 RID: 13478
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x040034A7 RID: 13479
		private const string TABLE = "QuestTimePointConfig";

		// Token: 0x040034A8 RID: 13480
		private const string COMMAND = "select BinData from `QuestTimePointConfig` where Id=?";

		// Token: 0x040034A9 RID: 13481
		private const string KEY_PREFIX = "QuestTimePointConfigById";

		// Token: 0x040034AA RID: 13482
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034AB RID: 13483
		private static int HandleId;
	}
}
