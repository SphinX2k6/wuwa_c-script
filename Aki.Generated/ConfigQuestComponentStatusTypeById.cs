using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078F RID: 1935
	public class ConfigQuestComponentStatusTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D6B RID: 11627 RVA: 0x0015D6D4 File Offset: 0x0015B8D4
		static ConfigQuestComponentStatusTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestComponentStatusTypeById.CreateStaticDefaultValue), new Action(ConfigQuestComponentStatusTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x0015D6F4 File Offset: 0x0015B8F4
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestComponentStatusTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestComponentStatusTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questmultiline.db"),
				new ValueTuple<string, object>("文件", "r.任务分线.xlsx"),
				new ValueTuple<string, object>("表名", "QuestComponentStatusType"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestComponentStatusType` where Id=?")
			});
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x0015D773 File Offset: 0x0015B973
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestComponentStatusTypeById.LogPair = null;
			ConfigQuestComponentStatusTypeById.HandleId = 0;
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x0015D781 File Offset: 0x0015B981
		public static void Init()
		{
			ConfigQuestComponentStatusTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestComponentStatusTypeById.HandleId, "db_questmultiline.db", "select BinData from `QuestComponentStatusType` where Id=?");
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x0015D79C File Offset: 0x0015B99C
		public static QuestComponentStatusType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestComponentStatusTypeById.HandleId, ConfigQuestComponentStatusTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestComponentStatusTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestComponentStatusType?(QuestComponentStatusType.GetRootAsQuestComponentStatusType(configBuffer));
				}
			}
			ConfigQuestComponentStatusTypeById.LogPair.Clear();
			ConfigQuestComponentStatusTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestComponentStatusTypeById.HandleId, 1, p0Id, ConfigQuestComponentStatusTypeById.LogPair) || ConfigCommon.Step(ConfigQuestComponentStatusTypeById.HandleId, true, ConfigQuestComponentStatusTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestComponentStatusTypeById.HandleId, ConfigQuestComponentStatusTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestComponentStatusTypeById.HandleId, 0, ConfigQuestComponentStatusTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestComponentStatusTypeById.HandleId, ConfigQuestComponentStatusTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestComponentStatusType rootAsQuestComponentStatusType = QuestComponentStatusType.GetRootAsQuestComponentStatusType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestComponentStatusTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestComponentStatusTypeById.HandleId, ConfigQuestComponentStatusTypeById.LogPair);
			return new QuestComponentStatusType?(rootAsQuestComponentStatusType);
		}

		// Token: 0x040034CF RID: 13519
		private const string DB = "db_questmultiline.db";

		// Token: 0x040034D0 RID: 13520
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x040034D1 RID: 13521
		private const string TABLE = "QuestComponentStatusType";

		// Token: 0x040034D2 RID: 13522
		private const string COMMAND = "select BinData from `QuestComponentStatusType` where Id=?";

		// Token: 0x040034D3 RID: 13523
		private const string KEY_PREFIX = "QuestComponentStatusTypeById";

		// Token: 0x040034D4 RID: 13524
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034D5 RID: 13525
		private static int HandleId;
	}
}
