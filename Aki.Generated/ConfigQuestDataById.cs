using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000776 RID: 1910
	public class ConfigQuestDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CD5 RID: 11477 RVA: 0x00156A10 File Offset: 0x00154C10
		static ConfigQuestDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestDataById.CreateStaticDefaultValue), new Action(ConfigQuestDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00156A30 File Offset: 0x00154C30
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questdata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Quest/任务_*"),
				new ValueTuple<string, object>("表名", "QuestData"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestData` where QuestId=?")
			});
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00156AAF File Offset: 0x00154CAF
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestDataById.LogPair = null;
			ConfigQuestDataById.HandleId = 0;
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00156ABD File Offset: 0x00154CBD
		public static void Init()
		{
			ConfigQuestDataById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestDataById.HandleId, "db_questdata.db", "select BinData from `QuestData` where QuestId=?");
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00156AD8 File Offset: 0x00154CD8
		public static QuestData? GetConfig(int p0QuestId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestDataById.HandleId, ConfigQuestDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestData?(QuestData.GetRootAsQuestData(configBuffer));
				}
			}
			ConfigQuestDataById.LogPair.Clear();
			ConfigQuestDataById.LogPair.Add(new ValueTuple<string, object>("QuestId", p0QuestId));
			if (!ConfigCommon.BindInt(ConfigQuestDataById.HandleId, 1, p0QuestId, ConfigQuestDataById.LogPair) || ConfigCommon.Step(ConfigQuestDataById.HandleId, true, ConfigQuestDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestDataById.HandleId, ConfigQuestDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestDataById.HandleId, 0, ConfigQuestDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestDataById.HandleId, ConfigQuestDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestData rootAsQuestData = QuestData.GetRootAsQuestData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestDataById.HandleId, ConfigQuestDataById.LogPair);
			return new QuestData?(rootAsQuestData);
		}

		// Token: 0x04003420 RID: 13344
		private const string DB = "db_questdata.db";

		// Token: 0x04003421 RID: 13345
		private const string FILE = "UniverseEditor/Quest/任务_*";

		// Token: 0x04003422 RID: 13346
		private const string TABLE = "QuestData";

		// Token: 0x04003423 RID: 13347
		private const string COMMAND = "select BinData from `QuestData` where QuestId=?";

		// Token: 0x04003424 RID: 13348
		private const string KEY_PREFIX = "QuestDataById";

		// Token: 0x04003425 RID: 13349
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003426 RID: 13350
		private static int HandleId;
	}
}
