using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077C RID: 1916
	public class ConfigQuestRefMapBlockConfigByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CF9 RID: 11513 RVA: 0x00157607 File Offset: 0x00155807
		static ConfigQuestRefMapBlockConfigByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestRefMapBlockConfigByQuestId.CreateStaticDefaultValue), new Action(ConfigQuestRefMapBlockConfigByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x00157628 File Offset: 0x00155828
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

		// Token: 0x06002CFB RID: 11515 RVA: 0x001576A7 File Offset: 0x001558A7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestRefMapBlockConfigByQuestId.LogPair = null;
			ConfigQuestRefMapBlockConfigByQuestId.HandleId = 0;
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x001576B5 File Offset: 0x001558B5
		public static void Init()
		{
			ConfigQuestRefMapBlockConfigByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigQuestRefMapBlockConfigByQuestId.HandleId, "db_questrefmapblock.db", "select BinData from `QuestRefMapBlockConfig` where QuestId=?");
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x001576D0 File Offset: 0x001558D0
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

		// Token: 0x0400344A RID: 13386
		private const string DB = "db_questrefmapblock.db";

		// Token: 0x0400344B RID: 13387
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/QuestRefMapBlock.csv";

		// Token: 0x0400344C RID: 13388
		private const string TABLE = "QuestRefMapBlockConfig";

		// Token: 0x0400344D RID: 13389
		private const string COMMAND = "select BinData from `QuestRefMapBlockConfig` where QuestId=?";

		// Token: 0x0400344E RID: 13390
		private const string KEY_PREFIX = "QuestRefMapBlockConfigByQuestId";

		// Token: 0x0400344F RID: 13391
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003450 RID: 13392
		private static int HandleId;
	}
}
