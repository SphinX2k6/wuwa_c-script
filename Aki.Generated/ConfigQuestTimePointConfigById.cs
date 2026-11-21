using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A3 RID: 1955
	public class ConfigQuestTimePointConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DE3 RID: 11747 RVA: 0x0015FFDB File Offset: 0x0015E1DB
		static ConfigQuestTimePointConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTimePointConfigById.CreateStaticDefaultValue), new Action(ConfigQuestTimePointConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x0015FFFC File Offset: 0x0015E1FC
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

		// Token: 0x06002DE5 RID: 11749 RVA: 0x0016007B File Offset: 0x0015E27B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTimePointConfigById.LogPair = null;
			ConfigQuestTimePointConfigById.HandleId = 0;
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x00160089 File Offset: 0x0015E289
		public static void Init()
		{
			ConfigQuestTimePointConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTimePointConfigById.HandleId, "db_questmultiline.db", "select BinData from `QuestTimePointConfig` where Id=?");
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x001600A4 File Offset: 0x0015E2A4
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

		// Token: 0x06002DE8 RID: 11752 RVA: 0x0016021C File Offset: 0x0015E41C
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

		// Token: 0x0400355B RID: 13659
		private const string DB = "db_questmultiline.db";

		// Token: 0x0400355C RID: 13660
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x0400355D RID: 13661
		private const string TABLE = "QuestTimePointConfig";

		// Token: 0x0400355E RID: 13662
		private const string COMMAND = "select BinData from `QuestTimePointConfig` where Id=?";

		// Token: 0x0400355F RID: 13663
		private const string KEY_PREFIX = "QuestTimePointConfigById";

		// Token: 0x04003560 RID: 13664
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003561 RID: 13665
		private static int HandleId;
	}
}
