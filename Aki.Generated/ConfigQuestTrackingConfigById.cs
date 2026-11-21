using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A5 RID: 1957
	public class ConfigQuestTrackingConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DF0 RID: 11760 RVA: 0x0016051F File Offset: 0x0015E71F
		static ConfigQuestTrackingConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTrackingConfigById.CreateStaticDefaultValue), new Action(ConfigQuestTrackingConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x00160540 File Offset: 0x0015E740
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

		// Token: 0x06002DF2 RID: 11762 RVA: 0x001605BF File Offset: 0x0015E7BF
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTrackingConfigById.LogPair = null;
			ConfigQuestTrackingConfigById.HandleId = 0;
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x001605CD File Offset: 0x0015E7CD
		public static void Init()
		{
			ConfigQuestTrackingConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTrackingConfigById.HandleId, "db_questtrackingconfig.db", "select BinData from `QuestTrackingConfig` where Id=?");
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x001605E8 File Offset: 0x0015E7E8
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

		// Token: 0x04003569 RID: 13673
		private const string DB = "db_questtrackingconfig.db";

		// Token: 0x0400356A RID: 13674
		private const string FILE = "k.可视化编辑/c.Csv/r.任务追踪配置/*.csv*";

		// Token: 0x0400356B RID: 13675
		private const string TABLE = "QuestTrackingConfig";

		// Token: 0x0400356C RID: 13676
		private const string COMMAND = "select BinData from `QuestTrackingConfig` where Id=?";

		// Token: 0x0400356D RID: 13677
		private const string KEY_PREFIX = "QuestTrackingConfigById";

		// Token: 0x0400356E RID: 13678
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400356F RID: 13679
		private static int HandleId;
	}
}
