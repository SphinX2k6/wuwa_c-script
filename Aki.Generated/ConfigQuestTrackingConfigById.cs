using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078B RID: 1931
	public class ConfigQuestTrackingConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D54 RID: 11604 RVA: 0x00159613 File Offset: 0x00157813
		static ConfigQuestTrackingConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTrackingConfigById.CreateStaticDefaultValue), new Action(ConfigQuestTrackingConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00159634 File Offset: 0x00157834
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTrackingConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTrackingConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtrackingconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/r.任务追踪配置/*.csv*"),
				new ValueTuple<string, object>("表名", "QuestTrackingConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTrackingConfig` where Id=?")
			});
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x001596B3 File Offset: 0x001578B3
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTrackingConfigById.LogPair = null;
			ConfigQuestTrackingConfigById.HandleId = 0;
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x001596C1 File Offset: 0x001578C1
		public static void Init()
		{
			ConfigQuestTrackingConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTrackingConfigById.HandleId, "db_questtrackingconfig.db", "select BinData from `QuestTrackingConfig` where Id=?");
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x001596DC File Offset: 0x001578DC
		public static QuestTrackingConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTrackingConfigById.HandleId, ConfigQuestTrackingConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTrackingConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestTrackingConfig?(QuestTrackingConfig.GetRootAsQuestTrackingConfig(configBuffer));
				}
			}
			ConfigQuestTrackingConfigById.LogPair.Clear();
			ConfigQuestTrackingConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestTrackingConfigById.HandleId, 1, p0Id, ConfigQuestTrackingConfigById.LogPair) || ConfigCommon.Step(ConfigQuestTrackingConfigById.HandleId, true, ConfigQuestTrackingConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestTrackingConfigById.HandleId, ConfigQuestTrackingConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTrackingConfigById.HandleId, 0, ConfigQuestTrackingConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestTrackingConfigById.HandleId, ConfigQuestTrackingConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestTrackingConfig rootAsQuestTrackingConfig = QuestTrackingConfig.GetRootAsQuestTrackingConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTrackingConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestTrackingConfigById.HandleId, ConfigQuestTrackingConfigById.LogPair);
			return new QuestTrackingConfig?(rootAsQuestTrackingConfig);
		}

		// Token: 0x040034B3 RID: 13491
		private const string DB = "db_questtrackingconfig.db";

		// Token: 0x040034B4 RID: 13492
		private const string FILE = "k.可视化编辑/c.Csv/r.任务追踪配置/*.csv*";

		// Token: 0x040034B5 RID: 13493
		private const string TABLE = "QuestTrackingConfig";

		// Token: 0x040034B6 RID: 13494
		private const string COMMAND = "select BinData from `QuestTrackingConfig` where Id=?";

		// Token: 0x040034B7 RID: 13495
		private const string KEY_PREFIX = "QuestTrackingConfigById";

		// Token: 0x040034B8 RID: 13496
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034B9 RID: 13497
		private static int HandleId;
	}
}
