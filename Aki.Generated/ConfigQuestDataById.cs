using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000790 RID: 1936
	public class ConfigQuestDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D71 RID: 11633 RVA: 0x0015D91C File Offset: 0x0015BB1C
		static ConfigQuestDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestDataById.CreateStaticDefaultValue), new Action(ConfigQuestDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x0015D93C File Offset: 0x0015BB3C
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

		// Token: 0x06002D73 RID: 11635 RVA: 0x0015D9BB File Offset: 0x0015BBBB
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestDataById.LogPair = null;
			ConfigQuestDataById.HandleId = 0;
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x0015D9C9 File Offset: 0x0015BBC9
		public static void Init()
		{
			ConfigQuestDataById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestDataById.HandleId, "db_questdata.db", "select BinData from `QuestData` where QuestId=?");
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x0015D9E4 File Offset: 0x0015BBE4
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

		// Token: 0x040034D6 RID: 13526
		private const string DB = "db_questdata.db";

		// Token: 0x040034D7 RID: 13527
		private const string FILE = "UniverseEditor/Quest/任务_*";

		// Token: 0x040034D8 RID: 13528
		private const string TABLE = "QuestData";

		// Token: 0x040034D9 RID: 13529
		private const string COMMAND = "select BinData from `QuestData` where QuestId=?";

		// Token: 0x040034DA RID: 13530
		private const string KEY_PREFIX = "QuestDataById";

		// Token: 0x040034DB RID: 13531
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034DC RID: 13532
		private static int HandleId;
	}
}
