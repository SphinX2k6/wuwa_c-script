using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000777 RID: 1911
	public class ConfigQuestMainTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CDB RID: 11483 RVA: 0x00156C58 File Offset: 0x00154E58
		static ConfigQuestMainTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestMainTypeById.CreateStaticDefaultValue), new Action(ConfigQuestMainTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x00156C78 File Offset: 0x00154E78
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestMainTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestMainTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtype.db"),
				new ValueTuple<string, object>("文件", "r.任务类型.xlsx"),
				new ValueTuple<string, object>("表名", "QuestMainType"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestMainType` where Id=?")
			});
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00156CF7 File Offset: 0x00154EF7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestMainTypeById.LogPair = null;
			ConfigQuestMainTypeById.HandleId = 0;
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x00156D05 File Offset: 0x00154F05
		public static void Init()
		{
			ConfigQuestMainTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestMainTypeById.HandleId, "db_questtype.db", "select BinData from `QuestMainType` where Id=?");
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x00156D20 File Offset: 0x00154F20
		public static QuestMainType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestMainTypeById.HandleId, ConfigQuestMainTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestMainTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestMainType?(QuestMainType.GetRootAsQuestMainType(configBuffer));
				}
			}
			ConfigQuestMainTypeById.LogPair.Clear();
			ConfigQuestMainTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestMainTypeById.HandleId, 1, p0Id, ConfigQuestMainTypeById.LogPair) || ConfigCommon.Step(ConfigQuestMainTypeById.HandleId, true, ConfigQuestMainTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestMainTypeById.HandleId, ConfigQuestMainTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestMainTypeById.HandleId, 0, ConfigQuestMainTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestMainTypeById.HandleId, ConfigQuestMainTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestMainType rootAsQuestMainType = QuestMainType.GetRootAsQuestMainType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestMainTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestMainTypeById.HandleId, ConfigQuestMainTypeById.LogPair);
			return new QuestMainType?(rootAsQuestMainType);
		}

		// Token: 0x04003427 RID: 13351
		private const string DB = "db_questtype.db";

		// Token: 0x04003428 RID: 13352
		private const string FILE = "r.任务类型.xlsx";

		// Token: 0x04003429 RID: 13353
		private const string TABLE = "QuestMainType";

		// Token: 0x0400342A RID: 13354
		private const string COMMAND = "select BinData from `QuestMainType` where Id=?";

		// Token: 0x0400342B RID: 13355
		private const string KEY_PREFIX = "QuestMainTypeById";

		// Token: 0x0400342C RID: 13356
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400342D RID: 13357
		private static int HandleId;
	}
}
