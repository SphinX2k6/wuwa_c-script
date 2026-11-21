using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000796 RID: 1942
	public class ConfigQuestRefMapBlockConfigByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D95 RID: 11669 RVA: 0x0015E513 File Offset: 0x0015C713
		static ConfigQuestRefMapBlockConfigByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestRefMapBlockConfigByQuestId.CreateStaticDefaultValue), new Action(ConfigQuestRefMapBlockConfigByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x0015E534 File Offset: 0x0015C734
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestRefMapBlockConfigByQuestId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestRefMapBlockConfigByQuestId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrefmapblock.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/QuestRefMapBlockConfig/QuestRefMapBlock.csv"),
				new ValueTuple<string, object>("表名", "QuestRefMapBlockConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestRefMapBlockConfig` where QuestId=?")
			});
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x0015E5B3 File Offset: 0x0015C7B3
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestRefMapBlockConfigByQuestId.LogPair = null;
			ConfigQuestRefMapBlockConfigByQuestId.HandleId = 0;
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x0015E5C1 File Offset: 0x0015C7C1
		public static void Init()
		{
			ConfigQuestRefMapBlockConfigByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigQuestRefMapBlockConfigByQuestId.HandleId, "db_questrefmapblock.db", "select BinData from `QuestRefMapBlockConfig` where QuestId=?");
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x0015E5DC File Offset: 0x0015C7DC
		public static QuestRefMapBlockConfig? GetConfig(int p0QuestId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestRefMapBlockConfigByQuestId.HandleId, ConfigQuestRefMapBlockConfigByQuestId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestRefMapBlockConfigByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestRefMapBlockConfig?(QuestRefMapBlockConfig.GetRootAsQuestRefMapBlockConfig(configBuffer));
				}
			}
			ConfigQuestRefMapBlockConfigByQuestId.LogPair.Clear();
			ConfigQuestRefMapBlockConfigByQuestId.LogPair.Add(new ValueTuple<string, object>("QuestId", p0QuestId));
			if (!ConfigCommon.BindInt(ConfigQuestRefMapBlockConfigByQuestId.HandleId, 1, p0QuestId, ConfigQuestRefMapBlockConfigByQuestId.LogPair) || ConfigCommon.Step(ConfigQuestRefMapBlockConfigByQuestId.HandleId, true, ConfigQuestRefMapBlockConfigByQuestId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestRefMapBlockConfigByQuestId.HandleId, ConfigQuestRefMapBlockConfigByQuestId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestRefMapBlockConfigByQuestId.HandleId, 0, ConfigQuestRefMapBlockConfigByQuestId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestRefMapBlockConfigByQuestId.HandleId, ConfigQuestRefMapBlockConfigByQuestId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestRefMapBlockConfig rootAsQuestRefMapBlockConfig = QuestRefMapBlockConfig.GetRootAsQuestRefMapBlockConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestRefMapBlockConfigByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestRefMapBlockConfigByQuestId.HandleId, ConfigQuestRefMapBlockConfigByQuestId.LogPair);
			return new QuestRefMapBlockConfig?(rootAsQuestRefMapBlockConfig);
		}

		// Token: 0x04003500 RID: 13568
		private const string DB = "db_questrefmapblock.db";

		// Token: 0x04003501 RID: 13569
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/QuestRefMapBlock.csv";

		// Token: 0x04003502 RID: 13570
		private const string TABLE = "QuestRefMapBlockConfig";

		// Token: 0x04003503 RID: 13571
		private const string COMMAND = "select BinData from `QuestRefMapBlockConfig` where QuestId=?";

		// Token: 0x04003504 RID: 13572
		private const string KEY_PREFIX = "QuestRefMapBlockConfigByQuestId";

		// Token: 0x04003505 RID: 13573
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003506 RID: 13574
		private static int HandleId;
	}
}
