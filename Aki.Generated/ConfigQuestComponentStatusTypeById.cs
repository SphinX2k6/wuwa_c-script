using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000775 RID: 1909
	public class ConfigQuestComponentStatusTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CCF RID: 11471 RVA: 0x001567C8 File Offset: 0x001549C8
		static ConfigQuestComponentStatusTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestComponentStatusTypeById.CreateStaticDefaultValue), new Action(ConfigQuestComponentStatusTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x001567E8 File Offset: 0x001549E8
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

		// Token: 0x06002CD1 RID: 11473 RVA: 0x00156867 File Offset: 0x00154A67
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestComponentStatusTypeById.LogPair = null;
			ConfigQuestComponentStatusTypeById.HandleId = 0;
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x00156875 File Offset: 0x00154A75
		public static void Init()
		{
			ConfigQuestComponentStatusTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestComponentStatusTypeById.HandleId, "db_questmultiline.db", "select BinData from `QuestComponentStatusType` where Id=?");
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x00156890 File Offset: 0x00154A90
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

		// Token: 0x04003419 RID: 13337
		private const string DB = "db_questmultiline.db";

		// Token: 0x0400341A RID: 13338
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x0400341B RID: 13339
		private const string TABLE = "QuestComponentStatusType";

		// Token: 0x0400341C RID: 13340
		private const string COMMAND = "select BinData from `QuestComponentStatusType` where Id=?";

		// Token: 0x0400341D RID: 13341
		private const string KEY_PREFIX = "QuestComponentStatusTypeById";

		// Token: 0x0400341E RID: 13342
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400341F RID: 13343
		private static int HandleId;
	}
}
